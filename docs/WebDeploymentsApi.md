# WebDeploymentsApi

## PureCloudPlatform.Client.V2.Api.WebDeploymentsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebdeploymentsConfiguration**](#DeleteWebdeploymentsConfiguration) | **Delete** /api/v2/webdeployments/configurations/{configurationId} | Delete all versions of a configuration |
| [**DeleteWebdeploymentsDeployment**](#DeleteWebdeploymentsDeployment) | **Delete** /api/v2/webdeployments/deployments/{deploymentId} | Delete a deployment |
| [**DeleteWebdeploymentsDeploymentCobrowseSessionId**](#DeleteWebdeploymentsDeploymentCobrowseSessionId) | **Delete** /api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId} | Deletes a cobrowse session |
| [**DeleteWebdeploymentsTokenRevoke**](#DeleteWebdeploymentsTokenRevoke) | **Delete** /api/v2/webdeployments/token/revoke | Invalidate JWT |
| [**GetWebdeploymentsConfigurationVersion**](#GetWebdeploymentsConfigurationVersion) | **Get** /api/v2/webdeployments/configurations/{configurationId}/versions/{versionId} | Get a configuration version |
| [**GetWebdeploymentsConfigurationVersions**](#GetWebdeploymentsConfigurationVersions) | **Get** /api/v2/webdeployments/configurations/{configurationId}/versions | Get the versions of a configuration |
| [**GetWebdeploymentsConfigurationVersionsDraft**](#GetWebdeploymentsConfigurationVersionsDraft) | **Get** /api/v2/webdeployments/configurations/{configurationId}/versions/draft | Get the configuration draft |
| [**GetWebdeploymentsConfigurations**](#GetWebdeploymentsConfigurations) | **Get** /api/v2/webdeployments/configurations | View configuration drafts |
| [**GetWebdeploymentsDeployment**](#GetWebdeploymentsDeployment) | **Get** /api/v2/webdeployments/deployments/{deploymentId} | Get a deployment |
| [**GetWebdeploymentsDeploymentCobrowseSessionId**](#GetWebdeploymentsDeploymentCobrowseSessionId) | **Get** /api/v2/webdeployments/deployments/{deploymentId}/cobrowse/{sessionId} | Retrieves a cobrowse session |
| [**GetWebdeploymentsDeploymentConfigurations**](#GetWebdeploymentsDeploymentConfigurations) | **Get** /api/v2/webdeployments/deployments/{deploymentId}/configurations | Get active configuration for a given deployment |
| [**GetWebdeploymentsDeploymentIdentityresolution**](#GetWebdeploymentsDeploymentIdentityresolution) | **Get** /api/v2/webdeployments/deployments/{deploymentId}/identityresolution | Get a deployment identity resolution setting. |
| [**GetWebdeploymentsDeployments**](#GetWebdeploymentsDeployments) | **Get** /api/v2/webdeployments/deployments | Get deployments |
| [**PostWebdeploymentsConfigurationVersionsDraftPublish**](#PostWebdeploymentsConfigurationVersionsDraftPublish) | **Post** /api/v2/webdeployments/configurations/{configurationId}/versions/draft/publish | Publish the configuration draft and create a new version |
| [**PostWebdeploymentsConfigurations**](#PostWebdeploymentsConfigurations) | **Post** /api/v2/webdeployments/configurations | Create a configuration draft |
| [**PostWebdeploymentsDeployments**](#PostWebdeploymentsDeployments) | **Post** /api/v2/webdeployments/deployments | Create a deployment |
| [**PostWebdeploymentsTokenOauthcodegrantjwtexchange**](#PostWebdeploymentsTokenOauthcodegrantjwtexchange) | **Post** /api/v2/webdeployments/token/oauthcodegrantjwtexchange | Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments. |
| [**PostWebdeploymentsTokenRefresh**](#PostWebdeploymentsTokenRefresh) | **Post** /api/v2/webdeployments/token/refresh | Refresh a JWT. |
| [**PutWebdeploymentsConfigurationVersionsDraft**](#PutWebdeploymentsConfigurationVersionsDraft) | **Put** /api/v2/webdeployments/configurations/{configurationId}/versions/draft | Update the configuration draft |
| [**PutWebdeploymentsDeployment**](#PutWebdeploymentsDeployment) | **Put** /api/v2/webdeployments/deployments/{deploymentId} | Update a deployment |
| [**PutWebdeploymentsDeploymentIdentityresolution**](#PutWebdeploymentsDeploymentIdentityresolution) | **Put** /api/v2/webdeployments/deployments/{deploymentId}/identityresolution | Update identity resolution settings for a deployment. |



## DeleteWebdeploymentsConfiguration

> void DeleteWebdeploymentsConfiguration (string configurationId)


Delete all versions of a configuration

Requires ALL permissions: 

* webDeployments:configuration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebdeploymentsConfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Delete all versions of a configuration
                apiInstance.DeleteWebdeploymentsConfiguration(configurationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |

### Return type

void (empty response body)


## DeleteWebdeploymentsDeployment

> void DeleteWebdeploymentsDeployment (string deploymentId)


Delete a deployment

Requires ALL permissions: 

* webDeployments:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID

            try
            { 
                // Delete a deployment
                apiInstance.DeleteWebdeploymentsDeployment(deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |

### Return type

void (empty response body)


## DeleteWebdeploymentsDeploymentCobrowseSessionId

> **Object** DeleteWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId)


Deletes a cobrowse session

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
    public class DeleteWebdeploymentsDeploymentCobrowseSessionIdExample
    {
        public void main()
        { 

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | WebMessaging deployment ID
            var sessionId = sessionId_example;  // string | Cobrowse session id or join code

            try
            { 
                // Deletes a cobrowse session
                Object result = apiInstance.DeleteWebdeploymentsDeploymentCobrowseSessionId(deploymentId, sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsDeploymentCobrowseSessionId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| WebMessaging deployment ID |  |
| **sessionId** | **string**| Cobrowse session id or join code |  |

### Return type

**Object**


## DeleteWebdeploymentsTokenRevoke

> void DeleteWebdeploymentsTokenRevoke (string xJourneySessionId = null, string xJourneySessionType = null)


Invalidate JWT

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
    public class DeleteWebdeploymentsTokenRevokeExample
    {
        public void main()
        { 

            var apiInstance = new WebDeploymentsApi();
            var xJourneySessionId = xJourneySessionId_example;  // string | The Customer's journey sessionId. (optional) 
            var xJourneySessionType = xJourneySessionType_example;  // string | The Customer's journey session type. (optional) 

            try
            { 
                // Invalidate JWT
                apiInstance.DeleteWebdeploymentsTokenRevoke(xJourneySessionId, xJourneySessionType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.DeleteWebdeploymentsTokenRevoke: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **xJourneySessionId** | **string**| The Customer&#39;s journey sessionId. | [optional]  |
| **xJourneySessionType** | **string**| The Customer&#39;s journey session type. | [optional]  |

### Return type

void (empty response body)


## GetWebdeploymentsConfigurationVersion

> [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion) GetWebdeploymentsConfigurationVersion (string configurationId, string versionId)


Get a configuration version

Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID
            var versionId = versionId_example;  // string | The version of the configuration to get

            try
            { 
                // Get a configuration version
                WebDeploymentConfigurationVersion result = apiInstance.GetWebdeploymentsConfigurationVersion(configurationId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
| **versionId** | **string**| The version of the configuration to get |  |

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)


## GetWebdeploymentsConfigurationVersions

> [**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing) GetWebdeploymentsConfigurationVersions (string configurationId)


Get the versions of a configuration

This returns the 50 most recent versions for this configuration

Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Get the versions of a configuration
                WebDeploymentConfigurationVersionEntityListing result = apiInstance.GetWebdeploymentsConfigurationVersions(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |

### Return type

[**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing)


## GetWebdeploymentsConfigurationVersionsDraft

> [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion) GetWebdeploymentsConfigurationVersionsDraft (string configurationId)


Get the configuration draft

Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationVersionsDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Get the configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.GetWebdeploymentsConfigurationVersionsDraft(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurationVersionsDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)


## GetWebdeploymentsConfigurations

> [**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing) GetWebdeploymentsConfigurations (bool? showOnlyPublished = null)


View configuration drafts

Requires ALL permissions: 

* webDeployments:configuration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var showOnlyPublished = true;  // bool? | Filter by published status. (optional) 

            try
            { 
                // View configuration drafts
                WebDeploymentConfigurationVersionEntityListing result = apiInstance.GetWebdeploymentsConfigurations(showOnlyPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **showOnlyPublished** | **bool?**| Filter by published status. | [optional]  |

### Return type

[**WebDeploymentConfigurationVersionEntityListing**](WebDeploymentConfigurationVersionEntityListing)


## GetWebdeploymentsDeployment

> [**WebDeployment**](WebDeployment) GetWebdeploymentsDeployment (string deploymentId, List<string> expand = null)


Get a deployment

Requires ALL permissions: 

* webDeployments:deployment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected.  (optional) 

            try
            { 
                // Get a deployment
                WebDeployment result = apiInstance.GetWebdeploymentsDeployment(deploymentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected.  | [optional] <br />**Values**: supportedContent, flowDetails |

### Return type

[**WebDeployment**](WebDeployment)


## GetWebdeploymentsDeploymentCobrowseSessionId

> [**CobrowseWebMessagingSession**](CobrowseWebMessagingSession) GetWebdeploymentsDeploymentCobrowseSessionId (string deploymentId, string sessionId)


Retrieves a cobrowse session

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
    public class GetWebdeploymentsDeploymentCobrowseSessionIdExample
    {
        public void main()
        { 

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | WebMessaging deployment ID
            var sessionId = sessionId_example;  // string | Cobrowse session id or join code

            try
            { 
                // Retrieves a cobrowse session
                CobrowseWebMessagingSession result = apiInstance.GetWebdeploymentsDeploymentCobrowseSessionId(deploymentId, sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeploymentCobrowseSessionId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| WebMessaging deployment ID |  |
| **sessionId** | **string**| Cobrowse session id or join code |  |

### Return type

[**CobrowseWebMessagingSession**](CobrowseWebMessagingSession)


## GetWebdeploymentsDeploymentConfigurations

> [**WebDeploymentActiveConfigurationOnDeployment**](WebDeploymentActiveConfigurationOnDeployment) GetWebdeploymentsDeploymentConfigurations (string deploymentId, string type = null, List<string> expand = null)


Get active configuration for a given deployment

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
    public class GetWebdeploymentsDeploymentConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var type = type_example;  // string | Get active configuration on a deployment (optional) 
            var expand = new List<string>(); // List<string> | Expand instructions for the return value (optional) 

            try
            { 
                // Get active configuration for a given deployment
                WebDeploymentActiveConfigurationOnDeployment result = apiInstance.GetWebdeploymentsDeploymentConfigurations(deploymentId, type, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeploymentConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **type** | **string**| Get active configuration on a deployment | [optional]  |
| **expand** | [**List<string>**](string)| Expand instructions for the return value | [optional] <br />**Values**: supportedContent |

### Return type

[**WebDeploymentActiveConfigurationOnDeployment**](WebDeploymentActiveConfigurationOnDeployment)


## GetWebdeploymentsDeploymentIdentityresolution

> [**DeploymentIdentityResolutionConfig**](DeploymentIdentityResolutionConfig) GetWebdeploymentsDeploymentIdentityresolution (string deploymentId)


Get a deployment identity resolution setting.

Requires ALL permissions: 

* webDeployments:deployment:view
* webDeployments:identityResolution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsDeploymentIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID

            try
            { 
                // Get a deployment identity resolution setting.
                DeploymentIdentityResolutionConfig result = apiInstance.GetWebdeploymentsDeploymentIdentityresolution(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeploymentIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |

### Return type

[**DeploymentIdentityResolutionConfig**](DeploymentIdentityResolutionConfig)


## GetWebdeploymentsDeployments

> [**ExpandableWebDeploymentEntityListing**](ExpandableWebDeploymentEntityListing) GetWebdeploymentsDeployments (List<string> expand = null)


Get deployments

Requires ALL permissions: 

* webDeployments:deployment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebdeploymentsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected.  (optional) 

            try
            { 
                // Get deployments
                ExpandableWebDeploymentEntityListing result = apiInstance.GetWebdeploymentsDeployments(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.GetWebdeploymentsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected.  | [optional] <br />**Values**: Configuration, SupportedContent, identityresolution |

### Return type

[**ExpandableWebDeploymentEntityListing**](ExpandableWebDeploymentEntityListing)


## PostWebdeploymentsConfigurationVersionsDraftPublish

> [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion) PostWebdeploymentsConfigurationVersionsDraftPublish (string configurationId)


Publish the configuration draft and create a new version

Requires ALL permissions: 

* webDeployments:configuration:edit
* webDeployments:configuration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsConfigurationVersionsDraftPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID

            try
            { 
                // Publish the configuration draft and create a new version
                WebDeploymentConfigurationVersion result = apiInstance.PostWebdeploymentsConfigurationVersionsDraftPublish(configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsConfigurationVersionsDraftPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)


## PostWebdeploymentsConfigurations

> [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion) PostWebdeploymentsConfigurations (WebDeploymentConfigurationVersion configurationVersion)


Create a configuration draft

Requires ALL permissions: 

* webDeployments:configuration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsConfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationVersion = new WebDeploymentConfigurationVersion(); // WebDeploymentConfigurationVersion | 

            try
            { 
                // Create a configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.PostWebdeploymentsConfigurations(configurationVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationVersion** | [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)|  |  |

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)


## PostWebdeploymentsDeployments

> [**WebDeployment**](WebDeployment) PostWebdeploymentsDeployments (WebDeployment deployment)


Create a deployment

Requires ALL permissions: 

* webDeployments:deployment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebdeploymentsDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deployment = new WebDeployment(); // WebDeployment | 

            try
            { 
                // Create a deployment
                WebDeployment result = apiInstance.PostWebdeploymentsDeployments(deployment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deployment** | [**WebDeployment**](WebDeployment)|  |  |

### Return type

[**WebDeployment**](WebDeployment)


## PostWebdeploymentsTokenOauthcodegrantjwtexchange

> [**WebDeploymentsAuthorizationResponse**](WebDeploymentsAuthorizationResponse) PostWebdeploymentsTokenOauthcodegrantjwtexchange (WebDeploymentsOAuthExchangeRequest body)


Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.

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
    public class PostWebdeploymentsTokenOauthcodegrantjwtexchangeExample
    {
        public void main()
        { 

            var apiInstance = new WebDeploymentsApi();
            var body = new WebDeploymentsOAuthExchangeRequest(); // WebDeploymentsOAuthExchangeRequest | webDeploymentsOAuthExchangeRequest

            try
            { 
                // Exchange an oAuth code (obtained using the Authorization Code Flow) for a JWT that can be used by webdeployments.
                WebDeploymentsAuthorizationResponse result = apiInstance.PostWebdeploymentsTokenOauthcodegrantjwtexchange(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsTokenOauthcodegrantjwtexchange: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebDeploymentsOAuthExchangeRequest**](WebDeploymentsOAuthExchangeRequest)| webDeploymentsOAuthExchangeRequest |  |

### Return type

[**WebDeploymentsAuthorizationResponse**](WebDeploymentsAuthorizationResponse)


## PostWebdeploymentsTokenRefresh

> [**SignedData**](SignedData) PostWebdeploymentsTokenRefresh (WebDeploymentsRefreshJWTRequest body = null)


Refresh a JWT.

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
    public class PostWebdeploymentsTokenRefreshExample
    {
        public void main()
        { 

            var apiInstance = new WebDeploymentsApi();
            var body = new WebDeploymentsRefreshJWTRequest(); // WebDeploymentsRefreshJWTRequest |  (optional) 

            try
            { 
                // Refresh a JWT.
                SignedData result = apiInstance.PostWebdeploymentsTokenRefresh(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PostWebdeploymentsTokenRefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebDeploymentsRefreshJWTRequest**](WebDeploymentsRefreshJWTRequest)|  | [optional]  |

### Return type

[**SignedData**](SignedData)


## PutWebdeploymentsConfigurationVersionsDraft

> [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion) PutWebdeploymentsConfigurationVersionsDraft (string configurationId, WebDeploymentConfigurationVersion configurationVersion)


Update the configuration draft

Requires ALL permissions: 

* webDeployments:configuration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebdeploymentsConfigurationVersionsDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var configurationId = configurationId_example;  // string | The configuration version ID
            var configurationVersion = new WebDeploymentConfigurationVersion(); // WebDeploymentConfigurationVersion | 

            try
            { 
                // Update the configuration draft
                WebDeploymentConfigurationVersion result = apiInstance.PutWebdeploymentsConfigurationVersionsDraft(configurationId, configurationVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PutWebdeploymentsConfigurationVersionsDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **configurationId** | **string**| The configuration version ID |  |
| **configurationVersion** | [**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)|  |  |

### Return type

[**WebDeploymentConfigurationVersion**](WebDeploymentConfigurationVersion)


## PutWebdeploymentsDeployment

> [**WebDeployment**](WebDeployment) PutWebdeploymentsDeployment (string deploymentId, WebDeployment deployment)


Update a deployment

Requires ALL permissions: 

* webDeployments:deployment:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebdeploymentsDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var deployment = new WebDeployment(); // WebDeployment | 

            try
            { 
                // Update a deployment
                WebDeployment result = apiInstance.PutWebdeploymentsDeployment(deploymentId, deployment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PutWebdeploymentsDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **deployment** | [**WebDeployment**](WebDeployment)|  |  |

### Return type

[**WebDeployment**](WebDeployment)


## PutWebdeploymentsDeploymentIdentityresolution

> [**DeploymentIdentityResolutionConfig**](DeploymentIdentityResolutionConfig) PutWebdeploymentsDeploymentIdentityresolution (string deploymentId, DeploymentIdentityResolutionConfig body)


Update identity resolution settings for a deployment.

Requires ALL permissions: 

* webDeployments:deployment:edit
* webDeployments:identityResolution:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebdeploymentsDeploymentIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebDeploymentsApi();
            var deploymentId = deploymentId_example;  // string | The deployment ID
            var body = new DeploymentIdentityResolutionConfig(); // DeploymentIdentityResolutionConfig | 

            try
            { 
                // Update identity resolution settings for a deployment.
                DeploymentIdentityResolutionConfig result = apiInstance.PutWebdeploymentsDeploymentIdentityresolution(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebDeploymentsApi.PutWebdeploymentsDeploymentIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The deployment ID |  |
| **body** | [**DeploymentIdentityResolutionConfig**](DeploymentIdentityResolutionConfig)|  |  |

### Return type

[**DeploymentIdentityResolutionConfig**](DeploymentIdentityResolutionConfig)


_PureCloudPlatform.Client.V2 243.0.0_
