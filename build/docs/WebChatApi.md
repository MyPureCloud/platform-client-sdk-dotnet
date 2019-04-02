---
title: WebChatApi
---
## PureCloudPlatform.Client.V2.Api.WebChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebchatDeployment**](WebChatApi.html#deletewebchatdeployment) | **DELETE** /api/v2/webchat/deployments/{deploymentId} | Delete a WebChat deployment |
| [**DeleteWebchatSettings**](WebChatApi.html#deletewebchatsettings) | **DELETE** /api/v2/webchat/settings | Remove WebChat deployment settings |
| [**GetWebchatDeployment**](WebChatApi.html#getwebchatdeployment) | **GET** /api/v2/webchat/deployments/{deploymentId} | Get a WebChat deployment |
| [**GetWebchatDeployments**](WebChatApi.html#getwebchatdeployments) | **GET** /api/v2/webchat/deployments | List WebChat deployments |
| [**GetWebchatSettings**](WebChatApi.html#getwebchatsettings) | **GET** /api/v2/webchat/settings | Get WebChat deployment settings |
| [**PostWebchatDeployments**](WebChatApi.html#postwebchatdeployments) | **POST** /api/v2/webchat/deployments | Create WebChat deployment |
| [**PutWebchatDeployment**](WebChatApi.html#putwebchatdeployment) | **PUT** /api/v2/webchat/deployments/{deploymentId} | Update a WebChat deployment |
| [**PutWebchatSettings**](WebChatApi.html#putwebchatsettings) | **PUT** /api/v2/webchat/settings | Update WebChat deployment settings |
{: class="table table-striped"}

<a name="deletewebchatdeployment"></a>

## void DeleteWebchatDeployment (string deploymentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a WebChat deployment



Requires ANY permissions: 

* webchat:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id

            try
            { 
                // Delete a WebChat deployment
                apiInstance.DeleteWebchatDeployment(deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.DeleteWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletewebchatsettings"></a>

## void DeleteWebchatSettings ()



Remove WebChat deployment settings



Requires ANY permissions: 

* webchat:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();

            try
            { 
                // Remove WebChat deployment settings
                apiInstance.DeleteWebchatSettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.DeleteWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getwebchatdeployment"></a>

## [**WebChatDeployment**](WebChatDeployment.html) GetWebchatDeployment (string deploymentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a WebChat deployment



Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id

            try
            { 
                // Get a WebChat deployment
                WebChatDeployment result = apiInstance.GetWebchatDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="getwebchatdeployments"></a>

## [**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing.html) GetWebchatDeployments ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

List WebChat deployments



Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();

            try
            { 
                // List WebChat deployments
                WebChatDeploymentEntityListing result = apiInstance.GetWebchatDeployments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing.html)

<a name="getwebchatsettings"></a>

## [**WebChatSettings**](WebChatSettings.html) GetWebchatSettings ()



Get WebChat deployment settings



Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();

            try
            { 
                // Get WebChat deployment settings
                WebChatSettings result = apiInstance.GetWebchatSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WebChatSettings**](WebChatSettings.html)

<a name="postwebchatdeployments"></a>

## [**WebChatDeployment**](WebChatDeployment.html) PostWebchatDeployments (WebChatDeployment body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create WebChat deployment



Requires ANY permissions: 

* webchat:deployment:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebchatDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();
            var body = new WebChatDeployment(); // WebChatDeployment | Deployment

            try
            { 
                // Create WebChat deployment
                WebChatDeployment result = apiInstance.PostWebchatDeployments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PostWebchatDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebChatDeployment**](WebChatDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="putwebchatdeployment"></a>

## [**WebChatDeployment**](WebChatDeployment.html) PutWebchatDeployment (string deploymentId, WebChatDeployment body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update a WebChat deployment



Requires ANY permissions: 

* webchat:deployment:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id
            var body = new WebChatDeployment(); // WebChatDeployment | Deployment

            try
            { 
                // Update a WebChat deployment
                WebChatDeployment result = apiInstance.PutWebchatDeployment(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PutWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |
| **body** | [**WebChatDeployment**](WebChatDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="putwebchatsettings"></a>

## [**WebChatSettings**](WebChatSettings.html) PutWebchatSettings (WebChatSettings body)



Update WebChat deployment settings



Requires ANY permissions: 

* webchat:deployment:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebChatApi();
            var body = new WebChatSettings(); // WebChatSettings | webChatSettings

            try
            { 
                // Update WebChat deployment settings
                WebChatSettings result = apiInstance.PutWebchatSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PutWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebChatSettings**](WebChatSettings.html)| webChatSettings |  |
{: class="table table-striped"}

### Return type

[**WebChatSettings**](WebChatSettings.html)

