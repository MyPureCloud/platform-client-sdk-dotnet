# DependenciesApi

## PureCloudPlatform.Client.V2.Api.DependenciesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby**](#GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby) | **Get** /api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredby | Get entities that require the given entity |
| [**GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts**](#GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts) | **Get** /api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requiredbycounts | An estimated count of entities that depend on this entity, including indirect dependencies. |
| [**GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires**](#GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires) | **Get** /api/v2/dependencies/type/{entityType}/id/{entityId}/connections/requires | Get entities that the given entity requires |



## GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby

> [**DependencyEntityListing**](DependencyEntityListing) GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)


Get entities that require the given entity

Requires ANY permissions: 

* dependencies:dependency:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DependenciesApi();
            var entityType = entityType_example;  // string | Entity type
            var entityId = entityId_example;  // string | Entity ID
            var pageSize = pageSize_example;  // string | Page size (max 100) (optional)  (default to "25")
            var beforeSourceType = beforeSourceType_example;  // string | Cursor for previous page (optional) 
            var beforeSourceId = beforeSourceId_example;  // string | Cursor for previous page (optional) 
            var afterSourceType = afterSourceType_example;  // string | Cursor for next page (optional) 
            var afterSourceId = afterSourceId_example;  // string | Cursor for next page (optional) 

            try
            { 
                // Get entities that require the given entity
                DependencyEntityListing result = apiInstance.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependenciesApi.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredby: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **entityType** | **string**| Entity type | <br />**Values**: Integration, DataAction, Credential |
| **entityId** | **string**| Entity ID |  |
| **pageSize** | **string**| Page size (max 100) | [optional] [default to "25"] |
| **beforeSourceType** | **string**| Cursor for previous page | [optional]  |
| **beforeSourceId** | **string**| Cursor for previous page | [optional]  |
| **afterSourceType** | **string**| Cursor for next page | [optional]  |
| **afterSourceId** | **string**| Cursor for next page | [optional]  |

### Return type

[**DependencyEntityListing**](DependencyEntityListing)


## GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts

> [**DependencyCount**](DependencyCount) GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts (string entityType, string entityId)


An estimated count of entities that depend on this entity, including indirect dependencies.

Requires ANY permissions: 

* dependencies:dependency:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycountsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DependenciesApi();
            var entityType = entityType_example;  // string | Entity type
            var entityId = entityId_example;  // string | Entity ID

            try
            { 
                // An estimated count of entities that depend on this entity, including indirect dependencies.
                DependencyCount result = apiInstance.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts(entityType, entityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependenciesApi.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiredbycounts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **entityType** | **string**| Entity type | <br />**Values**: Integration, DataAction, Credential |
| **entityId** | **string**| Entity ID |  |

### Return type

[**DependencyCount**](DependencyCount)


## GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires

> [**DependencyEntityListing**](DependencyEntityListing) GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires (string entityType, string entityId, string pageSize = null, string beforeSourceType = null, string beforeSourceId = null, string afterSourceType = null, string afterSourceId = null)


Get entities that the given entity requires

Requires ANY permissions: 

* dependencies:dependency:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequiresExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DependenciesApi();
            var entityType = entityType_example;  // string | Entity type
            var entityId = entityId_example;  // string | Entity ID
            var pageSize = pageSize_example;  // string | Page size (max 100) (optional)  (default to "25")
            var beforeSourceType = beforeSourceType_example;  // string | Cursor for previous page (optional) 
            var beforeSourceId = beforeSourceId_example;  // string | Cursor for previous page (optional) 
            var afterSourceType = afterSourceType_example;  // string | Cursor for next page (optional) 
            var afterSourceId = afterSourceId_example;  // string | Cursor for next page (optional) 

            try
            { 
                // Get entities that the given entity requires
                DependencyEntityListing result = apiInstance.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires(entityType, entityId, pageSize, beforeSourceType, beforeSourceId, afterSourceType, afterSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependenciesApi.GetDependenciesTypeEntityTypeIdEntityIdConnectionsRequires: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **entityType** | **string**| Entity type | <br />**Values**: Integration, DataAction, Credential |
| **entityId** | **string**| Entity ID |  |
| **pageSize** | **string**| Page size (max 100) | [optional] [default to "25"] |
| **beforeSourceType** | **string**| Cursor for previous page | [optional]  |
| **beforeSourceId** | **string**| Cursor for previous page | [optional]  |
| **afterSourceType** | **string**| Cursor for next page | [optional]  |
| **afterSourceId** | **string**| Cursor for next page | [optional]  |

### Return type

[**DependencyEntityListing**](DependencyEntityListing)


_PureCloudPlatform.Client.V2 270.0.0_
