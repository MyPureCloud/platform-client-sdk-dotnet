---
title: SCIMApi
---
## PureCloudPlatform.Client.V2.Api.SCIMApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteScimUser**](SCIMApi.html#deletescimuser) | **DELETE** /api/v2/scim/users/{userId} | Soft delete user with specified ID |
| [**DeleteScimV2User**](SCIMApi.html#deletescimv2user) | **DELETE** /api/v2/scim/v2/users/{userId} | Soft delete user with specified ID |
| [**GetScimGroup**](SCIMApi.html#getscimgroup) | **GET** /api/v2/scim/groups/{groupId} | Return Group with specified ID |
| [**GetScimGroups**](SCIMApi.html#getscimgroups) | **GET** /api/v2/scim/groups | Query Groups |
| [**GetScimUser**](SCIMApi.html#getscimuser) | **GET** /api/v2/scim/users/{userId} | Return user with specified ID (default version) |
| [**GetScimUsers**](SCIMApi.html#getscimusers) | **GET** /api/v2/scim/users | Query Users |
| [**GetScimV2Group**](SCIMApi.html#getscimv2group) | **GET** /api/v2/scim/v2/groups/{groupId} | Return Group with specified ID |
| [**GetScimV2Groups**](SCIMApi.html#getscimv2groups) | **GET** /api/v2/scim/v2/groups | Query Groups |
| [**GetScimV2Serviceproviderconfig**](SCIMApi.html#getscimv2serviceproviderconfig) | **GET** /api/v2/scim/v2/serviceproviderconfig | Get SCIM Configuration |
| [**GetScimV2User**](SCIMApi.html#getscimv2user) | **GET** /api/v2/scim/v2/users/{userId} | Return User with specified ID |
| [**GetScimV2Users**](SCIMApi.html#getscimv2users) | **GET** /api/v2/scim/v2/users | Query Users |
| [**PatchScimGroup**](SCIMApi.html#patchscimgroup) | **PATCH** /api/v2/scim/groups/{groupId} | Update Group with specified ID |
| [**PatchScimUser**](SCIMApi.html#patchscimuser) | **PATCH** /api/v2/scim/users/{userId} | Patch user with specified ID |
| [**PatchScimV2Group**](SCIMApi.html#patchscimv2group) | **PATCH** /api/v2/scim/v2/groups/{groupId} | Update Group with specified ID |
| [**PatchScimV2User**](SCIMApi.html#patchscimv2user) | **PATCH** /api/v2/scim/v2/users/{userId} | Update user with specified ID |
| [**PostScimUsers**](SCIMApi.html#postscimusers) | **POST** /api/v2/scim/users | Create user |
| [**PostScimV2Users**](SCIMApi.html#postscimv2users) | **POST** /api/v2/scim/v2/users | Create user |
| [**PutScimGroup**](SCIMApi.html#putscimgroup) | **PUT** /api/v2/scim/groups/{groupId} | Update Group with specified ID |
| [**PutScimUser**](SCIMApi.html#putscimuser) | **PUT** /api/v2/scim/users/{userId} | Update user with specified ID |
| [**PutScimV2Group**](SCIMApi.html#putscimv2group) | **PUT** /api/v2/scim/v2/groups/{groupId} | Update Group with specified ID |
| [**PutScimV2User**](SCIMApi.html#putscimv2user) | **PUT** /api/v2/scim/v2/users/{userId} | Update user with specified ID |
{: class="table table-striped"}

<a name="deletescimuser"></a>

## [**Empty**](Empty.html) DeleteScimUser (string userId, string ifMatch = null)



Soft delete user with specified ID



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
            var userId = userId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Soft delete user with specified ID
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
| **userId** | **string**|  |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="deletescimv2user"></a>

## [**Empty**](Empty.html) DeleteScimV2User (string userId, string ifMatch = null)



Soft delete user with specified ID



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
            var userId = userId_example;  // string | 
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Soft delete user with specified ID
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
| **userId** | **string**|  |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="getscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) GetScimGroup (string groupId, string ifNoneMatch = null)



Return Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var ifNoneMatch = ifNoneMatch_example;  // string | If-None-Match for ETag version checking (optional) 

            try
            { 
                // Return Group with specified ID
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
| **groupId** | **string**|  |  |
| **ifNoneMatch** | **string**| If-None-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="getscimgroups"></a>

## [**ScimListResponse**](ScimListResponse.html) GetScimGroups (int? startIndex = null, int? count = null, string filter = null)



Query Groups



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
            var startIndex = 56;  // int? | Starting item of request. 1-based (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 will return no results other than the totalResults count. (optional)  (default to 25)
            var filter = displayName eq groupName;  // string | filter parameter e.g. displayName eq groupName (optional) 

            try
            { 
                // Query Groups
                ScimListResponse result = apiInstance.GetScimGroups(startIndex, count, filter);
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
| **startIndex** | **int?**| Starting item of request. 1-based | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 will return no results other than the totalResults count. | [optional] [default to 25] |
| **filter** | **string**| filter parameter e.g. displayName eq groupName | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimListResponse**](ScimListResponse.html)

<a name="getscimuser"></a>

## [**ScimV2User**](ScimV2User.html) GetScimUser (string userId, string ifNoneMatch = null)



Return user with specified ID (default version)



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
            var userId = userId_example;  // string | 
            var ifNoneMatch = ifNoneMatch_example;  // string | If-None-Match for ETag version checking (optional) 

            try
            { 
                // Return user with specified ID (default version)
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
| **userId** | **string**|  |  |
| **ifNoneMatch** | **string**| If-None-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="getscimusers"></a>

## [**ScimListResponse**](ScimListResponse.html) GetScimUsers (string filter, int? startIndex = null, int? count = null)



Query Users



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
            var filter = filter_example;  // string | filter parameter e.g. userName eq search@sample.org
            var startIndex = 56;  // int? | Starting item of request. 1-based (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 will return no results other than the totalResults count. (optional)  (default to 25)

            try
            { 
                // Query Users
                ScimListResponse result = apiInstance.GetScimUsers(filter, startIndex, count);
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
| **filter** | **string**| filter parameter e.g. userName eq search@sample.org |  |
| **startIndex** | **int?**| Starting item of request. 1-based | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 will return no results other than the totalResults count. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimListResponse**](ScimListResponse.html)

<a name="getscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) GetScimV2Group (string groupId, string ifNoneMatch = null)



Return Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var ifNoneMatch = ifNoneMatch_example;  // string | If-None-Match for ETag version checking (optional) 

            try
            { 
                // Return Group with specified ID
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
| **groupId** | **string**|  |  |
| **ifNoneMatch** | **string**| If-None-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="getscimv2groups"></a>

## [**ScimListResponse**](ScimListResponse.html) GetScimV2Groups (string filter, int? startIndex = null, int? count = null)



Query Groups



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
            var filter = displayName eq groupName;  // string | filter parameter e.g. displayName eq groupName
            var startIndex = 56;  // int? | Starting item of request. 1-based (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 will return no results other than the totalResults count. (optional)  (default to 25)

            try
            { 
                // Query Groups
                ScimListResponse result = apiInstance.GetScimV2Groups(filter, startIndex, count);
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
| **filter** | **string**| filter parameter e.g. displayName eq groupName |  |
| **startIndex** | **int?**| Starting item of request. 1-based | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 will return no results other than the totalResults count. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimListResponse**](ScimListResponse.html)

<a name="getscimv2serviceproviderconfig"></a>

## [**ScimServiceProviderConfig**](ScimServiceProviderConfig.html) GetScimV2Serviceproviderconfig (string ifNoneMatch = null)



Get SCIM Configuration



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
            var ifNoneMatch = ifNoneMatch_example;  // string | If-None-Match for ETag version checking (optional) 

            try
            { 
                // Get SCIM Configuration
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
| **ifNoneMatch** | **string**| If-None-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimServiceProviderConfig**](ScimServiceProviderConfig.html)

<a name="getscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) GetScimV2User (string userId, string ifNoneMatch = null)



Return User with specified ID



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
            var userId = userId_example;  // string | 
            var ifNoneMatch = ifNoneMatch_example;  // string | If-None-Match for ETag version checking (optional) 

            try
            { 
                // Return User with specified ID
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
| **userId** | **string**|  |  |
| **ifNoneMatch** | **string**| If-None-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="getscimv2users"></a>

## [**ScimListResponse**](ScimListResponse.html) GetScimV2Users (string filter, int? startIndex = null, int? count = null)



Query Users



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
            var filter = filter_example;  // string | filter parameter e.g. userName eq search@sample.org
            var startIndex = 56;  // int? | Starting item of request. 1-based (optional)  (default to 1)
            var count = 56;  // int? | The requested number of items per page. A value of 0 will return no results other than the totalResults count. (optional)  (default to 25)

            try
            { 
                // Query Users
                ScimListResponse result = apiInstance.GetScimV2Users(filter, startIndex, count);
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
| **filter** | **string**| filter parameter e.g. userName eq search@sample.org |  |
| **startIndex** | **int?**| Starting item of request. 1-based | [optional] [default to 1] |
| **count** | **int?**| The requested number of items per page. A value of 0 will return no results other than the totalResults count. | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ScimListResponse**](ScimListResponse.html)

<a name="patchscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) PatchScimGroup (string groupId, PatchRequest body, string ifMatch = null)



Update Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var body = new PatchRequest(); // PatchRequest | Group
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update Group with specified ID
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
| **groupId** | **string**|  |  |
| **body** | [**PatchRequest**](PatchRequest.html)| Group |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="patchscimuser"></a>

## [**ScimV2User**](ScimV2User.html) PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null)



Patch user with specified ID



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
            var userId = userId_example;  // string | 
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | SCIM Patch Request
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Patch user with specified ID
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
| **userId** | **string**|  |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| SCIM Patch Request |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="patchscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) PatchScimV2Group (string groupId, PatchRequest body, string ifMatch = null)



Update Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var body = new PatchRequest(); // PatchRequest | Group
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update Group with specified ID
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
| **groupId** | **string**|  |  |
| **body** | [**PatchRequest**](PatchRequest.html)| Group |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="patchscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null)



Update user with specified ID



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
            var userId = userId_example;  // string | User Id
            var body = new ScimV2PatchRequest(); // ScimV2PatchRequest | SCIM Patch Request
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update user with specified ID
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
| **userId** | **string**| User Id |  |
| **body** | [**ScimV2PatchRequest**](ScimV2PatchRequest.html)| SCIM Patch Request |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="postscimusers"></a>

## [**ScimV2User**](ScimV2User.html) PostScimUsers (ScimV2CreateUser body)



Create user



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
            var body = new ScimV2CreateUser(); // ScimV2CreateUser | SCIM Create User

            try
            { 
                // Create user
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
| **body** | [**ScimV2CreateUser**](ScimV2CreateUser.html)| SCIM Create User |  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="postscimv2users"></a>

## [**ScimV2User**](ScimV2User.html) PostScimV2Users (ScimV2CreateUser body)



Create user



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
            var body = new ScimV2CreateUser(); // ScimV2CreateUser | SCIM Create User

            try
            { 
                // Create user
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
| **body** | [**ScimV2CreateUser**](ScimV2CreateUser.html)| SCIM Create User |  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="putscimgroup"></a>

## [**ScimV2Group**](ScimV2Group.html) PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null)



Update Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var body = new ScimV2Group(); // ScimV2Group | Group
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update Group with specified ID
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
| **groupId** | **string**|  |  |
| **body** | [**ScimV2Group**](ScimV2Group.html)| Group |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="putscimuser"></a>

## [**ScimV2User**](ScimV2User.html) PutScimUser (string userId, ScimV2User body, string ifMatch = null)



Update user with specified ID



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
            var userId = userId_example;  // string | 
            var body = new ScimV2User(); // ScimV2User | User
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update user with specified ID
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
| **userId** | **string**|  |  |
| **body** | [**ScimV2User**](ScimV2User.html)| User |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

<a name="putscimv2group"></a>

## [**ScimV2Group**](ScimV2Group.html) PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null)



Update Group with specified ID



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
            var groupId = groupId_example;  // string | 
            var body = new ScimV2Group(); // ScimV2Group | Group
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update Group with specified ID
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
| **groupId** | **string**|  |  |
| **body** | [**ScimV2Group**](ScimV2Group.html)| Group |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2Group**](ScimV2Group.html)

<a name="putscimv2user"></a>

## [**ScimV2User**](ScimV2User.html) PutScimV2User (string userId, ScimV2User body, string ifMatch = null)



Update user with specified ID



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
            var userId = userId_example;  // string | User Id
            var body = new ScimV2User(); // ScimV2User | User
            var ifMatch = ifMatch_example;  // string | If-Match for ETag version checking (optional) 

            try
            { 
                // Update user with specified ID
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
| **userId** | **string**| User Id |  |
| **body** | [**ScimV2User**](ScimV2User.html)| User |  |
| **ifMatch** | **string**| If-Match for ETag version checking | [optional]  |
{: class="table table-striped"}

### Return type

[**ScimV2User**](ScimV2User.html)

