---
title: LicenseApi
---
## PureCloudPlatform.Client.V2.Api.LicenseApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetLicenseDefinition**](LicenseApi.html#getlicensedefinition) | **GET** /api/v2/license/definitions/{licenseId} | Get PureCloud license definition. |
| [**GetLicenseDefinitions**](LicenseApi.html#getlicensedefinitions) | **GET** /api/v2/license/definitions | Get all PureCloud license definitions available for the organization. |
| [**GetLicenseOrganization**](LicenseApi.html#getlicenseorganization) | **GET** /api/v2/license/organization | Get license assignments for the organization. |
| [**GetLicenseUser**](LicenseApi.html#getlicenseuser) | **GET** /api/v2/license/users/{userId} | Get licenses for specified user. |
| [**PostLicenseOrganization**](LicenseApi.html#postlicenseorganization) | **POST** /api/v2/license/organization | Update the organization&#39;s license assignments in a batch. |
| [**PostLicenseUsers**](LicenseApi.html#postlicenseusers) | **POST** /api/v2/license/users | Fetch user licenses in a batch. |
{: class="table table-striped"}

<a name="getlicensedefinition"></a>

## [**LicenseDefinition**](LicenseDefinition.html) GetLicenseDefinition (string licenseId)

Get PureCloud license definition.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LicenseApi();
            

            try
            {
                
                // Get all PureCloud license definitions available for the organization.
                
                List&lt;LicenseDefinition&gt; result = apiInstance.GetLicenseDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseDefinitions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<LicenseDefinition>**](LicenseDefinition.html)

<a name="getlicenseorganization"></a>

## [**LicenseOrganization**](LicenseOrganization.html) GetLicenseOrganization ()

Get license assignments for the organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLicenseOrganizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LicenseApi();
            

            try
            {
                
                // Get license assignments for the organization.
                
                LicenseOrganization result = apiInstance.GetLicenseOrganization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.GetLicenseOrganization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**LicenseOrganization**](LicenseOrganization.html)

<a name="getlicenseuser"></a>

## [**LicenseUser**](LicenseUser.html) GetLicenseUser (string userId)

Get licenses for specified user.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| ID |  |
{: class="table table-striped"}

### Return type

[**LicenseUser**](LicenseUser.html)

<a name="postlicenseorganization"></a>

## [**List&lt;LicenseUpdateStatus&gt;**](LicenseUpdateStatus.html) PostLicenseOrganization (LicenseBatchAssignmentRequest body = null)

Update the organization's license assignments in a batch.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LicenseApi();
            
            
            
            var body = new LicenseBatchAssignmentRequest(); // LicenseBatchAssignmentRequest | The license assignments to update. (optional) 
            
            

            try
            {
                
                // Update the organization's license assignments in a batch.
                
                List&lt;LicenseUpdateStatus&gt; result = apiInstance.PostLicenseOrganization(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseOrganization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LicenseBatchAssignmentRequest**](LicenseBatchAssignmentRequest.html)| The license assignments to update. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<LicenseUpdateStatus>**](LicenseUpdateStatus.html)

<a name="postlicenseusers"></a>

## **Dictionary&lt;string, Object&gt;** PostLicenseUsers (List<string> body = null)

Fetch user licenses in a batch.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LicenseApi();
            
            
            var body = ;  // List<string> | The user IDs to fetch. (optional) 
            
            
            

            try
            {
                
                // Fetch user licenses in a batch.
                
                Dictionary&lt;string, Object&gt; result = apiInstance.PostLicenseUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.PostLicenseUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **List<string>**| The user IDs to fetch. | [optional]  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

