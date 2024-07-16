using NUnit.Framework;
using System;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
using PureCloudPlatform.Client.V2.Extensions.Notifications;
using PureCloudPlatform.Client.V2.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using System.Linq;
using Parameter = RestSharp.Parameter;
using System.Net;
using Moq;
using RichardSzalay.MockHttp;
using System.Net.Http;

namespace PureCloudPlatform.Client.V2.Tests
{

[TestFixture]
public class ApiClientTests
{
    string clientId = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_ID");
    string clientSecret = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_SECRET");
    string environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");

    private Stopwatch stopwatch;
    private static String path = "/api/v2/users";
    private static RestSharp.Method method = Method.Get;
    private static Dictionary<String, String> pathParams = new Dictionary<String, String>();
    private static List<Tuple<String, String>> queryParams = new List<Tuple<String, String>>();
    private static Dictionary<String, String> headerParams = new Dictionary<String, String>();
    private static Dictionary<String, String> formParams = new Dictionary<String, String>();
    private static Dictionary<String, FileParameter> fileParams = new Dictionary<String, FileParameter>();
    private static Object postBody = null;
    private static String contentType = null;

    [OneTimeSetUp]
    public void Init()
    {
        PureCloudRegionHosts? region = getRegion(environment);
        if(region == null){ //Returned in the case of default value
            PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.setBasePath("https://api." + environment);
        }
        else {
            PureCloudRegionHosts regionval = region.GetValueOrDefault();
            PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.setBasePath(regionval);
        }
        PureCloudPlatform.Client.V2.Client.Configuration.Default.ApiClient.PostToken(clientId, clientSecret);
    }

