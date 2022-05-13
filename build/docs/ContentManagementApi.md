---
title: ContentManagementApi
---
## PureCloudPlatform.Client.V2.Api.ContentManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteContentmanagementDocument**](ContentManagementApi.html#deletecontentmanagementdocument) | **DELETE** /api/v2/contentmanagement/documents/{documentId} | Delete a document. |
| [**DeleteContentmanagementShare**](ContentManagementApi.html#deletecontentmanagementshare) | **DELETE** /api/v2/contentmanagement/shares/{shareId} | Deletes an existing share. |
| [**DeleteContentmanagementStatusStatusId**](ContentManagementApi.html#deletecontentmanagementstatusstatusid) | **DELETE** /api/v2/contentmanagement/status/{statusId} | Cancel the command for this status |
| [**DeleteContentmanagementWorkspace**](ContentManagementApi.html#deletecontentmanagementworkspace) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId} | Delete a workspace |
| [**DeleteContentmanagementWorkspaceMember**](ContentManagementApi.html#deletecontentmanagementworkspacemember) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Delete a member from a workspace |
| [**DeleteContentmanagementWorkspaceTagvalue**](ContentManagementApi.html#deletecontentmanagementworkspacetagvalue) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Delete workspace tag |
| [**GetContentmanagementDocument**](ContentManagementApi.html#getcontentmanagementdocument) | **GET** /api/v2/contentmanagement/documents/{documentId} | Get a document. |
| [**GetContentmanagementDocumentAudits**](ContentManagementApi.html#getcontentmanagementdocumentaudits) | **GET** /api/v2/contentmanagement/documents/{documentId}/audits | Get a list of audits for a document. |
| [**GetContentmanagementDocumentContent**](ContentManagementApi.html#getcontentmanagementdocumentcontent) | **GET** /api/v2/contentmanagement/documents/{documentId}/content | Download a document. |
| [**GetContentmanagementDocuments**](ContentManagementApi.html#getcontentmanagementdocuments) | **GET** /api/v2/contentmanagement/documents | Get a list of documents. |
| [**GetContentmanagementQuery**](ContentManagementApi.html#getcontentmanagementquery) | **GET** /api/v2/contentmanagement/query | Query content |
| [**GetContentmanagementSecurityprofile**](ContentManagementApi.html#getcontentmanagementsecurityprofile) | **GET** /api/v2/contentmanagement/securityprofiles/{securityProfileId} | Get a Security Profile |
| [**GetContentmanagementSecurityprofiles**](ContentManagementApi.html#getcontentmanagementsecurityprofiles) | **GET** /api/v2/contentmanagement/securityprofiles | Get a List of Security Profiles |
| [**GetContentmanagementShare**](ContentManagementApi.html#getcontentmanagementshare) | **GET** /api/v2/contentmanagement/shares/{shareId} | Retrieve details about an existing share. |
| [**GetContentmanagementSharedSharedId**](ContentManagementApi.html#getcontentmanagementsharedsharedid) | **GET** /api/v2/contentmanagement/shared/{sharedId} | Get shared documents. Securely download a shared document. |
| [**GetContentmanagementShares**](ContentManagementApi.html#getcontentmanagementshares) | **GET** /api/v2/contentmanagement/shares | Gets a list of shares.  You must specify at least one filter (e.g. entityId). |
| [**GetContentmanagementStatus**](ContentManagementApi.html#getcontentmanagementstatus) | **GET** /api/v2/contentmanagement/status | Get a list of statuses for pending operations |
| [**GetContentmanagementStatusStatusId**](ContentManagementApi.html#getcontentmanagementstatusstatusid) | **GET** /api/v2/contentmanagement/status/{statusId} | Get a status. |
| [**GetContentmanagementUsage**](ContentManagementApi.html#getcontentmanagementusage) | **GET** /api/v2/contentmanagement/usage | Get usage details. |
| [**GetContentmanagementWorkspace**](ContentManagementApi.html#getcontentmanagementworkspace) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId} | Get a workspace. |
| [**GetContentmanagementWorkspaceDocuments**](ContentManagementApi.html#getcontentmanagementworkspacedocuments) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/documents | Get a list of documents. |
| [**GetContentmanagementWorkspaceMember**](ContentManagementApi.html#getcontentmanagementworkspacemember) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Get a workspace member |
| [**GetContentmanagementWorkspaceMembers**](ContentManagementApi.html#getcontentmanagementworkspacemembers) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/members | Get a list workspace members |
| [**GetContentmanagementWorkspaceTagvalue**](ContentManagementApi.html#getcontentmanagementworkspacetagvalue) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Get a workspace tag |
| [**GetContentmanagementWorkspaceTagvalues**](ContentManagementApi.html#getcontentmanagementworkspacetagvalues) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues | Get a list of workspace tags |
| [**GetContentmanagementWorkspaces**](ContentManagementApi.html#getcontentmanagementworkspaces) | **GET** /api/v2/contentmanagement/workspaces | Get a list of workspaces. |
| [**PostContentmanagementAuditquery**](ContentManagementApi.html#postcontentmanagementauditquery) | **POST** /api/v2/contentmanagement/auditquery | Query audits |
| [**PostContentmanagementDocument**](ContentManagementApi.html#postcontentmanagementdocument) | **POST** /api/v2/contentmanagement/documents/{documentId} | Update a document. |
| [**PostContentmanagementDocumentContent**](ContentManagementApi.html#postcontentmanagementdocumentcontent) | **POST** /api/v2/contentmanagement/documents/{documentId}/content | Replace the contents of a document. |
| [**PostContentmanagementDocuments**](ContentManagementApi.html#postcontentmanagementdocuments) | **POST** /api/v2/contentmanagement/documents | Add a document. |
| [**PostContentmanagementQuery**](ContentManagementApi.html#postcontentmanagementquery) | **POST** /api/v2/contentmanagement/query | Query content |
| [**PostContentmanagementShares**](ContentManagementApi.html#postcontentmanagementshares) | **POST** /api/v2/contentmanagement/shares | Creates a new share or updates an existing share if the entity has already been shared |
| [**PostContentmanagementWorkspaceTagvalues**](ContentManagementApi.html#postcontentmanagementworkspacetagvalues) | **POST** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues | Create a workspace tag |
| [**PostContentmanagementWorkspaceTagvaluesQuery**](ContentManagementApi.html#postcontentmanagementworkspacetagvaluesquery) | **POST** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query | Perform a prefix query on tags in the workspace |
| [**PostContentmanagementWorkspaces**](ContentManagementApi.html#postcontentmanagementworkspaces) | **POST** /api/v2/contentmanagement/workspaces | Create a group workspace |
| [**PutContentmanagementWorkspace**](ContentManagementApi.html#putcontentmanagementworkspace) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId} | Update a workspace |
| [**PutContentmanagementWorkspaceMember**](ContentManagementApi.html#putcontentmanagementworkspacemember) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Add a member to a workspace |
| [**PutContentmanagementWorkspaceTagvalue**](ContentManagementApi.html#putcontentmanagementworkspacetagvalue) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Update a workspace tag. Will update all documents with the new tag value. |
{: class="table table-striped"}

<a name="deletecontentmanagementdocument"></a>

## void DeleteContentmanagementDocument (string documentId, bool? _override = null)



Delete a document.



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
    public class DeleteContentmanagementDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            { 
                // Delete a document.
                apiInstance.DeleteContentmanagementDocument(documentId, _override);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecontentmanagementshare"></a>

## void DeleteContentmanagementShare (string shareId)



Deletes an existing share.

This revokes sharing rights specified in the share record



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
    public class DeleteContentmanagementShareExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var shareId = shareId_example;  // string | Share ID

            try
            { 
                // Deletes an existing share.
                apiInstance.DeleteContentmanagementShare(shareId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementShare: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecontentmanagementstatusstatusid"></a>

## void DeleteContentmanagementStatusStatusId (string statusId)



Cancel the command for this status



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
    public class DeleteContentmanagementStatusStatusIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var statusId = statusId_example;  // string | Status ID

            try
            { 
                // Cancel the command for this status
                apiInstance.DeleteContentmanagementStatusStatusId(statusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementStatusStatusId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecontentmanagementworkspace"></a>

## void DeleteContentmanagementWorkspace (string workspaceId, string moveChildrenToWorkspaceId = null)



Delete a workspace



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
    public class DeleteContentmanagementWorkspaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var moveChildrenToWorkspaceId = moveChildrenToWorkspaceId_example;  // string | New location for objects in deleted workspace. (optional) 

            try
            { 
                // Delete a workspace
                apiInstance.DeleteContentmanagementWorkspace(workspaceId, moveChildrenToWorkspaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **moveChildrenToWorkspaceId** | **string**| New location for objects in deleted workspace. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecontentmanagementworkspacemember"></a>

## void DeleteContentmanagementWorkspaceMember (string workspaceId, string memberId)



Delete a member from a workspace



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
    public class DeleteContentmanagementWorkspaceMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID

            try
            { 
                // Delete a member from a workspace
                apiInstance.DeleteContentmanagementWorkspaceMember(workspaceId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementWorkspaceMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecontentmanagementworkspacetagvalue"></a>

## void DeleteContentmanagementWorkspaceTagvalue (string workspaceId, string tagId)



Delete workspace tag

Delete a tag from a workspace. Will remove this tag from all documents.



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
    public class DeleteContentmanagementWorkspaceTagvalueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID

            try
            { 
                // Delete workspace tag
                apiInstance.DeleteContentmanagementWorkspaceTagvalue(workspaceId, tagId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteContentmanagementWorkspaceTagvalue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getcontentmanagementdocument"></a>

## [**Document**](Document.html) GetContentmanagementDocument (string documentId, List<string> expand = null)



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
    public class GetContentmanagementDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a document.
                Document result = apiInstance.GetContentmanagementDocument(documentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: lockInfo, acl, workspace |
{: class="table table-striped"}

### Return type

[**Document**](Document.html)

<a name="getcontentmanagementdocumentaudits"></a>

## [**DocumentAuditEntityListing**](DocumentAuditEntityListing.html) GetContentmanagementDocumentAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)



Get a list of audits for a document.



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
    public class GetContentmanagementDocumentAuditsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var transactionFilter = transactionFilter_example;  // string | Transaction filter (optional) 
            var level = level_example;  // string | level (optional)  (default to "USER")
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ascending")

            try
            { 
                // Get a list of audits for a document.
                DocumentAuditEntityListing result = apiInstance.GetContentmanagementDocumentAudits(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementDocumentAudits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **transactionFilter** | **string**| Transaction filter | [optional]  |
| **level** | **string**| level | [optional] [default to "USER"] |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to "ascending"] |
{: class="table table-striped"}

### Return type

[**DocumentAuditEntityListing**](DocumentAuditEntityListing.html)

<a name="getcontentmanagementdocumentcontent"></a>

## [**DownloadResponse**](DownloadResponse.html) GetContentmanagementDocumentContent (string documentId, string disposition = null, string contentType = null)



Download a document.



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
    public class GetContentmanagementDocumentContentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var disposition = disposition_example;  // string | Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional) 
            var contentType = contentType_example;  // string | The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav (optional) 

            try
            { 
                // Download a document.
                DownloadResponse result = apiInstance.GetContentmanagementDocumentContent(documentId, disposition, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementDocumentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **disposition** | **string**| Request how the content will be downloaded: a file attachment or inline. Default is attachment. | [optional] <br />**Values**: attachment, inline |
| **contentType** | **string**| The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav | [optional]  |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.html)

<a name="getcontentmanagementdocuments"></a>

## [**DocumentEntityListing**](DocumentEntityListing.html) GetContentmanagementDocuments (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of documents.



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
    public class GetContentmanagementDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var name = name_example;  // string | Name (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | name or dateCreated (optional) 
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to "ascending")

            try
            { 
                // Get a list of documents.
                DocumentEntityListing result = apiInstance.GetContentmanagementDocuments(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **name** | **string**| Name | [optional]  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl, workspace |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| name or dateCreated | [optional]  |
| **sortOrder** | **string**| ascending or descending | [optional] [default to "ascending"] |
{: class="table table-striped"}

### Return type

[**DocumentEntityListing**](DocumentEntityListing.html)

<a name="getcontentmanagementquery"></a>

## [**QueryResults**](QueryResults.html) GetContentmanagementQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null)



Query content



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
    public class GetContentmanagementQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var queryPhrase = queryPhrase_example;  // string | Phrase tokens are ANDed together over all searchable fields
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | name or dateCreated (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to "ascending")
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Query content
                QueryResults result = apiInstance.GetContentmanagementQuery(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queryPhrase** | **string**| Phrase tokens are ANDed together over all searchable fields |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| name or dateCreated | [optional] [default to "name"] |
| **sortOrder** | **string**| ascending or descending | [optional] [default to "ascending"] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl, workspace |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.html)

<a name="getcontentmanagementsecurityprofile"></a>

## [**SecurityProfile**](SecurityProfile.html) GetContentmanagementSecurityprofile (string securityProfileId)



Get a Security Profile



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
    public class GetContentmanagementSecurityprofileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var securityProfileId = securityProfileId_example;  // string | Security Profile Id

            try
            { 
                // Get a Security Profile
                SecurityProfile result = apiInstance.GetContentmanagementSecurityprofile(securityProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementSecurityprofile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **securityProfileId** | **string**| Security Profile Id |  |
{: class="table table-striped"}

### Return type

[**SecurityProfile**](SecurityProfile.html)

<a name="getcontentmanagementsecurityprofiles"></a>

## [**SecurityProfileEntityListing**](SecurityProfileEntityListing.html) GetContentmanagementSecurityprofiles ()



Get a List of Security Profiles



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
    public class GetContentmanagementSecurityprofilesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();

            try
            { 
                // Get a List of Security Profiles
                SecurityProfileEntityListing result = apiInstance.GetContentmanagementSecurityprofiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementSecurityprofiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**SecurityProfileEntityListing**](SecurityProfileEntityListing.html)

<a name="getcontentmanagementshare"></a>

## [**Share**](Share.html) GetContentmanagementShare (string shareId, List<string> expand = null)



Retrieve details about an existing share.



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
    public class GetContentmanagementShareExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var shareId = shareId_example;  // string | Share ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Retrieve details about an existing share.
                Share result = apiInstance.GetContentmanagementShare(shareId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementShare: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: member |
{: class="table table-striped"}

### Return type

[**Share**](Share.html)

<a name="getcontentmanagementsharedsharedid"></a>

## [**SharedResponse**](SharedResponse.html) GetContentmanagementSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)



Get shared documents. Securely download a shared document.

This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.



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
    public class GetContentmanagementSharedSharedIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var sharedId = sharedId_example;  // string | Shared ID
            var redirect = true;  // bool? | Turn on or off redirect (optional)  (default to true)
            var disposition = disposition_example;  // string | Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional)  (default to attachment)
            var contentType = contentType_example;  // string | The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav (optional) 
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            { 
                // Get shared documents. Securely download a shared document.
                SharedResponse result = apiInstance.GetContentmanagementSharedSharedId(sharedId, redirect, disposition, contentType, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementSharedSharedId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sharedId** | **string**| Shared ID |  |
| **redirect** | **bool?**| Turn on or off redirect | [optional] [default to true] |
| **disposition** | **string**| Request how the share content will be downloaded: attached as a file or inline. Default is attachment. | [optional] [default to attachment]<br />**Values**: attachment, inline, none |
| **contentType** | **string**| The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav | [optional]  |
| **expand** | **string**| Expand some document fields | [optional] <br />**Values**: document.acl |
{: class="table table-striped"}

### Return type

[**SharedResponse**](SharedResponse.html)

<a name="getcontentmanagementshares"></a>

## [**ShareEntityListing**](ShareEntityListing.html) GetContentmanagementShares (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null)



Gets a list of shares.  You must specify at least one filter (e.g. entityId).

Failing to specify a filter will return 400.



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
    public class GetContentmanagementSharesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var entityId = entityId_example;  // string | Filters the shares returned to only the entity specified by the value of this parameter. (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Gets a list of shares.  You must specify at least one filter (e.g. entityId).
                ShareEntityListing result = apiInstance.GetContentmanagementShares(entityId, expand, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementShares: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **entityId** | **string**| Filters the shares returned to only the entity specified by the value of this parameter. | [optional]  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: member |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**ShareEntityListing**](ShareEntityListing.html)

<a name="getcontentmanagementstatus"></a>

## [**CommandStatusEntityListing**](CommandStatusEntityListing.html) GetContentmanagementStatus (int? pageSize = null, int? pageNumber = null)



Get a list of statuses for pending operations



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
    public class GetContentmanagementStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of statuses for pending operations
                CommandStatusEntityListing result = apiInstance.GetContentmanagementStatus(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementStatus: " + e.Message );
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

[**CommandStatusEntityListing**](CommandStatusEntityListing.html)

<a name="getcontentmanagementstatusstatusid"></a>

## [**CommandStatus**](CommandStatus.html) GetContentmanagementStatusStatusId (string statusId)



Get a status.



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
    public class GetContentmanagementStatusStatusIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var statusId = statusId_example;  // string | Status ID

            try
            { 
                // Get a status.
                CommandStatus result = apiInstance.GetContentmanagementStatusStatusId(statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementStatusStatusId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

[**CommandStatus**](CommandStatus.html)

<a name="getcontentmanagementusage"></a>

## [**Usage**](Usage.html) GetContentmanagementUsage ()



Get usage details.



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
    public class GetContentmanagementUsageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();

            try
            { 
                // Get usage details.
                Usage result = apiInstance.GetContentmanagementUsage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**Usage**](Usage.html)

<a name="getcontentmanagementworkspace"></a>

## [**Workspace**](Workspace.html) GetContentmanagementWorkspace (string workspaceId, List<string> expand = null)



Get a workspace.



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
    public class GetContentmanagementWorkspaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a workspace.
                Workspace result = apiInstance.GetContentmanagementWorkspace(workspaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: summary, acl |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.html)

<a name="getcontentmanagementworkspacedocuments"></a>

## [**DocumentEntityListing**](DocumentEntityListing.html) GetContentmanagementWorkspaceDocuments (string workspaceId, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)



Get a list of documents.



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
    public class GetContentmanagementWorkspaceDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | name or dateCreated (optional) 
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to "ascending")

            try
            { 
                // Get a list of documents.
                DocumentEntityListing result = apiInstance.GetContentmanagementWorkspaceDocuments(workspaceId, expand, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaceDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl, workspace |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| name or dateCreated | [optional]  |
| **sortOrder** | **string**| ascending or descending | [optional] [default to "ascending"] |
{: class="table table-striped"}

### Return type

[**DocumentEntityListing**](DocumentEntityListing.html)

<a name="getcontentmanagementworkspacemember"></a>

## [**WorkspaceMember**](WorkspaceMember.html) GetContentmanagementWorkspaceMember (string workspaceId, string memberId, List<string> expand = null)



Get a workspace member



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
    public class GetContentmanagementWorkspaceMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a workspace member
                WorkspaceMember result = apiInstance.GetContentmanagementWorkspaceMember(workspaceId, memberId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaceMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: member |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.html)

<a name="getcontentmanagementworkspacemembers"></a>

## [**WorkspaceMemberEntityListing**](WorkspaceMemberEntityListing.html) GetContentmanagementWorkspaceMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null)



Get a list workspace members



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
    public class GetContentmanagementWorkspaceMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a list workspace members
                WorkspaceMemberEntityListing result = apiInstance.GetContentmanagementWorkspaceMembers(workspaceId, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaceMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: member |
{: class="table table-striped"}

### Return type

[**WorkspaceMemberEntityListing**](WorkspaceMemberEntityListing.html)

<a name="getcontentmanagementworkspacetagvalue"></a>

## [**TagValue**](TagValue.html) GetContentmanagementWorkspaceTagvalue (string workspaceId, string tagId, List<string> expand = null)



Get a workspace tag



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
    public class GetContentmanagementWorkspaceTagvalueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a workspace tag
                TagValue result = apiInstance.GetContentmanagementWorkspaceTagvalue(workspaceId, tagId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaceTagvalue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.html)

<a name="getcontentmanagementworkspacetagvalues"></a>

## [**TagValueEntityListing**](TagValueEntityListing.html) GetContentmanagementWorkspaceTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null)



Get a list of workspace tags



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
    public class GetContentmanagementWorkspaceTagvaluesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var value = value_example;  // string | filter the list of tags returned (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a list of workspace tags
                TagValueEntityListing result = apiInstance.GetContentmanagementWorkspaceTagvalues(workspaceId, value, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaceTagvalues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **value** | **string**| filter the list of tags returned | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl |
{: class="table table-striped"}

### Return type

[**TagValueEntityListing**](TagValueEntityListing.html)

<a name="getcontentmanagementworkspaces"></a>

## [**WorkspaceEntityListing**](WorkspaceEntityListing.html) GetContentmanagementWorkspaces (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null)



Get a list of workspaces.

Specifying 'content' access will return all workspaces the user has document access to, while 'admin' access will return all group workspaces the user has administrative rights to.



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
    public class GetContentmanagementWorkspacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var access = new List<string>(); // List<string> | Requested access level. (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a list of workspaces.
                WorkspaceEntityListing result = apiInstance.GetContentmanagementWorkspaces(pageSize, pageNumber, access, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetContentmanagementWorkspaces: " + e.Message );
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
| **access** | [**List<string>**](string.html)| Requested access level. | [optional] <br />**Values**: content, admin, document:create, document:viewContent, document:viewMetadata, document:download, document:delete, document:update, document:share, document:shareView, document:email, document:print, document:auditView, document:replace, document:tag, tag:create, tag:view, tag:update, tag:apply, tag:remove, tag:delete |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: summary, acl |
{: class="table table-striped"}

### Return type

[**WorkspaceEntityListing**](WorkspaceEntityListing.html)

<a name="postcontentmanagementauditquery"></a>

## [**QueryResults**](QueryResults.html) PostContentmanagementAuditquery (ContentQueryRequest body)



Query audits



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
    public class PostContentmanagementAuditqueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var body = new ContentQueryRequest(); // ContentQueryRequest | Allows for a filtered query returning facet information

            try
            { 
                // Query audits
                QueryResults result = apiInstance.PostContentmanagementAuditquery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementAuditquery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContentQueryRequest**](ContentQueryRequest.html)| Allows for a filtered query returning facet information |  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.html)

<a name="postcontentmanagementdocument"></a>

## [**Document**](Document.html) PostContentmanagementDocument (string documentId, DocumentUpdate body, string expand = null, bool? _override = null)



Update a document.



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
    public class PostContentmanagementDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new DocumentUpdate(); // DocumentUpdate | Document
            var expand = expand_example;  // string | Expand some document fields (optional) 
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            { 
                // Update a document.
                Document result = apiInstance.PostContentmanagementDocument(documentId, body, expand, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**DocumentUpdate**](DocumentUpdate.html)| Document |  |
| **expand** | **string**| Expand some document fields | [optional] <br />**Values**: acl |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.html)

<a name="postcontentmanagementdocumentcontent"></a>

## [**ReplaceResponse**](ReplaceResponse.html) PostContentmanagementDocumentContent (string documentId, ReplaceRequest body, bool? _override = null)



Replace the contents of a document.



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
    public class PostContentmanagementDocumentContentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new ReplaceRequest(); // ReplaceRequest | Replace Request
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            { 
                // Replace the contents of a document.
                ReplaceResponse result = apiInstance.PostContentmanagementDocumentContent(documentId, body, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementDocumentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**ReplaceRequest**](ReplaceRequest.html)| Replace Request |  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

[**ReplaceResponse**](ReplaceResponse.html)

<a name="postcontentmanagementdocuments"></a>

## [**Document**](Document.html) PostContentmanagementDocuments (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null)



Add a document.



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
    public class PostContentmanagementDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var body = new DocumentUpload(); // DocumentUpload | Document
            var copySource = copySource_example;  // string | Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional) 
            var moveSource = moveSource_example;  // string | Move a document to a new workspace. Provide a document ID as the move source. (optional) 
            var _override = true;  // bool? | Override any lock on the source document (optional) 

            try
            { 
                // Add a document.
                Document result = apiInstance.PostContentmanagementDocuments(body, copySource, moveSource, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DocumentUpload**](DocumentUpload.html)| Document |  |
| **copySource** | **string**| Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. | [optional]  |
| **moveSource** | **string**| Move a document to a new workspace. Provide a document ID as the move source. | [optional]  |
| **_override** | **bool?**| Override any lock on the source document | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.html)

<a name="postcontentmanagementquery"></a>

## [**QueryResults**](QueryResults.html) PostContentmanagementQuery (QueryRequest body, string expand = null)



Query content



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
    public class PostContentmanagementQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var body = new QueryRequest(); // QueryRequest | Allows for a filtered query returning facet information
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            { 
                // Query content
                QueryResults result = apiInstance.PostContentmanagementQuery(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueryRequest**](QueryRequest.html)| Allows for a filtered query returning facet information |  |
| **expand** | **string**| Expand some document fields | [optional] <br />**Values**: acl, workspace |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.html)

<a name="postcontentmanagementshares"></a>

## [**CreateShareResponse**](CreateShareResponse.html) PostContentmanagementShares (CreateShareRequest body)



Creates a new share or updates an existing share if the entity has already been shared



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
    public class PostContentmanagementSharesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var body = new CreateShareRequest(); // CreateShareRequest | CreateShareRequest - entity id and type and a single member or list of members are required

            try
            { 
                // Creates a new share or updates an existing share if the entity has already been shared
                CreateShareResponse result = apiInstance.PostContentmanagementShares(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementShares: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateShareRequest**](CreateShareRequest.html)| CreateShareRequest - entity id and type and a single member or list of members are required |  |
{: class="table table-striped"}

### Return type

[**CreateShareResponse**](CreateShareResponse.html)

<a name="postcontentmanagementworkspacetagvalues"></a>

## [**TagValue**](TagValue.html) PostContentmanagementWorkspaceTagvalues (string workspaceId, TagValue body)



Create a workspace tag



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
    public class PostContentmanagementWorkspaceTagvaluesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new TagValue(); // TagValue | tag

            try
            { 
                // Create a workspace tag
                TagValue result = apiInstance.PostContentmanagementWorkspaceTagvalues(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementWorkspaceTagvalues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagValue**](TagValue.html)| tag |  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.html)

<a name="postcontentmanagementworkspacetagvaluesquery"></a>

## [**TagValueEntityListing**](TagValueEntityListing.html) PostContentmanagementWorkspaceTagvaluesQuery (string workspaceId, TagQueryRequest body, List<string> expand = null)



Perform a prefix query on tags in the workspace



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
    public class PostContentmanagementWorkspaceTagvaluesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new TagQueryRequest(); // TagQueryRequest | query
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Perform a prefix query on tags in the workspace
                TagValueEntityListing result = apiInstance.PostContentmanagementWorkspaceTagvaluesQuery(workspaceId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementWorkspaceTagvaluesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagQueryRequest**](TagQueryRequest.html)| query |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: acl |
{: class="table table-striped"}

### Return type

[**TagValueEntityListing**](TagValueEntityListing.html)

<a name="postcontentmanagementworkspaces"></a>

## [**Workspace**](Workspace.html) PostContentmanagementWorkspaces (WorkspaceCreate body)



Create a group workspace



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
    public class PostContentmanagementWorkspacesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var body = new WorkspaceCreate(); // WorkspaceCreate | Workspace

            try
            { 
                // Create a group workspace
                Workspace result = apiInstance.PostContentmanagementWorkspaces(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostContentmanagementWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkspaceCreate**](WorkspaceCreate.html)| Workspace |  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.html)

<a name="putcontentmanagementworkspace"></a>

## [**Workspace**](Workspace.html) PutContentmanagementWorkspace (string workspaceId, Workspace body)



Update a workspace



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
    public class PutContentmanagementWorkspaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new Workspace(); // Workspace | Workspace

            try
            { 
                // Update a workspace
                Workspace result = apiInstance.PutContentmanagementWorkspace(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutContentmanagementWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**Workspace**](Workspace.html)| Workspace |  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.html)

<a name="putcontentmanagementworkspacemember"></a>

## [**WorkspaceMember**](WorkspaceMember.html) PutContentmanagementWorkspaceMember (string workspaceId, string memberId, WorkspaceMember body)



Add a member to a workspace



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
    public class PutContentmanagementWorkspaceMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID
            var body = new WorkspaceMember(); // WorkspaceMember | Workspace Member

            try
            { 
                // Add a member to a workspace
                WorkspaceMember result = apiInstance.PutContentmanagementWorkspaceMember(workspaceId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutContentmanagementWorkspaceMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**WorkspaceMember**](WorkspaceMember.html)| Workspace Member |  |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.html)

<a name="putcontentmanagementworkspacetagvalue"></a>

## [**TagValue**](TagValue.html) PutContentmanagementWorkspaceTagvalue (string workspaceId, string tagId, TagValue body)



Update a workspace tag. Will update all documents with the new tag value.



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
    public class PutContentmanagementWorkspaceTagvalueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID
            var body = new TagValue(); // TagValue | Workspace

            try
            { 
                // Update a workspace tag. Will update all documents with the new tag value.
                TagValue result = apiInstance.PutContentmanagementWorkspaceTagvalue(workspaceId, tagId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutContentmanagementWorkspaceTagvalue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **body** | [**TagValue**](TagValue.html)| Workspace |  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.html)

