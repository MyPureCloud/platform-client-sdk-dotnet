# CarrierServicesApi

## PureCloudPlatform.Client.V2.Api.CarrierServicesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetCarrierservicesIntegrationsEmergencylocationsMe**](#GetCarrierservicesIntegrationsEmergencylocationsMe) | **Get** /api/v2/carrierservices/integrations/emergencylocations/me | Get location for the logged in user |
| [**PostCarrierservicesIntegrationsEmergencylocationsMe**](#PostCarrierservicesIntegrationsEmergencylocationsMe) | **Post** /api/v2/carrierservices/integrations/emergencylocations/me | Set current location for the logged in user |



## GetCarrierservicesIntegrationsEmergencylocationsMe

> [**EmergencyLocation**](EmergencyLocation) GetCarrierservicesIntegrationsEmergencylocationsMe (string phoneNumber)


Get location for the logged in user

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
    public class GetCarrierservicesIntegrationsEmergencylocationsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CarrierServicesApi();
            var phoneNumber = phoneNumber_example;  // string | Phone number in E164 format

            try
            { 
                // Get location for the logged in user
                EmergencyLocation result = apiInstance.GetCarrierservicesIntegrationsEmergencylocationsMe(phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierServicesApi.GetCarrierservicesIntegrationsEmergencylocationsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumber** | **string**| Phone number in E164 format |  |

### Return type

[**EmergencyLocation**](EmergencyLocation)


## PostCarrierservicesIntegrationsEmergencylocationsMe

> [**EmergencyLocation**](EmergencyLocation) PostCarrierservicesIntegrationsEmergencylocationsMe (EmergencyLocation body = null)


Set current location for the logged in user

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
    public class PostCarrierservicesIntegrationsEmergencylocationsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CarrierServicesApi();
            var body = new EmergencyLocation(); // EmergencyLocation |  (optional) 

            try
            { 
                // Set current location for the logged in user
                EmergencyLocation result = apiInstance.PostCarrierservicesIntegrationsEmergencylocationsMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierServicesApi.PostCarrierservicesIntegrationsEmergencylocationsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmergencyLocation**](EmergencyLocation)|  | [optional]  |

### Return type

[**EmergencyLocation**](EmergencyLocation)


_PureCloudPlatform.Client.V2 231.0.0_
