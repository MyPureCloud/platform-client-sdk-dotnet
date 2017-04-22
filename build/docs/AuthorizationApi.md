---
title: AuthorizationApi
---
## PureCloudPlatform.Client.V2.Api.AuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAuthorizationRole**](AuthorizationApi.html#deleteauthorizationrole) | **DELETE** /api/v2/authorization/roles/{roleId} | Delete an organization role. |
| [**DeleteUserRoles**](AuthorizationApi.html#deleteuserroles) | **DELETE** /api/v2/users/{userId}/roles | Removes all the roles from the user. |
| [**GetAuthorizationPermissions**](AuthorizationApi.html#getauthorizationpermissions) | **GET** /api/v2/authorization/permissions | Get all permissions. |
| [**GetAuthorizationProducts**](AuthorizationApi.html#getauthorizationproducts) | **GET** /api/v2/authorization/products | Get the list of enabled products |
| [**GetAuthorizationRole**](AuthorizationApi.html#getauthorizationrole) | **GET** /api/v2/authorization/roles/{roleId} | Get a single organization role. |
| [**GetAuthorizationRoleComparedefaultRightRoleId**](AuthorizationApi.html#getauthorizationrolecomparedefaultrightroleid) | **GET** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an org role to default role comparison comparison |
| [**GetAuthorizationRoles**](AuthorizationApi.html#getauthorizationroles) | **GET** /api/v2/authorization/roles | Retrieve a list of all roles defined for the organization |
| [**GetUserRoles**](AuthorizationApi.html#getuserroles) | **GET** /api/v2/users/{userId}/roles | Returns a listing of roles and permissions for a user. |
| [**PatchAuthorizationRole**](AuthorizationApi.html#patchauthorizationrole) | **PATCH** /api/v2/authorization/roles/{roleId} | Patch Organization Role for needsUpdate Field |
| [**PostAuthorizationRoleComparedefaultRightRoleId**](AuthorizationApi.html#postauthorizationrolecomparedefaultrightroleid) | **POST** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an unsaved org role to default role comparison |
| [**PostAuthorizationRoles**](AuthorizationApi.html#postauthorizationroles) | **POST** /api/v2/authorization/roles | Create an organization role. |
| [**PostAuthorizationRolesDefault**](AuthorizationApi.html#postauthorizationrolesdefault) | **POST** /api/v2/authorization/roles/default | Restores all default roles |
| [**PutAuthorizationRole**](AuthorizationApi.html#putauthorizationrole) | **PUT** /api/v2/authorization/roles/{roleId} | Update an organization role. |
| [**PutAuthorizationRoleUsersAdd**](AuthorizationApi.html#putauthorizationroleusersadd) | **PUT** /api/v2/authorization/roles/{roleId}/users/add | Sets the users for the role |
| [**PutAuthorizationRoleUsersRemove**](AuthorizationApi.html#putauthorizationroleusersremove) | **PUT** /api/v2/authorization/roles/{roleId}/users/remove | Removes the users from the role |
| [**PutAuthorizationRolesDefault**](AuthorizationApi.html#putauthorizationrolesdefault) | **PUT** /api/v2/authorization/roles/default | Restore specified default roles |
| [**PutUserRoles**](AuthorizationApi.html#putuserroles) | **PUT** /api/v2/users/{userId}/roles | Sets the user&#39;s roles |
{: class="table table-striped"}

<a name="deleteauthorizationrole"></a>

## void DeleteAuthorizationRole (string roleId)

Delete an organization role.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuserroles"></a>

## void DeleteUserRoles (string userId)

Removes all the roles from the user.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Removes all the roles from the user.
                apiInstance.DeleteUserRoles(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getauthorizationpermissions"></a>

## [**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html) GetAuthorizationPermissions (int? pageSize = null, int? pageNumber = null)

Get all permissions.

Retrieve a list of all permission defined in the system.

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get all permissions.
                PermissionCollectionEntityListing result = apiInstance.GetAuthorizationPermissions(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationPermissions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html)

<a name="getauthorizationproducts"></a>

## [**OrganizationProductEntityListing**](OrganizationProductEntityListing.html) GetAuthorizationProducts ()

Get the list of enabled products

Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OrganizationProductEntityListing**](OrganizationProductEntityListing.html)

<a name="getauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) GetAuthorizationRole (string roleId)

Get a single organization role.

Get the organization role specified by its ID.

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID

            try
            {
                // Get a single organization role.
                DomainOrganizationRole result = apiInstance.GetAuthorizationRole(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRole: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="getauthorizationrolecomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) GetAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId)

Get an org role to default role comparison comparison

Compares any organization role to a default role id and show differences

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id

            try
            {
                // Get an org role to default role comparison comparison
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.html)

<a name="getauthorizationroles"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) GetAuthorizationRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, List<Object> permission = null, List<Object> defaultRoleId = null, bool? userCount = null)

Retrieve a list of all roles defined for the organization



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var permission = new List<Object>(); // List<Object> |  (optional) 
            var defaultRoleId = new List<Object>(); // List<Object> |  (optional) 
            var userCount = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Retrieve a list of all roles defined for the organization
                OrganizationRoleEntityListing result = apiInstance.GetAuthorizationRoles(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, defaultRoleId, userCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetAuthorizationRoles: " + e.Message );
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
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **permission** | [**List<Object>**](Object.html)|  | [optional]  |
| **defaultRoleId** | [**List<Object>**](Object.html)|  | [optional]  |
| **userCount** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="getuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetUserRoles (string userId)

Returns a listing of roles and permissions for a user.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="patchauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PatchAuthorizationRole (string roleId, DomainOrganizationRole body)

Patch Organization Role for needsUpdate Field

Patch Organization Role for needsUpdate Field

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="postauthorizationrolecomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) PostAuthorizationRoleComparedefaultRightRoleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body)

Get an unsaved org role to default role comparison

Allows users to compare their existing roles in an unsaved state to its default role

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

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

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **force** | **bool?**| Restore default roles | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="putauthorizationrole"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PutAuthorizationRole (string roleId, DomainOrganizationRoleUpdate body)

Update an organization role.

Update

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> | List of user IDs

            try
            {
                // Sets the users for the role
                List&lt;string&gt; result = apiInstance.PutAuthorizationRoleUsersAdd(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRoleUsersAdd: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putauthorizationroleusersremove"></a>

## **List&lt;string&gt;** PutAuthorizationRoleUsersRemove (string roleId, List<string> body)

Removes the users from the role



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> | List of user IDs

            try
            {
                // Removes the users from the role
                List&lt;string&gt; result = apiInstance.PutAuthorizationRoleUsersRemove(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutAuthorizationRoleUsersRemove: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putauthorizationrolesdefault"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) PutAuthorizationRolesDefault (List<DomainOrganizationRole> body)

Restore specified default roles



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<DomainOrganizationRole>**](DomainOrganizationRole.html)| Organization roles list |  |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="putuserroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserRoles (string userId, List<string> body)

Sets the user's roles



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> | List of roles

            try
            {
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserRoles(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutUserRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

