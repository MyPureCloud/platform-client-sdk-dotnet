# AgentCopilotApi

## PureCloudPlatform.Client.V2.Api.AgentCopilotApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAssistantCopilot**](#GetAssistantCopilot) | **Get** /api/v2/assistants/{assistantId}/copilot | Get copilot configuration of an assistant. |
| [**GetAssistantsCopilotFeaturesupport**](#GetAssistantsCopilotFeaturesupport) | **Get** /api/v2/assistants/copilot/featuresupport | Get information about the support of features for all the languages or only for a certain language. |
| [**PutAssistantCopilot**](#PutAssistantCopilot) | **Put** /api/v2/assistants/{assistantId}/copilot | Update agent copilot configuration |



## GetAssistantCopilot

> [**Copilot**](Copilot) GetAssistantCopilot (string assistantId)


Get copilot configuration of an assistant.

Requires ALL permissions: 

* assistants:copilot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantCopilotExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentCopilotApi();
            var assistantId = assistantId_example;  // string | Assistant ID

            try
            { 
                // Get copilot configuration of an assistant.
                Copilot result = apiInstance.GetAssistantCopilot(assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCopilotApi.GetAssistantCopilot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |

### Return type

[**Copilot**](Copilot)


## GetAssistantsCopilotFeaturesupport

> [**LanguageSupportResponse**](LanguageSupportResponse) GetAssistantsCopilotFeaturesupport (string language = null)


Get information about the support of features for all the languages or only for a certain language.

Requires ALL permissions: 

* assistants:copilot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantsCopilotFeaturesupportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentCopilotApi();
            var language = language_example;  // string | Which language are the features supported for (optional) 

            try
            { 
                // Get information about the support of features for all the languages or only for a certain language.
                LanguageSupportResponse result = apiInstance.GetAssistantsCopilotFeaturesupport(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCopilotApi.GetAssistantsCopilotFeaturesupport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| Which language are the features supported for | [optional]  |

### Return type

[**LanguageSupportResponse**](LanguageSupportResponse)


## PutAssistantCopilot

> [**Copilot**](Copilot) PutAssistantCopilot (string assistantId, Copilot body)


Update agent copilot configuration

Requires ALL permissions: 

* assistants:copilot:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAssistantCopilotExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentCopilotApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var body = new Copilot(); // Copilot | 

            try
            { 
                // Update agent copilot configuration
                Copilot result = apiInstance.PutAssistantCopilot(assistantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCopilotApi.PutAssistantCopilot: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **body** | [**Copilot**](Copilot)|  |  |

### Return type

[**Copilot**](Copilot)


_PureCloudPlatform.Client.V2 252.1.0_
