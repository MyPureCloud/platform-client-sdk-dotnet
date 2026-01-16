# WebMessagingApi

## PureCloudPlatform.Client.V2.Api.WebMessagingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebmessagingDeploymentPushdevice**](#DeleteWebmessagingDeploymentPushdevice) | **Delete** /api/v2/webmessaging/deployments/{deploymentId}/pushdevices/{tokenId} | Delete device information |
| [**GetWebmessagingMessages**](#GetWebmessagingMessages) | **Get** /api/v2/webmessaging/messages | Get the messages for a web messaging session. |
| [**PatchWebmessagingDeploymentPushdevice**](#PatchWebmessagingDeploymentPushdevice) | **Patch** /api/v2/webmessaging/deployments/{deploymentId}/pushdevices/{tokenId} | Edit device information |
| [**PostWebmessagingDeploymentPushdevice**](#PostWebmessagingDeploymentPushdevice) | **Post** /api/v2/webmessaging/deployments/{deploymentId}/pushdevices/{tokenId} | Add a new device information |



## DeleteWebmessagingDeploymentPushdevice

> void DeleteWebmessagingDeploymentPushdevice (string deploymentId, string tokenId)


Delete device information

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebmessagingDeploymentPushdeviceExample
    {
        public void main()
        { 

            var apiInstance = new WebMessagingApi();
            var deploymentId = deploymentId_example;  // string | WebMessaging deployment id
            var tokenId = tokenId_example;  // string | Device token id or cookie id

            try
            { 
                // Delete device information
                apiInstance.DeleteWebmessagingDeploymentPushdevice(deploymentId, tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebMessagingApi.DeleteWebmessagingDeploymentPushdevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| WebMessaging deployment id |  |
| **tokenId** | **string**| Device token id or cookie id |  |

### Return type

void (empty response body)


## GetWebmessagingMessages

> [**WebMessagingMessageEntityList**](WebMessagingMessageEntityList) GetWebmessagingMessages (int? pageSize = null, int? pageNumber = null)


Get the messages for a web messaging session.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebmessagingMessagesExample
    {
        public void main()
        { 

            var apiInstance = new WebMessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get the messages for a web messaging session.
                WebMessagingMessageEntityList result = apiInstance.GetWebmessagingMessages(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebMessagingApi.GetWebmessagingMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**WebMessagingMessageEntityList**](WebMessagingMessageEntityList)


## PatchWebmessagingDeploymentPushdevice

> void PatchWebmessagingDeploymentPushdevice (string deploymentId, string tokenId, PushDeviceUpdateRequest body)


Edit device information

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWebmessagingDeploymentPushdeviceExample
    {
        public void main()
        { 

            var apiInstance = new WebMessagingApi();
            var deploymentId = deploymentId_example;  // string | WebMessaging deployment id
            var tokenId = tokenId_example;  // string | Device token id or cookie id
            var body = new PushDeviceUpdateRequest(); // PushDeviceUpdateRequest | Request body

            try
            { 
                // Edit device information
                apiInstance.PatchWebmessagingDeploymentPushdevice(deploymentId, tokenId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebMessagingApi.PatchWebmessagingDeploymentPushdevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| WebMessaging deployment id |  |
| **tokenId** | **string**| Device token id or cookie id |  |
| **body** | [**PushDeviceUpdateRequest**](PushDeviceUpdateRequest)| Request body |  |

### Return type

void (empty response body)


## PostWebmessagingDeploymentPushdevice

> void PostWebmessagingDeploymentPushdevice (string deploymentId, string tokenId, PushDeviceInsertRequest body)


Add a new device information

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebmessagingDeploymentPushdeviceExample
    {
        public void main()
        { 

            var apiInstance = new WebMessagingApi();
            var deploymentId = deploymentId_example;  // string | WebMessaging deployment id
            var tokenId = tokenId_example;  // string | Device token id or cookie id
            var body = new PushDeviceInsertRequest(); // PushDeviceInsertRequest | Request body

            try
            { 
                // Add a new device information
                apiInstance.PostWebmessagingDeploymentPushdevice(deploymentId, tokenId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebMessagingApi.PostWebmessagingDeploymentPushdevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| WebMessaging deployment id |  |
| **tokenId** | **string**| Device token id or cookie id |  |
| **body** | [**PushDeviceInsertRequest**](PushDeviceInsertRequest)| Request body |  |

### Return type

void (empty response body)


_PureCloudPlatform.Client.V2 254.0.0_
