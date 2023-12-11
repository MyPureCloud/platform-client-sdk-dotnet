---
title: AuthorizationApi
---
## PureCloudPlatform.Client.V2.Api.AuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAuthorizationDivision**](AuthorizationApi.html#deleteauthorizationdivision) | **Delete** /api/v2/authorization/divisions/{divisionId} | Delete a division. |
| [**DeleteAuthorizationRole**](AuthorizationApi.html#deleteauthorizationrole) | **Delete** /api/v2/authorization/roles/{roleId} | Delete an organization role. |
| [**DeleteAuthorizationSubjectDivisionRole**](AuthorizationApi.html#deleteauthorizationsubjectdivisionrole) | **Delete** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Delete a grant of a role in a division |
| [**GetAuthorizationDivision**](AuthorizationApi.html#getauthorizationdivision) | **Get** /api/v2/authorization/divisions/{divisionId} | Returns an authorization division. |
| [**GetAuthorizationDivisionGrants**](AuthorizationApi.html#getauthorizationdivisiongrants) | **Get** /api/v2/authorization/divisions/{divisionId}/grants | Gets all grants for a given division. |
| [**GetAuthorizationDivisions**](AuthorizationApi.html#getauthorizationdivisions) | **Get** /api/v2/authorization/divisions | Retrieve a list of all divisions defined for the organization |
| [**GetAuthorizationDivisionsHome**](AuthorizationApi.html#getauthorizationdivisionshome) | **Get** /api/v2/authorization/divisions/home | Retrieve the home division for the organization. |
| [**GetAuthorizationDivisionsLimit**](AuthorizationApi.html#getauthorizationdivisionslimit) | **Get** /api/v2/authorization/divisions/limit | Returns the maximum allowed number of divisions. |
| [**GetAuthorizationDivisionspermittedMe**](AuthorizationApi.html#getauthorizationdivisionspermittedme) | **Get** /api/v2/authorization/divisionspermitted/me | Returns which divisions the current user has the given permission in. |
| [**GetAuthorizationDivisionspermittedPagedMe**](AuthorizationApi.html#getauthorizationdivisionspermittedpagedme) | **Get** /api/v2/authorization/divisionspermitted/paged/me | Returns which divisions the current user has the given permission in. |
| [**GetAuthorizationDivisionspermittedPagedSubjectId**](AuthorizationApi.html#getauthorizationdivisionspermittedpagedsubjectid) | **Get** /api/v2/authorization/divisionspermitted/paged/{subjectId} | Returns which divisions the specified user has the given permission in. |
| [**GetAuthorizationPermissions**](AuthorizationApi.html#getauthorizationpermissions) | **Get** /api/v2/authorization/permissions | Get all permissions. |
| [**GetAuthorizationProducts**](AuthorizationApi.html#getauthorizationproducts) | **Get** /api/v2/authorization/products | Get the list of enabled products |
| [**GetAuthorizationRole**](AuthorizationApi.html#getauthorizationrole) | **Get** /api/v2/authorization/roles/{roleId} | Get a single organization role. |
| [**GetAuthorizationRoleComparedefaultRightRoleId**](AuthorizationApi.html#getauthorizationrolecomparedefaultrightroleid) | **Get** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an org role to default role comparison |
| [**GetAuthorizationRoleSubjectgrants**](AuthorizationApi.html#getauthorizationrolesubjectgrants) | **Get** /api/v2/authorization/roles/{roleId}/subjectgrants | Get the subjects&#39; granted divisions in the specified role. |
| [**GetAuthorizationRoleUsers**](AuthorizationApi.html#getauthorizationroleusers) | **Get** /api/v2/authorization/roles/{roleId}/users | Get a list of the users in a specified role. |
| [**GetAuthorizationRoles**](AuthorizationApi.html#getauthorizationroles) | **Get** /api/v2/authorization/roles | Retrieve a list of all roles defined for the organization |
| [**GetAuthorizationSettings**](AuthorizationApi.html#getauthorizationsettings) | **Get** /api/v2/authorization/settings | Get authorization settings |
| [**GetAuthorizationSubject**](AuthorizationApi.html#getauthorizationsubject) | **Get** /api/v2/authorization/subjects/{subjectId} | Returns a listing of roles and permissions for a user. |
| [**GetAuthorizationSubjectsMe**](AuthorizationApi.html#getauthorizationsubjectsme) | **Get** /api/v2/authorization/subjects/me | Returns a listing of roles and permissions for the currently authenticated user. |
| [**GetAuthorizationSubjectsRolecounts**](AuthorizationApi.html#getauthorizationsubjectsrolecounts) | **Get** /api/v2/authorization/subjects/rolecounts | Get the count of roles granted to a list of subjects |
| [**GetUserRoles**](AuthorizationApi.html#getuserroles) | **Get** /api/v2/users/{subjectId}/roles | Returns a listing of roles and permissions for a user. |
| [**PatchAuthorizationRole**](AuthorizationApi.html#patchauthorizationrole) | **Patch** /api/v2/authorization/roles/{roleId} | Patch Organization Role for needsUpdate Field |
| [**PatchAuthorizationSettings**](AuthorizationApi.html#patchauthorizationsettings) | **Patch** /api/v2/authorization/settings | Change authorization settings |
| [**PostAuthorizationDivisionObject**](AuthorizationApi.html#postauthorizationdivisionobject) | **Post** /api/v2/authorization/divisions/{divisionId}/objects/{objectType} | Assign a list of objects to a division |
| [**PostAuthorizationDivisionRestore**](AuthorizationApi.html#postauthorizationdivisionrestore) | **Post** /api/v2/authorization/divisions/{divisionId}/restore | Recreate a previously deleted division. |
| [**PostAuthorizationDivisions**](AuthorizationApi.html#postauthorizationdivisions) | **Post** /api/v2/authorization/divisions | Create a division. |
| [**PostAuthorizationRole**](AuthorizationApi.html#postauthorizationrole) | **Post** /api/v2/authorization/roles/{roleId} | Bulk-grant subjects and divisions with an organization role. |
| [**PostAuthorizationRoleComparedefaultRightRoleId**](AuthorizationApi.html#postauthorizationrolecomparedefaultrightroleid) | **Post** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an unsaved org role to default role comparison |
| [**PostAuthorizationRoles**](AuthorizationApi.html#postauthorizationroles) | **Post** /api/v2/authorization/roles | Create an organization role. |
| [**PostAuthorizationRolesDefault**](AuthorizationApi.html#postauthorizationrolesdefault) | **Post** /api/v2/authorization/roles/default | Restores all default roles |
| [**PostAuthorizationSubjectBulkadd**](AuthorizationApi.html#postauthorizationsubjectbulkadd) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkadd | Bulk-grant roles and divisions to a subject. |
| [**PostAuthorizationSubjectBulkremove**](AuthorizationApi.html#postauthorizationsubjectbulkremove) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkremove | Bulk-remove grants from a subject. |
| [**PostAuthorizationSubjectBulkreplace**](AuthorizationApi.html#postauthorizationsubjectbulkreplace) | **Post** /api/v2/authorization/subjects/{subjectId}/bulkreplace | Replace subject&#39;s roles and divisions with the exact list supplied in the request. |
| [**PostAuthorizationSubjectDivisionRole**](AuthorizationApi.html#postauthorizationsubjectdivisionrole) | **Post** /api/v2/authorization/subjects/{subjectId}/divisions/{divisionId}/roles/{roleId} | Make a grant of a role in a division |
| [**PutAuthorizationDivision**](AuthorizationApi.html#putauthorizationdivision) | **Put** /api/v2/authorization/divisions/{divisionId} | Update a division. |
| [**PutAuthorizationRole**](AuthorizationApi.html#putauthorizationrole) | **Put** /api/v2/authorization/roles/{roleId} | Update an organization role. |
| [**PutAuthorizationRoleUsersAdd**](AuthorizationApi.html#putauthorizationroleusersadd) | **Put** /api/v2/authorization/roles/{roleId}/users/add | Sets the users for the role |
| [**PutAuthorizationRoleUsersRemove**](AuthorizationApi.html#putauthorizationroleusersremove) | **Put** /api/v2/authorization/roles/{roleId}/users/remove | Removes the users from the role |
| [**PutAuthorizationRolesDefault**](AuthorizationApi.html#putauthorizationrolesdefault) | **Put** /api/v2/authorization/roles/default | Restore specified default roles |
| [**PutUserRoles**](AuthorizationApi.html#putuserroles) | **Put** /api/v2/users/{subjectId}/roles | Sets the user&#39;s roles |
{: class="table table-striped"}

<a name="deleteauthorizationdivision"></a>

## void DeleteAuthorizationDivision (string divisionId, bool? force = null)



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

            var apiInstance = new AuthorizationApi();
            var divisionId = divisionId_example;  // string | Division ID
            var force = true;  // bool? | Force delete this division as well as the grants and objects associated with it (optional)  (default to false)

            try
            { 
                // Delete a division.
                apiInstance.DeleteAuthorizationDivision(divisionId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteAuthorizationDivision: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **force** | **bool?**| Force delete this division as well as the grants and objects associated with it | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteauthorizationrole"></a>

## void DeleteAuthorizationRole (string roleId)



Delete an organization role.

Requires ANY permissions: 

* authorization:role:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAuthorizationRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID

            try
            { 
                // Delete an organization role.
                apiInstance.DeleteAuthorizationRole(roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteAuthorizationRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteauthorizationsubjectdivisionrole"></a>

## void DeleteAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId)



Delete a grant of a role in a division

Requires ALL permissions: 

* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAuthorizationSubjectDivisionRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var divisionId = divisionId_example;  // string | the id of the division of the grant
            var roleId = roleId_example;  // string | the id of the role of the grant

            try
            { 
                // Delete a grant of a role in a division
                apiInstance.DeleteAuthorizationSubjectDivisionRole(subjectId, divisionId, roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteAuthorizationSubjectDivisionRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **divisionId** | **string**| the id of the division of the grant |  |
| **roleId** | **string**| the id of the role of the grant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getauthorizationdivision"></a>

## [**AuthzDivision**](AuthzDivision.html) GetAuthorizationDivision (string divisionId, bool? objectCount = null)



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

            var apiInstance = new AuthorizationApi();
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
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivision: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="getauthorizationdivisiongrants"></a>

## [**AuthzDivisionGrantEntityListing**](AuthzDivisionGrantEntityListing.html) GetAuthorizationDivisionGrants (string divisionId, int? pageNumber = null, int? pageSize = null)



Gets all grants for a given division.

Returns all grants assigned to a given division. Maximum page size is 500.

Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionGrantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var divisionId = divisionId_example;  // string | Division ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Gets all grants for a given division.
                AuthzDivisionGrantEntityListing result = apiInstance.GetAuthorizationDivisionGrants(divisionId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionGrants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**AuthzDivisionGrantEntityListing**](AuthzDivisionGrantEntityListing.html)

<a name="getauthorizationdivisions"></a>

## [**AuthzDivisionEntityListing**](AuthzDivisionEntityListing.html) GetAuthorizationDivisions (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, List<string> id = null, string name = null)



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

            var apiInstance = new AuthorizationApi();
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
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisions: " + e.Message );
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

            var apiInstance = new AuthorizationApi();

            try
            { 
                // Retrieve the home division for the organization.
                AuthzDivision result = apiInstance.GetAuthorizationDivisionsHome();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionsHome: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="getauthorizationdivisionslimit"></a>

## **int?** GetAuthorizationDivisionsLimit ()



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

            var apiInstance = new AuthorizationApi();

            try
            { 
                // Returns the maximum allowed number of divisions.
                int? result = apiInstance.GetAuthorizationDivisionsLimit();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionsLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

**int?**

<a name="getauthorizationdivisionspermittedme"></a>

## [**List&lt;AuthzDivision&gt;**](AuthzDivision.html) GetAuthorizationDivisionspermittedMe (string permission, string name = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Returns which divisions the current user has the given permission in.

This route is deprecated, use authorization/divisionspermitted/paged/me instead.

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
    public class GetAuthorizationDivisionspermittedMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var name = name_example;  // string | Search term to filter by division name (optional) 

            try
            { 
                // Returns which divisions the current user has the given permission in.
                List<AuthzDivision> result = apiInstance.GetAuthorizationDivisionspermittedMe(permission, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionspermittedMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **name** | **string**| Search term to filter by division name | [optional]  |
{: class="table table-striped"}

### Return type

[**List<AuthzDivision>**](AuthzDivision.html)

<a name="getauthorizationdivisionspermittedpagedme"></a>

## [**DivsPermittedEntityListing**](DivsPermittedEntityListing.html) GetAuthorizationDivisionspermittedPagedMe (string permission, int? pageNumber = null, int? pageSize = null)



Returns which divisions the current user has the given permission in.

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
    public class GetAuthorizationDivisionspermittedPagedMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Returns which divisions the current user has the given permission in.
                DivsPermittedEntityListing result = apiInstance.GetAuthorizationDivisionspermittedPagedMe(permission, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionspermittedPagedMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DivsPermittedEntityListing**](DivsPermittedEntityListing.html)

<a name="getauthorizationdivisionspermittedpagedsubjectid"></a>

## [**DivsPermittedEntityListing**](DivsPermittedEntityListing.html) GetAuthorizationDivisionspermittedPagedSubjectId (string subjectId, string permission, int? pageNumber = null, int? pageSize = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Returns which divisions the specified user has the given permission in.

This route is deprecated, use authorization/divisionspermitted/paged/me instead.

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
    public class GetAuthorizationDivisionspermittedPagedSubjectIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var permission = permission_example;  // string | The permission string, including the object to access, e.g. routing:queue:view
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Returns which divisions the specified user has the given permission in.
                DivsPermittedEntityListing result = apiInstance.GetAuthorizationDivisionspermittedPagedSubjectId(subjectId, permission, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationDivisionspermittedPagedSubjectId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **permission** | **string**| The permission string, including the object to access, e.g. routing:queue:view |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DivsPermittedEntityListing**](DivsPermittedEntityListing.html)

<a name="getauthorizationpermissions"></a>

## [**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html) GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null, string queryType = null, string query = null)



Get all permissions.

Retrieve a list of all permission defined in the system.

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
    public class GetAuthorizationPermissionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var queryType = queryType_example;  // string | Query filter type (optional) 
            var query = query_example;  // string | Comma-separated list of permissions or domains to query (optional) 

            try
            { 
                // Get all permissions.
                PermissionCollectionEntityListing result = apiInstance.GetAuthorizationPermissions(pageSize, pageNumber, queryType, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationPermissions: " + e.Message );
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
| **queryType** | **string**| Query filter type | [optional] <br />**Values**: domain, permission |
| **query** | **string**| Comma-separated list of permissions or domains to query | [optional]  |
{: class="table table-striped"}

### Return type

[**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html)

<a name="getauthorizationproducts"></a>

## [**OrganizationProductEntityListing**](OrganizationProductEntityListing.html) GetAuthorizationProducts ()



Get the list of enabled products

Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.

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
    public class GetAuthorizationProductsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();

            try
            { 
                // Get the list of enabled products
                OrganizationProductEntityListing result = apiInstance.GetAuthorizationProducts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**OrganizationProductEntityListing**](OrganizationProductEntityListing.html)

<a name="getauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) GetAuthorizationRole (string roleId, bool? userCount = null, List<string> expand = null)



Get a single organization role.

Get the organization role specified by its ID.

Requires ANY permissions: 

* authorization:role:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var userCount = userCount_example;  // bool? | Fetch the count of users who have this role granted in at least one division (optional)  (default to true)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. \"unusedPermissions\" returns the permissions not used for the role (optional) 

            try
            { 
                // Get a single organization role.
                DomainOrganizationRole result = apiInstance.GetAuthorizationRole(roleId, userCount, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **userCount** | **bool?**| Fetch the count of users who have this role granted in at least one division | [optional] [default to true]<br />**Values**: true, false |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. \&quot;unusedPermissions\&quot; returns the permissions not used for the role | [optional] <br />**Values**: unusedPermissions |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="getauthorizationrolecomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) GetAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId)



Get an org role to default role comparison

Compares any organization role to a default role id and show differences

Requires ANY permissions: 

* authorization:role:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationRoleComparedefaultRightRoleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id

            try
            { 
                // Get an org role to default role comparison
                DomainOrgRoleDifference result = apiInstance.GetAuthorizationRoleComparedefaultRightRoleId(leftRoleId, rightRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRoleComparedefaultRightRoleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.html)

<a name="getauthorizationrolesubjectgrants"></a>

## [**SubjectDivisionGrantsEntityListing**](SubjectDivisionGrantsEntityListing.html) GetAuthorizationRoleSubjectgrants (string roleId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)



Get the subjects' granted divisions in the specified role.

Includes the divisions for which the subject has a grant.

Requires ANY permissions: 

* authorization:role:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationRoleSubjectgrantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            { 
                // Get the subjects' granted divisions in the specified role.
                SubjectDivisionGrantsEntityListing result = apiInstance.GetAuthorizationRoleSubjectgrants(roleId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRoleSubjectgrants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**SubjectDivisionGrantsEntityListing**](SubjectDivisionGrantsEntityListing.html)

<a name="getauthorizationroleusers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetAuthorizationRoleUsers (string roleId, int? pageSize = null, int? pageNumber = null)



Get a list of the users in a specified role.

Get an array of the UUIDs of the users in the specified role.

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
    public class GetAuthorizationRoleUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of the users in a specified role.
                UserEntityListing result = apiInstance.GetAuthorizationRoleUsers(roleId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRoleUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getauthorizationroles"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, List<string> permission = null, List<string> defaultRoleId = null, bool? userCount = null, List<string> id = null)



Retrieve a list of all roles defined for the organization

Requires ANY permissions: 

* authorization:role:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var name = name_example;  // string |  (optional) 
            var permission = new List<string>(); // List<string> |  (optional) 
            var defaultRoleId = new List<string>(); // List<string> |  (optional) 
            var userCount = true;  // bool? |  (optional)  (default to true)
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Retrieve a list of all roles defined for the organization
                OrganizationRoleEntityListing result = apiInstance.GetAuthorizationRoles(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, permission, defaultRoleId, userCount, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRoles: " + e.Message );
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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**|  | [optional]  |
| **permission** | [**List<string>**](string.html)|  | [optional]  |
| **defaultRoleId** | [**List<string>**](string.html)|  | [optional]  |
| **userCount** | **bool?**|  | [optional] [default to true] |
| **id** | [**List<string>**](string.html)| id | [optional]  |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="getauthorizationsettings"></a>

## [**AuthorizationSettings**](AuthorizationSettings.html) GetAuthorizationSettings ()



Get authorization settings

Requires ANY permissions: 

* directory:organization:admin
* authorization:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();

            try
            { 
                // Get authorization settings
                AuthorizationSettings result = apiInstance.GetAuthorizationSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AuthorizationSettings**](AuthorizationSettings.html)

<a name="getauthorizationsubject"></a>

## [**AuthzSubject**](AuthzSubject.html) GetAuthorizationSubject (string subjectId)



Returns a listing of roles and permissions for a user.

Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationSubjectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)

            try
            { 
                // Returns a listing of roles and permissions for a user.
                AuthzSubject result = apiInstance.GetAuthorizationSubject(subjectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationSubject: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
{: class="table table-striped"}

### Return type

[**AuthzSubject**](AuthzSubject.html)

<a name="getauthorizationsubjectsme"></a>

## [**AuthzSubject**](AuthzSubject.html) GetAuthorizationSubjectsMe ()



Returns a listing of roles and permissions for the currently authenticated user.

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
    public class GetAuthorizationSubjectsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();

            try
            { 
                // Returns a listing of roles and permissions for the currently authenticated user.
                AuthzSubject result = apiInstance.GetAuthorizationSubjectsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationSubjectsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AuthzSubject**](AuthzSubject.html)

<a name="getauthorizationsubjectsrolecounts"></a>

## **Dictionary&lt;string, Object&gt;** GetAuthorizationSubjectsRolecounts (List<string> id = null)



Get the count of roles granted to a list of subjects

Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationSubjectsRolecountsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Get the count of roles granted to a list of subjects
                Dictionary<string, Object> result = apiInstance.GetAuthorizationSubjectsRolecounts(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationSubjectsRolecounts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| id | [optional]  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="getuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetUserRoles (string subjectId)



Returns a listing of roles and permissions for a user.

Requires ANY permissions: 

* authorization:grant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | User ID

            try
            { 
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserRoles(subjectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="patchauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PatchAuthorizationRole (string roleId, DomainOrganizationRole body)



Patch Organization Role for needsUpdate Field

Patch Organization Role for needsUpdate Field

Requires ANY permissions: 

* authorization:role:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAuthorizationRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            { 
                // Patch Organization Role for needsUpdate Field
                DomainOrganizationRole result = apiInstance.PatchAuthorizationRole(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PatchAuthorizationRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="patchauthorizationsettings"></a>

## [**AuthorizationSettings**](AuthorizationSettings.html) PatchAuthorizationSettings (AuthorizationSettings body)



Change authorization settings

Change authorization settings

Requires ANY permissions: 

* directory:organization:admin
* authorization:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAuthorizationSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var body = new AuthorizationSettings(); // AuthorizationSettings | Authorization Settings

            try
            { 
                // Change authorization settings
                AuthorizationSettings result = apiInstance.PatchAuthorizationSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PatchAuthorizationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuthorizationSettings**](AuthorizationSettings.html)| Authorization Settings |  |
{: class="table table-striped"}

### Return type

[**AuthorizationSettings**](AuthorizationSettings.html)

<a name="postauthorizationdivisionobject"></a>

## void PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)



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

            var apiInstance = new AuthorizationApi();
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
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationDivisionObject: " + e.Message );
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
| **body** | [**List<string>**](string.html)| Object Id List |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationdivisionrestore"></a>

## [**AuthzDivision**](AuthzDivision.html) PostAuthorizationDivisionRestore (string divisionId, AuthzDivision body = null)



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

            var apiInstance = new AuthorizationApi();
            var divisionId = divisionId_example;  // string | Division ID
            var body = new AuthzDivision(); // AuthzDivision | Recreated division data (optional) 

            try
            { 
                // Recreate a previously deleted division.
                AuthzDivision result = apiInstance.PostAuthorizationDivisionRestore(divisionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationDivisionRestore: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **body** | [**AuthzDivision**](AuthzDivision.html)| Recreated division data | [optional]  |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="postauthorizationdivisions"></a>

## [**AuthzDivision**](AuthzDivision.html) PostAuthorizationDivisions (AuthzDivision body)



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

            var apiInstance = new AuthorizationApi();
            var body = new AuthzDivision(); // AuthzDivision | Division

            try
            { 
                // Create a division.
                AuthzDivision result = apiInstance.PostAuthorizationDivisions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationDivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuthzDivision**](AuthzDivision.html)| Division |  |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="postauthorizationrole"></a>

## void PostAuthorizationRole (string roleId, SubjectDivisions body, string subjectType = null)



Bulk-grant subjects and divisions with an organization role.

Requires ALL permissions: 

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
    public class PostAuthorizationRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new SubjectDivisions(); // SubjectDivisions | Subjects and Divisions
            var subjectType = subjectType_example;  // string | what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional)  (default to "PC_USER")

            try
            { 
                // Bulk-grant subjects and divisions with an organization role.
                apiInstance.PostAuthorizationRole(roleId, body, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**SubjectDivisions**](SubjectDivisions.html)| Subjects and Divisions |  |
| **subjectType** | **string**| what the type of the subjects are (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationrolecomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) PostAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body)



Get an unsaved org role to default role comparison

Allows users to compare their existing roles in an unsaved state to its default role

Requires ANY permissions: 

* authorization:role:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationRoleComparedefaultRightRoleIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            { 
                // Get an unsaved org role to default role comparison
                DomainOrgRoleDifference result = apiInstance.PostAuthorizationRoleComparedefaultRightRoleId(leftRoleId, rightRoleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationRoleComparedefaultRightRoleId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.html)

<a name="postauthorizationroles"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PostAuthorizationRoles (DomainOrganizationRoleCreate body)



Create an organization role.

Requires ANY permissions: 

* authorization:role:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var body = new DomainOrganizationRoleCreate(); // DomainOrganizationRoleCreate | Organization role

            try
            { 
                // Create an organization role.
                DomainOrganizationRole result = apiInstance.PostAuthorizationRoles(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainOrganizationRoleCreate**](DomainOrganizationRoleCreate.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="postauthorizationrolesdefault"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) PostAuthorizationRolesDefault (bool? force = null)



Restores all default roles

This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.

Requires ANY permissions: 

* authorization:role:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationRolesDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var force = true;  // bool? | Restore default roles (optional)  (default to false)

            try
            { 
                // Restores all default roles
                OrganizationRoleEntityListing result = apiInstance.PostAuthorizationRolesDefault(force);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationRolesDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **force** | **bool?**| Restore default roles | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="postauthorizationsubjectbulkadd"></a>

## void PostAuthorizationSubjectBulkadd (string subjectId, RoleDivisionGrants body, string subjectType = null)



Bulk-grant roles and divisions to a subject.

Requires ALL permissions: 

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
    public class PostAuthorizationSubjectBulkaddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs
            var subjectType = subjectType_example;  // string | what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional)  (default to "PC_USER")

            try
            { 
                // Bulk-grant roles and divisions to a subject.
                apiInstance.PostAuthorizationSubjectBulkadd(subjectId, body, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationSubjectBulkadd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
| **subjectType** | **string**| what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectbulkremove"></a>

## void PostAuthorizationSubjectBulkremove (string subjectId, RoleDivisionGrants body)



Bulk-remove grants from a subject.

Requires ALL permissions: 

* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationSubjectBulkremoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs

            try
            { 
                // Bulk-remove grants from a subject.
                apiInstance.PostAuthorizationSubjectBulkremove(subjectId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationSubjectBulkremove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectbulkreplace"></a>

## void PostAuthorizationSubjectBulkreplace (string subjectId, RoleDivisionGrants body, string subjectType = null)



Replace subject's roles and divisions with the exact list supplied in the request.

This operation will not remove grants that are inherited from group membership. It will only set the grants directly applied to the subject.

Requires ALL permissions: 

* authorization:grant:add
* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationSubjectBulkreplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var body = new RoleDivisionGrants(); // RoleDivisionGrants | Pairs of role and division IDs
            var subjectType = subjectType_example;  // string | what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) (optional)  (default to "PC_USER")

            try
            { 
                // Replace subject's roles and divisions with the exact list supplied in the request.
                apiInstance.PostAuthorizationSubjectBulkreplace(subjectId, body, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationSubjectBulkreplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **body** | [**RoleDivisionGrants**](RoleDivisionGrants.html)| Pairs of role and division IDs |  |
| **subjectType** | **string**| what the type of the subject is (PC_GROUP, PC_USER or PC_OAUTH_CLIENT) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postauthorizationsubjectdivisionrole"></a>

## void PostAuthorizationSubjectDivisionRole (string subjectId, string divisionId, string roleId, string subjectType = null)



Make a grant of a role in a division

Requires ALL permissions: 

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
    public class PostAuthorizationSubjectDivisionRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | Subject ID (user or group)
            var divisionId = divisionId_example;  // string | the id of the division to which to make the grant
            var roleId = roleId_example;  // string | the id of the role to grant
            var subjectType = subjectType_example;  // string | what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) (optional)  (default to "PC_USER")

            try
            { 
                // Make a grant of a role in a division
                apiInstance.PostAuthorizationSubjectDivisionRole(subjectId, divisionId, roleId, subjectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostAuthorizationSubjectDivisionRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| Subject ID (user or group) |  |
| **divisionId** | **string**| the id of the division to which to make the grant |  |
| **roleId** | **string**| the id of the role to grant |  |
| **subjectType** | **string**| what the type of the subject is: PC_GROUP, PC_USER or PC_OAUTH_CLIENT (note: for cross-org authorization, please use the Organization Authorization endpoints) | [optional] [default to "PC_USER"] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putauthorizationdivision"></a>

## [**AuthzDivision**](AuthzDivision.html) PutAuthorizationDivision (string divisionId, AuthzDivision body)



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

            var apiInstance = new AuthorizationApi();
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
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationDivision: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **body** | [**AuthzDivision**](AuthzDivision.html)| Updated division data |  |
{: class="table table-striped"}

### Return type

[**AuthzDivision**](AuthzDivision.html)

<a name="putauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PutAuthorizationRole (string roleId, DomainOrganizationRoleUpdate body)



Update an organization role.

Update

Requires ANY permissions: 

* authorization:role:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAuthorizationRoleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRoleUpdate(); // DomainOrganizationRoleUpdate | Organization role

            try
            { 
                // Update an organization role.
                DomainOrganizationRole result = apiInstance.PutAuthorizationRole(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRole: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRoleUpdate**](DomainOrganizationRoleUpdate.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="putauthorizationroleusersadd"></a>

## **List&lt;string&gt;** PutAuthorizationRoleUsersAdd (string roleId, List<string> body)



Sets the users for the role

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
    public class PutAuthorizationRoleUsersAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new List<string>(); // List<string> | List of user IDs

            try
            { 
                // Sets the users for the role
                List<string> result = apiInstance.PutAuthorizationRoleUsersAdd(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRoleUsersAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**List<string>**](string.html)| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putauthorizationroleusersremove"></a>

## **List&lt;string&gt;** PutAuthorizationRoleUsersRemove (string roleId, List<string> body)



Removes the users from the role

Requires ANY permissions: 

* authorization:grant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAuthorizationRoleUsersRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new List<string>(); // List<string> | List of user IDs

            try
            { 
                // Removes the users from the role
                List<string> result = apiInstance.PutAuthorizationRoleUsersRemove(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRoleUsersRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**List<string>**](string.html)| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putauthorizationrolesdefault"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) PutAuthorizationRolesDefault (List<DomainOrganizationRole> body)



Restore specified default roles

Requires ANY permissions: 

* authorization:role:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAuthorizationRolesDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var body = new List<DomainOrganizationRole>(); // List<DomainOrganizationRole> | Organization roles list

            try
            { 
                // Restore specified default roles
                OrganizationRoleEntityListing result = apiInstance.PutAuthorizationRolesDefault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRolesDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<DomainOrganizationRole>**](DomainOrganizationRole.html)| Organization roles list |  |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="putuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserRoles (string subjectId, List<string> body)



Sets the user's roles

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
    public class PutUserRolesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuthorizationApi();
            var subjectId = subjectId_example;  // string | User ID
            var body = new List<string>(); // List<string> | List of roles

            try
            { 
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserRoles(subjectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **subjectId** | **string**| User ID |  |
| **body** | [**List<string>**](string.html)| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

