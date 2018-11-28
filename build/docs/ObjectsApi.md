---
title: ObjectsApi
---
## PureCloudPlatform.Client.V2.Api.ObjectsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAuthorizationDivision**](ObjectsApi.html#deleteauthorizationdivision) | **DELETE** /api/v2/authorization/divisions/{divisionId} | Delete a division. |
| [**GetAuthorizationDivision**](ObjectsApi.html#getauthorizationdivision) | **GET** /api/v2/authorization/divisions/{divisionId} | Returns an authorization division. |
| [**GetAuthorizationDivisions**](ObjectsApi.html#getauthorizationdivisions) | **GET** /api/v2/authorization/divisions | Retrieve a list of all divisions defined for the organization |
| [**GetAuthorizationDivisionsHome**](ObjectsApi.html#getauthorizationdivisionshome) | **GET** /api/v2/authorization/divisions/home | Retrieve the home division for the organization. |
| [**GetAuthorizationDivisionsLimit**](ObjectsApi.html#getauthorizationdivisionslimit) | **GET** /api/v2/authorization/divisions/limit | Returns the maximum allowed number of divisions. |
| [**PostAuthorizationDivisionObject**](ObjectsApi.html#postauthorizationdivisionobject) | **POST** /api/v2/authorization/divisions/{divisionId}/objects/{objectType} | Assign a list of objects to a division |
| [**PostAuthorizationDivisions**](ObjectsApi.html#postauthorizationdivisions) | **POST** /api/v2/authorization/divisions | Create a division. |
| [**PutAuthorizationDivision**](ObjectsApi.html#putauthorizationdivision) | **PUT** /api/v2/authorization/divisions/{divisionId} | Update a division. |
{: class="table table-striped"}

<a name="deleteauthorizationdivision"></a>

## void DeleteAuthorizationDivision (string divisionId)



Delete a division.



Requires ANY permissions: 

* authorization:division:delete

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAuthorizationDivisionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var divisionId = divisionId_example;  // string | Division ID
            
            
            

            try
            {
                
                // Delete a division.
                
                apiInstance.DeleteAuthorizationDivision(divisionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.DeleteAuthorizationDivision: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getauthorizationdivision"></a>

## [**AuthzDivision**](AuthzDivision.html) GetAuthorizationDivision (string divisionId, bool? objectCount = null)



Returns an authorization division.



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
    public class GetAuthorizationDivisionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var divisionId = divisionId_example;  // string | Division ID
            
            
            
            
            var objectCount = true;  // bool? | Get count of objects in this division, grouped by type (optional)  (default to false)
            
            
            

            try
            {
                
                // Returns an authorization division.
                
                AuthzDivision result = apiInstance.GetAuthorizationDivision(divisionId, objectCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivision: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **objectCount** | **bool?**| Get count of objects in this division, grouped by type | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="getauthorizationdivisions"></a>

## [**AuthzDivisionEntityListing**](AuthzDivisionEntityListing.html) GetAuthorizationDivisions (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)



Retrieve a list of all divisions defined for the organization

Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3

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
    public class GetAuthorizationDivisionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var objectCount = true;  // bool? | Include the count of objects contained in the division (optional)  (default to false)
            
            
            
            
            
            var id = new List<string>(); // List<string> | Optionally request specific divisions by their IDs (optional) 
            
            
            
            var name = name_example;  // string | Search term to filter by division name (optional) 
            
            
            

            try
            {
                
                // Retrieve a list of all divisions defined for the organization
                
                AuthzDivisionEntityListing result = apiInstance.GetAuthorizationDivisions(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, objectCount, id, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **objectCount** | **bool?**| Include the count of objects contained in the division | [optional] [default to false] |
| **id** | [**List<string>**](string.html)| Optionally request specific divisions by their IDs | [optional]  |
| **name** | **string**| Search term to filter by division name | [optional]  |
{: class="table table-striped"}

### Return type

[**AuthzDivisionEntityListing**](AuthzDivisionEntityListing.html)

<a name="getauthorizationdivisionshome"></a>

## [**AuthzDivision**](AuthzDivision.html) GetAuthorizationDivisionsHome ()



Retrieve the home division for the organization.

Will not include object counts.

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
    public class GetAuthorizationDivisionsHomeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            

            try
            {
                
                // Retrieve the home division for the organization.
                
                AuthzDivision result = apiInstance.GetAuthorizationDivisionsHome();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisionsHome: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="getauthorizationdivisionslimit"></a>

## **int?** GetAuthorizationDivisionsLimit ()



Returns the maximum allowed number of divisions.



Requires ANY permissions: 

* authorization:division:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionsLimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            

            try
            {
                
                // Returns the maximum allowed number of divisions.
                
                int? result = apiInstance.GetAuthorizationDivisionsLimit();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisionsLimit: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**int?**

<a name="postauthorizationdivisionobject"></a>

## void PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)



Assign a list of objects to a division

Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]

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
    public class PostAuthorizationDivisionObjectExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var divisionId = divisionId_example;  // string | Division ID
            
            
            
            
            var objectType = objectType_example;  // string | The type of the objects. Must be one of the valid object types
            
            
            
            
            var body = ;  // List<string> | Object Id List
            
            
            

            try
            {
                
                // Assign a list of objects to a division
                
                apiInstance.PostAuthorizationDivisionObject(divisionId, objectType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.PostAuthorizationDivisionObject: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **objectType** | **string**| The type of the objects. Must be one of the valid object types | <br />**Values**: QUEUE, CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, USER |
| **body** | **List<string>**| Object Id List |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationdivisions"></a>

## [**AuthzDivision**](AuthzDivision.html) PostAuthorizationDivisions (AuthzDivision body)



Create a division.



Requires ALL permissions: 

* authorization:division:add
* authorization:grant:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationDivisionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            
            var body = new AuthzDivision(); // AuthzDivision | Division
            
            

            try
            {
                
                // Create a division.
                
                AuthzDivision result = apiInstance.PostAuthorizationDivisions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.PostAuthorizationDivisions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuthzDivision**](AuthzDivision.html)| Division |  |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="putauthorizationdivision"></a>

## [**AuthzDivision**](AuthzDivision.html) PutAuthorizationDivision (string divisionId, AuthzDivision body)



Update a division.



Requires ANY permissions: 

* authorization:division:edit

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAuthorizationDivisionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var divisionId = divisionId_example;  // string | Division ID
            
            
            
            
            
            var body = new AuthzDivision(); // AuthzDivision | Updated division data
            
            

            try
            {
                
                // Update a division.
                
                AuthzDivision result = apiInstance.PutAuthorizationDivision(divisionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.PutAuthorizationDivision: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **body** | [**AuthzDivision**](AuthzDivision.html)| Updated division data |  |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

