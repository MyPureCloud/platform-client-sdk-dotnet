---
title: FaxApi
---
## PureCloudPlatform.Client.V2.Api.FaxApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteFaxDocument**](FaxApi.html#deletefaxdocument) | **DELETE** /api/v2/fax/documents/{documentId} | Delete a fax document. |
| [**GetFaxDocument**](FaxApi.html#getfaxdocument) | **GET** /api/v2/fax/documents/{documentId} | Get a document. |
| [**GetFaxDocumentContent**](FaxApi.html#getfaxdocumentcontent) | **GET** /api/v2/fax/documents/{documentId}/content | Download a fax document. |
| [**GetFaxDocuments**](FaxApi.html#getfaxdocuments) | **GET** /api/v2/fax/documents | Get a list of fax documents. |
| [**GetFaxSummary**](FaxApi.html#getfaxsummary) | **GET** /api/v2/fax/summary | Get fax summary |
| [**PutFaxDocument**](FaxApi.html#putfaxdocument) | **PUT** /api/v2/fax/documents/{documentId} | Update a fax document. |
{: class="table table-striped"}

<a name="deletefaxdocument"></a>

## void DeleteFaxDocument (string documentId)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getfaxdocument"></a>

## [**FaxDocument**](FaxDocument.html) GetFaxDocument (string documentId)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.html)

<a name="getfaxdocumentcontent"></a>

## [**DownloadResponse**](DownloadResponse.html) GetFaxDocumentContent (string documentId)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.html)

<a name="getfaxdocuments"></a>

## [**FaxDocumentEntityListing**](FaxDocumentEntityListing.html) GetFaxDocuments (int? pageSize = null, int? pageNumber = null)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**FaxDocumentEntityListing**](FaxDocumentEntityListing.html)

<a name="getfaxsummary"></a>

## [**FaxSummary**](FaxSummary.html) GetFaxSummary ()



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**FaxSummary**](FaxSummary.html)

<a name="putfaxdocument"></a>

## [**FaxDocument**](FaxDocument.html) PutFaxDocument (string documentId, FaxDocument body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
| **body** | [**FaxDocument**](FaxDocument.html)| Document |  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.html)

