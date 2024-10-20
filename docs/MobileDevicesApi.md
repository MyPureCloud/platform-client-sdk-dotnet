# MobileDevicesApi

## PureCloudPlatform.Client.V2.Api.MobileDevicesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMobiledevice**](#DeleteMobiledevice) | **Delete** /api/v2/mobiledevices/{deviceId} | Delete device |
| [**GetMobiledevice**](#GetMobiledevice) | **Get** /api/v2/mobiledevices/{deviceId} | Get device |
| [**GetMobiledevices**](#GetMobiledevices) | **Get** /api/v2/mobiledevices | Get a list of all devices. |
| [**PostMobiledevices**](#PostMobiledevices) | **Post** /api/v2/mobiledevices | Create User device |
| [**PutMobiledevice**](#PutMobiledevice) | **Put** /api/v2/mobiledevices/{deviceId} | Update device |



## DeleteMobiledevice

> void DeleteMobiledevice (string deviceId)


Delete device

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
    public class DeleteMobiledeviceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MobileDevicesApi();
            var deviceId = deviceId_example;  // string | Device ID

            try
            { 
                // Delete device
                apiInstance.DeleteMobiledevice(deviceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileDevicesApi.DeleteMobiledevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |

### Return type

void (empty response body)


## GetMobiledevice

> [**UserDevice**](UserDevice) GetMobiledevice (string deviceId)


Get device

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
    public class GetMobiledeviceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MobileDevicesApi();
            var deviceId = deviceId_example;  // string | Device ID

            try
            { 
                // Get device
                UserDevice result = apiInstance.GetMobiledevice(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileDevicesApi.GetMobiledevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |

### Return type

[**UserDevice**](UserDevice)


## GetMobiledevices

> [**DirectoryUserDevicesListing**](DirectoryUserDevicesListing) GetMobiledevices (int? pageSize = null, int? pageNumber = null, string sortOrder = null)


Get a list of all devices.

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
    public class GetMobiledevicesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MobileDevicesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ascending)

            try
            { 
                // Get a list of all devices.
                DirectoryUserDevicesListing result = apiInstance.GetMobiledevices(pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileDevicesApi.GetMobiledevices: " + e.Message );
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
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |

### Return type

[**DirectoryUserDevicesListing**](DirectoryUserDevicesListing)


## PostMobiledevices

> [**UserDevice**](UserDevice) PostMobiledevices (UserDevice body)


Create User device

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
    public class PostMobiledevicesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MobileDevicesApi();
            var body = new UserDevice(); // UserDevice | Device

            try
            { 
                // Create User device
                UserDevice result = apiInstance.PostMobiledevices(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileDevicesApi.PostMobiledevices: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDevice**](UserDevice)| Device |  |

### Return type

[**UserDevice**](UserDevice)


## PutMobiledevice

> [**UserDevice**](UserDevice) PutMobiledevice (string deviceId, UserDevice body = null)


Update device

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
    public class PutMobiledeviceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MobileDevicesApi();
            var deviceId = deviceId_example;  // string | Device ID
            var body = new UserDevice(); // UserDevice | Device (optional) 

            try
            { 
                // Update device
                UserDevice result = apiInstance.PutMobiledevice(deviceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileDevicesApi.PutMobiledevice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |
| **body** | [**UserDevice**](UserDevice)| Device | [optional]  |

### Return type

[**UserDevice**](UserDevice)


_PureCloudPlatform.Client.V2 219.0.0_
