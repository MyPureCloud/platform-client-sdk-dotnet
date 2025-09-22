# ObjectsApi

## PureCloudPlatform.Client.V2.Api.ObjectsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAuthorizationDivision**](#DeleteAuthorizationDivision) | **Delete** /api/v2/authorization/divisions/{divisionId} | Delete a division. |
| [**GetAuthorizationDivision**](#GetAuthorizationDivision) | **Get** /api/v2/authorization/divisions/{divisionId} | Returns an authorization division. |
| [**GetAuthorizationDivisions**](#GetAuthorizationDivisions) | **Get** /api/v2/authorization/divisions | Retrieve a list of all divisions defined for the organization |
| [**GetAuthorizationDivisionsDeleted**](#GetAuthorizationDivisionsDeleted) | **Get** /api/v2/authorization/divisions/deleted | Get a list of soft deleted divisions for the org |
| [**GetAuthorizationDivisionsHome**](#GetAuthorizationDivisionsHome) | **Get** /api/v2/authorization/divisions/home | Retrieve the home division for the organization. |
| [**GetAuthorizationDivisionsLimit**](#GetAuthorizationDivisionsLimit) | **Get** /api/v2/authorization/divisions/limit | Returns the maximum allowed number of divisions. |
| [**GetAuthorizationDivisionsQuery**](#GetAuthorizationDivisionsQuery) | **Get** /api/v2/authorization/divisions/query | Retrieve a list of all divisions defined for the organization with cursor |
| [**PostAuthorizationDivisionObject**](#PostAuthorizationDivisionObject) | **Post** /api/v2/authorization/divisions/{divisionId}/objects/{objectType} | Assign a list of objects to a division |
| [**PostAuthorizationDivisionRestore**](#PostAuthorizationDivisionRestore) | **Post** /api/v2/authorization/divisions/{divisionId}/restore | Recreate a previously deleted division. |
| [**PostAuthorizationDivisions**](#PostAuthorizationDivisions) | **Post** /api/v2/authorization/divisions | Create a division. |
| [**PutAuthorizationDivision**](#PutAuthorizationDivision) | **Put** /api/v2/authorization/divisions/{divisionId} | Update a division. |



## DeleteAuthorizationDivision

> void DeleteAuthorizationDivision (string divisionId, bool? force = null)


Delete a division.

Requires ANY permissions: 

* authorization:division:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var divisionId = divisionId_example;  // string | Division ID
            var force = true;  // bool? | DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. (optional)  (default to false)

            try
            { 
                // Delete a division.
                apiInstance.DeleteAuthorizationDivision(divisionId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.DeleteAuthorizationDivision: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **force** | **bool?**| DEPRECATED -  Force delete this division. Warning: This option may cause any remaining objects in this division to be inaccessible. | [optional] [default to false] |

### Return type

void (empty response body)


## GetAuthorizationDivision

> [**AuthzDivision**](AuthzDivision) GetAuthorizationDivision (string divisionId, bool? objectCount = null)


Returns an authorization division.

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
    public class GetAuthorizationDivisionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var divisionId = divisionId_example;  // string | Division ID
            var objectCount = objectCount_example;  // bool? | Get count of objects in this division, grouped by type (optional)  (default to false)

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **objectCount** | **bool?**| Get count of objects in this division, grouped by type | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**AuthzDivision**](AuthzDivision)


## GetAuthorizationDivisions

> [**AuthzDivisionEntityListing**](AuthzDivisionEntityListing) GetAuthorizationDivisions (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)


Retrieve a list of all divisions defined for the organization

Request specific divisions by id using a query param \"id\", e.g.  ?id=5f777167-63be-4c24-ad41-374155d9e28b&id=72e9fb25-c484-488d-9312-7acba82435b3

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
    public class GetAuthorizationDivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **objectCount** | **bool?**| Include the count of objects contained in the division | [optional] [default to false] |
| **id** | [**List<string>**](string)| Optionally request specific divisions by their IDs | [optional]  |
| **name** | **string**| Search term to filter by division name | [optional]  |

### Return type

[**AuthzDivisionEntityListing**](AuthzDivisionEntityListing)


## GetAuthorizationDivisionsDeleted

> [**AuthzDivisionEntityListing**](AuthzDivisionEntityListing) GetAuthorizationDivisionsDeleted (int? pageNumber = null, int? pageSize = null)


Get a list of soft deleted divisions for the org

Requires ANY permissions: 

* authorization:divisionDeleted:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionsDeletedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a list of soft deleted divisions for the org
                AuthzDivisionEntityListing result = apiInstance.GetAuthorizationDivisionsDeleted(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisionsDeleted: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**AuthzDivisionEntityListing**](AuthzDivisionEntityListing)


## GetAuthorizationDivisionsHome

> [**AuthzDivision**](AuthzDivision) GetAuthorizationDivisionsHome ()


Retrieve the home division for the organization.

Will not include object counts.

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
    public class GetAuthorizationDivisionsHomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AuthzDivision**](AuthzDivision)


## GetAuthorizationDivisionsLimit

> **int?** GetAuthorizationDivisionsLimit ()


Returns the maximum allowed number of divisions.

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
    public class GetAuthorizationDivisionsLimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters
This endpoint does require any parameters.

### Return type

**int?**


## GetAuthorizationDivisionsQuery

> [**AuthzDivisionCursorListing**](AuthzDivisionCursorListing) GetAuthorizationDivisionsQuery (string before = null, string after = null, string pageSize = null, List<string> id = null, string name = null)


Retrieve a list of all divisions defined for the organization with cursor

Use \"after\" and \"before\" param to fetch next/previous page}

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
    public class GetAuthorizationDivisionsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var id = new List<string>(); // List<string> | Optionally request specific divisions by their IDs (optional) 
            var name = name_example;  // string | Optionally request specific divisions by division name (optional) 

            try
            { 
                // Retrieve a list of all divisions defined for the organization with cursor
                AuthzDivisionCursorListing result = apiInstance.GetAuthorizationDivisionsQuery(before, after, pageSize, id, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisionsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **id** | [**List<string>**](string)| Optionally request specific divisions by their IDs | [optional]  |
| **name** | **string**| Optionally request specific divisions by division name | [optional]  |

### Return type

[**AuthzDivisionCursorListing**](AuthzDivisionCursorListing)


## PostAuthorizationDivisionObject

> void PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)


Assign a list of objects to a division

Set the division of a specified list of objects. The objects must all be of the same type, one of:  CAMPAIGN, MANAGEMENTUNIT, FLOW, QUEUE, DATATABLES or USER.  The body of the request is a list of object IDs, which are expected to be  GUIDs, e.g. [\"206ce31f-61ec-40ed-a8b1-be6f06303998\",\"250a754e-f5e4-4f51-800f-a92f09d3bf8c\"]

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
    public class PostAuthorizationDivisionObjectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var divisionId = divisionId_example;  // string | Division ID
            var objectType = objectType_example;  // string | The type of the objects. Must be one of the valid object types
            var body = new List<string>(); // List<string> | Object Id List

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **objectType** | **string**| The type of the objects. Must be one of the valid object types | <br />**Values**: QUEUE, CAMPAIGN, CONTACTLIST, DNCLIST, EMAILCAMPAIGN, MESSAGINGCAMPAIGN, MANAGEMENTUNIT, BUSINESSUNIT, FLOW, FLOWMILESTONE, FLOWOUTCOME, USER, CALLROUTE, EMERGENCYGROUPS, ROUTINGSCHEDULES, ROUTINGSCHEDULEGROUPS, DATATABLES, TEAM, WORKBIN, WORKTYPE, EXTENSIONPOOL, SKILLGROUP, SCRIPT |
| **body** | [**List<string>**](string)| Object Id List |  |

### Return type

void (empty response body)


## PostAuthorizationDivisionRestore

> [**AuthzDivision**](AuthzDivision) PostAuthorizationDivisionRestore (string divisionId, AuthzDivision body)


Recreate a previously deleted division.

Requires ANY permissions: 

* authorization:division:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationDivisionRestoreExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ObjectsApi();
            var divisionId = divisionId_example;  // string | Division ID
            var body = new AuthzDivision(); // AuthzDivision | Recreated division data

            try
            { 
                // Recreate a previously deleted division.
                AuthzDivision result = apiInstance.PostAuthorizationDivisionRestore(divisionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.PostAuthorizationDivisionRestore: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **body** | [**AuthzDivision**](AuthzDivision)| Recreated division data |  |

### Return type

[**AuthzDivision**](AuthzDivision)


## PostAuthorizationDivisions

> [**AuthzDivision**](AuthzDivision) PostAuthorizationDivisions (AuthzDivision body)


Create a division.

Requires ALL permissions: 

* authorization:division:add
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
    public class PostAuthorizationDivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuthzDivision**](AuthzDivision)| Division |  |

### Return type

[**AuthzDivision**](AuthzDivision)


## PutAuthorizationDivision

> [**AuthzDivision**](AuthzDivision) PutAuthorizationDivision (string divisionId, AuthzDivision body)


Update a division.

Requires ANY permissions: 

* authorization:division:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **body** | [**AuthzDivision**](AuthzDivision)| Updated division data |  |

### Return type

[**AuthzDivision**](AuthzDivision)


_PureCloudPlatform.Client.V2 242.0.0_
