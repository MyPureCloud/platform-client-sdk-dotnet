---
title: MobileDevicesApi
---
## PureCloudPlatform.Client.V2.Api.MobileDevicesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMobiledevice**](MobileDevicesApi.html#deletemobiledevice) | **DELETE** /api/v2/mobiledevices/{deviceId} | Delete device |
| [**GetMobiledevice**](MobileDevicesApi.html#getmobiledevice) | **GET** /api/v2/mobiledevices/{deviceId} | Get device |
| [**GetMobiledevices**](MobileDevicesApi.html#getmobiledevices) | **GET** /api/v2/mobiledevices | Get a list of all devices. |
| [**PostMobiledevices**](MobileDevicesApi.html#postmobiledevices) | **POST** /api/v2/mobiledevices | Create User device |
| [**PutMobiledevice**](MobileDevicesApi.html#putmobiledevice) | **PUT** /api/v2/mobiledevices/{deviceId} | Update device |
{: class="table table-striped"}

<a name="deletemobiledevice"></a>

## void DeleteMobiledevice (string deviceId)



Delete device



Requires NO permissions: 



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getmobiledevice"></a>

## [**UserDevice**](UserDevice.html) GetMobiledevice (string deviceId)



Get device



Requires NO permissions: 



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |
{: class="table table-striped"}

### Return type

[**UserDevice**](UserDevice.html)

<a name="getmobiledevices"></a>

## [**DirectoryUserDevicesListing**](DirectoryUserDevicesListing.html) GetMobiledevices (int? pageSize = null, int? pageNumber = null, string sortOrder = null)



Get a list of all devices.



Requires NO permissions: 



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**DirectoryUserDevicesListing**](DirectoryUserDevicesListing.html)

<a name="postmobiledevices"></a>

## [**UserDevice**](UserDevice.html) PostMobiledevices (UserDevice body)



Create User device



Requires NO permissions: 



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDevice**](UserDevice.html)| Device |  |
{: class="table table-striped"}

### Return type

[**UserDevice**](UserDevice.html)

<a name="putmobiledevice"></a>

## [**UserDevice**](UserDevice.html) PutMobiledevice (string deviceId, UserDevice body = null)



Update device



Requires NO permissions: 



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deviceId** | **string**| Device ID |  |
| **body** | [**UserDevice**](UserDevice.html)| Device | [optional]  |
{: class="table table-striped"}

### Return type

[**UserDevice**](UserDevice.html)

