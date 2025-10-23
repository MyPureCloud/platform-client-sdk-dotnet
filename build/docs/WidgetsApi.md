# WidgetsApi

## PureCloudPlatform.Client.V2.Api.WidgetsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWidgetsDeployment**](#DeleteWidgetsDeployment) | **Delete** /api/v2/widgets/deployments/{deploymentId} | Delete a Widget deployment |
| [**GetWidgetsDeployment**](#GetWidgetsDeployment) | **Get** /api/v2/widgets/deployments/{deploymentId} | Get a Widget deployment |
| [**GetWidgetsDeployments**](#GetWidgetsDeployments) | **Get** /api/v2/widgets/deployments | List Widget deployments |
| [**PostWidgetsDeployments**](#PostWidgetsDeployments) | **Post** /api/v2/widgets/deployments | Create Widget deployment |
| [**PutWidgetsDeployment**](#PutWidgetsDeployment) | **Put** /api/v2/widgets/deployments/{deploymentId} | Update a Widget deployment |



## DeleteWidgetsDeployment

> void DeleteWidgetsDeployment (string deploymentId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Delete a Widget deployment

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## GetWidgetsDeployment

> [**WidgetDeployment**](WidgetDeployment) GetWidgetsDeployment (string deploymentId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a Widget deployment

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**WidgetDeployment**](WidgetDeployment)


## GetWidgetsDeployments

> [**WidgetDeploymentEntityListing**](WidgetDeploymentEntityListing) GetWidgetsDeployments ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

List Widget deployments

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**WidgetDeploymentEntityListing**](WidgetDeploymentEntityListing)


## PostWidgetsDeployments

> [**WidgetDeployment**](WidgetDeployment) PostWidgetsDeployments (WidgetDeployment body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create Widget deployment

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **body** | [**WidgetDeployment**](WidgetDeployment)| Deployment |  |

### Return type

[**WidgetDeployment**](WidgetDeployment)


## PutWidgetsDeployment

> [**WidgetDeployment**](WidgetDeployment) PutWidgetsDeployment (string deploymentId, WidgetDeployment body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a Widget deployment

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **body** | [**WidgetDeployment**](WidgetDeployment)| Deployment |  |

### Return type

[**WidgetDeployment**](WidgetDeployment)


_PureCloudPlatform.Client.V2 246.0.0_
