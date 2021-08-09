---
title: TextbotsApi
---
## PureCloudPlatform.Client.V2.Api.TextbotsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostTextbotsBotflowsSessionTurns**](TextbotsApi.html#posttextbotsbotflowssessionturns) | **POST** /api/v2/textbots/botflows/sessions/{sessionId}/turns | Issue a bot flow turn event |
| [**PostTextbotsBotflowsSessions**](TextbotsApi.html#posttextbotsbotflowssessions) | **POST** /api/v2/textbots/botflows/sessions | Create an execution instance of a bot flow definition. |
| [**PostTextbotsBotsExecute**](TextbotsApi.html#posttextbotsbotsexecute) | **POST** /api/v2/textbots/bots/execute | Send an intent to a bot to start a dialog/interact with it via text |
{: class="table table-striped"}

<a name="posttextbotsbotflowssessionturns"></a>

## [**TextBotFlowTurnResponse**](TextBotFlowTurnResponse.html) PostTextbotsBotflowsSessionTurns (string sessionId, TextBotFlowTurnRequest turnRequest)



Issue a bot flow turn event

Send a turn event to an executing bot flow and produce the next action to take.

Requires ANY permissions: 

* textbots:botFlowSession:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTextbotsBotflowsSessionTurnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TextbotsApi();
            var sessionId = sessionId_example;  // string | The bot flow session ID, typically obtained from 'POST /api/v2/textbots/botflows/sessions'
            var turnRequest = new TextBotFlowTurnRequest(); // TextBotFlowTurnRequest | 

            try
            { 
                // Issue a bot flow turn event
                TextBotFlowTurnResponse result = apiInstance.PostTextbotsBotflowsSessionTurns(sessionId, turnRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextbotsApi.PostTextbotsBotflowsSessionTurns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39; |  |
| **turnRequest** | [**TextBotFlowTurnRequest**](TextBotFlowTurnRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**TextBotFlowTurnResponse**](TextBotFlowTurnResponse.html)

<a name="posttextbotsbotflowssessions"></a>

## [**TextBotFlowLaunchResponse**](TextBotFlowLaunchResponse.html) PostTextbotsBotflowsSessions (TextBotFlowLaunchRequest launchRequest)



Create an execution instance of a bot flow definition.

The launch is asynchronous; use the returned instance ID to post turns to it using 'POST /api/v2/textbots/botflows/sessions/{sessionId}/turns'.

Requires ANY permissions: 

* textbots:botFlowSession:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTextbotsBotflowsSessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TextbotsApi();
            var launchRequest = new TextBotFlowLaunchRequest(); // TextBotFlowLaunchRequest | 

            try
            { 
                // Create an execution instance of a bot flow definition.
                TextBotFlowLaunchResponse result = apiInstance.PostTextbotsBotflowsSessions(launchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextbotsApi.PostTextbotsBotflowsSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **launchRequest** | [**TextBotFlowLaunchRequest**](TextBotFlowLaunchRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**TextBotFlowLaunchResponse**](TextBotFlowLaunchResponse.html)

<a name="posttextbotsbotsexecute"></a>

## [**PostTextResponse**](PostTextResponse.html) PostTextbotsBotsExecute (PostTextRequest postTextRequest)



Send an intent to a bot to start a dialog/interact with it via text

This will either start a bot with the given id or relay a communication to an existing bot session.

Requires ANY permissions: 

* textbots:session:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTextbotsBotsExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TextbotsApi();
            var postTextRequest = new PostTextRequest(); // PostTextRequest | 

            try
            { 
                // Send an intent to a bot to start a dialog/interact with it via text
                PostTextResponse result = apiInstance.PostTextbotsBotsExecute(postTextRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextbotsApi.PostTextbotsBotsExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **postTextRequest** | [**PostTextRequest**](PostTextRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**PostTextResponse**](PostTextResponse.html)

