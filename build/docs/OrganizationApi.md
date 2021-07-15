---
title: OrganizationApi
---
## PureCloudPlatform.Client.V2.Api.OrganizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetFieldconfig**](OrganizationApi.html#getfieldconfig) | **GET** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetOrganizationsEmbeddedintegration**](OrganizationApi.html#getorganizationsembeddedintegration) | **GET** /api/v2/organizations/embeddedintegration | Get the list of domains that will be allowed to embed PureCloud applications |
| [**GetOrganizationsIpaddressauthentication**](OrganizationApi.html#getorganizationsipaddressauthentication) | **GET** /api/v2/organizations/ipaddressauthentication | Get organization IP address whitelist settings |
| [**GetOrganizationsLimitsChangerequest**](OrganizationApi.html#getorganizationslimitschangerequest) | **GET** /api/v2/organizations/limits/changerequests/{requestId} | Get a limit change request |
| [**GetOrganizationsLimitsChangerequests**](OrganizationApi.html#getorganizationslimitschangerequests) | **GET** /api/v2/organizations/limits/changerequests | Get the available limit change requests |
| [**GetOrganizationsLimitsDocs**](OrganizationApi.html#getorganizationslimitsdocs) | **GET** /api/v2/organizations/limits/docs | Get a link to the limit documentation |
| [**GetOrganizationsLimitsNamespace**](OrganizationApi.html#getorganizationslimitsnamespace) | **GET** /api/v2/organizations/limits/namespaces/{namespaceName} | Get the effective limits in a namespace for an organization |
| [**GetOrganizationsLimitsNamespaceDefaults**](OrganizationApi.html#getorganizationslimitsnamespacedefaults) | **GET** /api/v2/organizations/limits/namespaces/{namespaceName}/defaults | Get the default limits in a namespace for an organization |
| [**GetOrganizationsLimitsNamespaces**](OrganizationApi.html#getorganizationslimitsnamespaces) | **GET** /api/v2/organizations/limits/namespaces | Get the available limit namespaces |
| [**GetOrganizationsMe**](OrganizationApi.html#getorganizationsme) | **GET** /api/v2/organizations/me | Get organization. |
| [**GetOrganizationsWhitelist**](OrganizationApi.html#getorganizationswhitelist) | **GET** /api/v2/organizations/whitelist | Use PUT /api/v2/organizations/embeddedintegration instead |
| [**PatchOrganizationsFeature**](OrganizationApi.html#patchorganizationsfeature) | **PATCH** /api/v2/organizations/features/{featureName} | Update organization |
| [**PutOrganizationsEmbeddedintegration**](OrganizationApi.html#putorganizationsembeddedintegration) | **PUT** /api/v2/organizations/embeddedintegration | Update the list of domains that will be allowed to embed PureCloud applications |
| [**PutOrganizationsIpaddressauthentication**](OrganizationApi.html#putorganizationsipaddressauthentication) | **PUT** /api/v2/organizations/ipaddressauthentication | Update organization IP address whitelist settings |
| [**PutOrganizationsMe**](OrganizationApi.html#putorganizationsme) | **PUT** /api/v2/organizations/me | Update organization. |
| [**PutOrganizationsWhitelist**](OrganizationApi.html#putorganizationswhitelist) | **PUT** /api/v2/organizations/whitelist | Use PUT /api/v2/organizations/embeddedintegration instead |
{: class="table table-striped"}

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **type** | **string**| Field type | <br />**Values**: person, group, org, externalContact |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getorganizationsembeddedintegration"></a>

## [**EmbeddedIntegration**](EmbeddedIntegration.html) GetOrganizationsEmbeddedintegration ()



Get the list of domains that will be allowed to embed PureCloud applications



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
{: class="table table-striped"}

### Return type

[**EmbeddedIntegration**](EmbeddedIntegration.html)

<a name="getorganizationsipaddressauthentication"></a>

## [**IpAddressAuthentication**](IpAddressAuthentication.html) GetOrganizationsIpaddressauthentication ()



Get organization IP address whitelist settings



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
{: class="table table-striped"}

### Return type

[**IpAddressAuthentication**](IpAddressAuthentication.html)

<a name="getorganizationslimitschangerequest"></a>

## [**LimitChangeRequestDetails**](LimitChangeRequestDetails.html) GetOrganizationsLimitsChangerequest (string requestId)



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
{: class="table table-striped"}

### Return type

[**LimitChangeRequestDetails**](LimitChangeRequestDetails.html)

<a name="getorganizationslimitschangerequests"></a>

## [**LimitChangeRequestsEntityListing**](LimitChangeRequestsEntityListing.html) GetOrganizationsLimitsChangerequests (long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null)



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
| **status** | **string**| Status of the request to be filtered by | [optional] <br />**Values**: Open, Approved, ImplementingChange, ChangeImplemented, Rejected, Rollback, ImplementingRollback, RollbackImplemented |
| **pageSize** | **int?**| Page Size | [optional] [default to 25] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: statusHistory |
{: class="table table-striped"}

### Return type

[**LimitChangeRequestsEntityListing**](LimitChangeRequestsEntityListing.html)

<a name="getorganizationslimitsdocs"></a>

## [**UrlResponse**](UrlResponse.html) GetOrganizationsLimitsDocs ()



Get a link to the limit documentation



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
                // Get a link to the limit documentation
                UrlResponse result = apiInstance.GetOrganizationsLimitsDocs();
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
{: class="table table-striped"}

### Return type

[**UrlResponse**](UrlResponse.html)

<a name="getorganizationslimitsnamespace"></a>

## [**LimitsEntityListing**](LimitsEntityListing.html) GetOrganizationsLimitsNamespace (string namespaceName)



Get the effective limits in a namespace for an organization



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
{: class="table table-striped"}

### Return type

[**LimitsEntityListing**](LimitsEntityListing.html)

<a name="getorganizationslimitsnamespacedefaults"></a>

## [**LimitsEntityListing**](LimitsEntityListing.html) GetOrganizationsLimitsNamespaceDefaults (string namespaceName)



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
{: class="table table-striped"}

### Return type

[**LimitsEntityListing**](LimitsEntityListing.html)

<a name="getorganizationslimitsnamespaces"></a>

## [**PagedNamespaceListing**](PagedNamespaceListing.html) GetOrganizationsLimitsNamespaces (int? pageSize = null, int? pageNumber = null)



Get the available limit namespaces



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
                PagedNamespaceListing result = apiInstance.GetOrganizationsLimitsNamespaces(pageSize, pageNumber);
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
{: class="table table-striped"}

### Return type

[**PagedNamespaceListing**](PagedNamespaceListing.html)

<a name="getorganizationsme"></a>

## [**Organization**](Organization.html) GetOrganizationsMe ()



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
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="getorganizationswhitelist"></a>

## [**OrgWhitelistSettings**](OrgWhitelistSettings.html) GetOrganizationsWhitelist ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Use PUT /api/v2/organizations/embeddedintegration instead



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
                // Use PUT /api/v2/organizations/embeddedintegration instead
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
{: class="table table-striped"}

### Return type

[**OrgWhitelistSettings**](OrgWhitelistSettings.html)

<a name="patchorganizationsfeature"></a>

## [**OrganizationFeatures**](OrganizationFeatures.html) PatchOrganizationsFeature (string featureName, FeatureState enabled)



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
| **enabled** | [**FeatureState**](FeatureState.html)| New state of feature |  |
{: class="table table-striped"}

### Return type

[**OrganizationFeatures**](OrganizationFeatures.html)

<a name="putorganizationsembeddedintegration"></a>

## [**EmbeddedIntegration**](EmbeddedIntegration.html) PutOrganizationsEmbeddedintegration (EmbeddedIntegration body)



Update the list of domains that will be allowed to embed PureCloud applications



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
| **body** | [**EmbeddedIntegration**](EmbeddedIntegration.html)| Whitelist settings |  |
{: class="table table-striped"}

### Return type

[**EmbeddedIntegration**](EmbeddedIntegration.html)

<a name="putorganizationsipaddressauthentication"></a>

## [**IpAddressAuthentication**](IpAddressAuthentication.html) PutOrganizationsIpaddressauthentication (IpAddressAuthentication body)



Update organization IP address whitelist settings



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
| **body** | [**IpAddressAuthentication**](IpAddressAuthentication.html)| IP address Whitelist settings |  |
{: class="table table-striped"}

### Return type

[**IpAddressAuthentication**](IpAddressAuthentication.html)

<a name="putorganizationsme"></a>

## [**Organization**](Organization.html) PutOrganizationsMe (Organization body = null)



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
| **body** | [**Organization**](Organization.html)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="putorganizationswhitelist"></a>

## [**OrgWhitelistSettings**](OrgWhitelistSettings.html) PutOrganizationsWhitelist (OrgWhitelistSettings body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Use PUT /api/v2/organizations/embeddedintegration instead



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
                // Use PUT /api/v2/organizations/embeddedintegration instead
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
| **body** | [**OrgWhitelistSettings**](OrgWhitelistSettings.html)| Whitelist settings |  |
{: class="table table-striped"}

### Return type

[**OrgWhitelistSettings**](OrgWhitelistSettings.html)

