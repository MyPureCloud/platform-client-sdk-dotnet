# PresenceApi

## PureCloudPlatform.Client.V2.Api.PresenceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeletePresenceDefinition0**](#DeletePresenceDefinition0) | **Delete** /api/v2/presence/definitions/{definitionId} | Delete a Presence Definition |
| [**DeletePresenceSource**](#DeletePresenceSource) | **Delete** /api/v2/presence/sources/{sourceId} | Delete a Presence Source |
| [**DeletePresencedefinition**](#DeletePresencedefinition) | **Delete** /api/v2/presencedefinitions/{presenceId} | Delete a Presence Definition. Apps should migrate to use DELETE /api/v2/presence/definitions/{definitionId} instead |
| [**GetPresenceDefinition0**](#GetPresenceDefinition0) | **Get** /api/v2/presence/definitions/{definitionId} | Get a Presence Definition |
| [**GetPresenceDefinitions0**](#GetPresenceDefinitions0) | **Get** /api/v2/presence/definitions | Get a list of Presence Definitions |
| [**GetPresenceSettings**](#GetPresenceSettings) | **Get** /api/v2/presence/settings | Get the presence settings |
| [**GetPresenceSource**](#GetPresenceSource) | **Get** /api/v2/presence/sources/{sourceId} | Get a Presence Source |
| [**GetPresenceSources**](#GetPresenceSources) | **Get** /api/v2/presence/sources | Get a list of Presence Sources |
| [**GetPresenceUserPrimarysource**](#GetPresenceUserPrimarysource) | **Get** /api/v2/presence/users/{userId}/primarysource | Get a user&#39;s Primary Presence Source |
| [**GetPresencedefinition**](#GetPresencedefinition) | **Get** /api/v2/presencedefinitions/{presenceId} | Get a Presence Definition. Apps should migrate to use GET /api/v2/presence/definitions/{definitionId} instead |
| [**GetPresencedefinitions**](#GetPresencedefinitions) | **Get** /api/v2/presencedefinitions | Get an Organization&#39;s list of Presence Definitions. Apps should migrate to use GET /api/v2/presence/definitions instead |
| [**GetSystempresences**](#GetSystempresences) | **Get** /api/v2/systempresences | Get the list of SystemPresences |
| [**GetUserPresence**](#GetUserPresence) | **Get** /api/v2/users/{userId}/presences/{sourceId} | Get a user&#39;s Presence |
| [**GetUserPresencesPurecloud**](#GetUserPresencesPurecloud) | **Get** /api/v2/users/{userId}/presences/purecloud | Get a user&#39;s Genesys Cloud presence. |
| [**GetUsersPresenceBulk**](#GetUsersPresenceBulk) | **Get** /api/v2/users/presences/{sourceId}/bulk | Get bulk user presences for a single presence source |
| [**GetUsersPresencesPurecloudBulk**](#GetUsersPresencesPurecloudBulk) | **Get** /api/v2/users/presences/purecloud/bulk | Get bulk user presences for a Genesys Cloud (PURECLOUD) presence source |
| [**PatchUserPresence**](#PatchUserPresence) | **Patch** /api/v2/users/{userId}/presences/{sourceId} | Patch a user&#39;s Presence |
| [**PatchUserPresencesPurecloud**](#PatchUserPresencesPurecloud) | **Patch** /api/v2/users/{userId}/presences/purecloud | Patch a Genesys Cloud user&#39;s presence |
| [**PostPresenceDefinitions0**](#PostPresenceDefinitions0) | **Post** /api/v2/presence/definitions | Create a Presence Definition |
| [**PostPresenceSources**](#PostPresenceSources) | **Post** /api/v2/presence/sources | Create a Presence Source |
| [**PostPresencedefinitions**](#PostPresencedefinitions) | **Post** /api/v2/presencedefinitions | Create a Presence Definition. Apps should migrate to use POST /api/v2/presence/definitions instead |
| [**PutPresenceDefinition0**](#PutPresenceDefinition0) | **Put** /api/v2/presence/definitions/{definitionId} | Update a Presence Definition |
| [**PutPresenceSettings**](#PutPresenceSettings) | **Put** /api/v2/presence/settings | Update the presence settings |
| [**PutPresenceSource**](#PutPresenceSource) | **Put** /api/v2/presence/sources/{sourceId} | Update a Presence Source |
| [**PutPresenceUserPrimarysource**](#PutPresenceUserPrimarysource) | **Put** /api/v2/presence/users/{userId}/primarysource | Update a user&#39;s Primary Presence Source |
| [**PutPresencedefinition**](#PutPresencedefinition) | **Put** /api/v2/presencedefinitions/{presenceId} | Update a Presence Definition. Apps should migrate to use PUT /api/v2/presence/definitions/{definitionId} instead) |
| [**PutUsersPresencesBulk**](#PutUsersPresencesBulk) | **Put** /api/v2/users/presences/bulk | Update bulk user Presences |



## DeletePresenceDefinition0

> void DeletePresenceDefinition0 (string definitionId)


Delete a Presence Definition

Requires ANY permissions: 

* presence:presenceDefinition:delete
* presence:presenceDefinition:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeletePresenceDefinition0Example
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var definitionId = definitionId_example;  // string | Presence Definition ID

            try
            { 
                // Delete a Presence Definition
                apiInstance.DeletePresenceDefinition0(definitionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.DeletePresenceDefinition0: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **definitionId** | **string**| Presence Definition ID |  |

### Return type

void (empty response body)


## DeletePresenceSource

> void DeletePresenceSource (string sourceId)


Delete a Presence Source

Requires ANY permissions: 

* presence:source:delete
* presence:source:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeletePresenceSourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var sourceId = sourceId_example;  // string | Presence Source ID

            try
            { 
                // Delete a Presence Source
                apiInstance.DeletePresenceSource(sourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.DeletePresenceSource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sourceId** | **string**| Presence Source ID |  |

### Return type

void (empty response body)


## DeletePresencedefinition

> void DeletePresencedefinition (string presenceId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Delete a Presence Definition. Apps should migrate to use DELETE /api/v2/presence/definitions/{definitionId} instead

Requires ALL permissions: 

* presence:presenceDefinition:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID

            try
            { 
                // Delete a Presence Definition. Apps should migrate to use DELETE /api/v2/presence/definitions/{definitionId} instead
                apiInstance.DeletePresencedefinition(presenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.DeletePresencedefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |

### Return type

void (empty response body)


## GetPresenceDefinition0

> [**OrganizationPresenceDefinition**](OrganizationPresenceDefinition) GetPresenceDefinition0 (string definitionId, string localeCode = null)


Get a Presence Definition

Requires ALL permissions: 

* presence:presenceDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceDefinition0Example
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var definitionId = definitionId_example;  // string | Presence Definition ID
            var localeCode = localeCode_example;  // string | The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional) 

            try
            { 
                // Get a Presence Definition
                OrganizationPresenceDefinition result = apiInstance.GetPresenceDefinition0(definitionId, localeCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceDefinition0: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **definitionId** | **string**| Presence Definition ID |  |
| **localeCode** | **string**| The locale code to fetch for the presence definition. Use ALL to fetch everything. | [optional] <br />**Values**: ALL, he, fr, en_US, da, de, it, cs, es, fi, ar, ja, ko, nl, no, pl, pt_BR, pt_PT, ru, sv, th, tr, uk, zh_CN, zh_TW |

### Return type

[**OrganizationPresenceDefinition**](OrganizationPresenceDefinition)


## GetPresenceDefinitions0

> [**OrganizationPresenceDefinitionEntityListing**](OrganizationPresenceDefinitionEntityListing) GetPresenceDefinitions0 (string deactivated = null, List<string> divisionId = null, string localeCode = null)


Get a list of Presence Definitions

Requires ALL permissions: 

* presence:presenceDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceDefinitions0Example
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var deactivated = deactivated_example;  // string | Deactivated query can be TRUE or FALSE (optional)  (default to "false")
            var divisionId = new List<string>(); // List<string> | One or more division IDs. If nothing is provided, the definitions associated withthe list of divisions that the user has access to will be returned. (optional) 
            var localeCode = localeCode_example;  // string | The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional) 

            try
            { 
                // Get a list of Presence Definitions
                OrganizationPresenceDefinitionEntityListing result = apiInstance.GetPresenceDefinitions0(deactivated, divisionId, localeCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceDefinitions0: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deactivated** | **string**| Deactivated query can be TRUE or FALSE | [optional] [default to "false"] |
| **divisionId** | [**List<string>**](string)| One or more division IDs. If nothing is provided, the definitions associated withthe list of divisions that the user has access to will be returned. | [optional]  |
| **localeCode** | **string**| The locale code to fetch for the presence definition. Use ALL to fetch everything. | [optional] <br />**Values**: ALL, he, fr, en_US, da, de, it, cs, es, fi, ar, ja, ko, nl, no, pl, pt_BR, pt_PT, ru, sv, th, tr, uk, zh_CN, zh_TW |

### Return type

[**OrganizationPresenceDefinitionEntityListing**](OrganizationPresenceDefinitionEntityListing)


## GetPresenceSettings

> [**PresenceSettings**](PresenceSettings) GetPresenceSettings ()


Get the presence settings

Requires ALL permissions: 

* presence:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();

            try
            { 
                // Get the presence settings
                PresenceSettings result = apiInstance.GetPresenceSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**PresenceSettings**](PresenceSettings)


## GetPresenceSource

> [**Source**](Source) GetPresenceSource (string sourceId)


Get a Presence Source

Requires ALL permissions: 

* presence:source:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceSourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var sourceId = sourceId_example;  // string | Presence Source ID

            try
            { 
                // Get a Presence Source
                Source result = apiInstance.GetPresenceSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceSource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sourceId** | **string**| Presence Source ID |  |

### Return type

[**Source**](Source)


## GetPresenceSources

> [**SourceEntityListing**](SourceEntityListing) GetPresenceSources (string deactivated = null)


Get a list of Presence Sources

Requires ALL permissions: 

* presence:source:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceSourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var deactivated = deactivated_example;  // string | Deactivated query can be TRUE or FALSE (optional)  (default to "false")

            try
            { 
                // Get a list of Presence Sources
                SourceEntityListing result = apiInstance.GetPresenceSources(deactivated);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceSources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deactivated** | **string**| Deactivated query can be TRUE or FALSE | [optional] [default to "false"] |

### Return type

[**SourceEntityListing**](SourceEntityListing)


## GetPresenceUserPrimarysource

> [**UserPrimarySource**](UserPrimarySource) GetPresenceUserPrimarysource (string userId)


Get a user's Primary Presence Source

Requires ALL permissions: 

* presence:userPrimarySource:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetPresenceUserPrimarysourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user ID

            try
            { 
                // Get a user's Primary Presence Source
                UserPrimarySource result = apiInstance.GetPresenceUserPrimarysource(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceUserPrimarysource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user ID |  |

### Return type

[**UserPrimarySource**](UserPrimarySource)


## GetPresencedefinition

> [**OrganizationPresence**](OrganizationPresence) GetPresencedefinition (string presenceId, string localeCode = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a Presence Definition. Apps should migrate to use GET /api/v2/presence/definitions/{definitionId} instead

Requires ALL permissions: 

* presence:presenceDefinition:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID
            var localeCode = localeCode_example;  // string | The locale code to fetch for the presence definition. Use ALL to fetch everything. (optional) 

            try
            { 
                // Get a Presence Definition. Apps should migrate to use GET /api/v2/presence/definitions/{definitionId} instead
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **localeCode** | **string**| The locale code to fetch for the presence definition. Use ALL to fetch everything. | [optional]  |

### Return type

[**OrganizationPresence**](OrganizationPresence)


## GetPresencedefinitions

> [**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing) GetPresencedefinitions (int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get an Organization's list of Presence Definitions. Apps should migrate to use GET /api/v2/presence/definitions instead

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
    public class GetPresencedefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var deleted = deleted_example;  // string | Deleted query can be TRUE, FALSE or ALL (optional)  (default to "false")
            var localeCode = localeCode_example;  // string | The locale code to fetch for each presence definition. Use ALL to fetch everything. (optional) 

            try
            { 
                // Get an Organization's list of Presence Definitions. Apps should migrate to use GET /api/v2/presence/definitions instead
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **deleted** | **string**| Deleted query can be TRUE, FALSE or ALL | [optional] [default to "false"] |
| **localeCode** | **string**| The locale code to fetch for each presence definition. Use ALL to fetch everything. | [optional]  |

### Return type

[**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing)


## GetSystempresences

> [**List&lt;SystemPresence&gt;**](SystemPresence) GetSystempresences ()


Get the list of SystemPresences

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
    public class GetSystempresencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();

            try
            { 
                // Get the list of SystemPresences
                List<SystemPresence> result = apiInstance.GetSystempresences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetSystempresences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<SystemPresence>**](SystemPresence)


## GetUserPresence

> [**UserPresence**](UserPresence) GetUserPresence (string userId, string sourceId)


Get a user's Presence

Get a user's presence for the specified source that is not specifically listed.  Used to support custom presence sources. This endpoint does not support registered presence sources.

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
    public class GetUserPresenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var sourceId = sourceId_example;  // string | Presence source ID

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Presence source ID |  |

### Return type

[**UserPresence**](UserPresence)


## GetUserPresencesPurecloud

> [**UserPresence**](UserPresence) GetUserPresencesPurecloud (string userId)


Get a user's Genesys Cloud presence.

Get the default Genesys Cloud user presence source PURECLOUD

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
    public class GetUserPresencesPurecloudExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id

            try
            { 
                // Get a user's Genesys Cloud presence.
                UserPresence result = apiInstance.GetUserPresencesPurecloud(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUserPresencesPurecloud: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |

### Return type

[**UserPresence**](UserPresence)


## GetUsersPresenceBulk

> [**List&lt;UcUserPresence&gt;**](UcUserPresence) GetUsersPresenceBulk (string sourceId, List<string> id = null)


Get bulk user presences for a single presence source

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
    public class GetUsersPresenceBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var sourceId = sourceId_example;  // string | The requested presence source ID.
            var id = new List<string>(); // List<string> | A comma separated list of user IDs to fetch their presence status in bulk. Limit 50. (optional) 

            try
            { 
                // Get bulk user presences for a single presence source
                List<UcUserPresence> result = apiInstance.GetUsersPresenceBulk(sourceId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUsersPresenceBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sourceId** | **string**| The requested presence source ID. |  |
| **id** | [**List<string>**](string)| A comma separated list of user IDs to fetch their presence status in bulk. Limit 50. | [optional]  |

### Return type

[**List<UcUserPresence>**](UcUserPresence)


## GetUsersPresencesPurecloudBulk

> [**List&lt;UcUserPresence&gt;**](UcUserPresence) GetUsersPresencesPurecloudBulk (List<string> id = null)


Get bulk user presences for a Genesys Cloud (PURECLOUD) presence source

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
    public class GetUsersPresencesPurecloudBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var id = new List<string>(); // List<string> | A comma separated list of user IDs to fetch their presence status in bulk. Limit 50. (optional) 

            try
            { 
                // Get bulk user presences for a Genesys Cloud (PURECLOUD) presence source
                List<UcUserPresence> result = apiInstance.GetUsersPresencesPurecloudBulk(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUsersPresencesPurecloudBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| A comma separated list of user IDs to fetch their presence status in bulk. Limit 50. | [optional]  |

### Return type

[**List<UcUserPresence>**](UcUserPresence)


## PatchUserPresence

> [**UserPresence**](UserPresence) PatchUserPresence (string userId, string sourceId, UserPresence body)


Patch a user's Presence

Patch a user's presence for the specified source that is not specifically listed. This endpoint does not support registered presence sources. The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.

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
    public class PatchUserPresenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var sourceId = sourceId_example;  // string | Presence source ID
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Presence source ID |  |
| **body** | [**UserPresence**](UserPresence)| User presence |  |

### Return type

[**UserPresence**](UserPresence)


## PatchUserPresencesPurecloud

> [**UserPresence**](UserPresence) PatchUserPresencesPurecloud (string userId, UserPresence body)


Patch a Genesys Cloud user's presence

The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the PURECLOUD source as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.

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
    public class PatchUserPresencesPurecloudExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var body = new UserPresence(); // UserPresence | User presence

            try
            { 
                // Patch a Genesys Cloud user's presence
                UserPresence result = apiInstance.PatchUserPresencesPurecloud(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PatchUserPresencesPurecloud: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **body** | [**UserPresence**](UserPresence)| User presence |  |

### Return type

[**UserPresence**](UserPresence)


## PostPresenceDefinitions0

> [**OrganizationPresenceDefinition**](OrganizationPresenceDefinition) PostPresenceDefinitions0 (OrganizationPresenceDefinition body)


Create a Presence Definition

Requires ALL permissions: 

* presence:presenceDefinition:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostPresenceDefinitions0Example
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var body = new OrganizationPresenceDefinition(); // OrganizationPresenceDefinition | The Presence Definition to create

            try
            { 
                // Create a Presence Definition
                OrganizationPresenceDefinition result = apiInstance.PostPresenceDefinitions0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PostPresenceDefinitions0: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationPresenceDefinition**](OrganizationPresenceDefinition)| The Presence Definition to create |  |

### Return type

[**OrganizationPresenceDefinition**](OrganizationPresenceDefinition)


## PostPresenceSources

> [**Source**](Source) PostPresenceSources (Source body)


Create a Presence Source

Requires ALL permissions: 

* presence:source:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostPresenceSourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var body = new Source(); // Source | The Presence Source to create

            try
            { 
                // Create a Presence Source
                Source result = apiInstance.PostPresenceSources(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PostPresenceSources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Source**](Source)| The Presence Source to create |  |

### Return type

[**Source**](Source)


## PostPresencedefinitions

> [**OrganizationPresence**](OrganizationPresence) PostPresencedefinitions (OrganizationPresence body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create a Presence Definition. Apps should migrate to use POST /api/v2/presence/definitions instead

Requires ALL permissions: 

* presence:presenceDefinition:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var body = new OrganizationPresence(); // OrganizationPresence | The Presence Definition to create

            try
            { 
                // Create a Presence Definition. Apps should migrate to use POST /api/v2/presence/definitions instead
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationPresence**](OrganizationPresence)| The Presence Definition to create |  |

### Return type

[**OrganizationPresence**](OrganizationPresence)


## PutPresenceDefinition0

> [**OrganizationPresenceDefinition**](OrganizationPresenceDefinition) PutPresenceDefinition0 (string definitionId, OrganizationPresenceDefinition body)


Update a Presence Definition

Requires ALL permissions: 

* presence:presenceDefinition:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutPresenceDefinition0Example
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var definitionId = definitionId_example;  // string | Presence Definition ID
            var body = new OrganizationPresenceDefinition(); // OrganizationPresenceDefinition | The updated Presence Definition

            try
            { 
                // Update a Presence Definition
                OrganizationPresenceDefinition result = apiInstance.PutPresenceDefinition0(definitionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresenceDefinition0: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **definitionId** | **string**| Presence Definition ID |  |
| **body** | [**OrganizationPresenceDefinition**](OrganizationPresenceDefinition)| The updated Presence Definition |  |

### Return type

[**OrganizationPresenceDefinition**](OrganizationPresenceDefinition)


## PutPresenceSettings

> [**PresenceSettings**](PresenceSettings) PutPresenceSettings (PresenceSettings body)


Update the presence settings

Requires ALL permissions: 

* presence:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutPresenceSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var body = new PresenceSettings(); // PresenceSettings | Presence Settings

            try
            { 
                // Update the presence settings
                PresenceSettings result = apiInstance.PutPresenceSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresenceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PresenceSettings**](PresenceSettings)| Presence Settings |  |

### Return type

[**PresenceSettings**](PresenceSettings)


## PutPresenceSource

> [**Source**](Source) PutPresenceSource (string sourceId, Source body)


Update a Presence Source

Requires ALL permissions: 

* presence:source:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutPresenceSourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var sourceId = sourceId_example;  // string | Presence Source ID
            var body = new Source(); // Source | The updated Presence Source

            try
            { 
                // Update a Presence Source
                Source result = apiInstance.PutPresenceSource(sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresenceSource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sourceId** | **string**| Presence Source ID |  |
| **body** | [**Source**](Source)| The updated Presence Source |  |

### Return type

[**Source**](Source)


## PutPresenceUserPrimarysource

> [**UserPrimarySource**](UserPrimarySource) PutPresenceUserPrimarysource (string userId, UserPrimarySource body)


Update a user's Primary Presence Source

Requires ALL permissions: 

* presence:userPrimarySource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutPresenceUserPrimarysourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user ID
            var body = new UserPrimarySource(); // UserPrimarySource | Primary Source

            try
            { 
                // Update a user's Primary Presence Source
                UserPrimarySource result = apiInstance.PutPresenceUserPrimarysource(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresenceUserPrimarysource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user ID |  |
| **body** | [**UserPrimarySource**](UserPrimarySource)| Primary Source |  |

### Return type

[**UserPrimarySource**](UserPrimarySource)


## PutPresencedefinition

> [**OrganizationPresence**](OrganizationPresence) PutPresencedefinition (string presenceId, OrganizationPresence body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a Presence Definition. Apps should migrate to use PUT /api/v2/presence/definitions/{definitionId} instead)

Requires ALL permissions: 

* presence:presenceDefinition:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to update

            try
            { 
                // Update a Presence Definition. Apps should migrate to use PUT /api/v2/presence/definitions/{definitionId} instead)
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **body** | [**OrganizationPresence**](OrganizationPresence)| The OrganizationPresence to update |  |

### Return type

[**OrganizationPresence**](OrganizationPresence)


## PutUsersPresencesBulk

> [**List&lt;UserPresence&gt;**](UserPresence) PutUsersPresencesBulk (List<MutableUserPresence> body)


Update bulk user Presences

Requires ANY permissions: 

* presence:userPresence:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUsersPresencesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new PresenceApi();
            var body = new List<MutableUserPresence>(); // List<MutableUserPresence> | List of User presences

            try
            { 
                // Update bulk user Presences
                List<UserPresence> result = apiInstance.PutUsersPresencesBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutUsersPresencesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<MutableUserPresence>**](MutableUserPresence)| List of User presences |  |

### Return type

[**List<UserPresence>**](UserPresence)


_PureCloudPlatform.Client.V2 252.1.0_
