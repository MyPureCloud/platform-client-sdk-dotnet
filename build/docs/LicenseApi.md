---
title: LicenseApi
---
## PureCloudPlatform.Client.V2.Api.LicenseApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetLicenseDefinition**](LicenseApi.html#getlicensedefinition) | **Get** /api/v2/license/definitions/{licenseId} | Get PureCloud license definition. |
| [**GetLicenseDefinitions**](LicenseApi.html#getlicensedefinitions) | **Get** /api/v2/license/definitions | Get all PureCloud license definitions available for the organization. |
| [**GetLicenseToggle**](LicenseApi.html#getlicensetoggle) | **Get** /api/v2/license/toggles/{featureName} | Deprecated - no alternative required. This operation will always return &#39;true&#39; for requested toggles |
| [**GetLicenseUser**](LicenseApi.html#getlicenseuser) | **Get** /api/v2/license/users/{userId} | Get licenses for specified user. |
| [**GetLicenseUsers**](LicenseApi.html#getlicenseusers) | **Get** /api/v2/license/users | Get a page of users and their licenses |
| [**PostLicenseInfer**](LicenseApi.html#postlicenseinfer) | **Post** /api/v2/license/infer | Get a list of licenses inferred based on a list of roleIds |
| [**PostLicenseOrganization**](LicenseApi.html#postlicenseorganization) | **Post** /api/v2/license/organization | Update the organization&#39;s license assignments in a batch. |
| [**PostLicenseToggle**](LicenseApi.html#postlicensetoggle) | **Post** /api/v2/license/toggles/{featureName} | Deprecated. No alternative required - this endpoint has no effect |
| [**PostLicenseUsers**](LicenseApi.html#postlicenseusers) | **Post** /api/v2/license/users | Fetch user licenses in a batch. |
{: class="table table-striped"}

<a name="getlicensedefinition"></a>

## [**LicenseDefinition**](LicenseDefinition.html) GetLicenseDefinition (string licenseId)



Get PureCloud license definition.

Requires ANY permissions: 

* authorization:grant:add
* authorization:license:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLicenseDefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var licenseId = licenseId_example;  // string | ID

            try
            { 
                // Get PureCloud license definition.
                LicenseDefinition result = apiInstance.GetLicenseDefinition(licenseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **licenseId** | **string**| ID |  |
{: class="table table-striped"}

### Return type

[**LicenseDefinition**](LicenseDefinition.html)

<a name="getlicensedefinitions"></a>

## [**List&lt;LicenseDefinition&gt;**](LicenseDefinition.html) GetLicenseDefinitions ()



Get all PureCloud license definitions available for the organization.

Requires ANY permissions: 

* authorization:grant:add
* authorization:license:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLicenseDefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();

            try
            { 
                // Get all PureCloud license definitions available for the organization.
                List<LicenseDefinition> result = apiInstance.GetLicenseDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**List<LicenseDefinition>**](LicenseDefinition.html)

<a name="getlicensetoggle"></a>

## [**LicenseOrgToggle**](LicenseOrgToggle.html) GetLicenseToggle (string featureName)



Deprecated - no alternative required. This operation will always return 'true' for requested toggles

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
    public class GetLicenseToggleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var featureName = featureName_example;  // string | featureName

            try
            { 
                // Deprecated - no alternative required. This operation will always return 'true' for requested toggles
                LicenseOrgToggle result = apiInstance.GetLicenseToggle(featureName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseToggle: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **featureName** | **string**| featureName |  |
{: class="table table-striped"}

### Return type

[**LicenseOrgToggle**](LicenseOrgToggle.html)

<a name="getlicenseuser"></a>

## [**LicenseUser**](LicenseUser.html) GetLicenseUser (string userId)



Get licenses for specified user.

Requires ANY permissions: 

* authorization:grant:add
* authorization:license:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLicenseUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var userId = userId_example;  // string | ID

            try
            { 
                // Get licenses for specified user.
                LicenseUser result = apiInstance.GetLicenseUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| ID |  |
{: class="table table-striped"}

### Return type

[**LicenseUser**](LicenseUser.html)

<a name="getlicenseusers"></a>

## [**UserLicensesEntityListing**](UserLicensesEntityListing.html) GetLicenseUsers (int? pageSize = null, int? pageNumber = null)



Get a page of users and their licenses

Retrieve a page of users in an organization along with the licenses they possess.

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
    public class GetLicenseUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a page of users and their licenses
                UserLicensesEntityListing result = apiInstance.GetLicenseUsers(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseUsers: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**UserLicensesEntityListing**](UserLicensesEntityListing.html)

<a name="postlicenseinfer"></a>

## **List&lt;string&gt;** PostLicenseInfer (List<string> body = null)



Get a list of licenses inferred based on a list of roleIds

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
    public class PostLicenseInferExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var body = new List<string>(); // List<string> | The roleIds to use while inferring licenses (optional) 

            try
            { 
                // Get a list of licenses inferred based on a list of roleIds
                List<string> result = apiInstance.PostLicenseInfer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseInfer: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| The roleIds to use while inferring licenses | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="postlicenseorganization"></a>

## [**List&lt;LicenseUpdateStatus&gt;**](LicenseUpdateStatus.html) PostLicenseOrganization (LicenseBatchAssignmentRequest body = null)



Update the organization's license assignments in a batch.

Requires ANY permissions: 

* authorization:grant:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLicenseOrganizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var body = new LicenseBatchAssignmentRequest(); // LicenseBatchAssignmentRequest | The license assignments to update. (optional) 

            try
            { 
                // Update the organization's license assignments in a batch.
                List<LicenseUpdateStatus> result = apiInstance.PostLicenseOrganization(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LicenseBatchAssignmentRequest**](LicenseBatchAssignmentRequest.html)| The license assignments to update. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<LicenseUpdateStatus>**](LicenseUpdateStatus.html)

<a name="postlicensetoggle"></a>

## [**LicenseOrgToggle**](LicenseOrgToggle.html) PostLicenseToggle (string featureName)



Deprecated. No alternative required - this endpoint has no effect

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
    public class PostLicenseToggleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var featureName = featureName_example;  // string | featureName

            try
            { 
                // Deprecated. No alternative required - this endpoint has no effect
                LicenseOrgToggle result = apiInstance.PostLicenseToggle(featureName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseToggle: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **featureName** | **string**| featureName |  |
{: class="table table-striped"}

### Return type

[**LicenseOrgToggle**](LicenseOrgToggle.html)

<a name="postlicenseusers"></a>

## **Dictionary&lt;string, Object&gt;** PostLicenseUsers (List<string> body = null)



Fetch user licenses in a batch.

Requires ANY permissions: 

* authorization:grant:add
* authorization:license:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLicenseUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LicenseApi();
            var body = new List<string>(); // List<string> | The user IDs to fetch. (optional) 

            try
            { 
                // Fetch user licenses in a batch.
                Dictionary<string, Object> result = apiInstance.PostLicenseUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| The user IDs to fetch. | [optional]  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

