# TextbotsApi

## PureCloudPlatform.Client.V2.Api.TextbotsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetTextbotsBotsSearch**](#GetTextbotsBotsSearch) | **Get** /api/v2/textbots/bots/search | Find bots using the currently configured friendly name or ID. |
| [**PostTextbotsBotflowsSessionTurns**](#PostTextbotsBotflowsSessionTurns) | **Post** /api/v2/textbots/botflows/sessions/{sessionId}/turns | Issue a bot flow turn event |
| [**PostTextbotsBotflowsSessions**](#PostTextbotsBotflowsSessions) | **Post** /api/v2/textbots/botflows/sessions | Create an execution instance of a bot flow definition. |
| [**PostTextbotsBotsExecute**](#PostTextbotsBotsExecute) | **Post** /api/v2/textbots/bots/execute | Send an intent to a bot to start a dialog/interact with it via text |



## GetTextbotsBotsSearch

> [**BotSearchResponseEntityListing**](BotSearchResponseEntityListing) GetTextbotsBotsSearch (List<string> botType = null, string botName = null, List<string> botId = null, int? pageSize = null)


Find bots using the currently configured friendly name or ID.

The name does allow case-insensitive partial string matches or by IDs (up to 50), but not both at the same time. Optionally you can limit the scope of the search by providing one or more bot types.  You can specify the maximum results to return, up to a limit of 100

Requires ANY permissions: 

* integrations:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTextbotsBotsSearchExample
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
            var botType = new List<string>(); // List<string> | Bot types (optional) 
            var botName = botName_example;  // string | Bot name (optional) 
            var botId = new List<string>(); // List<string> | Bot IDs (optional) 
            var pageSize = 56;  // int? | The maximum results to return (optional)  (default to 25)

            try
            { 
                // Find bots using the currently configured friendly name or ID.
                BotSearchResponseEntityListing result = apiInstance.GetTextbotsBotsSearch(botType, botName, botId, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextbotsApi.GetTextbotsBotsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botType** | [**List<string>**](string)| Bot types | [optional] <br />**Values**: GenesysBotConnector, GenesysDialogEngine, AmazonLex, GoogleDialogFlowES, GoogleDialogFlowCX, NuanceDlg, GenesysBotFlow, GenesysDigitalBotFlow, GenesysVoiceSurveyFlow |
| **botName** | **string**| Bot name | [optional]  |
| **botId** | [**List<string>**](string)| Bot IDs | [optional]  |
| **pageSize** | **int?**| The maximum results to return | [optional] [default to 25] |

### Return type

[**BotSearchResponseEntityListing**](BotSearchResponseEntityListing)


## PostTextbotsBotflowsSessionTurns

> [**TextBotFlowTurnResponse**](TextBotFlowTurnResponse) PostTextbotsBotflowsSessionTurns (string sessionId, TextBotFlowTurnRequest turnRequest)


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
| **turnRequest** | [**TextBotFlowTurnRequest**](TextBotFlowTurnRequest)|  |  |

### Return type

[**TextBotFlowTurnResponse**](TextBotFlowTurnResponse)


## PostTextbotsBotflowsSessions

> [**TextBotFlowLaunchResponse**](TextBotFlowLaunchResponse) PostTextbotsBotflowsSessions (TextBotFlowLaunchRequest launchRequest)


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
| **launchRequest** | [**TextBotFlowLaunchRequest**](TextBotFlowLaunchRequest)|  |  |

### Return type

[**TextBotFlowLaunchResponse**](TextBotFlowLaunchResponse)


## PostTextbotsBotsExecute

> [**PostTextResponse**](PostTextResponse) PostTextbotsBotsExecute (PostTextRequest postTextRequest)


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
| **postTextRequest** | [**PostTextRequest**](PostTextRequest)|  |  |

### Return type

[**PostTextResponse**](PostTextResponse)


_PureCloudPlatform.Client.V2 218.0.0_
