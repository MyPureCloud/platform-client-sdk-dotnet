# AssistantCopilotVariationsApi

## PureCloudPlatform.Client.V2.Api.AssistantCopilotVariationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAssistantVariation**](#DeleteAssistantVariation) | **Delete** /api/v2/assistants/{assistantId}/variations/{variationId} | Delete assistant copilot variation by id |
| [**GetAssistantVariation**](#GetAssistantVariation) | **Get** /api/v2/assistants/{assistantId}/variations/{variationId} | Get assistant copilot variation by id |
| [**GetAssistantVariations**](#GetAssistantVariations) | **Get** /api/v2/assistants/{assistantId}/variations | Get variations of an assistant copilot |
| [**PostAssistantVariations**](#PostAssistantVariations) | **Post** /api/v2/assistants/{assistantId}/variations | Create assistant copilot variation |
| [**PutAssistantVariation**](#PutAssistantVariation) | **Put** /api/v2/assistants/{assistantId}/variations/{variationId} | Update assistant copilot variation by id |



## DeleteAssistantVariation

> void DeleteAssistantVariation (string assistantId, string variationId)


Delete assistant copilot variation by id

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
    public class DeleteAssistantVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AssistantCopilotVariationsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var variationId = variationId_example;  // string | Variation ID

            try
            { 
                // Delete assistant copilot variation by id
                apiInstance.DeleteAssistantVariation(assistantId, variationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantCopilotVariationsApi.DeleteAssistantVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **variationId** | **string**| Variation ID |  |

### Return type

void (empty response body)


## GetAssistantVariation

> [**AssistantCopilotVariation**](AssistantCopilotVariation) GetAssistantVariation (string assistantId, string variationId)


Get assistant copilot variation by id

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
    public class GetAssistantVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AssistantCopilotVariationsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var variationId = variationId_example;  // string | Variation ID

            try
            { 
                // Get assistant copilot variation by id
                AssistantCopilotVariation result = apiInstance.GetAssistantVariation(assistantId, variationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantCopilotVariationsApi.GetAssistantVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **variationId** | **string**| Variation ID |  |

### Return type

[**AssistantCopilotVariation**](AssistantCopilotVariation)


## GetAssistantVariations

> [**AssistantCopilotVariationListing**](AssistantCopilotVariationListing) GetAssistantVariations (string assistantId)


Get variations of an assistant copilot

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
    public class GetAssistantVariationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AssistantCopilotVariationsApi();
            var assistantId = assistantId_example;  // string | Assistant ID

            try
            { 
                // Get variations of an assistant copilot
                AssistantCopilotVariationListing result = apiInstance.GetAssistantVariations(assistantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantCopilotVariationsApi.GetAssistantVariations: " + e.Message );
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

[**AssistantCopilotVariationListing**](AssistantCopilotVariationListing)


## PostAssistantVariations

> [**AssistantCopilotVariation**](AssistantCopilotVariation) PostAssistantVariations (string assistantId, AssistantCopilotVariation body)


Create assistant copilot variation

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
    public class PostAssistantVariationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AssistantCopilotVariationsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var body = new AssistantCopilotVariation(); // AssistantCopilotVariation | 

            try
            { 
                // Create assistant copilot variation
                AssistantCopilotVariation result = apiInstance.PostAssistantVariations(assistantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantCopilotVariationsApi.PostAssistantVariations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **body** | [**AssistantCopilotVariation**](AssistantCopilotVariation)|  |  |

### Return type

[**AssistantCopilotVariation**](AssistantCopilotVariation)


## PutAssistantVariation

> [**AssistantCopilotVariation**](AssistantCopilotVariation) PutAssistantVariation (string assistantId, string variationId, AssistantCopilotVariation body)


Update assistant copilot variation by id

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
    public class PutAssistantVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AssistantCopilotVariationsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var variationId = variationId_example;  // string | Variation ID
            var body = new AssistantCopilotVariation(); // AssistantCopilotVariation | 

            try
            { 
                // Update assistant copilot variation by id
                AssistantCopilotVariation result = apiInstance.PutAssistantVariation(assistantId, variationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantCopilotVariationsApi.PutAssistantVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **variationId** | **string**| Variation ID |  |
| **body** | [**AssistantCopilotVariation**](AssistantCopilotVariation)|  |  |

### Return type

[**AssistantCopilotVariation**](AssistantCopilotVariation)


_PureCloudPlatform.Client.V2 258.0.0_
