Platform API Client SDK - .NET

[![NuGet Badge](https://img.shields.io/nuget/v/PureCloudPlatform.Client.V2)](https://www.nuget.org/packages/PureCloudPlatform.Client.V2/)
[![Release Notes Badge](https://developer-content.genesys.cloud/images/sdk-release-notes.png)](https://github.com/MyPureCloud/platform-client-sdk-dotnet/blob/master/releaseNotes.md)

Documentation can be found at https://mypurecloud.github.io/platform-client-sdk-dotnet/

Documentation version PureCloudPlatform.Client.V2 220.0.0

## Install Using nuget

```bash
install-package PureCloudPlatform.Client.V2
```

Package info can be found at [https://www.nuget.org/packages/PureCloudPlatform.Client.V2/](https://www.nuget.org/packages/PureCloudPlatform.Client.V2/)

## Using the Library

**Warning:** This library is generated using the Genesys Cloud public API swagger definition. Function parameter ordering can change without notice and cause breaking changes. To avoid this, it is recommended to use [named arguments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#named-arguments) when making API requests.

## Preview APIs

**Warning:** Preview APIs are included in this SDK. These resources are subject to both breaking and non-breaking changes at any time without notice. This includes, but is not limited to, changing resource names, paths, contracts, documentation, and removing resources entirely. For a full list of the preview APIs see [here](https://developer.genesys.cloud/platform/preview-apis)

### Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps.

If you're building from source or otherwise not using nuget, reference your version of PureCloudPlatform.Client.V2.dll in your project and add references or install packages for [RestSharp](http://www.nuget.org/packages/RestSharp/) and [JSON.NET](http://www.nuget.org/packages/Newtonsoft.Json/).

### Authenticating

#### Implicit Grant

**Use when...** 

* The app is authenticating as a human
* The app is running locally on the user's computer
* The app has an embedded browser to use for OAuth

If the application will be authenticating as a human, the [Implicit Grant](https://developer.genesys.cloud/authorization/platform-auth/use-implicit-grant) OAuth 2 flow may be used from an embeddable browser. The access token can be retrieved from the querystring of the redirected URL in the browser control. This process is packaged by the [GenesysCloudOAuthWebView](https://github.com/MyPureCloud/oauth-webview-dotnet) project.

See the browser control implemented in a winforms project in the [OAuth With Implicit Grant Login Flow](https://developer.genesys.cloud/authorization/platform-auth/guides/oauth-implicit-guide) tutorial.

#### Authorization Code Grant

**Use when...**

* The app is authenticating as a human
* The app is served via a web server, such as IIS
* There is server-side code that will be making API requests

The [Authorization Code Grant](https://developer.genesys.cloud/authorization/platform-auth/use-authorization-code) will return the auth code in the querystring to allow the server-side code to make the request to get an access token with the auth code, and prevent the access token from being known by the client-side. The process for this is:

* Redirect user to OAuth login page
* When the user is redirected to your URL, retrieve the auth code from the querystring on the server side
* On the server side, exchange the auth code for an access token

##### ASP.NET tutorial

This is a tutorial of how to use an Authorization Code Grant without using the SDK: [https://developer.genesys.cloud/authorization/platform-auth/guides/oauth-auth-code-guide](https://developer.genesys.cloud/authorization/platform-auth/guides/oauth-auth-code-guide)

##### Example with the SDK

In addition to the process in the tutorial above, swap out the POST to `https://login.<apihost>/oauth/token` with the following:

Use the following namespaces:

```csharp
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostToken_ extension method of _ApiClient_, including the redirect URI and auth code:

```csharp
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
  "http://redirecturi.com/",
  "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
```

By default, the SDK will transparently request a new access token using the refresh token when the access token expires. If you wish to implement the refresh logic set _ShouldRefreshAccessToken_ to false and store the refresh token from the auth response:

```csharp
var refreshToken = accessTokenInfo.RefreshToken;
Configuration.Default.ShouldRefreshAccessToken = false;
```

You can use the _ExpiresIn_ value to determine how long the token will live and proactively request a new one before it expires.

```csharp
var tokenTimeToLive = authTokenInfo.ExpiresIn;
```

When the access token expires, refresh it using the _PostToken_ method using the same clientId and clientSecret as used to request it.

```csharp
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
  authorizationCode: refreshToken,
  isRefreshRequest: true);
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
refreshToken = accessTokenInfo.RefreshToken;
```

#### OAuth2 SAML2 Bearer Grant

**Use when...**

* The app is authenticating as a human user, the [OAuth2 SAML2 Bearer](https://developer.genesys.cloud/authorization/platform-auth/use-saml2-bearer) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

```csharp
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostTokenSaml2Bearer_ extension method of _ApiClient_ with your orgName and encodedSamlAssertion

```csharp
var accessTokenInfo = Configuration.Default.ApiClient.PostTokenSaml2Bearer("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",orgName, encodedSamlAssertion);
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
```

#### PKCE Grant

**Use when...**

* The app is authenticating as a human user, the [PKCE Grant](https://developer.genesys.cloud/authorization/platform-auth/use-pkce) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

```csharp
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostTokenPKCE_ extension method of _ApiClient_ with your orgName and encodedSamlAssertion

```csharp
var accessTokenInfo = Configuration.Default.ApiClient.PostTokenPKCE(clientId, redirectUri, codeVerifier, authCode);
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
```

The SDK provides methods to generate a PKCE Code Verifier and to compute PKCE Code Challenge.

```csharp
codeVerifier = Configuration.Default.ApiClient.GeneratePKCECodeVerifier(128);
codeChallenge = Configuration.Default.ApiClient.ComputePKCECodeChallenge(codeVerifier);
```

#### Client Credentials Grant

**Use when...**

* The app is authenticating as a non-human (e.g. a service, scheduled task, or other non-UI application)

For headless and non-user applications, the [Client Credentials Grant](https://developer.genesys.cloud/authorization/platform-auth/use-client-credentials) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

```csharp
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
```

Then call the _PostToken_ extension method of _ApiClient_, leaving the redirect URI and auth code blank:

```csharp
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
```

### Making Requests

#### Setting the Environment

If connecting to a Genesys Cloud environment other than mypurecloud.com (e.g. mypurecloud.ie), set the new base path before constructing any API classes. The new base path should be the base path to the Platform API for your environment.

```csharp
PureCloudRegionHosts region = PureCloudRegionHosts.us_east_1;
Configuration.Default.ApiClient.setBasePath(region);
```

#### Setting the max retry time

By default, the .NET SDK does not automatically retry any failed requests.
To enable automatic retries, provide a RetryConfiguration object with the maximum number of seconds to retry requests and the max number of retries when building the ApiClient instance.

Building a `RetryConfiguration` instance:

```csharp
var retryConfig = new ApiClient.RetryConfiguration
{
  MaxRetryTimeSec = 10,
  RetryMax = 5;
};
```

Setting `RetryConfiguration` instance to `ApiClient`:

```csharp
Configuration.Default.ApiClient.RetryConfig = retryConfig;
```

Set the `MaxRetryTimeSec` to the number of seconds to process retries before returning an error.  
Set the `RetryMax` to the retries to attempt before returning an error.  
When the retry time is a positive integer, the SDK will follow the recommended backoff logic using the provided configuration.
The best practices are documented in the [Rate Limiting](https://developer.genesys.cloud/platform/api/rate-limits) Developer Center article.

#### Management of HTTP Responses with duplicate header names.

When an HTTP Response is received with duplicate header names, the SDK will automatically merge such headers and present them as single entry with a comma separated string value.
This applies to response headers in the ApiResponse class, or when enabling SDK logging.

e.g. HTTP Response with ("Server": "Google") and ("Server": "FrontEnd") will be made available and logged as: "Server": "Google, FrontEnd"

#### SDK Logging

Logging of API requests and responses can be controlled by several parameters on the `Configuration`'s `Logger` instance.

`LogLevel` values:

1. LogLevel.LTrace (HTTP Method, URL, Request Body, HTTP Status Code, Request Headers, Response Headers)
2. LogLevel.LDebug (HTTP Method, URL, Request Body, HTTP Status Code, Request Headers)
3. LogLevel.LError (HTTP Method, URL, Request Body, Response Body, HTTP Status Code, Request Headers, Response Headers)
4. LogLevel.LNone - default

`LogFormat` values:

1. JSON
2. Text - default

By default, the request and response bodies are not logged because these can contain PII. Be mindful of this data if choosing to log it.  
To log to a file, provide a `LogFilePath` value. SDK users are responsible for the rotation of the log file.

Example logging configuration:

```csharp
Configuration.Default.Logger.Level = LogLevel.LTrace;
Configuration.Default.Logger.Format = LogFormat.JSON;
Configuration.Default.Logger.LogRequestBody = true;
Configuration.Default.Logger.LogResponseBody = true;
Configuration.Default.Logger.LogToConsole = true;
Configuration.Default.Logger.LogFilePath = "/var/log/dotnetsdk.log";
```

#### Configuration file

Several configuration parameters can be applied using a configuration file. There are two sources for this file:

1. The SDK will look for `%HOMEDRIVE%%HOMEPATH%\.genesysclouddotnet\config` on Windows, or `$HOME/.genesysclouddotnet/config` on Unix.
2. Provide a valid file path to `Configuration.Default.ConfigFilePath`

The SDK will take an event-driven approach to monitor for config file changes and will apply changes in near real-time. To disable this behavior, set `Configuration.Default.AutoReloadConfig` to false.  
INI and JSON formats are supported. See below for examples of configuration values in both formats:

INI:
```ini
[logging]
log_level = trace
log_format = text
log_to_console = false
log_file_path = /var/log/dotnetsdk.log
log_response_body = false
log_request_body = false
[retry]
retry_wait_min = 3
retry_wait_max = 10
retry_max = 5
[reauthentication]
refresh_access_token = true
refresh_token_wait_max = 10
[general]
live_reload_config = true
host = https://api.mypurecloud.com
```

JSON:
```json
{
    "logging": {
        "log_level": "trace",
        "log_format": "text",
        "log_to_console": false,
        "log_file_path": "/var/log/dotnetsdk.log",
        "log_response_body": false,
        "log_request_body": false
    },
    "retry": {
        "retry_wait_min": 3,
        "retry_wait_max": 10,
        "retry_max": 5
    },
    "reauthentication": {
        "refresh_access_token": true,
        "refresh_token_wait_max": 10
    },
    "general": {
        "live_reload_config": true,
        "host": "https://api.mypurecloud.com"
    }
}
```

#### Invoking the API

There are two steps to making requests:

1. Instantiate one of the API classes in the PureCloudPlatform.Client.V2.Api namespace
2. Call the methods on the API object

Example of getting the authenticated user's information:

```csharp
// Instantiate instance of the Users API
var usersApi = new UsersApi();

// Get the logged in user
var me = usersApi.GetMe();
Console.WriteLine($"Hello, {me.DisplayName}");
```

## NotificationHandler Helper Class

The .NET SDK includes a helper class `NotificationHandler` to assist in managing GenesysCloud notifications. The class will create a single notification channel, or use an existing one, and provides methods to add and remove subscriptions and raises an event with a deserialized notification object whenever one is received.

**WARNING**

The helper uses [WebSocketSharp](https://www.nuget.org/packages/WebSocketSharp)'s websocket implementation. Unfortunately, the package is pre-release only and therefore cannot be included as a dependency in a release package. The dependency must be resolved manually. The nuget page for the package contains instructions for installing the pre-release pacakge.

### Using NotificationHandler

Create a new instance:

```csharp
var handler = new NotificationHandler();
```

If you're using a proxy server, use the following constructor:

```csharp
var handler = new NotificationHandler("YOUR_PROXY_URL");
```

If your proxy server requires authentication, use the following constructor:

```csharp
var handler = new NotificationHandler("YOUR_PROXY_URL", "YOUR_PROXY_USERNAME", "YOUR_PROXY_PASSWORD");
```

Add a subscription:

```csharp
// Single
handler.AddSubscription($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence));

// Multiple
var subscriptions = new List<Tuple<string, Type>>();
subscriptions.Add(new Tuple($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence)));
subscriptions.Add(new Tuple($"v2.users.{_me.Id}.routingStatus", typeof(UserRoutingStatusNotification)));
handler.AddSubscriptions(subscriptions);
```

Remove a subscription:

```csharp
handler.RemoveSubscription($"v2.users.{_me.Id}.conversations");
```

Handle incoming notification:

```csharp
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

```csharp
var handler = new NotificationHandler();
handler.AddSubscription($"v2.users.{_me.Id}.presence", typeof(PresenceEventUserPresence));
handler.AddSubscription($"v2.users.{_me.Id}.conversations", typeof(ConversationEventTopicConversation));
handler.NotificationReceived += (data) =>
{
    Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

    if (data.GetType() == typeof (NotificationData<PresenceEventUserPresence>))
    {
        var presence = (NotificationData<PresenceEventUserPresence>) data;
        Console.WriteLine($"New presence: {presence.EventBody.PresenceDefinition.SystemPresence}");
    }
    else if (data.GetType() == typeof (NotificationData<ConversationEventTopicConversation>))
    {
        var conversation = (NotificationData<ConversationEventTopicConversation>) data;
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

The SDK library uses [RestSharp](http://restsharp.org/) to make the REST requests. The majority of this work is done in [ApiClient.cs](https://github.com/MyPureCloud/platform-client-sdk-dotnet/blob/master/build/src/PureCloudPlatform.Client.V2/Client/ApiClient.cs)

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

This package is intended to be forwards compatible with v2 of Genesys Cloud's Platform API. While the general policy for the API is not to introduce breaking changes, there are certain additions and changes to the API that cause breaking changes for the SDK, often due to the way the API is expressed in its swagger definition. Because of this, the SDK can have a major version bump while the API remains at major version 2. While the SDK is intended to be forward compatible, patches will only be released to the latest version. For these reasons, it is strongly recommended that all applications using this SDK are kept up to date and use the latest version of the SDK.

For any issues, questions, or suggestions for the SDK, visit the [Genesys Cloud Developer Forum](https://developer.genesys.cloud/forum/).
