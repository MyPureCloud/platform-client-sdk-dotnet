# OrganizationApi

## PureCloudPlatform.Client.V2.Api.OrganizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetFieldconfig**](#GetFieldconfig) | **Get** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetOrganizationsAuthenticationSettings**](#GetOrganizationsAuthenticationSettings) | **Get** /api/v2/organizations/authentication/settings | Gets the organization&#39;s settings |
| [**GetOrganizationsEmbeddedintegration**](#GetOrganizationsEmbeddedintegration) | **Get** /api/v2/organizations/embeddedintegration | Get the list of domains that will be allowed to embed PureCloud applications |
| [**GetOrganizationsIpaddressauthentication**](#GetOrganizationsIpaddressauthentication) | **Get** /api/v2/organizations/ipaddressauthentication | Get organization IP address whitelist settings |
| [**GetOrganizationsLimitsChangerequest**](#GetOrganizationsLimitsChangerequest) | **Get** /api/v2/organizations/limits/changerequests/{requestId} | Get a limit change request |
| [**GetOrganizationsLimitsChangerequests**](#GetOrganizationsLimitsChangerequests) | **Get** /api/v2/organizations/limits/changerequests | Get the available limit change requests |
| [**GetOrganizationsLimitsDocs**](#GetOrganizationsLimitsDocs) | **Get** /api/v2/organizations/limits/docs | Get limit documentation |
| [**GetOrganizationsLimitsDocsFreetrial**](#GetOrganizationsLimitsDocsFreetrial) | **Get** /api/v2/organizations/limits/docs/freetrial | Get free trial limit documentation |
| [**GetOrganizationsLimitsNamespace**](#GetOrganizationsLimitsNamespace) | **Get** /api/v2/organizations/limits/namespaces/{namespaceName} | Get the effective limits in a namespace for an organization |
| [**GetOrganizationsLimitsNamespaceDefaults**](#GetOrganizationsLimitsNamespaceDefaults) | **Get** /api/v2/organizations/limits/namespaces/{namespaceName}/defaults | Get the default limits in a namespace for an organization |
| [**GetOrganizationsLimitsNamespaces**](#GetOrganizationsLimitsNamespaces) | **Get** /api/v2/organizations/limits/namespaces | Get the available limit namespaces |
| [**GetOrganizationsMe**](#GetOrganizationsMe) | **Get** /api/v2/organizations/me | Get organization. |
| [**GetOrganizationsWhitelist**](#GetOrganizationsWhitelist) | **Get** /api/v2/organizations/whitelist | This route is deprecated, please use /api/v2/organizations/authentication/settings instead |
| [**PatchOrganizationsAuthenticationSettings**](#PatchOrganizationsAuthenticationSettings) | **Patch** /api/v2/organizations/authentication/settings | Update the organization&#39;s settings |
| [**PatchOrganizationsFeature**](#PatchOrganizationsFeature) | **Patch** /api/v2/organizations/features/{featureName} | Update organization |
| [**PutOrganizationsEmbeddedintegration**](#PutOrganizationsEmbeddedintegration) | **Put** /api/v2/organizations/embeddedintegration | Update the list of domains that will be allowed to embed PureCloud applications |
| [**PutOrganizationsIpaddressauthentication**](#PutOrganizationsIpaddressauthentication) | **Put** /api/v2/organizations/ipaddressauthentication | Update organization IP address whitelist settings |
| [**PutOrganizationsMe**](#PutOrganizationsMe) | **Put** /api/v2/organizations/me | Update organization. |
| [**PutOrganizationsWhitelist**](#PutOrganizationsWhitelist) | **Put** /api/v2/organizations/whitelist | This route is deprecated, please use /api/v2/organizations/authentication/settings instead |



## GetFieldconfig

> [**FieldConfig**](FieldConfig) GetFieldconfig (string type)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Fetch field config for an entity type

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
    public class GetFieldconfigExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var type = type_example;  // string | Field type

            try
            { 
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type | <br />**Values**: person, group, org |

### Return type

[**FieldConfig**](FieldConfig)


## GetOrganizationsAuthenticationSettings

> [**OrgAuthSettings**](OrgAuthSettings) GetOrganizationsAuthenticationSettings ()


Gets the organization's settings

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrganizationsAuthenticationSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Gets the organization's settings
                OrgAuthSettings result = apiInstance.GetOrganizationsAuthenticationSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsAuthenticationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OrgAuthSettings**](OrgAuthSettings)


## GetOrganizationsEmbeddedintegration

> [**EmbeddedIntegration**](EmbeddedIntegration) GetOrganizationsEmbeddedintegration ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the list of domains that will be allowed to embed PureCloud applications

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

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
    public class GetOrganizationsEmbeddedintegrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Get the list of domains that will be allowed to embed PureCloud applications
                EmbeddedIntegration result = apiInstance.GetOrganizationsEmbeddedintegration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsEmbeddedintegration: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmbeddedIntegration**](EmbeddedIntegration)


## GetOrganizationsIpaddressauthentication

> [**IpAddressAuthentication**](IpAddressAuthentication) GetOrganizationsIpaddressauthentication ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get organization IP address whitelist settings

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrganizationsIpaddressauthenticationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Get organization IP address whitelist settings
                IpAddressAuthentication result = apiInstance.GetOrganizationsIpaddressauthentication();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsIpaddressauthentication: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**IpAddressAuthentication**](IpAddressAuthentication)


## GetOrganizationsLimitsChangerequest

> [**LimitChangeRequestDetails**](LimitChangeRequestDetails) GetOrganizationsLimitsChangerequest (string requestId)


Get a limit change request

Requires ANY permissions: 

* limits:organization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrganizationsLimitsChangerequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var requestId = requestId_example;  // string | Unique id for the limit change request

            try
            { 
                // Get a limit change request
                LimitChangeRequestDetails result = apiInstance.GetOrganizationsLimitsChangerequest(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsChangerequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **requestId** | **string**| Unique id for the limit change request |  |

### Return type

[**LimitChangeRequestDetails**](LimitChangeRequestDetails)


## GetOrganizationsLimitsChangerequests

> [**LimitChangeRequestsEntityListing**](LimitChangeRequestsEntityListing) GetOrganizationsLimitsChangerequests (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)


Get the available limit change requests

Timestamp interval defaults to the last 365 days if both query parameters are omitted. If only one parameter is omitted, the interval will default to a 180 day range in the specified direction.

Requires ANY permissions: 

* limits:organization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrganizationsLimitsChangerequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var after = 789;  // long? | Timestamp indicating the date to begin after when searching for requests. (optional) 
            var before = 789;  // long? | Timestamp indicating the date to end before when searching for requests. (optional) 
            var status = status_example;  // string | Status of the request to be filtered by (optional) 
            var pageSize = 56;  // int? | Page Size (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get the available limit change requests
                LimitChangeRequestsEntityListing result = apiInstance.GetOrganizationsLimitsChangerequests(after, before, status, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsChangerequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **long?**| Timestamp indicating the date to begin after when searching for requests. | [optional]  |
| **before** | **long?**| Timestamp indicating the date to end before when searching for requests. | [optional]  |
| **status** | **string**| Status of the request to be filtered by | [optional] <br />**Values**: Approved, Rejected, Rollback, Pending, Open, SecondaryApprovalNamespacesAdded, ReviewerApproved, ReviewerRejected, ReviewerRollback, ImplementingChange, ChangeImplemented, ImplementingRollback, RollbackImplemented |
| **pageSize** | **int?**| Page Size | [optional] [default to 25] |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: statusHistory |

### Return type

[**LimitChangeRequestsEntityListing**](LimitChangeRequestsEntityListing)


## GetOrganizationsLimitsDocs

> [**LimitDocumentation**](LimitDocumentation) GetOrganizationsLimitsDocs ()


Get limit documentation

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
    public class GetOrganizationsLimitsDocsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Get limit documentation
                LimitDocumentation result = apiInstance.GetOrganizationsLimitsDocs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsDocs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**LimitDocumentation**](LimitDocumentation)


## GetOrganizationsLimitsDocsFreetrial

> [**FreeTrialLimitDocs**](FreeTrialLimitDocs) GetOrganizationsLimitsDocsFreetrial ()


Get free trial limit documentation

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
    public class GetOrganizationsLimitsDocsFreetrialExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Get free trial limit documentation
                FreeTrialLimitDocs result = apiInstance.GetOrganizationsLimitsDocsFreetrial();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsDocsFreetrial: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FreeTrialLimitDocs**](FreeTrialLimitDocs)


## GetOrganizationsLimitsNamespace

> [**LimitsEntityListing**](LimitsEntityListing) GetOrganizationsLimitsNamespace (string namespaceName)


Get the effective limits in a namespace for an organization

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
    public class GetOrganizationsLimitsNamespaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var namespaceName = namespaceName_example;  // string | The namespace to fetch limits for

            try
            { 
                // Get the effective limits in a namespace for an organization
                LimitsEntityListing result = apiInstance.GetOrganizationsLimitsNamespace(namespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsNamespace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **namespaceName** | **string**| The namespace to fetch limits for |  |

### Return type

[**LimitsEntityListing**](LimitsEntityListing)


## GetOrganizationsLimitsNamespaceDefaults

> [**LimitsEntityListing**](LimitsEntityListing) GetOrganizationsLimitsNamespaceDefaults (string namespaceName)


Get the default limits in a namespace for an organization

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
    public class GetOrganizationsLimitsNamespaceDefaultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var namespaceName = namespaceName_example;  // string | The namespace to fetch defaults limits for

            try
            { 
                // Get the default limits in a namespace for an organization
                LimitsEntityListing result = apiInstance.GetOrganizationsLimitsNamespaceDefaults(namespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsNamespaceDefaults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **namespaceName** | **string**| The namespace to fetch defaults limits for |  |

### Return type

[**LimitsEntityListing**](LimitsEntityListing)


## GetOrganizationsLimitsNamespaces

> **Object** GetOrganizationsLimitsNamespaces (int? pageSize = null, int? pageNumber = null)


Get the available limit namespaces

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
    public class GetOrganizationsLimitsNamespacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 100)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get the available limit namespaces
                Object result = apiInstance.GetOrganizationsLimitsNamespaces(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsLimitsNamespaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 100] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

**Object**


## GetOrganizationsMe

> [**Organization**](Organization) GetOrganizationsMe ()


Get organization.

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
    public class GetOrganizationsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // Get organization.
                Organization result = apiInstance.GetOrganizationsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**Organization**](Organization)


## GetOrganizationsWhitelist

> [**OrgWhitelistSettings**](OrgWhitelistSettings) GetOrganizationsWhitelist ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

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
    public class GetOrganizationsWhitelistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();

            try
            { 
                // This route is deprecated, please use /api/v2/organizations/authentication/settings instead
                OrgWhitelistSettings result = apiInstance.GetOrganizationsWhitelist();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsWhitelist: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OrgWhitelistSettings**](OrgWhitelistSettings)


## PatchOrganizationsAuthenticationSettings

> [**OrgAuthSettings**](OrgAuthSettings) PatchOrganizationsAuthenticationSettings (OrgAuthSettings body)


Update the organization's settings

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOrganizationsAuthenticationSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var body = new OrgAuthSettings(); // OrgAuthSettings | Org settings

            try
            { 
                // Update the organization's settings
                OrgAuthSettings result = apiInstance.PatchOrganizationsAuthenticationSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PatchOrganizationsAuthenticationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrgAuthSettings**](OrgAuthSettings)| Org settings |  |

### Return type

[**OrgAuthSettings**](OrgAuthSettings)


## PatchOrganizationsFeature

> [**OrganizationFeatures**](OrganizationFeatures) PatchOrganizationsFeature (string featureName, FeatureState enabled)


Update organization

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOrganizationsFeatureExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var featureName = featureName_example;  // string | Organization feature
            var enabled = new FeatureState(); // FeatureState | New state of feature

            try
            { 
                // Update organization
                OrganizationFeatures result = apiInstance.PatchOrganizationsFeature(featureName, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PatchOrganizationsFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **featureName** | **string**| Organization feature | <br />**Values**: realtimeCIC, purecloud, hipaa, ucEnabled, pci, purecloudVoice, xmppFederation, chat, informalPhotos, directory, contactCenter, unifiedCommunications, custserv |
| **enabled** | [**FeatureState**](FeatureState)| New state of feature |  |

### Return type

[**OrganizationFeatures**](OrganizationFeatures)


## PutOrganizationsEmbeddedintegration

> [**EmbeddedIntegration**](EmbeddedIntegration) PutOrganizationsEmbeddedintegration (EmbeddedIntegration body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update the list of domains that will be allowed to embed PureCloud applications

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrganizationsEmbeddedintegrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var body = new EmbeddedIntegration(); // EmbeddedIntegration | Whitelist settings

            try
            { 
                // Update the list of domains that will be allowed to embed PureCloud applications
                EmbeddedIntegration result = apiInstance.PutOrganizationsEmbeddedintegration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationsEmbeddedintegration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmbeddedIntegration**](EmbeddedIntegration)| Whitelist settings |  |

### Return type

[**EmbeddedIntegration**](EmbeddedIntegration)


## PutOrganizationsIpaddressauthentication

> [**IpAddressAuthentication**](IpAddressAuthentication) PutOrganizationsIpaddressauthentication (IpAddressAuthentication body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update organization IP address whitelist settings

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrganizationsIpaddressauthenticationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var body = new IpAddressAuthentication(); // IpAddressAuthentication | IP address Whitelist settings

            try
            { 
                // Update organization IP address whitelist settings
                IpAddressAuthentication result = apiInstance.PutOrganizationsIpaddressauthentication(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationsIpaddressauthentication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IpAddressAuthentication**](IpAddressAuthentication)| IP address Whitelist settings |  |

### Return type

[**IpAddressAuthentication**](IpAddressAuthentication)


## PutOrganizationsMe

> [**Organization**](Organization) PutOrganizationsMe (Organization body = null)


Update organization.

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrganizationsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var body = new Organization(); // Organization | Organization (optional) 

            try
            { 
                // Update organization.
                Organization result = apiInstance.PutOrganizationsMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Organization**](Organization)| Organization | [optional]  |

### Return type

[**Organization**](Organization)


## PutOrganizationsWhitelist

> [**OrgWhitelistSettings**](OrgWhitelistSettings) PutOrganizationsWhitelist (OrgWhitelistSettings body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

This route is deprecated, please use /api/v2/organizations/authentication/settings instead

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrganizationsWhitelistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OrganizationApi();
            var body = new OrgWhitelistSettings(); // OrgWhitelistSettings | Whitelist settings

            try
            { 
                // This route is deprecated, please use /api/v2/organizations/authentication/settings instead
                OrgWhitelistSettings result = apiInstance.PutOrganizationsWhitelist(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationsWhitelist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrgWhitelistSettings**](OrgWhitelistSettings)| Whitelist settings |  |

### Return type

[**OrgWhitelistSettings**](OrgWhitelistSettings)


_PureCloudPlatform.Client.V2 231.1.0_
