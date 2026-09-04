# FaxApi

## PureCloudPlatform.Client.V2.Api.FaxApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteFaxDocument**](#DeleteFaxDocument) | **Delete** /api/v2/fax/documents/{documentId} | Delete a fax document. |
| [**GetFaxDocument**](#GetFaxDocument) | **Get** /api/v2/fax/documents/{documentId} | Get a document. |
| [**GetFaxDocumentContent**](#GetFaxDocumentContent) | **Get** /api/v2/fax/documents/{documentId}/content | Download a fax document. |
| [**GetFaxDocuments**](#GetFaxDocuments) | **Get** /api/v2/fax/documents | Get a list of fax documents. |
| [**GetFaxFaxIdStatus**](#GetFaxFaxIdStatus) | **Get** /api/v2/fax/{faxId}/status | Get fax status |
| [**GetFaxSettings**](#GetFaxSettings) | **Get** /api/v2/fax/settings | Get organization config for given organization |
| [**GetFaxSummary**](#GetFaxSummary) | **Get** /api/v2/fax/summary | Get fax summary |
| [**PutFaxDocument**](#PutFaxDocument) | **Put** /api/v2/fax/documents/{documentId} | Update a fax document. |
| [**PutFaxSettings**](#PutFaxSettings) | **Put** /api/v2/fax/settings | Update/write organization config for given organization |



## DeleteFaxDocument

> void DeleteFaxDocument (string documentId)


Delete a fax document.

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
    public class DeleteFaxDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            { 
                // Delete a fax document.
                apiInstance.DeleteFaxDocument(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.DeleteFaxDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |

### Return type

void (empty response body)


## GetFaxDocument

> [**FaxDocument**](FaxDocument) GetFaxDocument (string documentId)


Get a document.

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
    public class GetFaxDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            { 
                // Get a document.
                FaxDocument result = apiInstance.GetFaxDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |

### Return type

[**FaxDocument**](FaxDocument)


## GetFaxDocumentContent

> [**DownloadResponse**](DownloadResponse) GetFaxDocumentContent (string documentId)


Download a fax document.

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
    public class GetFaxDocumentContentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            { 
                // Download a fax document.
                DownloadResponse result = apiInstance.GetFaxDocumentContent(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxDocumentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |

### Return type

[**DownloadResponse**](DownloadResponse)


## GetFaxDocuments

> [**FaxDocumentEntityListing**](FaxDocumentEntityListing) GetFaxDocuments (int? pageSize = null, int? pageNumber = null)


Get a list of fax documents.

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
    public class GetFaxDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of fax documents.
                FaxDocumentEntityListing result = apiInstance.GetFaxDocuments(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxDocuments: " + e.Message );
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

### Return type

[**FaxDocumentEntityListing**](FaxDocumentEntityListing)


## GetFaxFaxIdStatus

> [**OutboundFaxStatus**](OutboundFaxStatus) GetFaxFaxIdStatus (string faxId)


Get fax status

Retrieves status for an outbound (sent) fax. Only the authenticated user who sent the fax can fetch its status; this operation does not expose inbound or other users' faxes. When the `result` field is present on the response body, it describes the terminal outcome of **transmitting** the fax to the remote endpoint (e.g. SUCCESS or FAILURE). 

Requires ANY permissions: 

* conversation:fax:send

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFaxFaxIdStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var faxId = faxId_example;  // string | Fax ID of an outbound fax sent by the authenticated user only.

            try
            { 
                // Get fax status
                OutboundFaxStatus result = apiInstance.GetFaxFaxIdStatus(faxId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxFaxIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **faxId** | **string**| Fax ID of an outbound fax sent by the authenticated user only. |  |

### Return type

[**OutboundFaxStatus**](OutboundFaxStatus)


## GetFaxSettings

> [**FaxConfig**](FaxConfig) GetFaxSettings ()


Get organization config for given organization

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
    public class GetFaxSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();

            try
            { 
                // Get organization config for given organization
                FaxConfig result = apiInstance.GetFaxSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FaxConfig**](FaxConfig)


## GetFaxSummary

> [**FaxSummary**](FaxSummary) GetFaxSummary ()


Get fax summary

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
    public class GetFaxSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();

            try
            { 
                // Get fax summary
                FaxSummary result = apiInstance.GetFaxSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetFaxSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FaxSummary**](FaxSummary)


## PutFaxDocument

> [**FaxDocument**](FaxDocument) PutFaxDocument (string documentId, FaxDocument body)


Update a fax document.

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
    public class PutFaxDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new FaxDocument(); // FaxDocument | Document

            try
            { 
                // Update a fax document.
                FaxDocument result = apiInstance.PutFaxDocument(documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.PutFaxDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**FaxDocument**](FaxDocument)| Document |  |

### Return type

[**FaxDocument**](FaxDocument)


## PutFaxSettings

> [**FaxConfig**](FaxConfig) PutFaxSettings (FaxConfig body = null)


Update/write organization config for given organization

Requires ANY permissions: 

* directory:organization:admin

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFaxSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FaxApi();
            var body = new FaxConfig(); // FaxConfig |  (optional) 

            try
            { 
                // Update/write organization config for given organization
                FaxConfig result = apiInstance.PutFaxSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.PutFaxSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxConfig**](FaxConfig)|  | [optional]  |

### Return type

[**FaxConfig**](FaxConfig)


_PureCloudPlatform.Client.V2 272.0.0_
