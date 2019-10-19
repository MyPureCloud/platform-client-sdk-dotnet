---
title: SCIMApi
---
## PureCloudPlatform.Client.V2.Api.SCIMApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteScimUser**](SCIMApi.html#deletescimuser) | **DELETE** /api/v2/scim/users/{userId} | Delete a user |
| [**DeleteScimV2User**](SCIMApi.html#deletescimv2user) | **DELETE** /api/v2/scim/v2/users/{userId} | Delete a user |
| [**GetScimGroup**](SCIMApi.html#getscimgroup) | **GET** /api/v2/scim/groups/{groupId} | Get a group |
| [**GetScimGroups**](SCIMApi.html#getscimgroups) | **GET** /api/v2/scim/groups | Get a list of groups |
| [**GetScimResourcetype**](SCIMApi.html#getscimresourcetype) | **GET** /api/v2/scim/resourcetypes/{resourceType} | Get a resource type |
| [**GetScimResourcetypes**](SCIMApi.html#getscimresourcetypes) | **GET** /api/v2/scim/resourcetypes | Get a list of resource types |
| [**GetScimServiceproviderconfig**](SCIMApi.html#getscimserviceproviderconfig) | **GET** /api/v2/scim/serviceproviderconfig | Get a service provider&#39;s configuration |
| [**GetScimUser**](SCIMApi.html#getscimuser) | **GET** /api/v2/scim/users/{userId} | Get a user |
| [**GetScimUsers**](SCIMApi.html#getscimusers) | **GET** /api/v2/scim/users | Get a list of users |
| [**GetScimV2Group**](SCIMApi.html#getscimv2group) | **GET** /api/v2/scim/v2/groups/{groupId} | Get a group |
| [**GetScimV2Groups**](SCIMApi.html#getscimv2groups) | **GET** /api/v2/scim/v2/groups | Get a list of groups |
| [**GetScimV2Resourcetype**](SCIMApi.html#getscimv2resourcetype) | **GET** /api/v2/scim/v2/resourcetypes/{resourceType} | Get a resource type |
| [**GetScimV2Resourcetypes**](SCIMApi.html#getscimv2resourcetypes) | **GET** /api/v2/scim/v2/resourcetypes | Get a list of resource types |
| [**GetScimV2Serviceproviderconfig**](SCIMApi.html#getscimv2serviceproviderconfig) | **GET** /api/v2/scim/v2/serviceproviderconfig | Get a service provider&#39;s configuration |
| [**GetScimV2User**](SCIMApi.html#getscimv2user) | **GET** /api/v2/scim/v2/users/{userId} | Get a user |
| [**GetScimV2Users**](SCIMApi.html#getscimv2users) | **GET** /api/v2/scim/v2/users | Get a list of users |
| [**PatchScimGroup**](SCIMApi.html#patchscimgroup) | **PATCH** /api/v2/scim/groups/{groupId} | Modify a group |
| [**PatchScimUser**](SCIMApi.html#patchscimuser) | **PATCH** /api/v2/scim/users/{userId} | Modify a user |
| [**PatchScimV2Group**](SCIMApi.html#patchscimv2group) | **PATCH** /api/v2/scim/v2/groups/{groupId} | Modify a group |
| [**PatchScimV2User**](SCIMApi.html#patchscimv2user) | **PATCH** /api/v2/scim/v2/users/{userId} | Modify a user |
| [**PostScimUsers**](SCIMApi.html#postscimusers) | **POST** /api/v2/scim/users | Create a user |
| [**PostScimV2Users**](SCIMApi.html#postscimv2users) | **POST** /api/v2/scim/v2/users | Create a user |
| [**PutScimGroup**](SCIMApi.html#putscimgroup) | **PUT** /api/v2/scim/groups/{groupId} | Replace a group |
| [**PutScimUser**](SCIMApi.html#putscimuser) | **PUT** /api/v2/scim/users/{userId} | Replace a user |
| [**PutScimV2Group**](SCIMApi.html#putscimv2group) | **PUT** /api/v2/scim/v2/groups/{groupId} | Replace a group |
| [**PutScimV2User**](SCIMApi.html#putscimv2user) | **PUT** /api/v2/scim/v2/users/{userId} | Replace a user |
{: class="table table-striped"}

<a name="deletescimuser"></a>

## [**Empty**](Empty.html) DeleteScimUser (string userId, string ifMatch = null)



Delete a user



Requires ANY permissions: 

* directory:user:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteScimUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/users.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Delete a user
                Empty result = apiInstance.DeleteScimUser(userId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.DeleteScimUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/users. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deletescimv2user"></a>

## [**Empty**](Empty.html) DeleteScimV2User (string userId, string ifMatch = null)



Delete a user



Requires ANY permissions: 

* directory:user:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteScimV2UserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/v2/users.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Delete a user
                Empty result = apiInstance.DeleteScimV2User(userId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.DeleteScimV2User: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/v2/users. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="getscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) GetScimGroup (string groupId, string ifNoneMatch = null)



Get a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/groups.
            var ifNoneMatch = ifNoneMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional) 

            try
            { 
                // Get a group
                ScimV2Group result = apiInstance.GetScimGroup(groupId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/groups. |  |
| **ifNoneMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="getscimgroups"></a>

## [**ScimGroupListResponse**](ScimGroupListResponse.html) GetScimGroups (int? startIndex = null, int? count = null, string filter = null)



Get a list of groups



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var startIndex = 56;  // int? | The 1-based index of the first query result. (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 returns \"totalResults\". (optional)  (default to 25)
            var filter = displayName eq groupName;  // string | Filters results. (optional) 

            try
            { 
                // Get a list of groups
                ScimGroupListResponse result = apiInstance.GetScimGroups(startIndex, count, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startIndex** | **int?**| The 1-based index of the first query result. | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. | [optional] [default to 25] |
| **filter** | **string**| Filters results. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimGroupListResponse**](ScimGroupListResponse.html)

<a name="getscimresourcetype"></a>

## [**ScimConfigResourceType**](ScimConfigResourceType.html) GetScimResourcetype (string resourceType)



Get a resource type



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
    public class GetScimResourcetypeExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();
            var resourceType = resourceType_example;  // string | The type of resource. Returned with GET /api/v2/scim/resourcetypes.

            try
            { 
                // Get a resource type
                ScimConfigResourceType result = apiInstance.GetScimResourcetype(resourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimResourcetype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **resourceType** | **string**| The type of resource. Returned with GET /api/v2/scim/resourcetypes. | <br />**Values**: User, Group, ServiceProviderConfig, ResourceType |
{: class="table table-striped"}

### Return type

[**ScimConfigResourceType**](ScimConfigResourceType.html)

<a name="getscimresourcetypes"></a>

## [**ScimConfigResourceTypesListResponse**](ScimConfigResourceTypesListResponse.html) GetScimResourcetypes ()



Get a list of resource types



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
    public class GetScimResourcetypesExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();

            try
            { 
                // Get a list of resource types
                ScimConfigResourceTypesListResponse result = apiInstance.GetScimResourcetypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimResourcetypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ScimConfigResourceTypesListResponse**](ScimConfigResourceTypesListResponse.html)

<a name="getscimserviceproviderconfig"></a>

## [**ScimServiceProviderConfig**](ScimServiceProviderConfig.html) GetScimServiceproviderconfig (string ifNoneMatch = null)



Get a service provider's configuration



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
    public class GetScimServiceproviderconfigExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();
            var ifNoneMatch = ifNoneMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional) 

            try
            { 
                // Get a service provider's configuration
                ScimServiceProviderConfig result = apiInstance.GetScimServiceproviderconfig(ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimServiceproviderconfig: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ifNoneMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimServiceProviderConfig**](ScimServiceProviderConfig.html)

<a name="getscimuser"></a>

## [**ScimV2User**](ScimV2User.html) GetScimUser (string userId, string ifNoneMatch = null)



Get a user



Requires ANY permissions: 

* directory:user:view
* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/users.
            var ifNoneMatch = ifNoneMatch_example;  // string | TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional) 

            try
            { 
                // Get a user
                ScimV2User result = apiInstance.GetScimUser(userId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/users. |  |
| **ifNoneMatch** | **string**| TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="getscimusers"></a>

## [**ScimUserListResponse**](ScimUserListResponse.html) GetScimUsers (string filter, int? startIndex = null, int? count = null)



Get a list of users



Requires ANY permissions: 

* directory:user:view
* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var filter = filter_example;  // string | Filters results.
            var startIndex = 56;  // int? | The 1-based index of the first query result. (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 returns \"totalResults\". (optional)  (default to 25)

            try
            { 
                // Get a list of users
                ScimUserListResponse result = apiInstance.GetScimUsers(filter, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filter** | **string**| Filters results. |  |
| **startIndex** | **int?**| The 1-based index of the first query result. | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimUserListResponse**](ScimUserListResponse.html)

<a name="getscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) GetScimV2Group (string groupId, string ifNoneMatch = null)



Get a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimV2GroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/v2/groups.
            var ifNoneMatch = ifNoneMatch_example;  // string | TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional) 

            try
            { 
                // Get a group
                ScimV2Group result = apiInstance.GetScimV2Group(groupId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Group: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/v2/groups. |  |
| **ifNoneMatch** | **string**| TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="getscimv2groups"></a>

## [**ScimGroupListResponse**](ScimGroupListResponse.html) GetScimV2Groups (string filter, int? startIndex = null, int? count = null)



Get a list of groups



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimV2GroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var filter = displayName eq groupName;  // string | Filters results.
            var startIndex = 56;  // int? | The 1-based index of the first query result. (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 returns \"totalResults\". (optional)  (default to 25)

            try
            { 
                // Get a list of groups
                ScimGroupListResponse result = apiInstance.GetScimV2Groups(filter, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Groups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filter** | **string**| Filters results. |  |
| **startIndex** | **int?**| The 1-based index of the first query result. | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimGroupListResponse**](ScimGroupListResponse.html)

<a name="getscimv2resourcetype"></a>

## [**ScimConfigResourceType**](ScimConfigResourceType.html) GetScimV2Resourcetype (string resourceType)



Get a resource type



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
    public class GetScimV2ResourcetypeExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();
            var resourceType = resourceType_example;  // string | The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.

            try
            { 
                // Get a resource type
                ScimConfigResourceType result = apiInstance.GetScimV2Resourcetype(resourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Resourcetype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **resourceType** | **string**| The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes. | <br />**Values**: User, Group, ServiceProviderConfig, ResourceType |
{: class="table table-striped"}

### Return type

[**ScimConfigResourceType**](ScimConfigResourceType.html)

<a name="getscimv2resourcetypes"></a>

## [**ScimConfigResourceTypesListResponse**](ScimConfigResourceTypesListResponse.html) GetScimV2Resourcetypes ()



Get a list of resource types



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
    public class GetScimV2ResourcetypesExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();

            try
            { 
                // Get a list of resource types
                ScimConfigResourceTypesListResponse result = apiInstance.GetScimV2Resourcetypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Resourcetypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ScimConfigResourceTypesListResponse**](ScimConfigResourceTypesListResponse.html)

<a name="getscimv2serviceproviderconfig"></a>

## [**ScimServiceProviderConfig**](ScimServiceProviderConfig.html) GetScimV2Serviceproviderconfig (string ifNoneMatch = null)



Get a service provider's configuration



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
    public class GetScimV2ServiceproviderconfigExample
    {
        public void main()
        { 

            var apiInstance = new SCIMApi();
            var ifNoneMatch = ifNoneMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional) 

            try
            { 
                // Get a service provider's configuration
                ScimServiceProviderConfig result = apiInstance.GetScimV2Serviceproviderconfig(ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Serviceproviderconfig: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ifNoneMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimServiceProviderConfig**](ScimServiceProviderConfig.html)

<a name="getscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) GetScimV2User (string userId, string ifNoneMatch = null)



Get a user



Requires ANY permissions: 

* directory:user:view
* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimV2UserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/v2/users.
            var ifNoneMatch = ifNoneMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional) 

            try
            { 
                // Get a user
                ScimV2User result = apiInstance.GetScimV2User(userId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2User: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/v2/users. |  |
| **ifNoneMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="getscimv2users"></a>

## [**ScimUserListResponse**](ScimUserListResponse.html) GetScimV2Users (string filter, int? startIndex = null, int? count = null)



Get a list of users



Requires ANY permissions: 

* directory:user:view
* directory:user:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScimV2UsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var filter = filter_example;  // string | Filters results.
            var startIndex = 56;  // int? | The 1-based index of the first query result. (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 returns \"totalResults\". (optional)  (default to 25)

            try
            { 
                // Get a list of users
                ScimUserListResponse result = apiInstance.GetScimV2Users(filter, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.GetScimV2Users: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filter** | **string**| Filters results. |  |
| **startIndex** | **int?**| The 1-based index of the first query result. | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimUserListResponse**](ScimUserListResponse.html)

<a name="patchscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) PatchScimGroup (string groupId, ScimV2PatchRequest body, string ifMatch = null)



Modify a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchScimGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/groups.
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | The information used to modify a group.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Modify a group
                ScimV2Group result = apiInstance.PatchScimGroup(groupId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PatchScimGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/groups. |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| The information used to modify a group. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="patchscimuser"></a>

## [**ScimV2User**](ScimV2User.html) PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null)



Modify a user



Requires ANY permissions: 

* directory:user:edit
* directory:user:setPassword

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchScimUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/users.
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | The information used to modify a user.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Modify a user
                ScimV2User result = apiInstance.PatchScimUser(userId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PatchScimUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/users. |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| The information used to modify a user. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="patchscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) PatchScimV2Group (string groupId, ScimV2PatchRequest body, string ifMatch = null)



Modify a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchScimV2GroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/v2/groups.
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | The information used to modify a group.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Modify a group
                ScimV2Group result = apiInstance.PatchScimV2Group(groupId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PatchScimV2Group: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/v2/groups. |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| The information used to modify a group. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="patchscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null)



Modify a user



Requires ANY permissions: 

* directory:user:edit
* directory:user:setPassword

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchScimV2UserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/v2/users.
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | The information used to modify a user.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Modify a user
                ScimV2User result = apiInstance.PatchScimV2User(userId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PatchScimV2User: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/v2/users. |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| The information used to modify a user. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="postscimusers"></a>

## [**ScimV2User**](ScimV2User.html) PostScimUsers (ScimV2CreateUser body)



Create a user



Requires ANY permissions: 

* directory:user:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostScimUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var body = new ScimV2CreateUser(); // ScimV2CreateUser | The information used to create a user.

            try
            { 
                // Create a user
                ScimV2User result = apiInstance.PostScimUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PostScimUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScimV2CreateUser**](ScimV2CreateUser.html)| The information used to create a user. |  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="postscimv2users"></a>

## [**ScimV2User**](ScimV2User.html) PostScimV2Users (ScimV2CreateUser body)



Create a user



Requires ANY permissions: 

* directory:user:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostScimV2UsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var body = new ScimV2CreateUser(); // ScimV2CreateUser | The information used to create a user.

            try
            { 
                // Create a user
                ScimV2User result = apiInstance.PostScimV2Users(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PostScimV2Users: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScimV2CreateUser**](ScimV2CreateUser.html)| The information used to create a user. |  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="putscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null)



Replace a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutScimGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/groups.
            var body = new ScimV2Group(); // ScimV2Group | The information used to replace a group.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Replace a group
                ScimV2Group result = apiInstance.PutScimGroup(groupId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PutScimGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/groups. |  |
| **body** | [**ScimV2Group**](ScimV2Group.html)| The information used to replace a group. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="putscimuser"></a>

## [**ScimV2User**](ScimV2User.html) PutScimUser (string userId, ScimV2User body, string ifMatch = null)



Replace a user



Requires ANY permissions: 

* directory:user:edit
* directory:user:setPassword

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutScimUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/users.
            var body = new ScimV2User(); // ScimV2User | The information used to replace a user.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Replace a user
                ScimV2User result = apiInstance.PutScimUser(userId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PutScimUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/users. |  |
| **body** | [**ScimV2User**](ScimV2User.html)| The information used to replace a user. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="putscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null)



Replace a group



Requires ANY permissions: 

* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutScimV2GroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var groupId = groupId_example;  // string | The ID of a group. Returned with GET /api/v2/scim/v2/groups.
            var body = new ScimV2Group(); // ScimV2Group | The information used to replace a group.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Replace a group
                ScimV2Group result = apiInstance.PutScimV2Group(groupId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PutScimV2Group: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| The ID of a group. Returned with GET /api/v2/scim/v2/groups. |  |
| **body** | [**ScimV2Group**](ScimV2Group.html)| The information used to replace a group. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="putscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) PutScimV2User (string userId, ScimV2User body, string ifMatch = null)



Replace a user



Requires ANY permissions: 

* directory:user:edit
* directory:user:setPassword

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutScimV2UserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SCIMApi();
            var userId = userId_example;  // string | The ID of a user. Returned with GET /api/v2/scim/v2/users.
            var body = new ScimV2User(); // ScimV2User | The information used to replace a user.
            var ifMatch = ifMatch_example;  // string | The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \"42\". If the ETag is different from the version on the server, returns 400 with a \"scimType\" of \"invalidVers\". (optional) 

            try
            { 
                // Replace a user
                ScimV2User result = apiInstance.PutScimV2User(userId, body, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SCIMApi.PutScimV2User: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. Returned with GET /api/v2/scim/v2/users. |  |
| **body** | [**ScimV2User**](ScimV2User.html)| The information used to replace a user. |  |
| **ifMatch** | **string**| The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

