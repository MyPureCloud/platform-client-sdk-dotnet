# GroupsApi

## PureCloudPlatform.Client.V2.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGroup**](#DeleteGroup) | **Delete** /api/v2/groups/{groupId} | Delete group |
| [**DeleteGroupDynamicsettings**](#DeleteGroupDynamicsettings) | **Delete** /api/v2/groups/{groupId}/dynamicsettings | Remove dynamic group definition |
| [**DeleteGroupMembers**](#DeleteGroupMembers) | **Delete** /api/v2/groups/{groupId}/members | Remove members |
| [**GetFieldconfig**](#GetFieldconfig) | **Get** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetGroup**](#GetGroup) | **Get** /api/v2/groups/{groupId} | Get group |
| [**GetGroupDynamicsettings**](#GetGroupDynamicsettings) | **Get** /api/v2/groups/{groupId}/dynamicsettings | Get dynamic group definition |
| [**GetGroupIndividuals**](#GetGroupIndividuals) | **Get** /api/v2/groups/{groupId}/individuals | Get all individuals associated with the group |
| [**GetGroupMembers**](#GetGroupMembers) | **Get** /api/v2/groups/{groupId}/members | Get group members, includes individuals, owners, and dynamically included people |
| [**GetGroupProfile**](#GetGroupProfile) | **Get** /api/v2/groups/{groupId}/profile | Get group profile |
| [**GetGroups**](#GetGroups) | **Get** /api/v2/groups | Get a group list |
| [**GetGroupsSearch**](#GetGroupsSearch) | **Get** /api/v2/groups/search | Search groups using the q64 value returned from a previous search |
| [**GetProfilesGroups**](#GetProfilesGroups) | **Get** /api/v2/profiles/groups | Get group profile listing |
| [**PostGroupMembers**](#PostGroupMembers) | **Post** /api/v2/groups/{groupId}/members | Add members |
| [**PostGroups**](#PostGroups) | **Post** /api/v2/groups | Create a group |
| [**PostGroupsDynamicsettingsPreview**](#PostGroupsDynamicsettingsPreview) | **Post** /api/v2/groups/dynamicsettings/preview | Preview the number of users selected for a dynamic group definition query |
| [**PostGroupsSearch**](#PostGroupsSearch) | **Post** /api/v2/groups/search | Search groups |
| [**PutGroup**](#PutGroup) | **Put** /api/v2/groups/{groupId} | Update group |
| [**PutGroupDynamicsettings**](#PutGroupDynamicsettings) | **Put** /api/v2/groups/{groupId}/dynamicsettings | Create / Update dynamic group definition |



## DeleteGroup

> void DeleteGroup (string groupId)


Delete group

Requires ANY permissions: 

* directory:group:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Delete group
                apiInstance.DeleteGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

void (empty response body)


## DeleteGroupDynamicsettings

> void DeleteGroupDynamicsettings (string groupId)


Remove dynamic group definition

DeleteGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Remove dynamic group definition
                apiInstance.DeleteGroupDynamicsettings(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

void (empty response body)


## DeleteGroupMembers

> **Object** DeleteGroupMembers (string groupId, string ids)


Remove members

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
    public class DeleteGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var ids = ids_example;  // string | Comma separated list of userIds to remove. A maximum of 50 members are allowed per request.

            try
            { 
                // Remove members
                Object result = apiInstance.DeleteGroupMembers(groupId, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **ids** | **string**| Comma separated list of userIds to remove. A maximum of 50 members are allowed per request. |  |

### Return type

**Object**


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

            var apiInstance = new GroupsApi();
            var type = type_example;  // string | Field type

            try
            { 
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetFieldconfig: " + e.Message );
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


## GetGroup

> [**Group**](Group) GetGroup (string groupId)


Get group

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
    public class GetGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get group
                Group result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

[**Group**](Group)


## GetGroupDynamicsettings

> [**DynamicGroupDefinition**](DynamicGroupDefinition) GetGroupDynamicsettings (string groupId)


Get dynamic group definition

GetGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get dynamic group definition
                DynamicGroupDefinition result = apiInstance.GetGroupDynamicsettings(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

[**DynamicGroupDefinition**](DynamicGroupDefinition)


## GetGroupIndividuals

> [**UserEntityListing**](UserEntityListing) GetGroupIndividuals (string groupId)


Get all individuals associated with the group

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
    public class GetGroupIndividualsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get all individuals associated with the group
                UserEntityListing result = apiInstance.GetGroupIndividuals(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupIndividuals: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

[**UserEntityListing**](UserEntityListing)


## GetGroupMembers

> [**UserEntityListing**](UserEntityListing) GetGroupMembers (string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)


Get group members, includes individuals, owners, and dynamically included people

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
    public class GetGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get group members, includes individuals, owners, and dynamically included people
                UserEntityListing result = apiInstance.GetGroupMembers(groupId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, externalContactsSettings, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin |

### Return type

[**UserEntityListing**](UserEntityListing)


## GetGroupProfile

> [**GroupProfile**](GroupProfile) GetGroupProfile (string groupId, string fields = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get group profile

This api is deprecated. Use /api/v2/groups instead

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
    public class GetGroupProfileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | groupId
            var fields = fields_example;  // string | Comma separated fields to return.  Allowable values can be found by querying /api/v2/fieldconfig?type=group and using the key for the elements returned by the fieldList (optional) 

            try
            { 
                // Get group profile
                GroupProfile result = apiInstance.GetGroupProfile(groupId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| groupId |  |
| **fields** | **string**| Comma separated fields to return.  Allowable values can be found by querying /api/v2/fieldconfig?type&#x3D;group and using the key for the elements returned by the fieldList | [optional]  |

### Return type

[**GroupProfile**](GroupProfile)


## GetGroups

> [**GroupEntityListing**](GroupEntityListing) GetGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null)


Get a group list

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
    public class GetGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // Get a group list
                GroupEntityListing result = apiInstance.GetGroups(pageSize, pageNumber, id, jabberId, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
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
| **id** | [**List<string>**](string)| id | [optional]  |
| **jabberId** | [**List<string>**](string)| A list of jabberIds to fetch by bulk (cannot be used with the \&quot;id\&quot; parameter) | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |

### Return type

[**GroupEntityListing**](GroupEntityListing)


## GetGroupsSearch

> [**GroupsSearchResponse**](GroupsSearchResponse) GetGroupsSearch (string q64, List<string> expand = null)


Search groups using the q64 value returned from a previous search

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
    public class GetGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search groups using the q64 value returned from a previous search
                GroupsSearchResponse result = apiInstance.GetGroupsSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse)


## GetProfilesGroups

> [**GroupProfileEntityListing**](GroupProfileEntityListing) GetProfilesGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, List<string> jabberId = null, string sortOrder = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get group profile listing

This api is deprecated. Use /api/v2/groups instead.

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
    public class GetProfilesGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var jabberId = new List<string>(); // List<string> | A list of jabberIds to fetch by bulk (cannot be used with the \"id\" parameter) (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // Get group profile listing
                GroupProfileEntityListing result = apiInstance.GetProfilesGroups(pageSize, pageNumber, id, jabberId, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetProfilesGroups: " + e.Message );
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
| **id** | [**List<string>**](string)| id | [optional]  |
| **jabberId** | [**List<string>**](string)| A list of jabberIds to fetch by bulk (cannot be used with the \&quot;id\&quot; parameter) | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |

### Return type

[**GroupProfileEntityListing**](GroupProfileEntityListing)


## PostGroupMembers

> **Object** PostGroupMembers (string groupId, GroupMembersUpdate body)


Add members

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
    public class PostGroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupMembersUpdate(); // GroupMembersUpdate | Add members

            try
            { 
                // Add members
                Object result = apiInstance.PostGroupMembers(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupMembersUpdate**](GroupMembersUpdate)| Add members |  |

### Return type

**Object**


## PostGroups

> [**Group**](Group) PostGroups (GroupCreate body)


Create a group

Requires ANY permissions: 

* directory:group:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new GroupCreate(); // GroupCreate | Group

            try
            { 
                // Create a group
                Group result = apiInstance.PostGroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupCreate**](GroupCreate)| Group |  |

### Return type

[**Group**](Group)


## PostGroupsDynamicsettingsPreview

> [**DynamicGroupQueryPreview**](DynamicGroupQueryPreview) PostGroupsDynamicsettingsPreview (DynamicGroupQuery body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Preview the number of users selected for a dynamic group definition query

PostGroupsDynamicsettingsPreview is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* directory:group:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGroupsDynamicsettingsPreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new DynamicGroupQuery(); // DynamicGroupQuery | Group query to preview

            try
            { 
                // Preview the number of users selected for a dynamic group definition query
                DynamicGroupQueryPreview result = apiInstance.PostGroupsDynamicsettingsPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupsDynamicsettingsPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DynamicGroupQuery**](DynamicGroupQuery)| Group query to preview |  |

### Return type

[**DynamicGroupQueryPreview**](DynamicGroupQueryPreview)


## PostGroupsSearch

> [**GroupsSearchResponse**](GroupsSearchResponse) PostGroupsSearch (GroupSearchRequest body)


Search groups

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
    public class PostGroupsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            { 
                // Search groups
                GroupsSearchResponse result = apiInstance.PostGroupsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupSearchRequest**](GroupSearchRequest)| Search request options |  |

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse)


## PutGroup

> [**Group**](Group) PutGroup (string groupId, GroupUpdate body = null)


Update group

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
    public class PutGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupUpdate(); // GroupUpdate | Group (optional) 

            try
            { 
                // Update group
                Group result = apiInstance.PutGroup(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupUpdate**](GroupUpdate)| Group | [optional]  |

### Return type

[**Group**](Group)


## PutGroupDynamicsettings

> void PutGroupDynamicsettings (string groupId, DynamicGroupQuery body)


Create / Update dynamic group definition

PutGroupDynamicsettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PutGroupDynamicsettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new DynamicGroupQuery(); // DynamicGroupQuery | Create/Update dynamic groups

            try
            { 
                // Create / Update dynamic group definition
                apiInstance.PutGroupDynamicsettings(groupId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupDynamicsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**DynamicGroupQuery**](DynamicGroupQuery)| Create/Update dynamic groups |  |

### Return type

void (empty response body)


_PureCloudPlatform.Client.V2 228.0.0_
