using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
using PureCloudPlatform.Client.V2.Extensions.Notifications;
using PureCloudPlatform.Client.V2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Tests
{
    [Timeout(60 * 1000)]
    public class SdkTests
    {
        private bool stop;

        string clientId = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_ID");
        string clientSecret = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_SECRET");
        string environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");

        UsersApi usersApi = new UsersApi();
        PresenceApi presenceApi = new PresenceApi();

        string userId;
        string userEmail;
        string userName = ".NET SDK Tester";
        string userDepartment = "Ministry of Testing";
        string userProfileSkill = "Testmaster";
        string busyPresenceId = "31fe3bac-dea6-44b7-bed7-47f91660a1a0";
        string availablePresenceId = "6a3af858-942f-489d-9700-5f9bcdcdae9b";

        public SdkTests()
        {
        }

        [Test, Order(0)]
        public void TraceBasicInformation()
        {
            Console.WriteLine($"PURECLOUD_ENVIRONMENT={environment}");
            Assert.IsNotEmpty(environment);
            Assert.IsNotNull(environment);

            Console.WriteLine($"PURECLOUD_CLIENT_ID={clientId}");
            Assert.IsNotEmpty(clientId);
            Assert.IsNotNull(clientId);

            Assert.IsNotEmpty(clientSecret);
            Assert.IsNotNull(clientSecret);

            userEmail = $"{Guid.NewGuid()}@{environment}";
            Console.WriteLine($"userEmail={userEmail}");
        }

        [Test, Order(1)]
        public void Authenticate()
        {
            PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api." + environment);
            var accessTokenInfo = PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.PostToken(clientId, clientSecret);
            PureCloudPlatform.Client.V2.Client.Configuration.Default.AccessToken = accessTokenInfo.AccessToken;

            Assert.IsNotEmpty(PureCloudPlatform.Client.V2.Client.Configuration.Default.AccessToken);
        }

        [Test, Order(2)]
        public void CreateUser()
        {
            var newUser = new CreateUser()
            {
                Name = userName,
                Email = userEmail,
                Password = Guid.NewGuid() + "!@#$1234asdfASDF"
            };

            var user = usersApi.PostUsers(newUser);

            userId = user.Id;
            Assert.AreEqual(user.Name, userName);
            Assert.AreEqual(user.Email, userEmail);

            Console.WriteLine($"Created user with ID {userId}");
        }

        [Test, Order(3)]
        public void UpdateUser()
        {
            var updateUser = new UpdateUser()
            {
                Department = userDepartment,
                Version = 1
            };

            var user = usersApi.PatchUser(userId, updateUser);

            Assert.AreEqual(user.Id, userId);
            Assert.AreEqual(user.Name, userName);
            Assert.AreEqual(user.Email, userEmail);
            Assert.AreEqual(user.Department, userDepartment);
        }

        [Test, Order(4)]
        public void SetProfileSkills()
        {
            var skills = usersApi.PutUserProfileskills(userId, new List<string>() { userProfileSkill });

            Assert.AreEqual(skills.Count, 1);
            Assert.AreEqual(skills[0], userProfileSkill);
        }

        [Test, Order(5)]
        public void TestNotifications()
        {
            var handler = new NotificationHandler();

            // Start the handler inside of the task to block this test until the notifications come in
            var tcs = new TaskCompletionSource<bool>();
            var busyReceived = false;
            var availableReceived = false;
            Task.Factory.StartNew(() =>
            {
                handler.NotificationReceived += (data) =>
                {
                    try
                    {
                        if (data.GetType() == typeof(NotificationData<PresenceEventUserPresence>))
                        {
                            var presence = (NotificationData<PresenceEventUserPresence>)data;

                            // Check to see what we got
                            if (presence.EventBody.PresenceDefinition.Id == availablePresenceId) availableReceived = true;
                            if (presence.EventBody.PresenceDefinition.Id == busyPresenceId) busyReceived = true;

                            // Complete the async task
                            if (busyReceived && availableReceived) tcs.SetResult(true);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Suppress this error that happens occasionally:
                        // An attempt was made to transition a task to a final state when it had already completed.
                    } 
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                };
            });

            // Register topic
            handler.AddSubscription($"v2.users.{userId}.presence", typeof(PresenceEventUserPresence));

            // Change presences
            presenceApi.PatchUserPresence(userId, "PURECLOUD", new UserPresence() { PresenceDefinition = new PresenceDefinition(busyPresenceId) });
            presenceApi.PatchUserPresence(userId, "PURECLOUD", new UserPresence() { PresenceDefinition = new PresenceDefinition(availablePresenceId) });

            // The getter for Result will block until the task has completed
            var result = tcs.Task.Result;

            // Assert that both worked
            Assert.AreEqual(busyReceived, true);
            Assert.AreEqual(availableReceived, true);
        }

        [Test, Order(6)]
        public void GetUser()
        {
            var user = usersApi.GetUser(userId, new List<string>() { "profileSkills" }, null);

            Assert.AreEqual(user.Id, userId);
            Assert.AreEqual(user.Name, userName);
            Assert.AreEqual(user.Email, userEmail);
            Assert.AreEqual(user.Department, userDepartment);
            Assert.IsNotNull(user.ProfileSkills);
            Assert.AreEqual(user.ProfileSkills.Count, 1);
            Assert.AreEqual(user.ProfileSkills[0], userProfileSkill);
        }

        [Test, Order(7)]
        public void DeleteUser()
        {
            usersApi.DeleteUser(userId);
        }



        [SetUp]
        public void SetUp()
        {
            if (stop)
            {
                Assert.Inconclusive("Previous test failed");
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                stop = true;
            }
        }
    }
}