    [Test]
    public void InvokeTestWith_429()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 6,
            RetryAfterDefaultMs = 100,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();

        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)429);
            response.Headers.Add("Retry-After", "3");
            return Task.FromResult(response);
        });

        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        Assert.That(stopwatch.ElapsedMilliseconds >= 6000 && stopwatch.ElapsedMilliseconds < 6100, "It will wait for every 100 Mills and retry until 6 Seconds");
        Assert.Equals(429, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public void InvokeTestWith_429_And_No_MaxRetryTime()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 0,
            RetryAfterDefaultMs = 100,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        var response = new HttpResponseMessage((System.Net.HttpStatusCode)429);
        response.Headers.Add("Retry-After", "3");
        mockHttp.When("*").Respond(response);
        
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
       
        Assert.That(stopwatch.ElapsedMilliseconds >= 0 && stopwatch.ElapsedMilliseconds < 100, "Since maxRetryTime is not provided it will not retry even if the status code is 429");
        Assert.Equals(429, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public void InvokeTestWith_502()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 13,
            RetryAfterDefaultMs = 2000,
            BackOffIntervalMs = 11000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();

        mockHttp.When("*").Respond((System.Net.HttpStatusCode)502);
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
       
        Assert.That(stopwatch.ElapsedMilliseconds >= 13000 && stopwatch.ElapsedMilliseconds < 13100, "It will wait for every 2 Sec and retry for 5 times then it will backoff for 3 sec and retry then it exits.");
        Assert.Equals(502, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public void InvokeTestWith_503()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 40,
            RetryAfterDefaultMs = 200,
            BackOffIntervalMs = 3000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((System.Net.HttpStatusCode)503);
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 40000 && stopwatch.ElapsedMilliseconds < 40100, "It will wait for every 200 Mills and retry for 5 times then it will backoff for 3 Sec once, 9 Sec once and 27 Sec before retrying");
        Assert.Equals(503, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public void InvokeTestWith_504()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 2,
            RetryAfterDefaultMs = 1000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();

        mockHttp.When("*").Respond((System.Net.HttpStatusCode)504);
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 2000 && stopwatch.ElapsedMilliseconds < 2100, "It will wait for every 1 sec and retry for 2 times");
        Assert.Equals(504, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public void InvokeTestWith_504_No_MaxRetryTime()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 0,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((System.Net.HttpStatusCode)504);
        
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)apiClient.CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 0 && stopwatch.ElapsedMilliseconds < 100, "Since maxRetryTime is not provided it will not retry even if the status code is 504");
        Assert.Equals(504, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_429()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 5,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)429);
            response.Headers.Add("Retry-After", "1");
            return Task.FromResult(response);
        });

        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 5000 && stopwatch.ElapsedMilliseconds < 5100, "It will wait for every 1 Sec provided by Retry-After header Sec and retry for 5 Sec");
        Assert.Equals(429, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_429_And_No_MaxRetryTime()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 0,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        var response = new HttpResponseMessage((System.Net.HttpStatusCode)429);
        response.Headers.Add("Retry-After", "1");

        mockHttp.When("*").Respond(response);

        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 0 && stopwatch.ElapsedMilliseconds < 100, "Since maxWaitTime is 0 it will not retry even if status code is 429");
        Assert.Equals(429, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_502()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 13,
            RetryAfterDefaultMs = 2000,
            BackOffIntervalMs = 11000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();

        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)502);
            return Task.FromResult(response);
        });
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        
        Assert.That(stopwatch.ElapsedMilliseconds >= 13000 && stopwatch.ElapsedMilliseconds < 13100, "It will wait for every 2 Sec and retry for 5 times then it will backoff for 3 sec and retry then it exits.");
        Assert.Equals(502, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_503()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 40,
            RetryAfterDefaultMs = 200,
            BackOffIntervalMs = 3000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)503);
            return Task.FromResult(response);
        });
        
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        Assert.That(stopwatch.ElapsedMilliseconds >= 40000 && stopwatch.ElapsedMilliseconds < 40100, "It will wait for every 200 Mills and retry for 5 times then it will backoff for 3 Sec once, 9 Sec once and 27 Sec before retrying");
        Assert.Equals(503, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_504()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 2,
            RetryAfterDefaultMs = 1000,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)504);
            return Task.FromResult(response);
        });
        
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        Assert.That(stopwatch.ElapsedMilliseconds >= 2000 && stopwatch.ElapsedMilliseconds < 2100, "It will wait for every 1 sec and retry for 2 times");
        Assert.Equals(504, (int)user.StatusCode);
        stopwatch.Stop();
    }

    [Test]
    public async Task InvokeAsyncTestWith_504_And_No_MaxRetryTime()
    {
        var retryConfig = new ApiClient.RetryConfiguration
        {
            MaxRetryTimeSec = 0,
            RetryMax = 50
        };

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.When("*").Respond((req) =>
        {
            var response = new HttpResponseMessage((System.Net.HttpStatusCode)504);
            return Task.FromResult(response);
        });
        
        var apiClient = new ApiClient(new PureCloudPlatform.Client.V2.Client.Configuration());
        apiClient.RetryConfig = retryConfig;
        apiClient.ClientOptions.HttpMessageHandler = mockHttp;

        stopwatch = Stopwatch.StartNew();
        RestResponse user = (RestResponse)await apiClient.CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
        Assert.That(stopwatch.ElapsedMilliseconds >= 0 && stopwatch.ElapsedMilliseconds < 100, "Since maxRetryTime is not provided it will not retry even if the status code is 504");
        Assert.Equals(504, (int)user.StatusCode);
        stopwatch.Stop();
    }

   

    public Nullable<PureCloudRegionHosts> getRegion(String str = "http://api.mypurecloud.com")
    {
        switch (str)
        {
            case "mypurecloud.com":
                return PureCloudRegionHosts.us_east_1;
            case "mypurecloud.ie":
                return PureCloudRegionHosts.eu_west_1;
            case "mypurecloud.de":
                return PureCloudRegionHosts.eu_central_1;
            case "mypurecloud.jp":
                return PureCloudRegionHosts.ap_northeast_1;
            case "mypurecloud.com.au":
                return PureCloudRegionHosts.ap_southeast_2;
            case "usw2.pure.cloud":
                return PureCloudRegionHosts.us_west_2;
            case "cac1.pure.cloud":
                return PureCloudRegionHosts.ca_central_1;
            case "apne2.pure.cloud":
                return PureCloudRegionHosts.ap_northeast_2;
            case "euw2.pure.cloud":
                return PureCloudRegionHosts.eu_west_2;
            case "aps1.pure.cloud":
                return PureCloudRegionHosts.ap_south_1;
            case "use2.us-gov-pure.cloud":
                return PureCloudRegionHosts.us_east_2;
            default:
                Console.WriteLine("Value does not exist in enum using default val");
                return null;
        }
    }
}
}