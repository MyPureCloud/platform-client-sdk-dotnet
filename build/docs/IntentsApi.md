# IntentsApi

## PureCloudPlatform.Client.V2.Api.IntentsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIntentsCategory**](#DeleteIntentsCategory) | **Delete** /api/v2/intents/categories/{categoryId} | Delete category for categoryId |
| [**DeleteIntentsCustomerintent**](#DeleteIntentsCustomerintent) | **Delete** /api/v2/intents/customerintents/{customerIntentId} | Delete customer intent for customerIntentId |
| [**GetIntentsAssignmentsExternalcontact**](#GetIntentsAssignmentsExternalcontact) | **Get** /api/v2/intents/assignments/externalcontacts/{externalContactId} | Get customer intent assignments for externalContactId |
| [**GetIntentsCategories**](#GetIntentsCategories) | **Get** /api/v2/intents/categories | Get categories |
| [**GetIntentsCategory**](#GetIntentsCategory) | **Get** /api/v2/intents/categories/{categoryId} | Get category for categoryId |
| [**GetIntentsCustomerintent**](#GetIntentsCustomerintent) | **Get** /api/v2/intents/customerintents/{customerIntentId} | Get customer intent for customerIntentId |
| [**GetIntentsCustomerintentSourceintents**](#GetIntentsCustomerintentSourceintents) | **Get** /api/v2/intents/customerintents/{customerIntentId}/sourceintents | Get source intents mapped to a customer intent |
| [**GetIntentsCustomerintents**](#GetIntentsCustomerintents) | **Get** /api/v2/intents/customerintents | Get customer intents |
| [**GetIntentsSourceintents**](#GetIntentsSourceintents) | **Get** /api/v2/intents/sourceintents | Get all mapped source intents by type. If no type selected default is type Segment |
| [**PatchIntentsCategory**](#PatchIntentsCategory) | **Patch** /api/v2/intents/categories/{categoryId} | Patch category for categoryId |
| [**PatchIntentsCustomerintent**](#PatchIntentsCustomerintent) | **Patch** /api/v2/intents/customerintents/{customerIntentId} | Patch customer intent for customerIntentId |
| [**PostIntentsAssignmentsExternalcontactCustomerintentAssignment**](#PostIntentsAssignmentsExternalcontactCustomerintentAssignment) | **Post** /api/v2/intents/assignments/externalcontacts/{externalContactId}/customerintents/{customerIntentId}/assignment | Create customer intent assignment for external contact |
| [**PostIntentsCategories**](#PostIntentsCategories) | **Post** /api/v2/intents/categories | Create category |
| [**PostIntentsCustomerintentSourceintentsBulkAdd**](#PostIntentsCustomerintentSourceintentsBulkAdd) | **Post** /api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/add | Bulk add source intents to a customer intent |
| [**PostIntentsCustomerintentSourceintentsBulkRemove**](#PostIntentsCustomerintentSourceintentsBulkRemove) | **Post** /api/v2/intents/customerintents/{customerIntentId}/sourceintents/bulk/remove | Bulk remove source intents mapped to a customer intent |
| [**PostIntentsCustomerintents**](#PostIntentsCustomerintents) | **Post** /api/v2/intents/customerintents | Create customer intents |



## DeleteIntentsCategory

> void DeleteIntentsCategory (string categoryId)


Delete category for categoryId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntentsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var categoryId = categoryId_example;  // string | Category id

            try
            { 
                // Delete category for categoryId
                apiInstance.DeleteIntentsCategory(categoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.DeleteIntentsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category id |  |

### Return type

void (empty response body)


## DeleteIntentsCustomerintent

> void DeleteIntentsCustomerintent (string customerIntentId)


Delete customer intent for customerIntentId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntentsCustomerintentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id

            try
            { 
                // Delete customer intent for customerIntentId
                apiInstance.DeleteIntentsCustomerintent(customerIntentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.DeleteIntentsCustomerintent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |

### Return type

void (empty response body)


## GetIntentsAssignmentsExternalcontact

> [**CustomerIntentAssignmentListing**](CustomerIntentAssignmentListing) GetIntentsAssignmentsExternalcontact (string externalContactId, int? pageSize = null, int? pageNumber = null)


Get customer intent assignments for externalContactId

Requires ANY permissions: 

* externalContacts:customerIntentAssignments:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsAssignmentsExternalcontactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var externalContactId = externalContactId_example;  // string | External Contact id
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)

            try
            { 
                // Get customer intent assignments for externalContactId
                CustomerIntentAssignmentListing result = apiInstance.GetIntentsAssignmentsExternalcontact(externalContactId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsAssignmentsExternalcontact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalContactId** | **string**| External Contact id |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |

### Return type

[**CustomerIntentAssignmentListing**](CustomerIntentAssignmentListing)


## GetIntentsCategories

> [**IntentsCategoryListing**](IntentsCategoryListing) GetIntentsCategories (int? pageSize = null, int? pageNumber = null, string queryValue = null)


Get categories

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var queryValue = queryValue_example;  // string | Search query value to filter results by (optional) 

            try
            { 
                // Get categories
                IntentsCategoryListing result = apiInstance.GetIntentsCategories(pageSize, pageNumber, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsCategories: " + e.Message );
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
| **queryValue** | **string**| Search query value to filter results by | [optional]  |

### Return type

[**IntentsCategoryListing**](IntentsCategoryListing)


## GetIntentsCategory

> [**IntentsCategory**](IntentsCategory) GetIntentsCategory (string categoryId)


Get category for categoryId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var categoryId = categoryId_example;  // string | Category id

            try
            { 
                // Get category for categoryId
                IntentsCategory result = apiInstance.GetIntentsCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category id |  |

### Return type

[**IntentsCategory**](IntentsCategory)


## GetIntentsCustomerintent

> [**CustomerIntentResponse**](CustomerIntentResponse) GetIntentsCustomerintent (string customerIntentId)


Get customer intent for customerIntentId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsCustomerintentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id

            try
            { 
                // Get customer intent for customerIntentId
                CustomerIntentResponse result = apiInstance.GetIntentsCustomerintent(customerIntentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsCustomerintent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |

### Return type

[**CustomerIntentResponse**](CustomerIntentResponse)


## GetIntentsCustomerintentSourceintents

> [**CustomerSourceIntentListing**](CustomerSourceIntentListing) GetIntentsCustomerintentSourceintents (string customerIntentId, int? pageSize = null, int? pageNumber = null, string queryValue = null)


Get source intents mapped to a customer intent

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsCustomerintentSourceintentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var queryValue = queryValue_example;  // string | Search query value to filter results by (optional) 

            try
            { 
                // Get source intents mapped to a customer intent
                CustomerSourceIntentListing result = apiInstance.GetIntentsCustomerintentSourceintents(customerIntentId, pageSize, pageNumber, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsCustomerintentSourceintents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **queryValue** | **string**| Search query value to filter results by | [optional]  |

### Return type

[**CustomerSourceIntentListing**](CustomerSourceIntentListing)


## GetIntentsCustomerintents

> [**CustomerIntentListing**](CustomerIntentListing) GetIntentsCustomerintents (int? pageSize = null, int? pageNumber = null, string queryValue = null, string categoryId = null)


Get customer intents

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsCustomerintentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var queryValue = queryValue_example;  // string | Search query value to filter results by (optional) 
            var categoryId = categoryId_example;  // string | CategoryId to filter query by (optional) 

            try
            { 
                // Get customer intents
                CustomerIntentListing result = apiInstance.GetIntentsCustomerintents(pageSize, pageNumber, queryValue, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsCustomerintents: " + e.Message );
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
| **queryValue** | **string**| Search query value to filter results by | [optional]  |
| **categoryId** | **string**| CategoryId to filter query by | [optional]  |

### Return type

[**CustomerIntentListing**](CustomerIntentListing)


## GetIntentsSourceintents

> [**CustomerSourceIntentListing**](CustomerSourceIntentListing) GetIntentsSourceintents (int? pageSize = null, int? pageNumber = null, string type = null, string sourceId = null)


Get all mapped source intents by type. If no type selected default is type Segment

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntentsSourceintentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var type = type_example;  // string | Source Type to query by. If none selected default response will be for type Segment. (optional) 
            var sourceId = sourceId_example;  // string | Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot (optional) 

            try
            { 
                // Get all mapped source intents by type. If no type selected default is type Segment
                CustomerSourceIntentListing result = apiInstance.GetIntentsSourceintents(pageSize, pageNumber, type, sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.GetIntentsSourceintents: " + e.Message );
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
| **type** | **string**| Source Type to query by. If none selected default response will be for type Segment. | [optional] <br />**Values**: Bot, Copilot, Digitalbot, Segment, Topic, Unknown |
| **sourceId** | **string**| Source Id to query by. Only required for sourceType: Copilot, Bot, Digitalbot | [optional]  |

### Return type

[**CustomerSourceIntentListing**](CustomerSourceIntentListing)


## PatchIntentsCategory

> [**IntentsCategory**](IntentsCategory) PatchIntentsCategory (string categoryId, IntentsCategoryPatch body)


Patch category for categoryId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntentsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var categoryId = categoryId_example;  // string | Category id
            var body = new IntentsCategoryPatch(); // IntentsCategoryPatch | category

            try
            { 
                // Patch category for categoryId
                IntentsCategory result = apiInstance.PatchIntentsCategory(categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PatchIntentsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category id |  |
| **body** | [**IntentsCategoryPatch**](IntentsCategoryPatch)| category |  |

### Return type

[**IntentsCategory**](IntentsCategory)


## PatchIntentsCustomerintent

> [**CustomerIntentResponse**](CustomerIntentResponse) PatchIntentsCustomerintent (string customerIntentId, CustomerIntentPatch body)


Patch customer intent for customerIntentId

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntentsCustomerintentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id
            var body = new CustomerIntentPatch(); // CustomerIntentPatch | Customer intent

            try
            { 
                // Patch customer intent for customerIntentId
                CustomerIntentResponse result = apiInstance.PatchIntentsCustomerintent(customerIntentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PatchIntentsCustomerintent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |
| **body** | [**CustomerIntentPatch**](CustomerIntentPatch)| Customer intent |  |

### Return type

[**CustomerIntentResponse**](CustomerIntentResponse)


## PostIntentsAssignmentsExternalcontactCustomerintentAssignment

> [**CustomerIntentAssignmentResponse**](CustomerIntentAssignmentResponse) PostIntentsAssignmentsExternalcontactCustomerintentAssignment (string externalContactId, string customerIntentId, CustomerIntentAssignmentRequest body)


Create customer intent assignment for external contact

Requires ANY permissions: 

* externalContacts:customerIntentAssignments:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntentsAssignmentsExternalcontactCustomerintentAssignmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var externalContactId = externalContactId_example;  // string | External Contact id
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id
            var body = new CustomerIntentAssignmentRequest(); // CustomerIntentAssignmentRequest | Customer intent assignment

            try
            { 
                // Create customer intent assignment for external contact
                CustomerIntentAssignmentResponse result = apiInstance.PostIntentsAssignmentsExternalcontactCustomerintentAssignment(externalContactId, customerIntentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PostIntentsAssignmentsExternalcontactCustomerintentAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalContactId** | **string**| External Contact id |  |
| **customerIntentId** | **string**| Customer Intent id |  |
| **body** | [**CustomerIntentAssignmentRequest**](CustomerIntentAssignmentRequest)| Customer intent assignment |  |

### Return type

[**CustomerIntentAssignmentResponse**](CustomerIntentAssignmentResponse)


## PostIntentsCategories

> [**IntentsCategory**](IntentsCategory) PostIntentsCategories (IntentsCategory body)


Create category

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntentsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var body = new IntentsCategory(); // IntentsCategory | category

            try
            { 
                // Create category
                IntentsCategory result = apiInstance.PostIntentsCategories(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PostIntentsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IntentsCategory**](IntentsCategory)| category |  |

### Return type

[**IntentsCategory**](IntentsCategory)


## PostIntentsCustomerintentSourceintentsBulkAdd

> [**BulkSourceIntentsResponse**](BulkSourceIntentsResponse) PostIntentsCustomerintentSourceintentsBulkAdd (string customerIntentId, BulkAddSourceIntentsRequest body)


Bulk add source intents to a customer intent

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntentsCustomerintentSourceintentsBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id
            var body = new BulkAddSourceIntentsRequest(); // BulkAddSourceIntentsRequest | Source intents to be added

            try
            { 
                // Bulk add source intents to a customer intent
                BulkSourceIntentsResponse result = apiInstance.PostIntentsCustomerintentSourceintentsBulkAdd(customerIntentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PostIntentsCustomerintentSourceintentsBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |
| **body** | [**BulkAddSourceIntentsRequest**](BulkAddSourceIntentsRequest)| Source intents to be added |  |

### Return type

[**BulkSourceIntentsResponse**](BulkSourceIntentsResponse)


## PostIntentsCustomerintentSourceintentsBulkRemove

> [**BulkSourceIntentsResponse**](BulkSourceIntentsResponse) PostIntentsCustomerintentSourceintentsBulkRemove (string customerIntentId, BulkRemoveSourceIntentsRequest body)


Bulk remove source intents mapped to a customer intent

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntentsCustomerintentSourceintentsBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var customerIntentId = customerIntentId_example;  // string | Customer Intent id
            var body = new BulkRemoveSourceIntentsRequest(); // BulkRemoveSourceIntentsRequest | Source intents to be removed

            try
            { 
                // Bulk remove source intents mapped to a customer intent
                BulkSourceIntentsResponse result = apiInstance.PostIntentsCustomerintentSourceintentsBulkRemove(customerIntentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PostIntentsCustomerintentSourceintentsBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIntentId** | **string**| Customer Intent id |  |
| **body** | [**BulkRemoveSourceIntentsRequest**](BulkRemoveSourceIntentsRequest)| Source intents to be removed |  |

### Return type

[**BulkSourceIntentsResponse**](BulkSourceIntentsResponse)


## PostIntentsCustomerintents

> [**CustomerIntentResponse**](CustomerIntentResponse) PostIntentsCustomerintents (CustomerIntent body)


Create customer intents

Requires ANY permissions: 

* externalContacts:customerIntentTaxonomy:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntentsCustomerintentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new IntentsApi();
            var body = new CustomerIntent(); // CustomerIntent | Customer intent

            try
            { 
                // Create customer intents
                CustomerIntentResponse result = apiInstance.PostIntentsCustomerintents(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntentsApi.PostIntentsCustomerintents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CustomerIntent**](CustomerIntent)| Customer intent |  |

### Return type

[**CustomerIntentResponse**](CustomerIntentResponse)


_PureCloudPlatform.Client.V2 254.0.0_
