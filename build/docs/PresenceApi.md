---
title: PresenceApi
---
## PureCloudPlatform.Client.V2.Api.PresenceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeletePresencedefinition**](PresenceApi.html#deletepresencedefinition) | **DELETE** /api/v2/presencedefinitions/{presenceId} | Delete a Presence Definition |
| [**GetPresencedefinition**](PresenceApi.html#getpresencedefinition) | **GET** /api/v2/presencedefinitions/{presenceId} | Get a Presence Definition |
| [**GetPresencedefinitions**](PresenceApi.html#getpresencedefinitions) | **GET** /api/v2/presencedefinitions | Get an Organization&#39;s list of Presence Definitions |
| [**GetSystempresences**](PresenceApi.html#getsystempresences) | **GET** /api/v2/systempresences | Get the list of SystemPresences |
| [**GetUserPresence**](PresenceApi.html#getuserpresence) | **GET** /api/v2/users/{userId}/presences/{sourceId} | Get a user&#39;s Presence |
| [**PatchUserPresence**](PresenceApi.html#patchuserpresence) | **PATCH** /api/v2/users/{userId}/presences/{sourceId} | Patch a user&#39;s Presence |
| [**PostPresencedefinitions**](PresenceApi.html#postpresencedefinitions) | **POST** /api/v2/presencedefinitions | Create a Presence Definition |
| [**PutPresencedefinition**](PresenceApi.html#putpresencedefinition) | **PUT** /api/v2/presencedefinitions/{presenceId} | Update a Presence Definition |
{: class="table table-striped"}

<a name="deletepresencedefinition"></a>

## void DeletePresencedefinition (string presenceId)



Delete a Presence Definition



Requires ANY permissions: 

* presence:presenceDefinition:delete

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeletePresencedefinitionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var presenceId = presenceId_example;  // string | Organization Presence ID
            
            
            

            try
            {
                
                // Delete a Presence Definition
                
                apiInstance.DeletePresencedefinition(presenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.DeletePresencedefinition: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getpresencedefinition"></a>

## [**OrganizationPresence**](OrganizationPresence.html) GetPresencedefinition (string presenceId, string localeCode = null)



Get a Presence Definition



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
    public class GetPresencedefinitionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var presenceId = presenceId_example;  // string | Organization Presence ID
            
            
            
            
            var localeCode = localeCode_example;  // string | The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional) 
            
            
            

            try
            {
                
                // Get a Presence Definition
                
                OrganizationPresence result = apiInstance.GetPresencedefinition(presenceId, localeCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresencedefinition: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **localeCode** | **string**| The locale code to fetch for the presence definition. Use ALL to fetch everything. | [optional]  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

<a name="getpresencedefinitions"></a>

## [**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html) GetPresencedefinitions (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)



Get an Organization's list of Presence Definitions



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
    public class GetPresencedefinitionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var deleted = deleted_example;  // string | Deleted query can be TRUE, FALSE or ALL (optional)  (default to false)
            
            
            
            
            var localeCode = localeCode_example;  // string | The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional) 
            
            
            

            try
            {
                
                // Get an Organization's list of Presence Definitions
                
                OrganizationPresenceEntityListing result = apiInstance.GetPresencedefinitions(pageNumber, pageSize, deleted, localeCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresencedefinitions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **deleted** | **string**| Deleted query can be TRUE, FALSE or ALL | [optional] [default to false] |
| **localeCode** | **string**| The locale code to fetch for each presence definition. Use ALL to fetch everything. | [optional]  |
{: class="table table-striped"}

### Return type

[**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html)

<a name="getsystempresences"></a>

## [**List&lt;SystemPresence&gt;**](SystemPresence.html) GetSystempresences ()



Get the list of SystemPresences



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
    public class GetSystempresencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            

            try
            {
                
                // Get the list of SystemPresences
                
                List&lt;SystemPresence&gt; result = apiInstance.GetSystempresences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetSystempresences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<SystemPresence>**](SystemPresence.html)

<a name="getuserpresence"></a>

## [**UserPresence**](UserPresence.html) GetUserPresence (string userId, string sourceId)



Get a user's Presence



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
    public class GetUserPresenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var userId = userId_example;  // string | user Id
            
            
            
            
            var sourceId = sourceId_example;  // string | Source
            
            
            

            try
            {
                
                // Get a user's Presence
                
                UserPresence result = apiInstance.GetUserPresence(userId, sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUserPresence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Source |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.html)

<a name="patchuserpresence"></a>

## [**UserPresence**](UserPresence.html) PatchUserPresence (string userId, string sourceId, UserPresence body)



Patch a user's Presence

The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.

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
    public class PatchUserPresenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var userId = userId_example;  // string | user Id
            
            
            
            
            var sourceId = sourceId_example;  // string | Source
            
            
            
            
            
            var body = new UserPresence(); // UserPresence | User presence
            
            

            try
            {
                
                // Patch a user's Presence
                
                UserPresence result = apiInstance.PatchUserPresence(userId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PatchUserPresence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Source |  |
| **body** | [**UserPresence**](UserPresence.html)| User presence |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.html)

<a name="postpresencedefinitions"></a>

## [**OrganizationPresence**](OrganizationPresence.html) PostPresencedefinitions (OrganizationPresence body)



Create a Presence Definition



Requires ANY permissions: 

* presence:presenceDefinition:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostPresencedefinitionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            
            var body = new OrganizationPresence(); // OrganizationPresence | The Presence Definition to create
            
            

            try
            {
                
                // Create a Presence Definition
                
                OrganizationPresence result = apiInstance.PostPresencedefinitions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PostPresencedefinitions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationPresence**](OrganizationPresence.html)| The Presence Definition to create |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

<a name="putpresencedefinition"></a>

## [**OrganizationPresence**](OrganizationPresence.html) PutPresencedefinition (string presenceId, OrganizationPresence body)



Update a Presence Definition



Requires ANY permissions: 

* presence:presenceDefinition:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutPresencedefinitionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new PresenceApi();
            
            
            var presenceId = presenceId_example;  // string | Organization Presence ID
            
            
            
            
            
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to update
            
            

            try
            {
                
                // Update a Presence Definition
                
                OrganizationPresence result = apiInstance.PutPresencedefinition(presenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresencedefinition: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **body** | [**OrganizationPresence**](OrganizationPresence.html)| The OrganizationPresence to update |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

