---
title: Platform API Client SDK - .NET
---

[![NuGet Badge](https://buildstats.info/nuget/PureCloudPlatform.Client.V2)](https://www.nuget.org/packages/PureCloudPlatform.Client.V2/)

Documentation can be found at [https://developer.mypurecloud.com/api/rest/client-libraries/dotnet/](https://developer.mypurecloud.com/api/rest/client-libraries/dotnet/)

## Install Using nuget

```{"language":"csharp"}
install-package PureCloudPlatform.Client.V2
```

Package info can be found at [https://www.nuget.org/packages/PureCloudPlatform.Client.V2/](https://www.nuget.org/packages/PureCloudPlatform.Client.V2/)

## Using the Library

### Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps.

If you're building from source or otherwise not using nuget, reference your version of PureCloudPlatform.Client.V2.dll in your project and add references or install packages for [RestSharp](http://www.nuget.org/packages/RestSharp/) and [JSON.NET](http://www.nuget.org/packages/Newtonsoft.Json/).

### Authenticating

#### Implicit Grant

**Use when...** 

* The app is authenticating as a human
* The app is running locally on the user's computer
* The app has an embedded browser to use for OAuth

If the application will be authenticating as a human, the [Implicit Grant](http://developer.mypurecloud.com/api/rest/authorization/use-implicit-grant.html) OAuth 2 flow may be used from an embeddable browser. The access token can be retrieved from the querystring of the redirected URL in the browser control. This process is implemented in the [PureCloud API dotNET OAuth Control](https://github.com/MyPureCloud/purecloud_api_dotnet_oauth_control) project.

See the browser control implemented in a winforms project in the [C# OAuth With Implicit Grant](https://developer.mypurecloud.com/api/tutorials/oauth-implicit/#csharp) tutorial.

#### Authorization Code Grant

**Use when...**

* The app is authenticating as a human
* The app is served via a web server, such as IIS
* There is server-side code that will be making API requests

The [Authorization Code Grant](https://developer.mypurecloud.com/api/rest/authorization/use-authorization-code.html) will return the auth code in the querystring to allow the server-side code to make the request to get an access token with the auth code, and prevent the access token from being known by the client-side. The process for this is:

* Redirect user to OAuth login page
* When the user is redirected to your URL, retrieve the auth code from the querystring on the server side
* On the server side, exchange the auth code for an access token

##### ASP.NET tutorial

This is a tutorial of how to use an Authorization Code Grant without using the SDK: [https://developer.mypurecloud.com/api/tutorials/oauth-auth-code/#csharp](https://developer.mypurecloud.com/api/tutorials/oauth-auth-code/#csharp)

##### Example with the SDK

In addition to the process in the tutorial above, swap out the POST to "https://login." + host + "/oauth/token" with the following:

Use the following namespaces:

```{"language":"csharp"}
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostToken_ extension method of _ApiClient_, including the redirect URI and auth code:

```{"language":"csharp"}
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
  "http://redirecturi.com/",
  "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
Configuration.Default.AccessToken = accessTokenInfo.AccessToken;
```

#### OAuth2 SAML2 Bearer Grant

**Use when...**

* The app is authenticating as a human user, the [OAuth2 SAML2 Bearer](https://developer.mypurecloud.com/api/rest/authorization/use-saml2-bearer.html) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

```{"language":"csharp"}
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostTokenSaml2Bearer_ extension method of _ApiClient_ with your orgName and encodedSamlaAsertion

```{"language":"csharp"}
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",orgName, encodedSamlAssertion);
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
Configuration.Default.AccessToken = accessTokenInfo.AccessToken;
```

#### Client Credentials Grant

**Use when...**

* The app is authenticating as a non-human (e.g. a service, scheduled task, or other non-UI application)

For headless and non-user applications, the [Client Credentials Grant](http://developer.mypurecloud.com/api/rest/authorization/use-client-credentials.html) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

```{"language":"csharp"}
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostToken_ extension method of _ApiClient_, leaving the redirect URI and auth code blank:

```{"language":"csharp"}
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
Configuration.Default.AccessToken = accessTokenInfo.AccessToken;
```

### Making Requests

#### Setting the Environment

If connecting to a PureCloud environment other than mypurecloud.com (e.g. mypurecloud.ie), set the new base path before constructing any API classes. The new base path should be the base path to the Platform API for your environment.

```{"language":"csharp"}
PureCloudRegionHosts region = PureCloudRegionHosts.us_east_1;
Configuration.Default.ApiClient.setBasePath(region);
```

#### Setting the Access Token

Once an access token has been obtained from one of the OAuth methods, it must be set in the SDK's configuration.

```{"language":"csharp"}
PureCloudPlatform.Client.V2.Client.Configuration.Default.AccessToken = "BL4Cb3EQIQFlqIItaj-zf5eIhAiP96zk3333QImd24P99ojbFHtpgUTJdRIkuUYfXMy0afEnZcWnEQ";
```

#### Invoking the API

There are two steps to making requests:

1. Instantiate one of the API classes in the PureCloudPlatform.Client.V2.Api namespace
2. Call the methods on the API object

Example of getting the authenticated user's information:

```{"language":"csharp"}
// Instantiate instance of the Users API
var usersApi = new UsersApi();

// Get the logged in user
var me = usersApi.GetMe();
Console.WriteLine($"Hello, {me.DisplayName}");
```

## NotificationHandler Helper Class

The .NET SDK includes a helper class `NotificationHandler` to assist in managing PureCloud notifications. The class will create a single notification channel, or use an existing one, and provides methods to add and remove subscriptions and raises an event with a deserialized notification object whenever one is received.

**WARNING**

The helper uses [WebSocketSharp](https://www.nuget.org/packages/WebSocketSharp)'s websocket implementation. Unfortunately, the package is pre-release only and therefore cannot be included as a dependency in a release package. The dependency must be resolved manually. The nuget page for the package contains instructions for installing the pre-release pacakge.

### Using NotificationHandler

Create a new instance:

```{"language":"csharp"}
var handler = new NotificationHandler();
```

If you're using a proxy server, use the following constructor:

```{"language":"csharp"}
var handler = new NotificationHandler("YOUR_PROXY_URL");
```

If your proxy server requires authentication, use the following constructor:

```{"language":"csharp"}
var handler = new NotificationHandler("YOUR_PROXY_URL", "YOUR_PROXY_USERNAME", "YOUR_PROXY_PASSWORD");
```

Add a subscription:

```{"language":"csharp"}
// Single
handler.AddSubscription($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence));

// Multiple
var subscriptions = new List<Tuple<string, Type>>();
subscriptions.Add(new Tuple($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence)));
subscriptions.Add(new Tuple($"v2.users.{_me.Id}.routingStatus", typeof(UserRoutingStatusNotification)));
handler.AddSubscriptions(subscriptions);
```

Remove a subscription:

```{"language":"csharp"}
handler.RemoveSubscription($"v2.users.{_me.Id}.conversations");
```

Handle incoming notification:

```{"language":"csharp"}
handler.NotificationReceived += (data) =>
{
    Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

    if (data.GetType() == typeof (NotificationData<PresenceEventUserPresence>))
    {
        var presence = (NotificationData<PresenceEventUserPresence>) data;
        Console.WriteLine($"New presence: {presence.EventBody.PresenceDefinition.SystemPresence}");
    }
};
```

Full example:

```{"language":"csharp"}
var handler = new NotificationHandler();
handler.AddSubscription($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence));
handler.AddSubscription($"v2.users.{_me.Id}.conversations", typeof(ConversationNotification));
handler.NotificationReceived += (data) =>
{
    Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

    if (data.GetType() == typeof (NotificationData<PresenceEventUserPresence>))
    {
        var presence = (NotificationData<PresenceEventUserPresence>) data;
        Console.WriteLine($"New presence: {presence.EventBody.PresenceDefinition.SystemPresence}");
    }
    else if (data.GetType() == typeof (NotificationData<ConversationNotification>))
    {
        var conversation = (NotificationData<ConversationNotification>) data;
        Console.WriteLine($"Conversation: {conversation.EventBody.Id}");
    }
};

Console.WriteLine("Websocket connected, awaiting messages...");
Console.WriteLine("Press any key to remove conversations subscription.");
Console.ReadKey(true);

handler.RemoveSubscription($"v2.users.{_me.Id}.conversations");

Console.WriteLine("Conversations subscription removed, awaiting messages...");
Console.ReadKey(true);
```

### Notification Topics and Classes for Deserialization

The SDK contains a static class, [NotificationTopics](https://github.com/MyPureCloud/platform-client-sdk-dotnet/tree/master/build/src/PureCloudPlatform.Client.V2/Client/NotificationTopics.cs), that contains a dictionary of all of the known topics and the types that should be used for deserialization. This class exists to allow an application to dynamically see the defined topics and programatically specify the defined type for a known topic. This class also serves as a reference to the developer to know which classes go with which topics.

_Note that the deserializer does not use this mapping; it uses the type provided to it when adding a topic subscription._

## SDK Information

### REST Requests

The SDK library uses [RestSharp](http://restsharp.org/) to make the REST reqests. The majority of this work is done in [ApiClient.cs](https://github.com/MyPureCloud/platform-client-sdk-dotnet/blob/master/build/src/PureCloudPlatform.Client.V2/Client/ApiClient.cs)

### Building from Source

If you're working inside Visual Studio, adding the files to your project allows you to edit and build inside an IDE.

1. Clone the repo
2. Open the solution file: [PureCloudPlatform.Client.V2.sln](https://github.com/MyPureCloud/platform-client-sdk-dotnet/blob/master/build/PureCloudPlatform.Client.V2.sln)
3. Resolve/restore dependencies (`Update-Package –reinstall` in the _Package Manager Console_)
4. Build the project in Visual Studio

Alternatively, the code can be compiled via the command line. The official builds do this using cross-platform tools: [compile.sh](https://github.com/MyPureCloud/platform-client-sdk-common/blob/master/resources/sdk/pureclouddotnet/scripts/compile.sh)

## SDK Source Code Generation

The SDK is automatically regenerated and published from the API's definition after each API release. For more information on the build process, see the [platform-client-sdk-common](https://github.com/MyPureCloud/platform-client-sdk-common) project.


## Versioning

The SDK's version is incremented according to the [Semantic Versioning Specification](https://semver.org/). The decision to increment version numbers is determined by [diffing the Platform API's swagger](https://github.com/purecloudlabs/platform-client-sdk-common/blob/master/modules/swaggerDiff.js) for automated builds, and optionally forcing a version bump when a build is triggered manually (e.g. releasing a bugfix).


## Support

This package is intended to be forwards compatible with v2 of PureCloud's Platform API. While the general policy for the API is not to introduce breaking changes, there are certain additions and changes to the API that cause breaking changes for the SDK, often due to the way the API is expressed in its swagger definition. Because of this, the SDK can have a major version bump while the API remains at major version 2. While the SDK is intended to be forward compatible, patches will only be released to the latest version. For these reasons, it is strongly recommended that all applications using this SDK are kept up to date and use the latest version of the SDK.

For any issues, questions, or suggestions for the SDK, visit the [PureCloud Developer Forum](https://developer.mypurecloud.com/forum/).
