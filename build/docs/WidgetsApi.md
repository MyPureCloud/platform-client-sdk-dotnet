---
title: WidgetsApi
---
## PureCloudPlatform.Client.V2.Api.WidgetsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWidgetsDeployment**](WidgetsApi.html#deletewidgetsdeployment) | **DELETE** /api/v2/widgets/deployments/{deploymentId} | Delete a Widget deployment |
| [**GetWidgetsDeployment**](WidgetsApi.html#getwidgetsdeployment) | **GET** /api/v2/widgets/deployments/{deploymentId} | Get a Widget deployment |
| [**GetWidgetsDeployments**](WidgetsApi.html#getwidgetsdeployments) | **GET** /api/v2/widgets/deployments | List Widget deployments |
| [**PostWidgetsDeployments**](WidgetsApi.html#postwidgetsdeployments) | **POST** /api/v2/widgets/deployments | Create Widget deployment |
| [**PutWidgetsDeployment**](WidgetsApi.html#putwidgetsdeployment) | **PUT** /api/v2/widgets/deployments/{deploymentId} | Update a Widget deployment |
{: class="table table-striped"}

<a name="deletewidgetsdeployment"></a>

## void DeleteWidgetsDeployment (string deploymentId)



Delete a Widget deployment



Requires ANY permissions: 

* widgets:deployment:delete
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
    public class DeleteWidgetsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetsApi();
            var deploymentId = deploymentId_example;  // string | Widget Config Id

            try
            { 
                // Delete a Widget deployment
                apiInstance.DeleteWidgetsDeployment(deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.DeleteWidgetsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Widget Config Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getwidgetsdeployment"></a>

## [**WidgetDeployment**](WidgetDeployment.html) GetWidgetsDeployment (string deploymentId)



Get a Widget deployment



Requires ANY permissions: 

* widgets:deployment:view
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
    public class GetWidgetsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetsApi();
            var deploymentId = deploymentId_example;  // string | Widget Config Id

            try
            { 
                // Get a Widget deployment
                WidgetDeployment result = apiInstance.GetWidgetsDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Widget Config Id |  |
{: class="table table-striped"}

### Return type

[**WidgetDeployment**](WidgetDeployment.html)

<a name="getwidgetsdeployments"></a>

## [**WidgetDeploymentEntityListing**](WidgetDeploymentEntityListing.html) GetWidgetsDeployments ()



List Widget deployments



Requires ANY permissions: 

* widgets:deployment:view
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
    public class GetWidgetsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetsApi();

            try
            { 
                // List Widget deployments
                WidgetDeploymentEntityListing result = apiInstance.GetWidgetsDeployments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WidgetDeploymentEntityListing**](WidgetDeploymentEntityListing.html)

<a name="postwidgetsdeployments"></a>

## [**WidgetDeployment**](WidgetDeployment.html) PostWidgetsDeployments (WidgetDeployment body)



Create Widget deployment



Requires ANY permissions: 

* widgets:deployment:add
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
    public class PostWidgetsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetsApi();
            var body = new WidgetDeployment(); // WidgetDeployment | Deployment

            try
            { 
                // Create Widget deployment
                WidgetDeployment result = apiInstance.PostWidgetsDeployments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.PostWidgetsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WidgetDeployment**](WidgetDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WidgetDeployment**](WidgetDeployment.html)

<a name="putwidgetsdeployment"></a>

## [**WidgetDeployment**](WidgetDeployment.html) PutWidgetsDeployment (string deploymentId, WidgetDeployment body)



Update a Widget deployment



Requires ANY permissions: 

* widgets:deployment:edit
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
    public class PutWidgetsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetsApi();
            var deploymentId = deploymentId_example;  // string | Widget Config Id
            var body = new WidgetDeployment(); // WidgetDeployment | Deployment

            try
            { 
                // Update a Widget deployment
                WidgetDeployment result = apiInstance.PutWidgetsDeployment(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.PutWidgetsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Widget Config Id |  |
| **body** | [**WidgetDeployment**](WidgetDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WidgetDeployment**](WidgetDeployment.html)

