---
title: GroupsApi
---
## PureCloudPlatform.Client.V2.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGroup**](GroupsApi.html#deletegroup) | **DELETE** /api/v2/groups/{groupId} | Delete group |
| [**DeleteGroupMembers**](GroupsApi.html#deletegroupmembers) | **DELETE** /api/v2/groups/{groupId}/members | Remove members |
| [**GetFieldconfig**](GroupsApi.html#getfieldconfig) | **GET** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetGroup**](GroupsApi.html#getgroup) | **GET** /api/v2/groups/{groupId} | Get group |
| [**GetGroupIndividuals**](GroupsApi.html#getgroupindividuals) | **GET** /api/v2/groups/{groupId}/individuals | Get all individuals associated with the group |
| [**GetGroupMembers**](GroupsApi.html#getgroupmembers) | **GET** /api/v2/groups/{groupId}/members | Get group members, includes individuals, owners, and dynamically included people |
| [**GetGroupProfile**](GroupsApi.html#getgroupprofile) | **GET** /api/v2/groups/{groupId}/profile | Get group profile |
| [**GetGroups**](GroupsApi.html#getgroups) | **GET** /api/v2/groups | Get a group list |
| [**GetGroupsSearch**](GroupsApi.html#getgroupssearch) | **GET** /api/v2/groups/search | Search groups using the q64 value returned from a previous search |
| [**GetProfilesGroups**](GroupsApi.html#getprofilesgroups) | **GET** /api/v2/profiles/groups | Get group profile listing |
| [**PostGroupMembers**](GroupsApi.html#postgroupmembers) | **POST** /api/v2/groups/{groupId}/members | Add members |
| [**PostGroups**](GroupsApi.html#postgroups) | **POST** /api/v2/groups | Create a group |
| [**PostGroupsSearch**](GroupsApi.html#postgroupssearch) | **POST** /api/v2/groups/search | Search groups |
| [**PutGroup**](GroupsApi.html#putgroup) | **PUT** /api/v2/groups/{groupId} | Update group |
{: class="table table-striped"}

<a name="deletegroup"></a>

## void DeleteGroup (string groupId)

Delete group



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletegroupmembers"></a>

## [**Empty**](Empty.html) DeleteGroupMembers (string groupId, string ids)

Remove members



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GroupsApi();
            
            
            var groupId = groupId_example;  // string | Group ID
            
            
            
            
            var ids = ids_example;  // string | Comma separated list of userIds to remove
            
            
            

            try
            {
                
                // Remove members
                
                Empty result = apiInstance.DeleteGroupMembers(groupId, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupMembers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **ids** | **string**| Comma separated list of userIds to remove |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

Fetch field config for an entity type



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type | <br />**Values**: person, group, org, externalContact |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getgroup"></a>

## [**Group**](Group.html) GetGroup (string groupId)

Get group



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="getgroupindividuals"></a>

## [**UserEntityListing**](UserEntityListing.html) GetGroupIndividuals (string groupId)

Get all individuals associated with the group



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroupmembers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetGroupMembers (string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)

Get group members, includes individuals, owners, and dynamically included people



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: routingStatus, presence, conversationSummary, outOfOffice, geolocation, station, authorization, profileSkills, locations, groups |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroupprofile"></a>

## [**GroupProfile**](GroupProfile.html) GetGroupProfile (string groupId, string fields = null)

Get group profile



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| groupId |  |
| **fields** | **string**| Comma separated fields to return.  Allowable values can be found by querying /api/v2/fieldconfig?type=group and using the key for the elements returned by the fieldList | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupProfile**](GroupProfile.html)

<a name="getgroups"></a>

## [**GroupEntityListing**](GroupEntityListing.html) GetGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)

Get a group list



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GroupsApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            
            var id = new List<string>(); // List<string> | id (optional) 
            
            
            
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            
            
            

            try
            {
                
                // Get a group list
                
                GroupEntityListing result = apiInstance.GetGroups(pageSize, pageNumber, id, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**GroupEntityListing**](GroupEntityListing.html)

<a name="getgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetGroupsSearch (string q64, List<string> expand = null)

Search groups using the q64 value returned from a previous search



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="getprofilesgroups"></a>

## [**GroupProfileEntityListing**](GroupProfileEntityListing.html) GetProfilesGroups (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)

Get group profile listing



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GroupsApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            
            var id = new List<string>(); // List<string> | id (optional) 
            
            
            
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            
            
            

            try
            {
                
                // Get group profile listing
                
                GroupProfileEntityListing result = apiInstance.GetProfilesGroups(pageSize, pageNumber, id, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetProfilesGroups: " + e.Message );
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**GroupProfileEntityListing**](GroupProfileEntityListing.html)

<a name="postgroupmembers"></a>

## [**Empty**](Empty.html) PostGroupMembers (string groupId, GroupMembersUpdate body)

Add members



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GroupsApi();
            
            
            var groupId = groupId_example;  // string | Group ID
            
            
            
            
            
            var body = new GroupMembersUpdate(); // GroupMembersUpdate | Add members
            
            

            try
            {
                
                // Add members
                
                Empty result = apiInstance.PostGroupMembers(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupMembers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupMembersUpdate**](GroupMembersUpdate.html)| Add members |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="postgroups"></a>

## [**Group**](Group.html) PostGroups (GroupCreate body)

Create a group



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupCreate**](GroupCreate.html)| Group |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="postgroupssearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostGroupsSearch (GroupSearchRequest body)

Search groups



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupSearchRequest**](GroupSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="putgroup"></a>

## [**Group**](Group.html) PutGroup (string groupId, GroupUpdate body = null)

Update group



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupUpdate**](GroupUpdate.html)| Group | [optional]  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

