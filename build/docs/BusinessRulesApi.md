# BusinessRulesApi

## PureCloudPlatform.Client.V2.Api.BusinessRulesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteBusinessrulesDecisiontable**](#DeleteBusinessrulesDecisiontable) | **Delete** /api/v2/businessrules/decisiontables/{tableId} | Delete a decision table |
| [**DeleteBusinessrulesDecisiontableVersion**](#DeleteBusinessrulesDecisiontableVersion) | **Delete** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion} | Delete a decision table version |
| [**DeleteBusinessrulesDecisiontableVersionRow**](#DeleteBusinessrulesDecisiontableVersionRow) | **Delete** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId} | Delete a decision table row |
| [**DeleteBusinessrulesSchema**](#DeleteBusinessrulesSchema) | **Delete** /api/v2/businessrules/schemas/{schemaId} | Delete a schema |
| [**GetBusinessrulesDecisiontable**](#GetBusinessrulesDecisiontable) | **Get** /api/v2/businessrules/decisiontables/{tableId} | Get a decision table |
| [**GetBusinessrulesDecisiontableVersion**](#GetBusinessrulesDecisiontableVersion) | **Get** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion} | Get a decision table version |
| [**GetBusinessrulesDecisiontableVersionRow**](#GetBusinessrulesDecisiontableVersionRow) | **Get** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId} | Get a decision table row |
| [**GetBusinessrulesDecisiontableVersionRows**](#GetBusinessrulesDecisiontableVersionRows) | **Get** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows | Get a list of decision table rows. |
| [**GetBusinessrulesDecisiontableVersions**](#GetBusinessrulesDecisiontableVersions) | **Get** /api/v2/businessrules/decisiontables/{tableId}/versions | Get a list of decision table versions |
| [**GetBusinessrulesDecisiontables**](#GetBusinessrulesDecisiontables) | **Get** /api/v2/businessrules/decisiontables | Get a list of decision tables. |
| [**GetBusinessrulesDecisiontablesSearch**](#GetBusinessrulesDecisiontablesSearch) | **Get** /api/v2/businessrules/decisiontables/search | Search for decision tables. |
| [**GetBusinessrulesSchema**](#GetBusinessrulesSchema) | **Get** /api/v2/businessrules/schemas/{schemaId} | Get a schema |
| [**GetBusinessrulesSchemas**](#GetBusinessrulesSchemas) | **Get** /api/v2/businessrules/schemas | Get a list of schemas. |
| [**GetBusinessrulesSchemasCoretype**](#GetBusinessrulesSchemasCoretype) | **Get** /api/v2/businessrules/schemas/coretypes/{coreTypeName} | Get a specific named core type. |
| [**GetBusinessrulesSchemasCoretypes**](#GetBusinessrulesSchemasCoretypes) | **Get** /api/v2/businessrules/schemas/coretypes | Get the core types from which all schemas are built. |
| [**PatchBusinessrulesDecisiontable**](#PatchBusinessrulesDecisiontable) | **Patch** /api/v2/businessrules/decisiontables/{tableId} | Update a decision table |
| [**PatchBusinessrulesDecisiontableVersion**](#PatchBusinessrulesDecisiontableVersion) | **Patch** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion} | Update a decision table version |
| [**PostBusinessrulesDecisiontableExecute**](#PostBusinessrulesDecisiontableExecute) | **Post** /api/v2/businessrules/decisiontables/{tableId}/execute | Execute a published decision table |
| [**PostBusinessrulesDecisiontableVersionCopy**](#PostBusinessrulesDecisiontableVersionCopy) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/copy | Copy a decision table version |
| [**PostBusinessrulesDecisiontableVersionExecute**](#PostBusinessrulesDecisiontableVersionExecute) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/execute | Execute a decision table version |
| [**PostBusinessrulesDecisiontableVersionRows**](#PostBusinessrulesDecisiontableVersionRows) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows | Create a decision table row |
| [**PostBusinessrulesDecisiontableVersionRowsSearch**](#PostBusinessrulesDecisiontableVersionRowsSearch) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/search | Search for decision table rows |
| [**PostBusinessrulesDecisiontableVersionSync**](#PostBusinessrulesDecisiontableVersionSync) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/sync | Update the Business Rules Schema to the latest version for a given decision table version |
| [**PostBusinessrulesDecisiontableVersions**](#PostBusinessrulesDecisiontableVersions) | **Post** /api/v2/businessrules/decisiontables/{tableId}/versions | Create a new decision table version |
| [**PostBusinessrulesDecisiontables**](#PostBusinessrulesDecisiontables) | **Post** /api/v2/businessrules/decisiontables | Create a decision table |
| [**PostBusinessrulesSchemas**](#PostBusinessrulesSchemas) | **Post** /api/v2/businessrules/schemas | Create a schema |
| [**PutBusinessrulesDecisiontableVersionPublish**](#PutBusinessrulesDecisiontableVersionPublish) | **Put** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/publish | Publish a decision table version |
| [**PutBusinessrulesDecisiontableVersionRow**](#PutBusinessrulesDecisiontableVersionRow) | **Put** /api/v2/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId} | Full update a decision table row |
| [**PutBusinessrulesSchema**](#PutBusinessrulesSchema) | **Put** /api/v2/businessrules/schemas/{schemaId} | Update a schema |



## DeleteBusinessrulesDecisiontable

> void DeleteBusinessrulesDecisiontable (string tableId, bool? forceDelete = null)


Delete a decision table

DeleteBusinessrulesDecisiontable is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteBusinessrulesDecisiontableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var forceDelete = true;  // bool? | Force delete decision table (under certain conditions) (optional)  (default to false)

            try
            { 
                // Delete a decision table
                apiInstance.DeleteBusinessrulesDecisiontable(tableId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.DeleteBusinessrulesDecisiontable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **forceDelete** | **bool?**| Force delete decision table (under certain conditions) | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteBusinessrulesDecisiontableVersion

> void DeleteBusinessrulesDecisiontableVersion (string tableId, int? tableVersion)


Delete a decision table version

DeleteBusinessrulesDecisiontableVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteBusinessrulesDecisiontableVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version

            try
            { 
                // Delete a decision table version
                apiInstance.DeleteBusinessrulesDecisiontableVersion(tableId, tableVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.DeleteBusinessrulesDecisiontableVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |

### Return type

void (empty response body)


## DeleteBusinessrulesDecisiontableVersionRow

> void DeleteBusinessrulesDecisiontableVersionRow (string tableId, int? tableVersion, string rowId)


Delete a decision table row

DeleteBusinessrulesDecisiontableVersionRow is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* businessrules:decisionTableRow:delete
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteBusinessrulesDecisiontableVersionRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var rowId = rowId_example;  // string | Row ID

            try
            { 
                // Delete a decision table row
                apiInstance.DeleteBusinessrulesDecisiontableVersionRow(tableId, tableVersion, rowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.DeleteBusinessrulesDecisiontableVersionRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **rowId** | **string**| Row ID |  |

### Return type

void (empty response body)


## DeleteBusinessrulesSchema

> void DeleteBusinessrulesSchema (string schemaId)


Delete a schema

DeleteBusinessrulesSchema is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteBusinessrulesSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Delete a schema
                apiInstance.DeleteBusinessrulesSchema(schemaId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.DeleteBusinessrulesSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |

### Return type

void (empty response body)


## GetBusinessrulesDecisiontable

> [**DecisionTable**](DecisionTable) GetBusinessrulesDecisiontable (string tableId)


Get a decision table

GetBusinessrulesDecisiontable is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID

            try
            { 
                // Get a decision table
                DecisionTable result = apiInstance.GetBusinessrulesDecisiontable(tableId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |

### Return type

[**DecisionTable**](DecisionTable)


## GetBusinessrulesDecisiontableVersion

> [**DecisionTableVersion**](DecisionTableVersion) GetBusinessrulesDecisiontableVersion (string tableId, int? tableVersion)


Get a decision table version

GetBusinessrulesDecisiontableVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontableVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version

            try
            { 
                // Get a decision table version
                DecisionTableVersion result = apiInstance.GetBusinessrulesDecisiontableVersion(tableId, tableVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontableVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## GetBusinessrulesDecisiontableVersionRow

> [**DecisionTableRow**](DecisionTableRow) GetBusinessrulesDecisiontableVersionRow (string tableId, int? tableVersion, string rowId)


Get a decision table row

GetBusinessrulesDecisiontableVersionRow is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontableVersionRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var rowId = rowId_example;  // string | Row ID

            try
            { 
                // Get a decision table row
                DecisionTableRow result = apiInstance.GetBusinessrulesDecisiontableVersionRow(tableId, tableVersion, rowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontableVersionRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **rowId** | **string**| Row ID |  |

### Return type

[**DecisionTableRow**](DecisionTableRow)


## GetBusinessrulesDecisiontableVersionRows

> [**DecisionTableRowListing**](DecisionTableRowListing) GetBusinessrulesDecisiontableVersionRows (string tableId, int? tableVersion, string pageNumber = null, string pageSize = null)


Get a list of decision table rows.

GetBusinessrulesDecisiontableVersionRows is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontableVersionRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var pageNumber = pageNumber_example;  // string | Page number of the entities to return. Defaults to 1. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. Defaults to 25. (optional) 

            try
            { 
                // Get a list of decision table rows.
                DecisionTableRowListing result = apiInstance.GetBusinessrulesDecisiontableVersionRows(tableId, tableVersion, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontableVersionRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **pageNumber** | **string**| Page number of the entities to return. Defaults to 1. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. Defaults to 25. | [optional]  |

### Return type

[**DecisionTableRowListing**](DecisionTableRowListing)


## GetBusinessrulesDecisiontableVersions

> [**DecisionTableVersionListing**](DecisionTableVersionListing) GetBusinessrulesDecisiontableVersions (string tableId, string after = null, string pageSize = null)


Get a list of decision table versions

GetBusinessrulesDecisiontableVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontableVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional) 

            try
            { 
                // Get a list of decision table versions
                DecisionTableVersionListing result = apiInstance.GetBusinessrulesDecisiontableVersions(tableId, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontableVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional]  |

### Return type

[**DecisionTableVersionListing**](DecisionTableVersionListing)


## GetBusinessrulesDecisiontables

> [**DecisionTableListing**](DecisionTableListing) GetBusinessrulesDecisiontables (string after = null, string pageSize = null, List<string> divisionIds = null, string name = null)


Get a list of decision tables.

GetBusinessrulesDecisiontables is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional) 
            var divisionIds = new List<string>(); // List<string> | One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional) 
            var name = name_example;  // string | Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional) 

            try
            { 
                // Get a list of decision tables.
                DecisionTableListing result = apiInstance.GetBusinessrulesDecisiontables(after, pageSize, divisionIds, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional]  |
| **divisionIds** | [**List<string>**](string)| One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. | [optional]  |
| **name** | **string**| Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. | [optional]  |

### Return type

[**DecisionTableListing**](DecisionTableListing)


## GetBusinessrulesDecisiontablesSearch

> [**DecisionTableListing**](DecisionTableListing) GetBusinessrulesDecisiontablesSearch (string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null)


Search for decision tables.

GetBusinessrulesDecisiontablesSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesDecisiontablesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional) 
            var schemaId = schemaId_example;  // string | Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional) 
            var name = name_example;  // string | Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional) 
            var withPublishedVersion = true;  // bool? | Filters results to only decision tables that have at least one version in Published status (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in response (optional) 
            var ids = new List<string>(); // List<string> | Decision table IDs to search for (optional) 

            try
            { 
                // Search for decision tables.
                DecisionTableListing result = apiInstance.GetBusinessrulesDecisiontablesSearch(after, pageSize, schemaId, name, withPublishedVersion, expand, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesDecisiontablesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional]  |
| **schemaId** | **string**| Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. | [optional]  |
| **name** | **string**| Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. | [optional]  |
| **withPublishedVersion** | **bool?**| Filters results to only decision tables that have at least one version in Published status | [optional]  |
| **expand** | [**List<string>**](string)| Fields to expand in response | [optional] <br />**Values**: ExecutionInputSchema, ExecutionOutputSchema |
| **ids** | [**List<string>**](string)| Decision table IDs to search for | [optional]  |

### Return type

[**DecisionTableListing**](DecisionTableListing)


## GetBusinessrulesSchema

> [**DataSchema**](DataSchema) GetBusinessrulesSchema (string schemaId)


Get a schema

GetBusinessrulesSchema is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get a schema
                DataSchema result = apiInstance.GetBusinessrulesSchema(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |

### Return type

[**DataSchema**](DataSchema)


## GetBusinessrulesSchemas

> [**DataSchemaListing**](DataSchemaListing) GetBusinessrulesSchemas ()


Get a list of schemas.

GetBusinessrulesSchemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();

            try
            { 
                // Get a list of schemas.
                DataSchemaListing result = apiInstance.GetBusinessrulesSchemas();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**DataSchemaListing**](DataSchemaListing)


## GetBusinessrulesSchemasCoretype

> [**Coretype**](Coretype) GetBusinessrulesSchemasCoretype (string coreTypeName)


Get a specific named core type.

GetBusinessrulesSchemasCoretype is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesSchemasCoretypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var coreTypeName = coreTypeName_example;  // string | The core type's name

            try
            { 
                // Get a specific named core type.
                Coretype result = apiInstance.GetBusinessrulesSchemasCoretype(coreTypeName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesSchemasCoretype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **coreTypeName** | **string**| The core type&#39;s name |  |

### Return type

[**Coretype**](Coretype)


## GetBusinessrulesSchemasCoretypes

> [**CoretypeListing**](CoretypeListing) GetBusinessrulesSchemasCoretypes ()


Get the core types from which all schemas are built.

GetBusinessrulesSchemasCoretypes is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBusinessrulesSchemasCoretypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();

            try
            { 
                // Get the core types from which all schemas are built.
                CoretypeListing result = apiInstance.GetBusinessrulesSchemasCoretypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.GetBusinessrulesSchemasCoretypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CoretypeListing**](CoretypeListing)


## PatchBusinessrulesDecisiontable

> [**DecisionTable**](DecisionTable) PatchBusinessrulesDecisiontable (string tableId, UpdateDecisionTableRequest body)


Update a decision table

PatchBusinessrulesDecisiontable is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* businessrules:decisionTable:edit
* businessrules:businessRulesSchema:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchBusinessrulesDecisiontableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var body = new UpdateDecisionTableRequest(); // UpdateDecisionTableRequest | Decision Table

            try
            { 
                // Update a decision table
                DecisionTable result = apiInstance.PatchBusinessrulesDecisiontable(tableId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PatchBusinessrulesDecisiontable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **body** | [**UpdateDecisionTableRequest**](UpdateDecisionTableRequest)| Decision Table |  |

### Return type

[**DecisionTable**](DecisionTable)


## PatchBusinessrulesDecisiontableVersion

> [**DecisionTableVersion**](DecisionTableVersion) PatchBusinessrulesDecisiontableVersion (string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body)


Update a decision table version

PatchBusinessrulesDecisiontableVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchBusinessrulesDecisiontableVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var body = new UpdateDecisionTableVersionRequest(); // UpdateDecisionTableVersionRequest | Decision Table

            try
            { 
                // Update a decision table version
                DecisionTableVersion result = apiInstance.PatchBusinessrulesDecisiontableVersion(tableId, tableVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PatchBusinessrulesDecisiontableVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **body** | [**UpdateDecisionTableVersionRequest**](UpdateDecisionTableVersionRequest)| Decision Table |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PostBusinessrulesDecisiontableExecute

> [**DecisionTableExecutionResponse**](DecisionTableExecutionResponse) PostBusinessrulesDecisiontableExecute (string tableId, DecisionTableExecutionRequest body)


Execute a published decision table

PostBusinessrulesDecisiontableExecute is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var body = new DecisionTableExecutionRequest(); // DecisionTableExecutionRequest | Decision Table

            try
            { 
                // Execute a published decision table
                DecisionTableExecutionResponse result = apiInstance.PostBusinessrulesDecisiontableExecute(tableId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **body** | [**DecisionTableExecutionRequest**](DecisionTableExecutionRequest)| Decision Table |  |

### Return type

[**DecisionTableExecutionResponse**](DecisionTableExecutionResponse)


## PostBusinessrulesDecisiontableVersionCopy

> [**DecisionTableVersion**](DecisionTableVersion) PostBusinessrulesDecisiontableVersionCopy (string tableId, int? tableVersion, CopyDecisionTableRequest body)


Copy a decision table version

PostBusinessrulesDecisiontableVersionCopy is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:copy

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var body = new CopyDecisionTableRequest(); // CopyDecisionTableRequest | Decision Table

            try
            { 
                // Copy a decision table version
                DecisionTableVersion result = apiInstance.PostBusinessrulesDecisiontableVersionCopy(tableId, tableVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersionCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **body** | [**CopyDecisionTableRequest**](CopyDecisionTableRequest)| Decision Table |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PostBusinessrulesDecisiontableVersionExecute

> [**DecisionTableExecutionResponse**](DecisionTableExecutionResponse) PostBusinessrulesDecisiontableVersionExecute (string tableId, int? tableVersion, DecisionTableExecutionRequest body)


Execute a decision table version

PostBusinessrulesDecisiontableVersionExecute is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var body = new DecisionTableExecutionRequest(); // DecisionTableExecutionRequest | Decision Table

            try
            { 
                // Execute a decision table version
                DecisionTableExecutionResponse result = apiInstance.PostBusinessrulesDecisiontableVersionExecute(tableId, tableVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersionExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **body** | [**DecisionTableExecutionRequest**](DecisionTableExecutionRequest)| Decision Table |  |

### Return type

[**DecisionTableExecutionResponse**](DecisionTableExecutionResponse)


## PostBusinessrulesDecisiontableVersionRows

> [**DecisionTableRow**](DecisionTableRow) PostBusinessrulesDecisiontableVersionRows (string tableId, int? tableVersion, CreateDecisionTableRowRequest body)


Create a decision table row

PostBusinessrulesDecisiontableVersionRows is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* businessrules:decisionTableRow:add
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var body = new CreateDecisionTableRowRequest(); // CreateDecisionTableRowRequest | Create decision table row request

            try
            { 
                // Create a decision table row
                DecisionTableRow result = apiInstance.PostBusinessrulesDecisiontableVersionRows(tableId, tableVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersionRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **body** | [**CreateDecisionTableRowRequest**](CreateDecisionTableRowRequest)| Create decision table row request |  |

### Return type

[**DecisionTableRow**](DecisionTableRow)


## PostBusinessrulesDecisiontableVersionRowsSearch

> [**DecisionTableRowListing**](DecisionTableRowListing) PostBusinessrulesDecisiontableVersionRowsSearch (string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null)


Search for decision table rows

PostBusinessrulesDecisiontableVersionRowsSearch is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTableRow:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionRowsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var body = new SearchDecisionTableRowsRequest(); // SearchDecisionTableRowsRequest | Search decision table rows request
            var pageNumber = pageNumber_example;  // string | Page number of the entities to return. Defaults to 1. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. Defaults to 25. (optional) 

            try
            { 
                // Search for decision table rows
                DecisionTableRowListing result = apiInstance.PostBusinessrulesDecisiontableVersionRowsSearch(tableId, tableVersion, body, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersionRowsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **body** | [**SearchDecisionTableRowsRequest**](SearchDecisionTableRowsRequest)| Search decision table rows request |  |
| **pageNumber** | **string**| Page number of the entities to return. Defaults to 1. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. Defaults to 25. | [optional]  |

### Return type

[**DecisionTableRowListing**](DecisionTableRowListing)


## PostBusinessrulesDecisiontableVersionSync

> [**DecisionTableVersion**](DecisionTableVersion) PostBusinessrulesDecisiontableVersionSync (string tableId, int? tableVersion)


Update the Business Rules Schema to the latest version for a given decision table version

PostBusinessrulesDecisiontableVersionSync is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionSyncExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version

            try
            { 
                // Update the Business Rules Schema to the latest version for a given decision table version
                DecisionTableVersion result = apiInstance.PostBusinessrulesDecisiontableVersionSync(tableId, tableVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersionSync: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PostBusinessrulesDecisiontableVersions

> [**DecisionTableVersion**](DecisionTableVersion) PostBusinessrulesDecisiontableVersions (string tableId)


Create a new decision table version

PostBusinessrulesDecisiontableVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontableVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID

            try
            { 
                // Create a new decision table version
                DecisionTableVersion result = apiInstance.PostBusinessrulesDecisiontableVersions(tableId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontableVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PostBusinessrulesDecisiontables

> [**DecisionTableVersion**](DecisionTableVersion) PostBusinessrulesDecisiontables (CreateDecisionTableRequest body)


Create a decision table

PostBusinessrulesDecisiontables is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* businessrules:decisionTable:add
* businessrules:businessRulesSchema:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesDecisiontablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var body = new CreateDecisionTableRequest(); // CreateDecisionTableRequest | Decision Table

            try
            { 
                // Create a decision table
                DecisionTableVersion result = apiInstance.PostBusinessrulesDecisiontables(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesDecisiontables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateDecisionTableRequest**](CreateDecisionTableRequest)| Decision Table |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PostBusinessrulesSchemas

> [**DataSchema**](DataSchema) PostBusinessrulesSchemas (DataSchema body)


Create a schema

PostBusinessrulesSchemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostBusinessrulesSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var body = new DataSchema(); // DataSchema | Schema

            try
            { 
                // Create a schema
                DataSchema result = apiInstance.PostBusinessrulesSchemas(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PostBusinessrulesSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataSchema**](DataSchema)| Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PutBusinessrulesDecisiontableVersionPublish

> [**DecisionTableVersion**](DecisionTableVersion) PutBusinessrulesDecisiontableVersionPublish (string tableId, int? tableVersion)


Publish a decision table version

PutBusinessrulesDecisiontableVersionPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:decisionTable:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutBusinessrulesDecisiontableVersionPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version

            try
            { 
                // Publish a decision table version
                DecisionTableVersion result = apiInstance.PutBusinessrulesDecisiontableVersionPublish(tableId, tableVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PutBusinessrulesDecisiontableVersionPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |

### Return type

[**DecisionTableVersion**](DecisionTableVersion)


## PutBusinessrulesDecisiontableVersionRow

> [**DecisionTableRow**](DecisionTableRow) PutBusinessrulesDecisiontableVersionRow (string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body)


Full update a decision table row

PutBusinessrulesDecisiontableVersionRow is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* businessrules:decisionTableRow:edit
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutBusinessrulesDecisiontableVersionRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var tableId = tableId_example;  // string | Table ID
            var tableVersion = 56;  // int? | Table Version
            var rowId = rowId_example;  // string | Row ID
            var body = new PutDecisionTableRowRequest(); // PutDecisionTableRowRequest | Full update decision table row request

            try
            { 
                // Full update a decision table row
                DecisionTableRow result = apiInstance.PutBusinessrulesDecisiontableVersionRow(tableId, tableVersion, rowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PutBusinessrulesDecisiontableVersionRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tableId** | **string**| Table ID |  |
| **tableVersion** | **int?**| Table Version |  |
| **rowId** | **string**| Row ID |  |
| **body** | [**PutDecisionTableRowRequest**](PutDecisionTableRowRequest)| Full update decision table row request |  |

### Return type

[**DecisionTableRow**](DecisionTableRow)


## PutBusinessrulesSchema

> [**DataSchema**](DataSchema) PutBusinessrulesSchema (string schemaId, DataSchema body)


Update a schema

PutBusinessrulesSchema is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* businessrules:businessRulesSchema:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutBusinessrulesSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BusinessRulesApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var body = new DataSchema(); // DataSchema | Data Schema

            try
            { 
                // Update a schema
                DataSchema result = apiInstance.PutBusinessrulesSchema(schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessRulesApi.PutBusinessrulesSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **body** | [**DataSchema**](DataSchema)| Data Schema |  |

### Return type

[**DataSchema**](DataSchema)


_PureCloudPlatform.Client.V2 239.1.0_
