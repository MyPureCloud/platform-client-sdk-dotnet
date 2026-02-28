# KnowledgeApi

## PureCloudPlatform.Client.V2.Api.KnowledgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteKnowledgeKnowledgebase**](#DeleteKnowledgeKnowledgebase) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Delete knowledge base |
| [**DeleteKnowledgeKnowledgebaseCategory**](#DeleteKnowledgeKnowledgebaseCategory) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Delete category |
| [**DeleteKnowledgeKnowledgebaseDocument**](#DeleteKnowledgeKnowledgebaseDocument) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Delete document. |
| [**DeleteKnowledgeKnowledgebaseDocumentVariation**](#DeleteKnowledgeKnowledgebaseDocumentVariation) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Delete a variation for a document. |
| [**DeleteKnowledgeKnowledgebaseExportJob**](#DeleteKnowledgeKnowledgebaseExportJob) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId} | Delete export job |
| [**DeleteKnowledgeKnowledgebaseImportJob**](#DeleteKnowledgeKnowledgebaseImportJob) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Delete import job |
| [**DeleteKnowledgeKnowledgebaseLabel**](#DeleteKnowledgeKnowledgebaseLabel) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Delete label |
| [**DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId**](#DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId} | Delete Salesforce Knowledge integration source |
| [**DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId**](#DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId} | Delete ServiceNow Knowledge integration source |
| [**DeleteKnowledgeKnowledgebaseSynchronizeJob**](#DeleteKnowledgeKnowledgebaseSynchronizeJob) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/synchronize/jobs/{syncJobId} | Delete synchronization job |
| [**DeleteKnowledgeSetting**](#DeleteKnowledgeSetting) | **Delete** /api/v2/knowledge/settings/{knowledgeSettingId} | Delete Knowledge setting. |
| [**GetKnowledgeGuestSessionCategories**](#GetKnowledgeGuestSessionCategories) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/categories | Get categories |
| [**GetKnowledgeGuestSessionDocument**](#GetKnowledgeGuestSessionDocument) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId} | Get a knowledge document by ID. |
| [**GetKnowledgeGuestSessionDocuments**](#GetKnowledgeGuestSessionDocuments) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/documents | Get documents. |
| [**GetKnowledgeIntegrationOptions**](#GetKnowledgeIntegrationOptions) | **Get** /api/v2/knowledge/integrations/{integrationId}/options | Get sync options available for a knowledge-connect integration |
| [**GetKnowledgeKnowledgebase**](#GetKnowledgeKnowledgebase) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Get knowledge base |
| [**GetKnowledgeKnowledgebaseCategories**](#GetKnowledgeKnowledgebaseCategories) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories | Get categories |
| [**GetKnowledgeKnowledgebaseCategory**](#GetKnowledgeKnowledgebaseCategory) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Get category |
| [**GetKnowledgeKnowledgebaseDocument**](#GetKnowledgeKnowledgebaseDocument) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Get document. |
| [**GetKnowledgeKnowledgebaseDocumentFeedback**](#GetKnowledgeKnowledgebaseDocumentFeedback) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback | Get a list of feedback records given on a document |
| [**GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId**](#GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback/{feedbackId} | Get a single feedback record given on a document |
| [**GetKnowledgeKnowledgebaseDocumentVariation**](#GetKnowledgeKnowledgebaseDocumentVariation) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Get a variation for a document. |
| [**GetKnowledgeKnowledgebaseDocumentVariations**](#GetKnowledgeKnowledgebaseDocumentVariations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations | Get variations for a document. |
| [**GetKnowledgeKnowledgebaseDocumentVersion**](#GetKnowledgeKnowledgebaseDocumentVersion) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId} | Get document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersionVariation**](#GetKnowledgeKnowledgebaseDocumentVersionVariation) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId}/variations/{variationId} | Get variation for the given document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersionVariations**](#GetKnowledgeKnowledgebaseDocumentVersionVariations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId}/variations | Get variations for the given document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersions**](#GetKnowledgeKnowledgebaseDocumentVersions) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions | Get document versions. |
| [**GetKnowledgeKnowledgebaseDocuments**](#GetKnowledgeKnowledgebaseDocuments) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents | Get documents. |
| [**GetKnowledgeKnowledgebaseExportJob**](#GetKnowledgeKnowledgebaseExportJob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId} | Get export job report |
| [**GetKnowledgeKnowledgebaseImportJob**](#GetKnowledgeKnowledgebaseImportJob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Get import job report |
| [**GetKnowledgeKnowledgebaseLabel**](#GetKnowledgeKnowledgebaseLabel) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Get label |
| [**GetKnowledgeKnowledgebaseLabels**](#GetKnowledgeKnowledgebaseLabels) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels | Get labels |
| [**GetKnowledgeKnowledgebaseOperations**](#GetKnowledgeKnowledgebaseOperations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations | Get operations |
| [**GetKnowledgeKnowledgebaseOperationsUsersQuery**](#GetKnowledgeKnowledgebaseOperationsUsersQuery) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations/users/query | Get ids of operation creator users and oauth clients |
| [**GetKnowledgeKnowledgebaseParseJob**](#GetKnowledgeKnowledgebaseParseJob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId} | Get parse job report |
| [**GetKnowledgeKnowledgebaseSources**](#GetKnowledgeKnowledgebaseSources) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources | Get Knowledge integration sources |
| [**GetKnowledgeKnowledgebaseSourcesSalesforceSourceId**](#GetKnowledgeKnowledgebaseSourcesSalesforceSourceId) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId} | Get Salesforce Knowledge integration source |
| [**GetKnowledgeKnowledgebaseSourcesServicenowSourceId**](#GetKnowledgeKnowledgebaseSourcesServicenowSourceId) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId} | Get ServiceNow Knowledge integration source |
| [**GetKnowledgeKnowledgebaseSynchronizeJob**](#GetKnowledgeKnowledgebaseSynchronizeJob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/synchronize/jobs/{syncJobId} | Get synchronization job report |
| [**GetKnowledgeKnowledgebaseUnansweredGroup**](#GetKnowledgeKnowledgebaseUnansweredGroup) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId} | Get knowledge base unanswered group for a particular groupId |
| [**GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup**](#GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId}/phrasegroups/{phraseGroupId} | Get knowledge base unanswered phrase group for a particular phraseGroupId |
| [**GetKnowledgeKnowledgebaseUnansweredGroups**](#GetKnowledgeKnowledgebaseUnansweredGroups) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups | Get knowledge base unanswered groups |
| [**GetKnowledgeKnowledgebaseUploadsUrlsJob**](#GetKnowledgeKnowledgebaseUploadsUrlsJob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId} | Get content upload from URL job status |
| [**GetKnowledgeKnowledgebases**](#GetKnowledgeKnowledgebases) | **Get** /api/v2/knowledge/knowledgebases | Get knowledge bases |
| [**GetKnowledgeSetting**](#GetKnowledgeSetting) | **Get** /api/v2/knowledge/settings/{knowledgeSettingId} | Get Knowledge setting. |
| [**GetKnowledgeSettings**](#GetKnowledgeSettings) | **Get** /api/v2/knowledge/settings | Get Knowledge settings. |
| [**PatchKnowledgeGuestSessionDocumentsSearchSearchId**](#PatchKnowledgeGuestSessionDocumentsSearchSearchId) | **Patch** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search/{searchId} | Update search result. |
| [**PatchKnowledgeKnowledgebase**](#PatchKnowledgeKnowledgebase) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Update knowledge base |
| [**PatchKnowledgeKnowledgebaseCategory**](#PatchKnowledgeKnowledgebaseCategory) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Update category |
| [**PatchKnowledgeKnowledgebaseChunksSearchSearchId**](#PatchKnowledgeKnowledgebaseChunksSearchSearchId) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/chunks/search/{searchId} | Register chunk search result. |
| [**PatchKnowledgeKnowledgebaseDocument**](#PatchKnowledgeKnowledgebaseDocument) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Update document. |
| [**PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId**](#PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback/{feedbackId} | Update feedback on a document |
| [**PatchKnowledgeKnowledgebaseDocumentVariation**](#PatchKnowledgeKnowledgebaseDocumentVariation) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Update a variation for a document. |
| [**PatchKnowledgeKnowledgebaseDocumentsSearchSearchId**](#PatchKnowledgeKnowledgebaseDocumentsSearchSearchId) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search/{searchId} | Update search result. |
| [**PatchKnowledgeKnowledgebaseImportJob**](#PatchKnowledgeKnowledgebaseImportJob) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Start import job |
| [**PatchKnowledgeKnowledgebaseLabel**](#PatchKnowledgeKnowledgebaseLabel) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Update label |
| [**PatchKnowledgeKnowledgebaseParseJob**](#PatchKnowledgeKnowledgebaseParseJob) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId} | Send update to the parse operation |
| [**PatchKnowledgeKnowledgebaseSynchronizeJob**](#PatchKnowledgeKnowledgebaseSynchronizeJob) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/synchronize/jobs/{syncJobId} | Update synchronization job |
| [**PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup**](#PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId}/phrasegroups/{phraseGroupId} | Update a Knowledge base unanswered phrase group |
| [**PatchKnowledgeSetting**](#PatchKnowledgeSetting) | **Patch** /api/v2/knowledge/settings/{knowledgeSettingId} | Update Knowledge setting. |
| [**PostKnowledgeDocumentuploads**](#PostKnowledgeDocumentuploads) | **Post** /api/v2/knowledge/documentuploads | Creates a presigned URL for uploading a knowledge import file with a set of documents |
| [**PostKnowledgeGuestSessionDocumentCopies**](#PostKnowledgeGuestSessionDocumentCopies) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/copies | Indicate that the document was copied by the user. |
| [**PostKnowledgeGuestSessionDocumentFeedback**](#PostKnowledgeGuestSessionDocumentFeedback) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/feedback | Give feedback on a document |
| [**PostKnowledgeGuestSessionDocumentViews**](#PostKnowledgeGuestSessionDocumentViews) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/views | Create view event for a document. |
| [**PostKnowledgeGuestSessionDocumentsAnswers**](#PostKnowledgeGuestSessionDocumentsAnswers) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/answers | Answer documents. |
| [**PostKnowledgeGuestSessionDocumentsPresentations**](#PostKnowledgeGuestSessionDocumentsPresentations) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/presentations | Indicate that documents were presented to the user. |
| [**PostKnowledgeGuestSessionDocumentsSearch**](#PostKnowledgeGuestSessionDocumentsSearch) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search | Search the documents in a guest session. |
| [**PostKnowledgeGuestSessionDocumentsSearchSuggestions**](#PostKnowledgeGuestSessionDocumentsSearchSuggestions) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search/suggestions | Query the knowledge documents to provide suggestions for auto completion. |
| [**PostKnowledgeGuestSessions**](#PostKnowledgeGuestSessions) | **Post** /api/v2/knowledge/guest/sessions | Create guest session |
| [**PostKnowledgeKnowledgebaseCategories**](#PostKnowledgeKnowledgebaseCategories) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories | Create new category |
| [**PostKnowledgeKnowledgebaseChunksSearch**](#PostKnowledgeKnowledgebaseChunksSearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/chunks/search | Search for chunks in a knowledge base |
| [**PostKnowledgeKnowledgebaseDocumentCopies**](#PostKnowledgeKnowledgebaseDocumentCopies) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/copies | Indicate that the document was copied by the user. |
| [**PostKnowledgeKnowledgebaseDocumentFeedback**](#PostKnowledgeKnowledgebaseDocumentFeedback) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback | Give feedback on a document |
| [**PostKnowledgeKnowledgebaseDocumentVariations**](#PostKnowledgeKnowledgebaseDocumentVariations) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations | Create a variation for a document. |
| [**PostKnowledgeKnowledgebaseDocumentVersions**](#PostKnowledgeKnowledgebaseDocumentVersions) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions | Creates or restores a document version. |
| [**PostKnowledgeKnowledgebaseDocumentViews**](#PostKnowledgeKnowledgebaseDocumentViews) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/views | Create view for a document. |
| [**PostKnowledgeKnowledgebaseDocuments**](#PostKnowledgeKnowledgebaseDocuments) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents | Create document. |
| [**PostKnowledgeKnowledgebaseDocumentsAnswers**](#PostKnowledgeKnowledgebaseDocumentsAnswers) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/answers | Answer documents. |
| [**PostKnowledgeKnowledgebaseDocumentsBulkRemove**](#PostKnowledgeKnowledgebaseDocumentsBulkRemove) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/bulk/remove | Bulk remove documents. |
| [**PostKnowledgeKnowledgebaseDocumentsBulkUpdate**](#PostKnowledgeKnowledgebaseDocumentsBulkUpdate) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/bulk/update | Bulk update documents. |
| [**PostKnowledgeKnowledgebaseDocumentsPresentations**](#PostKnowledgeKnowledgebaseDocumentsPresentations) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/presentations | Indicate that documents were presented to the user. |
| [**PostKnowledgeKnowledgebaseDocumentsQuery**](#PostKnowledgeKnowledgebaseDocumentsQuery) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/query | Query for knowledge documents. |
| [**PostKnowledgeKnowledgebaseDocumentsSearch**](#PostKnowledgeKnowledgebaseDocumentsSearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search | Search the documents in a knowledge base. |
| [**PostKnowledgeKnowledgebaseDocumentsSearchSuggestions**](#PostKnowledgeKnowledgebaseDocumentsSearchSuggestions) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search/suggestions | Query the knowledge documents to provide suggestions for auto completion. |
| [**PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd**](#PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/versions/bulk/add | Bulk add document versions. |
| [**PostKnowledgeKnowledgebaseExportJobs**](#PostKnowledgeKnowledgebaseExportJobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs | Create export job |
| [**PostKnowledgeKnowledgebaseImportJobs**](#PostKnowledgeKnowledgebaseImportJobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs | Create import job |
| [**PostKnowledgeKnowledgebaseLabels**](#PostKnowledgeKnowledgebaseLabels) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels | Create new label |
| [**PostKnowledgeKnowledgebaseParseJobImport**](#PostKnowledgeKnowledgebaseParseJobImport) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId}/import | Import the parsed articles |
| [**PostKnowledgeKnowledgebaseParseJobs**](#PostKnowledgeKnowledgebaseParseJobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs | Create parse job |
| [**PostKnowledgeKnowledgebaseSourcesSalesforce**](#PostKnowledgeKnowledgebaseSourcesSalesforce) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce | Create Salesforce Knowledge integration source |
| [**PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync**](#PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}/sync | Start sync on Salesforce Knowledge integration source |
| [**PostKnowledgeKnowledgebaseSourcesServicenow**](#PostKnowledgeKnowledgebaseSourcesServicenow) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow | Create ServiceNow Knowledge integration source |
| [**PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync**](#PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId}/sync | Start synchronization on ServiceNow Knowledge integration source |
| [**PostKnowledgeKnowledgebaseSynchronizeJobs**](#PostKnowledgeKnowledgebaseSynchronizeJobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/synchronize/jobs | Create synchronization job |
| [**PostKnowledgeKnowledgebaseUploadsUrlsJobs**](#PostKnowledgeKnowledgebaseUploadsUrlsJobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs | Create content upload from URL job |
| [**PostKnowledgeKnowledgebases**](#PostKnowledgeKnowledgebases) | **Post** /api/v2/knowledge/knowledgebases | Create new knowledge base |
| [**PostKnowledgeSearchPreview**](#PostKnowledgeSearchPreview) | **Post** /api/v2/knowledge/search/preview | Get Knowledge Search Preview |
| [**PostKnowledgeSettings**](#PostKnowledgeSettings) | **Post** /api/v2/knowledge/settings | Create Knowledge setting. |
| [**PutKnowledgeKnowledgebaseSourcesSalesforceSourceId**](#PutKnowledgeKnowledgebaseSourcesSalesforceSourceId) | **Put** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId} | Update Salesforce Knowledge integration source |
| [**PutKnowledgeKnowledgebaseSourcesServicenowSourceId**](#PutKnowledgeKnowledgebaseSourcesServicenowSourceId) | **Put** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId} | Update ServiceNow Knowledge integration source |



## DeleteKnowledgeKnowledgebase

> [**KnowledgeBase**](KnowledgeBase) DeleteKnowledgeKnowledgebase (string knowledgeBaseId)


Delete knowledge base

Requires ALL permissions: 

* knowledge:knowledgebase:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID

            try
            { 
                // Delete knowledge base
                KnowledgeBase result = apiInstance.DeleteKnowledgeKnowledgebase(knowledgeBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |

### Return type

[**KnowledgeBase**](KnowledgeBase)


## DeleteKnowledgeKnowledgebaseCategory

> [**CategoryResponse**](CategoryResponse) DeleteKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId)


Delete category

Requires ALL permissions: 

* knowledge:category:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var categoryId = categoryId_example;  // string | Category ID

            try
            { 
                // Delete category
                CategoryResponse result = apiInstance.DeleteKnowledgeKnowledgebaseCategory(knowledgeBaseId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **categoryId** | **string**| Category ID |  |

### Return type

[**CategoryResponse**](CategoryResponse)


## DeleteKnowledgeKnowledgebaseDocument

> void DeleteKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId)


Delete document.

Requires ALL permissions: 

* knowledge:document:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.

            try
            { 
                // Delete document.
                apiInstance.DeleteKnowledgeKnowledgebaseDocument(knowledgeBaseId, documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseDocumentVariation

> void DeleteKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId)


Delete a variation for a document.

Requires ANY permissions: 

* knowledge:document:delete
* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseDocumentVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var documentVariationId = documentVariationId_example;  // string | Globally unique identifier for a document variation.
            var documentId = documentId_example;  // string | Globally unique identifier for a document.
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for a knowledge base.

            try
            { 
                // Delete a variation for a document.
                apiInstance.DeleteKnowledgeKnowledgebaseDocumentVariation(documentVariationId, documentId, knowledgeBaseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseDocumentVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentVariationId** | **string**| Globally unique identifier for a document variation. |  |
| **documentId** | **string**| Globally unique identifier for a document. |  |
| **knowledgeBaseId** | **string**| Globally unique identifier for a knowledge base. |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseExportJob

> void DeleteKnowledgeKnowledgebaseExportJob (string knowledgeBaseId, string exportJobId)


Delete export job

Requires ALL permissions: 

* knowledge:exportJob:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseExportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var exportJobId = exportJobId_example;  // string | Export job ID

            try
            { 
                // Delete export job
                apiInstance.DeleteKnowledgeKnowledgebaseExportJob(knowledgeBaseId, exportJobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseExportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **exportJobId** | **string**| Export job ID |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseImportJob

> void DeleteKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId)


Delete import job

Requires ALL permissions: 

* knowledge:importJob:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseImportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var importJobId = importJobId_example;  // string | Import job ID

            try
            { 
                // Delete import job
                apiInstance.DeleteKnowledgeKnowledgebaseImportJob(knowledgeBaseId, importJobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **importJobId** | **string**| Import job ID |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseLabel

> [**LabelResponse**](LabelResponse) DeleteKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId)


Delete label

Requires ALL permissions: 

* knowledge:label:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var labelId = labelId_example;  // string | Label ID

            try
            { 
                // Delete label
                LabelResponse result = apiInstance.DeleteKnowledgeKnowledgebaseLabel(knowledgeBaseId, labelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **labelId** | **string**| Label ID |  |

### Return type

[**LabelResponse**](LabelResponse)


## DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId

> void DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId (string knowledgeBaseId, string sourceId)


Delete Salesforce Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID

            try
            { 
                // Delete Salesforce Knowledge integration source
                apiInstance.DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId(knowledgeBaseId, sourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId

> void DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId (string knowledgeBaseId, string sourceId)


Delete ServiceNow Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseSourcesServicenowSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID

            try
            { 
                // Delete ServiceNow Knowledge integration source
                apiInstance.DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId(knowledgeBaseId, sourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseSourcesServicenowSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |

### Return type

void (empty response body)


## DeleteKnowledgeKnowledgebaseSynchronizeJob

> void DeleteKnowledgeKnowledgebaseSynchronizeJob (string knowledgeBaseId, string syncJobId)


Delete synchronization job

Requires ALL permissions: 

* knowledge:syncJob:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseSynchronizeJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var syncJobId = syncJobId_example;  // string | Synchronization job ID

            try
            { 
                // Delete synchronization job
                apiInstance.DeleteKnowledgeKnowledgebaseSynchronizeJob(knowledgeBaseId, syncJobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseSynchronizeJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **syncJobId** | **string**| Synchronization job ID |  |

### Return type

void (empty response body)


## DeleteKnowledgeSetting

> void DeleteKnowledgeSetting (string knowledgeSettingId)


Delete Knowledge setting.

Requires ALL permissions: 

* knowledge:knowledgeSetting:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeSettingId = knowledgeSettingId_example;  // string | Knowledge Setting ID.

            try
            { 
                // Delete Knowledge setting.
                apiInstance.DeleteKnowledgeSetting(knowledgeSettingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeSettingId** | **string**| Knowledge Setting ID. |  |

### Return type

void (empty response body)


## GetKnowledgeGuestSessionCategories

> [**GuestCategoryResponseListing**](GuestCategoryResponseListing) GetKnowledgeGuestSessionCategories (string sessionId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null)


Get categories

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
    public class GetKnowledgeGuestSessionCategoriesExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var parentId = parentId_example;  // string | If specified, retrieves the children categories by parent category ID. (optional) 
            var isRoot = true;  // bool? | If specified, retrieves only the root categories. (optional) 
            var name = name_example;  // string | Filter to return the categories that starts with the given category name. (optional) 
            var sortBy = sortBy_example;  // string | Name: sort by category names alphabetically; Hierarchy: sort by the full path of hierarchical category names alphabetically (optional)  (default to Name)
            var expand = expand_example;  // string | The specified entity attribute will be filled. Supported value:\"Ancestors\": every ancestors will be filled via the parent attribute recursively,but only the id, name, parentId will be present for the ancestors. (optional) 
            var includeDocumentCount = true;  // bool? | If specified, retrieves the number of documents related to category. (optional) 

            try
            { 
                // Get categories
                GuestCategoryResponseListing result = apiInstance.GetKnowledgeGuestSessionCategories(sessionId, before, after, pageSize, parentId, isRoot, name, sortBy, expand, includeDocumentCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeGuestSessionCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **parentId** | **string**| If specified, retrieves the children categories by parent category ID. | [optional]  |
| **isRoot** | **bool?**| If specified, retrieves only the root categories. | [optional]  |
| **name** | **string**| Filter to return the categories that starts with the given category name. | [optional]  |
| **sortBy** | **string**| Name: sort by category names alphabetically; Hierarchy: sort by the full path of hierarchical category names alphabetically | [optional] [default to Name]<br />**Values**: Name, Hierarchy |
| **expand** | **string**| The specified entity attribute will be filled. Supported value:\&quot;Ancestors\&quot;: every ancestors will be filled via the parent attribute recursively,but only the id, name, parentId will be present for the ancestors. | [optional]  |
| **includeDocumentCount** | **bool?**| If specified, retrieves the number of documents related to category. | [optional]  |

### Return type

[**GuestCategoryResponseListing**](GuestCategoryResponseListing)


## GetKnowledgeGuestSessionDocument

> [**KnowledgeGuestDocumentResponse**](KnowledgeGuestDocumentResponse) GetKnowledgeGuestSessionDocument (string sessionId, string documentId)


Get a knowledge document by ID.

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
    public class GetKnowledgeGuestSessionDocumentExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var documentId = documentId_example;  // string | Document ID

            try
            { 
                // Get a knowledge document by ID.
                KnowledgeGuestDocumentResponse result = apiInstance.GetKnowledgeGuestSessionDocument(sessionId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeGuestSessionDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **documentId** | **string**| Document ID |  |

### Return type

[**KnowledgeGuestDocumentResponse**](KnowledgeGuestDocumentResponse)


## GetKnowledgeGuestSessionDocuments

> [**KnowledgeGuestDocumentResponseListing**](KnowledgeGuestDocumentResponseListing) GetKnowledgeGuestSessionDocuments (string sessionId, List<string> categoryId = null, int? pageSize = null)


Get documents.

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
    public class GetKnowledgeGuestSessionDocumentsExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var categoryId = new List<string>(); // List<string> | If specified, retrieves documents associated with category ids, comma separated values expected. (optional) 
            var pageSize = 56;  // int? | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get documents.
                KnowledgeGuestDocumentResponseListing result = apiInstance.GetKnowledgeGuestSessionDocuments(sessionId, categoryId, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeGuestSessionDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **categoryId** | [**List<string>**](string)| If specified, retrieves documents associated with category ids, comma separated values expected. | [optional]  |
| **pageSize** | **int?**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**KnowledgeGuestDocumentResponseListing**](KnowledgeGuestDocumentResponseListing)


## GetKnowledgeIntegrationOptions

> [**KnowledgeIntegrationOptionsResponse**](KnowledgeIntegrationOptionsResponse) GetKnowledgeIntegrationOptions (string integrationId, List<string> knowledgeBaseIds = null)


Get sync options available for a knowledge-connect integration

Requires ALL permissions: 

* knowledge:integrationOptions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeIntegrationOptionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var knowledgeBaseIds = new List<string>(); // List<string> | Narrowing down filtering option results by knowledge base. (optional) 

            try
            { 
                // Get sync options available for a knowledge-connect integration
                KnowledgeIntegrationOptionsResponse result = apiInstance.GetKnowledgeIntegrationOptions(integrationId, knowledgeBaseIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeIntegrationOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **knowledgeBaseIds** | [**List<string>**](string)| Narrowing down filtering option results by knowledge base. | [optional]  |

### Return type

[**KnowledgeIntegrationOptionsResponse**](KnowledgeIntegrationOptionsResponse)


## GetKnowledgeKnowledgebase

> [**KnowledgeBase**](KnowledgeBase) GetKnowledgeKnowledgebase (string knowledgeBaseId)


Get knowledge base

Requires ALL permissions: 

* knowledge:knowledgebase:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID

            try
            { 
                // Get knowledge base
                KnowledgeBase result = apiInstance.GetKnowledgeKnowledgebase(knowledgeBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |

### Return type

[**KnowledgeBase**](KnowledgeBase)


## GetKnowledgeKnowledgebaseCategories

> [**CategoryResponseListing**](CategoryResponseListing) GetKnowledgeKnowledgebaseCategories (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null)


Get categories

Requires ALL permissions: 

* knowledge:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var parentId = parentId_example;  // string | If specified, retrieves the children categories by parent category ID. (optional) 
            var isRoot = true;  // bool? | If specified, retrieves only the root categories. (optional) 
            var name = name_example;  // string | Filter to return the categories that starts with the given category name. (optional) 
            var sortBy = sortBy_example;  // string | Name: sort by category names alphabetically; Hierarchy: sort by the full path of hierarchical category names alphabetically (optional)  (default to Name)
            var expand = expand_example;  // string | The specified entity attribute will be filled. Supported value:\"Ancestors\": every ancestors will be filled via the parent attribute recursively,but only the id, name, parentId will be present for the ancestors. (optional) 
            var includeDocumentCount = true;  // bool? | If specified, retrieves the number of documents related to category. (optional) 

            try
            { 
                // Get categories
                CategoryResponseListing result = apiInstance.GetKnowledgeKnowledgebaseCategories(knowledgeBaseId, before, after, pageSize, parentId, isRoot, name, sortBy, expand, includeDocumentCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **parentId** | **string**| If specified, retrieves the children categories by parent category ID. | [optional]  |
| **isRoot** | **bool?**| If specified, retrieves only the root categories. | [optional]  |
| **name** | **string**| Filter to return the categories that starts with the given category name. | [optional]  |
| **sortBy** | **string**| Name: sort by category names alphabetically; Hierarchy: sort by the full path of hierarchical category names alphabetically | [optional] [default to Name]<br />**Values**: Name, Hierarchy |
| **expand** | **string**| The specified entity attribute will be filled. Supported value:\&quot;Ancestors\&quot;: every ancestors will be filled via the parent attribute recursively,but only the id, name, parentId will be present for the ancestors. | [optional]  |
| **includeDocumentCount** | **bool?**| If specified, retrieves the number of documents related to category. | [optional]  |

### Return type

[**CategoryResponseListing**](CategoryResponseListing)


## GetKnowledgeKnowledgebaseCategory

> [**CategoryResponse**](CategoryResponse) GetKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId)


Get category

Requires ALL permissions: 

* knowledge:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var categoryId = categoryId_example;  // string | Category ID

            try
            { 
                // Get category
                CategoryResponse result = apiInstance.GetKnowledgeKnowledgebaseCategory(knowledgeBaseId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **categoryId** | **string**| Category ID |  |

### Return type

[**CategoryResponse**](CategoryResponse)


## GetKnowledgeKnowledgebaseDocument

> [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse) GetKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId, List<string> expand = null, string state = null)


Get document.

Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. Max No. of variations that can be returned on expand is 20. (optional) 
            var state = state_example;  // string | \"when state is \"Draft\", draft version of the document is returned,otherwise by default published version is returned in the response. (optional) 

            try
            { 
                // Get document.
                KnowledgeDocumentResponse result = apiInstance.GetKnowledgeKnowledgebaseDocument(knowledgeBaseId, documentId, expand, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. Max No. of variations that can be returned on expand is 20. | [optional] <br />**Values**: category, labels, variations |
| **state** | **string**| \&quot;when state is \&quot;Draft\&quot;, draft version of the document is returned,otherwise by default published version is returned in the response. | [optional] <br />**Values**: Draft, Published |

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse)


## GetKnowledgeKnowledgebaseDocumentFeedback

> [**KnowledgeDocumentFeedbackResponseListing**](KnowledgeDocumentFeedbackResponseListing) GetKnowledgeKnowledgebaseDocumentFeedback (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, bool? onlyCommented = null, string documentVersionId = null, string documentVariationId = null, string appType = null, string queryType = null, string userId = null, string queueId = null, string state = null)


Get a list of feedback records given on a document

Requires ANY permissions: 

* knowledge:feedback:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var onlyCommented = true;  // bool? | If true, only feedback records that have comment are returned. If false, feedback records with and without comment are returned. Default: false. (optional) 
            var documentVersionId = documentVersionId_example;  // string | Document version ID to filter by. Supported only if onlyCommented=true is set. (optional) 
            var documentVariationId = documentVariationId_example;  // string | Document variation ID to filter by. Supported only if onlyCommented=true is set. (optional) 
            var appType = appType_example;  // string | Application type to filter by. Supported only if onlyCommented=true is set. (optional) 
            var queryType = queryType_example;  // string | Query type to filter by. Supported only if onlyCommented=true is set. (optional) 
            var userId = userId_example;  // string | The ID of the user, who created the feedback, to filter by. Supported only if onlyCommented=true is set. (optional) 
            var queueId = queueId_example;  // string | Queue ID to filter by. Supported only if onlyCommented=true is set. (optional) 
            var state = state_example;  // string | State to filter by. Supported only if onlyCommented=true is set. Default: Final (optional) 

            try
            { 
                // Get a list of feedback records given on a document
                KnowledgeDocumentFeedbackResponseListing result = apiInstance.GetKnowledgeKnowledgebaseDocumentFeedback(knowledgeBaseId, documentId, before, after, pageSize, onlyCommented, documentVersionId, documentVariationId, appType, queryType, userId, queueId, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **onlyCommented** | **bool?**| If true, only feedback records that have comment are returned. If false, feedback records with and without comment are returned. Default: false. | [optional]  |
| **documentVersionId** | **string**| Document version ID to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **documentVariationId** | **string**| Document variation ID to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **appType** | **string**| Application type to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional] <br />**Values**: Assistant, BotFlow, MessengerKnowledgeApp, SmartAdvisor, SupportCenter |
| **queryType** | **string**| Query type to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional] <br />**Values**: Unknown, Article, AutoSearch, Category, ManualSearch, Recommendation, Suggestion, ExpandedArticle |
| **userId** | **string**| The ID of the user, who created the feedback, to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **queueId** | **string**| Queue ID to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **state** | **string**| State to filter by. Supported only if onlyCommented&#x3D;true is set. Default: Final | [optional] <br />**Values**: All, Draft, Final |

### Return type

[**KnowledgeDocumentFeedbackResponseListing**](KnowledgeDocumentFeedbackResponseListing)


## GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId

> [**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse) GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId (string knowledgeBaseId, string documentId, string feedbackId)


Get a single feedback record given on a document

Requires ANY permissions: 

* knowledge:feedback:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var feedbackId = feedbackId_example;  // string | Feedback ID.

            try
            { 
                // Get a single feedback record given on a document
                KnowledgeDocumentFeedbackResponse result = apiInstance.GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId(knowledgeBaseId, documentId, feedbackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **feedbackId** | **string**| Feedback ID. |  |

### Return type

[**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse)


## GetKnowledgeKnowledgebaseDocumentVariation

> [**DocumentVariationResponse**](DocumentVariationResponse) GetKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId, string documentState = null, List<string> expand = null)


Get a variation for a document.

Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var documentVariationId = documentVariationId_example;  // string | Globally unique identifier for a document variation.
            var documentId = documentId_example;  // string | Globally unique identifier for a document.
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for a knowledge base.
            var documentState = documentState_example;  // string | The state of the document. (optional) 
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get a variation for a document.
                DocumentVariationResponse result = apiInstance.GetKnowledgeKnowledgebaseDocumentVariation(documentVariationId, documentId, knowledgeBaseId, documentState, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentVariationId** | **string**| Globally unique identifier for a document variation. |  |
| **documentId** | **string**| Globally unique identifier for a document. |  |
| **knowledgeBaseId** | **string**| Globally unique identifier for a knowledge base. |  |
| **documentState** | **string**| The state of the document. | [optional] <br />**Values**: Draft, Published |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: contentUrl |

### Return type

[**DocumentVariationResponse**](DocumentVariationResponse)


## GetKnowledgeKnowledgebaseDocumentVariations

> [**DocumentVariationResponseListing**](DocumentVariationResponseListing) GetKnowledgeKnowledgebaseDocumentVariations (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, string documentState = null, List<string> expand = null)


Get variations for a document.

Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVariationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var documentState = documentState_example;  // string | The state of the document. (optional) 
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get variations for a document.
                DocumentVariationResponseListing result = apiInstance.GetKnowledgeKnowledgebaseDocumentVariations(knowledgeBaseId, documentId, before, after, pageSize, documentState, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVariations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **documentState** | **string**| The state of the document. | [optional] <br />**Values**: Draft, Published |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: contentUrl |

### Return type

[**DocumentVariationResponseListing**](DocumentVariationResponseListing)


## GetKnowledgeKnowledgebaseDocumentVersion

> [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion) GetKnowledgeKnowledgebaseDocumentVersion (string knowledgeBaseId, string documentId, string versionId, List<string> expand = null)


Get document version.

Requires ALL permissions: 

* knowledge:documentVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var versionId = versionId_example;  // string | Globally unique identifier for the document version.
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get document version.
                KnowledgeDocumentVersion result = apiInstance.GetKnowledgeKnowledgebaseDocumentVersion(knowledgeBaseId, documentId, versionId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **versionId** | **string**| Globally unique identifier for the document version. |  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels |

### Return type

[**KnowledgeDocumentVersion**](KnowledgeDocumentVersion)


## GetKnowledgeKnowledgebaseDocumentVersionVariation

> [**KnowledgeDocumentVersionVariation**](KnowledgeDocumentVersionVariation) GetKnowledgeKnowledgebaseDocumentVersionVariation (string knowledgeBaseId, string documentId, string versionId, string variationId)


Get variation for the given document version.

Requires ALL permissions: 

* knowledge:documentVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVersionVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var versionId = versionId_example;  // string | Globally unique identifier for the document version.
            var variationId = variationId_example;  // string | Globally unique identifier for the document version variation.

            try
            { 
                // Get variation for the given document version.
                KnowledgeDocumentVersionVariation result = apiInstance.GetKnowledgeKnowledgebaseDocumentVersionVariation(knowledgeBaseId, documentId, versionId, variationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVersionVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **versionId** | **string**| Globally unique identifier for the document version. |  |
| **variationId** | **string**| Globally unique identifier for the document version variation. |  |

### Return type

[**KnowledgeDocumentVersionVariation**](KnowledgeDocumentVersionVariation)


## GetKnowledgeKnowledgebaseDocumentVersionVariations

> [**KnowledgeDocumentVersionVariationListing**](KnowledgeDocumentVersionVariationListing) GetKnowledgeKnowledgebaseDocumentVersionVariations (string knowledgeBaseId, string documentId, string versionId, string before = null, string after = null, string pageSize = null)


Get variations for the given document version.

Requires ALL permissions: 

* knowledge:documentVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVersionVariationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var versionId = versionId_example;  // string | Globally unique identifier for the document version.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get variations for the given document version.
                KnowledgeDocumentVersionVariationListing result = apiInstance.GetKnowledgeKnowledgebaseDocumentVersionVariations(knowledgeBaseId, documentId, versionId, before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVersionVariations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **versionId** | **string**| Globally unique identifier for the document version. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**KnowledgeDocumentVersionVariationListing**](KnowledgeDocumentVersionVariationListing)


## GetKnowledgeKnowledgebaseDocumentVersions

> [**KnowledgeDocumentVersionListing**](KnowledgeDocumentVersionListing) GetKnowledgeKnowledgebaseDocumentVersions (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, List<string> expand = null)


Get document versions.

Requires ALL permissions: 

* knowledge:documentVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get document versions.
                KnowledgeDocumentVersionListing result = apiInstance.GetKnowledgeKnowledgebaseDocumentVersions(knowledgeBaseId, documentId, before, after, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocumentVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels |

### Return type

[**KnowledgeDocumentVersionListing**](KnowledgeDocumentVersionListing)


## GetKnowledgeKnowledgebaseDocuments

> [**KnowledgeDocumentResponseListing**](KnowledgeDocumentResponseListing) GetKnowledgeKnowledgebaseDocuments (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, List<string> documentId = null, List<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, List<string> labelIds = null, List<string> expand = null, List<string> externalIds = null)


Get documents.

Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var interval = interval_example;  // string | Retrieves the documents modified in specified date and time range. If the after and before cursor parameters are within this interval, it would return valid data, otherwise it throws an error.The dates in the interval are represented in ISO-8601 format: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ (optional) 
            var documentId = new List<string>(); // List<string> | Retrieves the specified documents, comma separated values expected. (optional) 
            var categoryId = new List<string>(); // List<string> | If specified, retrieves documents associated with category ids, comma separated values expected. (optional) 
            var includeSubcategories = true;  // bool? | Works along with 'categoryId' query parameter. If specified, retrieves documents associated with category ids and its children categories. (optional) 
            var includeDrafts = true;  // bool? | If includeDrafts is true, Documents in the draft state are also returned in the response. (optional) 
            var labelIds = new List<string>(); // List<string> | If specified, retrieves documents associated with label ids, comma separated values expected. (optional) 
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 
            var externalIds = new List<string>(); // List<string> | If specified, retrieves documents associated with external ids, comma separated values expected. (optional) 

            try
            { 
                // Get documents.
                KnowledgeDocumentResponseListing result = apiInstance.GetKnowledgeKnowledgebaseDocuments(knowledgeBaseId, before, after, pageSize, interval, documentId, categoryId, includeSubcategories, includeDrafts, labelIds, expand, externalIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **interval** | **string**| Retrieves the documents modified in specified date and time range. If the after and before cursor parameters are within this interval, it would return valid data, otherwise it throws an error.The dates in the interval are represented in ISO-8601 format: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ | [optional]  |
| **documentId** | [**List<string>**](string)| Retrieves the specified documents, comma separated values expected. | [optional]  |
| **categoryId** | [**List<string>**](string)| If specified, retrieves documents associated with category ids, comma separated values expected. | [optional]  |
| **includeSubcategories** | **bool?**| Works along with &#39;categoryId&#39; query parameter. If specified, retrieves documents associated with category ids and its children categories. | [optional]  |
| **includeDrafts** | **bool?**| If includeDrafts is true, Documents in the draft state are also returned in the response. | [optional]  |
| **labelIds** | [**List<string>**](string)| If specified, retrieves documents associated with label ids, comma separated values expected. | [optional]  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels |
| **externalIds** | [**List<string>**](string)| If specified, retrieves documents associated with external ids, comma separated values expected. | [optional]  |

### Return type

[**KnowledgeDocumentResponseListing**](KnowledgeDocumentResponseListing)


## GetKnowledgeKnowledgebaseExportJob

> [**KnowledgeExportJobResponse**](KnowledgeExportJobResponse) GetKnowledgeKnowledgebaseExportJob (string knowledgeBaseId, string exportJobId)


Get export job report

Requires ALL permissions: 

* knowledge:exportJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseExportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var exportJobId = exportJobId_example;  // string | Export job ID

            try
            { 
                // Get export job report
                KnowledgeExportJobResponse result = apiInstance.GetKnowledgeKnowledgebaseExportJob(knowledgeBaseId, exportJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseExportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **exportJobId** | **string**| Export job ID |  |

### Return type

[**KnowledgeExportJobResponse**](KnowledgeExportJobResponse)


## GetKnowledgeKnowledgebaseImportJob

> [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse) GetKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId, List<string> expand = null)


Get import job report

Requires ALL permissions: 

* knowledge:importJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseImportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var importJobId = importJobId_example;  // string | Import job ID
            var expand = new List<string>(); // List<string> | If expand contains 'urls' downloadURL and failedEntitiesURL will be filled. (optional) 

            try
            { 
                // Get import job report
                KnowledgeImportJobResponse result = apiInstance.GetKnowledgeKnowledgebaseImportJob(knowledgeBaseId, importJobId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **importJobId** | **string**| Import job ID |  |
| **expand** | [**List<string>**](string)| If expand contains &#39;urls&#39; downloadURL and failedEntitiesURL will be filled. | [optional] <br />**Values**: urls |

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse)


## GetKnowledgeKnowledgebaseLabel

> [**LabelResponse**](LabelResponse) GetKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId)


Get label

Requires ALL permissions: 

* knowledge:label:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var labelId = labelId_example;  // string | Label ID

            try
            { 
                // Get label
                LabelResponse result = apiInstance.GetKnowledgeKnowledgebaseLabel(knowledgeBaseId, labelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **labelId** | **string**| Label ID |  |

### Return type

[**LabelResponse**](LabelResponse)


## GetKnowledgeKnowledgebaseLabels

> [**LabelListing**](LabelListing) GetKnowledgeKnowledgebaseLabels (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null)


Get labels

Requires ALL permissions: 

* knowledge:label:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLabelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Filter to return the labels that contains the given phrase in the name. (optional) 
            var includeDocumentCount = true;  // bool? | If specified, retrieves the number of documents related to label. (optional) 

            try
            { 
                // Get labels
                LabelListing result = apiInstance.GetKnowledgeKnowledgebaseLabels(knowledgeBaseId, before, after, pageSize, name, includeDocumentCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Filter to return the labels that contains the given phrase in the name. | [optional]  |
| **includeDocumentCount** | **bool?**| If specified, retrieves the number of documents related to label. | [optional]  |

### Return type

[**LabelListing**](LabelListing)


## GetKnowledgeKnowledgebaseOperations

> [**OperationListing**](OperationListing) GetKnowledgeKnowledgebaseOperations (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, List<string> userId = null, List<string> type = null, List<string> status = null, string interval = null, List<string> sourceId = null)


Get operations

Requires ALL permissions: 

* knowledge:importExportOperationsList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseOperationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var userId = new List<string>(); // List<string> | If specified, retrieves operations associated with user ids, comma separated values expected. (optional) 
            var type = new List<string>(); // List<string> | If specified, retrieves operations with specified operation type, comma separated values expected. (optional) 
            var status = new List<string>(); // List<string> | If specified, retrieves operations with specified operation status, comma separated values expected. (optional) 
            var interval = interval_example;  // string | Retrieves the operations modified in specified date and time range. If the after and before cursor parameters are within this interval, it would return valid data, otherwise it throws an error.The dates in the interval are represented in ISO-8601 format: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ (optional) 
            var sourceId = new List<string>(); // List<string> | If specified, retrieves operations associated with source ids, comma separated values expected. (optional) 

            try
            { 
                // Get operations
                OperationListing result = apiInstance.GetKnowledgeKnowledgebaseOperations(knowledgeBaseId, before, after, pageSize, userId, type, status, interval, sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **userId** | [**List<string>**](string)| If specified, retrieves operations associated with user ids, comma separated values expected. | [optional]  |
| **type** | [**List<string>**](string)| If specified, retrieves operations with specified operation type, comma separated values expected. | [optional] <br />**Values**: Export, Import, Parse, Sync |
| **status** | [**List<string>**](string)| If specified, retrieves operations with specified operation status, comma separated values expected. | [optional]  |
| **interval** | **string**| Retrieves the operations modified in specified date and time range. If the after and before cursor parameters are within this interval, it would return valid data, otherwise it throws an error.The dates in the interval are represented in ISO-8601 format: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ | [optional]  |
| **sourceId** | [**List<string>**](string)| If specified, retrieves operations associated with source ids, comma separated values expected. | [optional]  |

### Return type

[**OperationListing**](OperationListing)


## GetKnowledgeKnowledgebaseOperationsUsersQuery

> [**OperationCreatorUserResponse**](OperationCreatorUserResponse) GetKnowledgeKnowledgebaseOperationsUsersQuery (string knowledgeBaseId)


Get ids of operation creator users and oauth clients

Requires ALL permissions: 

* knowledge:importExportOperationsList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseOperationsUsersQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID

            try
            { 
                // Get ids of operation creator users and oauth clients
                OperationCreatorUserResponse result = apiInstance.GetKnowledgeKnowledgebaseOperationsUsersQuery(knowledgeBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseOperationsUsersQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |

### Return type

[**OperationCreatorUserResponse**](OperationCreatorUserResponse)


## GetKnowledgeKnowledgebaseParseJob

> [**KnowledgeParseJobResponse**](KnowledgeParseJobResponse) GetKnowledgeKnowledgebaseParseJob (string knowledgeBaseId, string parseJobId, List<string> expand = null)


Get parse job report

Requires ALL permissions: 

* knowledge:importJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseParseJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var parseJobId = parseJobId_example;  // string | Parse job ID
            var expand = new List<string>(); // List<string> | If expand contains 'urls' downloadURL and failedEntitiesURL will be filled. (optional) 

            try
            { 
                // Get parse job report
                KnowledgeParseJobResponse result = apiInstance.GetKnowledgeKnowledgebaseParseJob(knowledgeBaseId, parseJobId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseParseJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **parseJobId** | **string**| Parse job ID |  |
| **expand** | [**List<string>**](string)| If expand contains &#39;urls&#39; downloadURL and failedEntitiesURL will be filled. | [optional] <br />**Values**: urls |

### Return type

[**KnowledgeParseJobResponse**](KnowledgeParseJobResponse)


## GetKnowledgeKnowledgebaseSources

> [**List&lt;SourceBaseResponse&gt;**](SourceBaseResponse) GetKnowledgeKnowledgebaseSources (string knowledgeBaseId, string type = null, List<string> expand = null, List<string> ids = null)


Get Knowledge integration sources

Requires ALL permissions: 

* knowledge:integrationSource:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseSourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var type = type_example;  // string | If specified, retrieves integration sources with specified integration type. (optional) 
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 
            var ids = new List<string>(); // List<string> | If specified, retrieves integration sources with specified IDs. (optional) 

            try
            { 
                // Get Knowledge integration sources
                List<SourceBaseResponse> result = apiInstance.GetKnowledgeKnowledgebaseSources(knowledgeBaseId, type, expand, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseSources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **type** | **string**| If specified, retrieves integration sources with specified integration type. | [optional] <br />**Values**: Salesforce, ServiceNow |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: lastsync |
| **ids** | [**List<string>**](string)| If specified, retrieves integration sources with specified IDs. | [optional]  |

### Return type

[**List<SourceBaseResponse>**](SourceBaseResponse)


## GetKnowledgeKnowledgebaseSourcesSalesforceSourceId

> [**SalesforceSourceResponse**](SalesforceSourceResponse) GetKnowledgeKnowledgebaseSourcesSalesforceSourceId (string knowledgeBaseId, string sourceId, List<string> expand = null)


Get Salesforce Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseSourcesSalesforceSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get Salesforce Knowledge integration source
                SalesforceSourceResponse result = apiInstance.GetKnowledgeKnowledgebaseSourcesSalesforceSourceId(knowledgeBaseId, sourceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseSourcesSalesforceSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: lastsync |

### Return type

[**SalesforceSourceResponse**](SalesforceSourceResponse)


## GetKnowledgeKnowledgebaseSourcesServicenowSourceId

> [**ServiceNowSourceResponse**](ServiceNowSourceResponse) GetKnowledgeKnowledgebaseSourcesServicenowSourceId (string knowledgeBaseId, string sourceId, List<string> expand = null)


Get ServiceNow Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseSourcesServicenowSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var expand = new List<string>(); // List<string> | The specified entity attributes will be filled. Comma separated values expected. (optional) 

            try
            { 
                // Get ServiceNow Knowledge integration source
                ServiceNowSourceResponse result = apiInstance.GetKnowledgeKnowledgebaseSourcesServicenowSourceId(knowledgeBaseId, sourceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseSourcesServicenowSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **expand** | [**List<string>**](string)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: lastsync |

### Return type

[**ServiceNowSourceResponse**](ServiceNowSourceResponse)


## GetKnowledgeKnowledgebaseSynchronizeJob

> [**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse) GetKnowledgeKnowledgebaseSynchronizeJob (string knowledgeBaseId, string syncJobId)


Get synchronization job report

Requires ALL permissions: 

* knowledge:syncJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseSynchronizeJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var syncJobId = syncJobId_example;  // string | Synchronization job ID

            try
            { 
                // Get synchronization job report
                KnowledgeSyncJobResponse result = apiInstance.GetKnowledgeKnowledgebaseSynchronizeJob(knowledgeBaseId, syncJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseSynchronizeJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **syncJobId** | **string**| Synchronization job ID |  |

### Return type

[**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse)


## GetKnowledgeKnowledgebaseUnansweredGroup

> [**UnansweredGroup**](UnansweredGroup) GetKnowledgeKnowledgebaseUnansweredGroup (string knowledgeBaseId, string groupId, string app = null, String dateStart = null, String dateEnd = null)


Get knowledge base unanswered group for a particular groupId

Requires ALL permissions: 

* knowledge:groups:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseUnansweredGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var groupId = groupId_example;  // string | The ID of the group to be retrieved.
            var app = app_example;  // string | The app value to be used for filtering phrases. (optional) 
            var dateStart = 2013-10-20;  // String | The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Get knowledge base unanswered group for a particular groupId
                UnansweredGroup result = apiInstance.GetKnowledgeKnowledgebaseUnansweredGroup(knowledgeBaseId, groupId, app, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseUnansweredGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **groupId** | **string**| The ID of the group to be retrieved. |  |
| **app** | **string**| The app value to be used for filtering phrases. | [optional] <br />**Values**: SupportCenter, MessengerKnowledgeApp, BotFlow, Assistant, SmartAdvisor |
| **dateStart** | **String**| The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**UnansweredGroup**](UnansweredGroup)


## GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup

> [**UnansweredPhraseGroup**](UnansweredPhraseGroup) GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup (string knowledgeBaseId, string groupId, string phraseGroupId, string app = null, String dateStart = null, String dateEnd = null)


Get knowledge base unanswered phrase group for a particular phraseGroupId

Requires ALL permissions: 

* knowledge:groups:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var groupId = groupId_example;  // string | The ID of the group to be retrieved.
            var phraseGroupId = phraseGroupId_example;  // string | The ID of the phraseGroup to be retrieved.
            var app = app_example;  // string | The app value to be used for filtering phrases. (optional) 
            var dateStart = 2013-10-20;  // String | The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Get knowledge base unanswered phrase group for a particular phraseGroupId
                UnansweredPhraseGroup result = apiInstance.GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup(knowledgeBaseId, groupId, phraseGroupId, app, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **groupId** | **string**| The ID of the group to be retrieved. |  |
| **phraseGroupId** | **string**| The ID of the phraseGroup to be retrieved. |  |
| **app** | **string**| The app value to be used for filtering phrases. | [optional] <br />**Values**: SupportCenter, MessengerKnowledgeApp, BotFlow, Assistant, SmartAdvisor |
| **dateStart** | **String**| The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**UnansweredPhraseGroup**](UnansweredPhraseGroup)


## GetKnowledgeKnowledgebaseUnansweredGroups

> [**UnansweredGroups**](UnansweredGroups) GetKnowledgeKnowledgebaseUnansweredGroups (string knowledgeBaseId, string app = null, String dateStart = null, String dateEnd = null)


Get knowledge base unanswered groups

Requires ALL permissions: 

* knowledge:groups:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseUnansweredGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var app = app_example;  // string | The app value to be used for filtering phrases. (optional) 
            var dateStart = 2013-10-20;  // String | The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Get knowledge base unanswered groups
                UnansweredGroups result = apiInstance.GetKnowledgeKnowledgebaseUnansweredGroups(knowledgeBaseId, app, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseUnansweredGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **app** | **string**| The app value to be used for filtering phrases. | [optional] <br />**Values**: SupportCenter, MessengerKnowledgeApp, BotFlow, Assistant, SmartAdvisor |
| **dateStart** | **String**| The start date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| The end date to be used for filtering phrases. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**UnansweredGroups**](UnansweredGroups)


## GetKnowledgeKnowledgebaseUploadsUrlsJob

> [**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse) GetKnowledgeKnowledgebaseUploadsUrlsJob (string knowledgeBaseId, string jobId)


Get content upload from URL job status

Requires ALL permissions: 

* knowledge:uploadSourceUrlJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseUploadsUrlsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var jobId = jobId_example;  // string | Upload job ID

            try
            { 
                // Get content upload from URL job status
                GetUploadSourceUrlJobStatusResponse result = apiInstance.GetKnowledgeKnowledgebaseUploadsUrlsJob(knowledgeBaseId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseUploadsUrlsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **jobId** | **string**| Upload job ID |  |

### Return type

[**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse)


## GetKnowledgeKnowledgebases

> [**KnowledgeBaseListing**](KnowledgeBaseListing) GetKnowledgeKnowledgebases (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null)


Get knowledge bases

Requires ALL permissions: 

* knowledge:knowledgebase:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 100. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional) 
            var name = name_example;  // string | Filter by Name. (optional) 
            var coreLanguage = coreLanguage_example;  // string | Filter by core language. (optional) 
            var published = true;  // bool? | Filter by published status. (optional) 
            var sortBy = sortBy_example;  // string | Sort by. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort Order. (optional) 

            try
            { 
                // Get knowledge bases
                KnowledgeBaseListing result = apiInstance.GetKnowledgeKnowledgebases(before, after, limit, pageSize, name, coreLanguage, published, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 100. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional]  |
| **name** | **string**| Filter by Name. | [optional]  |
| **coreLanguage** | **string**| Filter by core language. | [optional] <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA, cs-CZ, fil-PH, ms-MY, he-IL, el-GR |
| **published** | **bool?**| Filter by published status. | [optional]  |
| **sortBy** | **string**| Sort by. | [optional] <br />**Values**: Name, Date |
| **sortOrder** | **string**| Sort Order. | [optional] <br />**Values**: ASC, ascending, DESC, descending |

### Return type

[**KnowledgeBaseListing**](KnowledgeBaseListing)


## GetKnowledgeSetting

> [**KnowledgeSettingsResponse**](KnowledgeSettingsResponse) GetKnowledgeSetting (string knowledgeSettingId)


Get Knowledge setting.

Requires ALL permissions: 

* knowledge:knowledgeSetting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeSettingId = knowledgeSettingId_example;  // string | Knowledge Setting ID.

            try
            { 
                // Get Knowledge setting.
                KnowledgeSettingsResponse result = apiInstance.GetKnowledgeSetting(knowledgeSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeSettingId** | **string**| Knowledge Setting ID. |  |

### Return type

[**KnowledgeSettingsResponse**](KnowledgeSettingsResponse)


## GetKnowledgeSettings

> [**KnowledgeSettingListing**](KnowledgeSettingListing) GetKnowledgeSettings (string before = null, string after = null, string pageSize = null, string name = null, string sourceId = null, string sortBy = null, string sortOrder = null)


Get Knowledge settings.

Requires ALL permissions: 

* knowledge:knowledgeSetting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Knowledge setting name to search upon. (optional) 
            var sourceId = sourceId_example;  // string | Source ID to filter knowledge settings by. (optional) 
            var sortBy = sortBy_example;  // string | Field to sort the knowledge settings on. (optional) 
            var sortOrder = sortOrder_example;  // string | Sorting order for knowledge settings. (optional) 

            try
            { 
                // Get Knowledge settings.
                KnowledgeSettingListing result = apiInstance.GetKnowledgeSettings(before, after, pageSize, name, sourceId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Knowledge setting name to search upon. | [optional]  |
| **sourceId** | **string**| Source ID to filter knowledge settings by. | [optional]  |
| **sortBy** | **string**| Field to sort the knowledge settings on. | [optional] <br />**Values**: dateModified, name |
| **sortOrder** | **string**| Sorting order for knowledge settings. | [optional] <br />**Values**: Asc, Desc |

### Return type

[**KnowledgeSettingListing**](KnowledgeSettingListing)


## PatchKnowledgeGuestSessionDocumentsSearchSearchId

> void PatchKnowledgeGuestSessionDocumentsSearchSearchId (string sessionId, string searchId, SearchUpdateRequest body)


Update search result.

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
    public class PatchKnowledgeGuestSessionDocumentsSearchSearchIdExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var searchId = searchId_example;  // string | Search Result ID
            var body = new SearchUpdateRequest(); // SearchUpdateRequest | 

            try
            { 
                // Update search result.
                apiInstance.PatchKnowledgeGuestSessionDocumentsSearchSearchId(sessionId, searchId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeGuestSessionDocumentsSearchSearchId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **searchId** | **string**| Search Result ID |  |
| **body** | [**SearchUpdateRequest**](SearchUpdateRequest)|  |  |

### Return type

void (empty response body)


## PatchKnowledgeKnowledgebase

> [**KnowledgeBase**](KnowledgeBase) PatchKnowledgeKnowledgebase (string knowledgeBaseId, KnowledgeBaseUpdateRequest body)


Update knowledge base

Requires ALL permissions: 

* knowledge:knowledgebase:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeBaseUpdateRequest(); // KnowledgeBaseUpdateRequest | 

            try
            { 
                // Update knowledge base
                KnowledgeBase result = apiInstance.PatchKnowledgeKnowledgebase(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeBaseUpdateRequest**](KnowledgeBaseUpdateRequest)|  |  |

### Return type

[**KnowledgeBase**](KnowledgeBase)


## PatchKnowledgeKnowledgebaseCategory

> [**CategoryResponse**](CategoryResponse) PatchKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId, CategoryUpdateRequest body)


Update category

Requires ALL permissions: 

* knowledge:category:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var categoryId = categoryId_example;  // string | Category ID
            var body = new CategoryUpdateRequest(); // CategoryUpdateRequest | 

            try
            { 
                // Update category
                CategoryResponse result = apiInstance.PatchKnowledgeKnowledgebaseCategory(knowledgeBaseId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **categoryId** | **string**| Category ID |  |
| **body** | [**CategoryUpdateRequest**](CategoryUpdateRequest)|  |  |

### Return type

[**CategoryResponse**](CategoryResponse)


## PatchKnowledgeKnowledgebaseChunksSearchSearchId

> void PatchKnowledgeKnowledgebaseChunksSearchSearchId (string knowledgeBaseId, string searchId, ChunkSearchRegisterRequest body = null)


Register chunk search result.

Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseChunksSearchSearchIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge Base ID
            var searchId = searchId_example;  // string | Unique identifier of search request
            var body = new ChunkSearchRegisterRequest(); // ChunkSearchRegisterRequest |  (optional) 

            try
            { 
                // Register chunk search result.
                apiInstance.PatchKnowledgeKnowledgebaseChunksSearchSearchId(knowledgeBaseId, searchId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseChunksSearchSearchId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge Base ID |  |
| **searchId** | **string**| Unique identifier of search request |  |
| **body** | [**ChunkSearchRegisterRequest**](ChunkSearchRegisterRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchKnowledgeKnowledgebaseDocument

> [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse) PatchKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId, KnowledgeDocumentReq body)


Update document.

Requires ALL permissions: 

* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var body = new KnowledgeDocumentReq(); // KnowledgeDocumentReq | 

            try
            { 
                // Update document.
                KnowledgeDocumentResponse result = apiInstance.PatchKnowledgeKnowledgebaseDocument(knowledgeBaseId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **body** | [**KnowledgeDocumentReq**](KnowledgeDocumentReq)|  |  |

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse)


## PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId

> [**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse) PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId (string knowledgeBaseId, string documentId, string feedbackId, KnowledgeDocumentFeedbackUpdateRequest body = null)


Update feedback on a document

Requires ANY permissions: 

* knowledge:feedback:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var feedbackId = feedbackId_example;  // string | Feedback ID.
            var body = new KnowledgeDocumentFeedbackUpdateRequest(); // KnowledgeDocumentFeedbackUpdateRequest |  (optional) 

            try
            { 
                // Update feedback on a document
                KnowledgeDocumentFeedbackResponse result = apiInstance.PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId(knowledgeBaseId, documentId, feedbackId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **feedbackId** | **string**| Feedback ID. |  |
| **body** | [**KnowledgeDocumentFeedbackUpdateRequest**](KnowledgeDocumentFeedbackUpdateRequest)|  | [optional]  |

### Return type

[**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse)


## PatchKnowledgeKnowledgebaseDocumentVariation

> [**DocumentVariationResponse**](DocumentVariationResponse) PatchKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId, DocumentVariationRequest body)


Update a variation for a document.

Requires ALL permissions: 

* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseDocumentVariationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var documentVariationId = documentVariationId_example;  // string | Globally unique identifier for a document variation.
            var documentId = documentId_example;  // string | Globally unique identifier for a document.
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for a knowledge base.
            var body = new DocumentVariationRequest(); // DocumentVariationRequest | 

            try
            { 
                // Update a variation for a document.
                DocumentVariationResponse result = apiInstance.PatchKnowledgeKnowledgebaseDocumentVariation(documentVariationId, documentId, knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseDocumentVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentVariationId** | **string**| Globally unique identifier for a document variation. |  |
| **documentId** | **string**| Globally unique identifier for a document. |  |
| **knowledgeBaseId** | **string**| Globally unique identifier for a knowledge base. |  |
| **body** | [**DocumentVariationRequest**](DocumentVariationRequest)|  |  |

### Return type

[**DocumentVariationResponse**](DocumentVariationResponse)


## PatchKnowledgeKnowledgebaseDocumentsSearchSearchId

> void PatchKnowledgeKnowledgebaseDocumentsSearchSearchId (string knowledgeBaseId, string searchId, SearchUpdateRequest body = null)


Update search result.

Requires ALL permissions: 

* knowledge:search:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseDocumentsSearchSearchIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | The ID of knowledge base containing the documents to query.
            var searchId = searchId_example;  // string | Search Result ID
            var body = new SearchUpdateRequest(); // SearchUpdateRequest |  (optional) 

            try
            { 
                // Update search result.
                apiInstance.PatchKnowledgeKnowledgebaseDocumentsSearchSearchId(knowledgeBaseId, searchId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseDocumentsSearchSearchId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| The ID of knowledge base containing the documents to query. |  |
| **searchId** | **string**| Search Result ID |  |
| **body** | [**SearchUpdateRequest**](SearchUpdateRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchKnowledgeKnowledgebaseImportJob

> [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse) PatchKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId, ImportStatusRequest body)


Start import job

Requires ALL permissions: 

* knowledge:importJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseImportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var importJobId = importJobId_example;  // string | Import job ID
            var body = new ImportStatusRequest(); // ImportStatusRequest | 

            try
            { 
                // Start import job
                KnowledgeImportJobResponse result = apiInstance.PatchKnowledgeKnowledgebaseImportJob(knowledgeBaseId, importJobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **importJobId** | **string**| Import job ID |  |
| **body** | [**ImportStatusRequest**](ImportStatusRequest)|  |  |

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse)


## PatchKnowledgeKnowledgebaseLabel

> [**LabelResponse**](LabelResponse) PatchKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId, LabelUpdateRequest body)


Update label

Requires ALL permissions: 

* knowledge:label:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var labelId = labelId_example;  // string | Label ID
            var body = new LabelUpdateRequest(); // LabelUpdateRequest | 

            try
            { 
                // Update label
                LabelResponse result = apiInstance.PatchKnowledgeKnowledgebaseLabel(knowledgeBaseId, labelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **labelId** | **string**| Label ID |  |
| **body** | [**LabelUpdateRequest**](LabelUpdateRequest)|  |  |

### Return type

[**LabelResponse**](LabelResponse)


## PatchKnowledgeKnowledgebaseParseJob

> void PatchKnowledgeKnowledgebaseParseJob (string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestPatch body)


Send update to the parse operation

Requires ALL permissions: 

* knowledge:importJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseParseJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var parseJobId = parseJobId_example;  // string | Parse job ID
            var body = new KnowledgeParseJobRequestPatch(); // KnowledgeParseJobRequestPatch | 

            try
            { 
                // Send update to the parse operation
                apiInstance.PatchKnowledgeKnowledgebaseParseJob(knowledgeBaseId, parseJobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseParseJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **parseJobId** | **string**| Parse job ID |  |
| **body** | [**KnowledgeParseJobRequestPatch**](KnowledgeParseJobRequestPatch)|  |  |

### Return type

void (empty response body)


## PatchKnowledgeKnowledgebaseSynchronizeJob

> [**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse) PatchKnowledgeKnowledgebaseSynchronizeJob (string knowledgeBaseId, string syncJobId, SyncStatusRequest body)


Update synchronization job

Requires ALL permissions: 

* knowledge:syncJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseSynchronizeJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var syncJobId = syncJobId_example;  // string | Synchronization job ID
            var body = new SyncStatusRequest(); // SyncStatusRequest | 

            try
            { 
                // Update synchronization job
                KnowledgeSyncJobResponse result = apiInstance.PatchKnowledgeKnowledgebaseSynchronizeJob(knowledgeBaseId, syncJobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseSynchronizeJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **syncJobId** | **string**| Synchronization job ID |  |
| **body** | [**SyncStatusRequest**](SyncStatusRequest)|  |  |

### Return type

[**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse)


## PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup

> [**UnansweredPhraseGroupUpdateResponse**](UnansweredPhraseGroupUpdateResponse) PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup (string knowledgeBaseId, string groupId, string phraseGroupId, UnansweredPhraseGroupPatchRequestBody body)


Update a Knowledge base unanswered phrase group

Requires ALL permissions: 

* knowledge:groups:edit
* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var groupId = groupId_example;  // string | The ID of the group to be updated.
            var phraseGroupId = phraseGroupId_example;  // string | The ID of the phraseGroup to be updated.
            var body = new UnansweredPhraseGroupPatchRequestBody(); // UnansweredPhraseGroupPatchRequestBody | Request body of the update unanswered group endpoint.

            try
            { 
                // Update a Knowledge base unanswered phrase group
                UnansweredPhraseGroupUpdateResponse result = apiInstance.PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup(knowledgeBaseId, groupId, phraseGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **groupId** | **string**| The ID of the group to be updated. |  |
| **phraseGroupId** | **string**| The ID of the phraseGroup to be updated. |  |
| **body** | [**UnansweredPhraseGroupPatchRequestBody**](UnansweredPhraseGroupPatchRequestBody)| Request body of the update unanswered group endpoint. |  |

### Return type

[**UnansweredPhraseGroupUpdateResponse**](UnansweredPhraseGroupUpdateResponse)


## PatchKnowledgeSetting

> [**KnowledgeSettingsResponse**](KnowledgeSettingsResponse) PatchKnowledgeSetting (string knowledgeSettingId, KnowledgeSettingsRequest body)


Update Knowledge setting.

Requires ALL permissions: 

* knowledge:knowledgeSetting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeSettingId = knowledgeSettingId_example;  // string | Knowledge Setting ID.
            var body = new KnowledgeSettingsRequest(); // KnowledgeSettingsRequest | 

            try
            { 
                // Update Knowledge setting.
                KnowledgeSettingsResponse result = apiInstance.PatchKnowledgeSetting(knowledgeSettingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeSettingId** | **string**| Knowledge Setting ID. |  |
| **body** | [**KnowledgeSettingsRequest**](KnowledgeSettingsRequest)|  |  |

### Return type

[**KnowledgeSettingsResponse**](KnowledgeSettingsResponse)


## PostKnowledgeDocumentuploads

> [**UploadUrlResponse**](UploadUrlResponse) PostKnowledgeDocumentuploads (UploadUrlRequest body)


Creates a presigned URL for uploading a knowledge import file with a set of documents

Requires ALL permissions: 

* knowledge:document:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeDocumentuploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates a presigned URL for uploading a knowledge import file with a set of documents
                UploadUrlResponse result = apiInstance.PostKnowledgeDocumentuploads(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeDocumentuploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest)| query |  |

### Return type

[**UploadUrlResponse**](UploadUrlResponse)


## PostKnowledgeGuestSessionDocumentCopies

> void PostKnowledgeGuestSessionDocumentCopies (string sessionId, string documentId, KnowledgeGuestDocumentCopy body = null)


Indicate that the document was copied by the user.

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
    public class PostKnowledgeGuestSessionDocumentCopiesExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var documentId = documentId_example;  // string | Document ID
            var body = new KnowledgeGuestDocumentCopy(); // KnowledgeGuestDocumentCopy |  (optional) 

            try
            { 
                // Indicate that the document was copied by the user.
                apiInstance.PostKnowledgeGuestSessionDocumentCopies(sessionId, documentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentCopies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **documentId** | **string**| Document ID |  |
| **body** | [**KnowledgeGuestDocumentCopy**](KnowledgeGuestDocumentCopy)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeGuestSessionDocumentFeedback

> [**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback) PostKnowledgeGuestSessionDocumentFeedback (string sessionId, string documentId, KnowledgeGuestDocumentFeedback body = null)


Give feedback on a document

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
    public class PostKnowledgeGuestSessionDocumentFeedbackExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var documentId = documentId_example;  // string | Document ID.
            var body = new KnowledgeGuestDocumentFeedback(); // KnowledgeGuestDocumentFeedback |  (optional) 

            try
            { 
                // Give feedback on a document
                KnowledgeGuestDocumentFeedback result = apiInstance.PostKnowledgeGuestSessionDocumentFeedback(sessionId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **documentId** | **string**| Document ID. |  |
| **body** | [**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback)|  | [optional]  |

### Return type

[**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback)


## PostKnowledgeGuestSessionDocumentViews

> void PostKnowledgeGuestSessionDocumentViews (string sessionId, string documentId, KnowledgeGuestDocumentView body = null)


Create view event for a document.

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
    public class PostKnowledgeGuestSessionDocumentViewsExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var documentId = documentId_example;  // string | Document ID
            var body = new KnowledgeGuestDocumentView(); // KnowledgeGuestDocumentView |  (optional) 

            try
            { 
                // Create view event for a document.
                apiInstance.PostKnowledgeGuestSessionDocumentViews(sessionId, documentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentViews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **documentId** | **string**| Document ID |  |
| **body** | [**KnowledgeGuestDocumentView**](KnowledgeGuestDocumentView)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeGuestSessionDocumentsAnswers

> [**KnowledgeGuestAnswerDocumentsResponse**](KnowledgeGuestAnswerDocumentsResponse) PostKnowledgeGuestSessionDocumentsAnswers (string sessionId, KnowledgeDocumentsAnswerFilter body)


Answer documents.

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
    public class PostKnowledgeGuestSessionDocumentsAnswersExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var body = new KnowledgeDocumentsAnswerFilter(); // KnowledgeDocumentsAnswerFilter | 

            try
            { 
                // Answer documents.
                KnowledgeGuestAnswerDocumentsResponse result = apiInstance.PostKnowledgeGuestSessionDocumentsAnswers(sessionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentsAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **body** | [**KnowledgeDocumentsAnswerFilter**](KnowledgeDocumentsAnswerFilter)|  |  |

### Return type

[**KnowledgeGuestAnswerDocumentsResponse**](KnowledgeGuestAnswerDocumentsResponse)


## PostKnowledgeGuestSessionDocumentsPresentations

> void PostKnowledgeGuestSessionDocumentsPresentations (string sessionId, KnowledgeGuestDocumentPresentation body = null)


Indicate that documents were presented to the user.

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
    public class PostKnowledgeGuestSessionDocumentsPresentationsExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var body = new KnowledgeGuestDocumentPresentation(); // KnowledgeGuestDocumentPresentation |  (optional) 

            try
            { 
                // Indicate that documents were presented to the user.
                apiInstance.PostKnowledgeGuestSessionDocumentsPresentations(sessionId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentsPresentations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **body** | [**KnowledgeGuestDocumentPresentation**](KnowledgeGuestDocumentPresentation)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeGuestSessionDocumentsSearch

> [**KnowledgeDocumentGuestSearch**](KnowledgeDocumentGuestSearch) PostKnowledgeGuestSessionDocumentsSearch (string sessionId, List<string> expand = null, KnowledgeDocumentGuestSearchRequest body = null)


Search the documents in a guest session.

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
    public class PostKnowledgeGuestSessionDocumentsSearchExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var expand = new List<string>(); // List<string> | Fields, if any, to expand for each document in the search result matching the query. (optional) 
            var body = new KnowledgeDocumentGuestSearchRequest(); // KnowledgeDocumentGuestSearchRequest |  (optional) 

            try
            { 
                // Search the documents in a guest session.
                KnowledgeDocumentGuestSearch result = apiInstance.PostKnowledgeGuestSessionDocumentsSearch(sessionId, expand, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **expand** | [**List<string>**](string)| Fields, if any, to expand for each document in the search result matching the query. | [optional] <br />**Values**: documentVariations, documentAlternatives, knowledgeBaseLanguageCode |
| **body** | [**KnowledgeDocumentGuestSearchRequest**](KnowledgeDocumentGuestSearchRequest)|  | [optional]  |

### Return type

[**KnowledgeDocumentGuestSearch**](KnowledgeDocumentGuestSearch)


## PostKnowledgeGuestSessionDocumentsSearchSuggestions

> [**KnowledgeGuestDocumentSuggestion**](KnowledgeGuestDocumentSuggestion) PostKnowledgeGuestSessionDocumentsSearchSuggestions (string sessionId, KnowledgeGuestDocumentSuggestionRequest body = null)


Query the knowledge documents to provide suggestions for auto completion.

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
    public class PostKnowledgeGuestSessionDocumentsSearchSuggestionsExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var sessionId = sessionId_example;  // string | Knowledge guest session ID.
            var body = new KnowledgeGuestDocumentSuggestionRequest(); // KnowledgeGuestDocumentSuggestionRequest |  (optional) 

            try
            { 
                // Query the knowledge documents to provide suggestions for auto completion.
                KnowledgeGuestDocumentSuggestion result = apiInstance.PostKnowledgeGuestSessionDocumentsSearchSuggestions(sessionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessionDocumentsSearchSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| Knowledge guest session ID. |  |
| **body** | [**KnowledgeGuestDocumentSuggestionRequest**](KnowledgeGuestDocumentSuggestionRequest)|  | [optional]  |

### Return type

[**KnowledgeGuestDocumentSuggestion**](KnowledgeGuestDocumentSuggestion)


## PostKnowledgeGuestSessions

> [**KnowledgeGuestSession**](KnowledgeGuestSession) PostKnowledgeGuestSessions (KnowledgeGuestSession body)


Create guest session

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
    public class PostKnowledgeGuestSessionsExample
    {
        public void main()
        { 

            var apiInstance = new KnowledgeApi();
            var body = new KnowledgeGuestSession(); // KnowledgeGuestSession | 

            try
            { 
                // Create guest session
                KnowledgeGuestSession result = apiInstance.PostKnowledgeGuestSessions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeGuestSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeGuestSession**](KnowledgeGuestSession)|  |  |

### Return type

[**KnowledgeGuestSession**](KnowledgeGuestSession)


## PostKnowledgeKnowledgebaseCategories

> [**CategoryResponse**](CategoryResponse) PostKnowledgeKnowledgebaseCategories (string knowledgeBaseId, CategoryCreateRequest body)


Create new category

Requires ALL permissions: 

* knowledge:category:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new CategoryCreateRequest(); // CategoryCreateRequest | 

            try
            { 
                // Create new category
                CategoryResponse result = apiInstance.PostKnowledgeKnowledgebaseCategories(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**CategoryCreateRequest**](CategoryCreateRequest)|  |  |

### Return type

[**CategoryResponse**](CategoryResponse)


## PostKnowledgeKnowledgebaseChunksSearch

> [**KnowledgeDocumentChunkResponse**](KnowledgeDocumentChunkResponse) PostKnowledgeKnowledgebaseChunksSearch (string knowledgeBaseId, KnowledgeDocumentChunkRequest body = null)


Search for chunks in a knowledge base

Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseChunksSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge Base ID
            var body = new KnowledgeDocumentChunkRequest(); // KnowledgeDocumentChunkRequest |  (optional) 

            try
            { 
                // Search for chunks in a knowledge base
                KnowledgeDocumentChunkResponse result = apiInstance.PostKnowledgeKnowledgebaseChunksSearch(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseChunksSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge Base ID |  |
| **body** | [**KnowledgeDocumentChunkRequest**](KnowledgeDocumentChunkRequest)|  | [optional]  |

### Return type

[**KnowledgeDocumentChunkResponse**](KnowledgeDocumentChunkResponse)


## PostKnowledgeKnowledgebaseDocumentCopies

> void PostKnowledgeKnowledgebaseDocumentCopies (string knowledgeBaseId, string documentId, KnowledgeDocumentCopy body = null)


Indicate that the document was copied by the user.

Requires ALL permissions: 

* knowledge:documentCopy:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentCopiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var body = new KnowledgeDocumentCopy(); // KnowledgeDocumentCopy |  (optional) 

            try
            { 
                // Indicate that the document was copied by the user.
                apiInstance.PostKnowledgeKnowledgebaseDocumentCopies(knowledgeBaseId, documentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentCopies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **body** | [**KnowledgeDocumentCopy**](KnowledgeDocumentCopy)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeKnowledgebaseDocumentFeedback

> [**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse) PostKnowledgeKnowledgebaseDocumentFeedback (string knowledgeBaseId, string documentId, KnowledgeDocumentFeedback body = null)


Give feedback on a document

Requires ANY permissions: 

* knowledge:feedback:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var body = new KnowledgeDocumentFeedback(); // KnowledgeDocumentFeedback |  (optional) 

            try
            { 
                // Give feedback on a document
                KnowledgeDocumentFeedbackResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentFeedback(knowledgeBaseId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **body** | [**KnowledgeDocumentFeedback**](KnowledgeDocumentFeedback)|  | [optional]  |

### Return type

[**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse)


## PostKnowledgeKnowledgebaseDocumentVariations

> [**DocumentVariationResponse**](DocumentVariationResponse) PostKnowledgeKnowledgebaseDocumentVariations (string knowledgeBaseId, string documentId, DocumentVariationRequest body)


Create a variation for a document.

Requires ANY permissions: 

* knowledge:document:add
* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentVariationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var body = new DocumentVariationRequest(); // DocumentVariationRequest | 

            try
            { 
                // Create a variation for a document.
                DocumentVariationResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentVariations(knowledgeBaseId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentVariations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **body** | [**DocumentVariationRequest**](DocumentVariationRequest)|  |  |

### Return type

[**DocumentVariationResponse**](DocumentVariationResponse)


## PostKnowledgeKnowledgebaseDocumentVersions

> [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion) PostKnowledgeKnowledgebaseDocumentVersions (string knowledgeBaseId, string documentId, KnowledgeDocumentVersion body)


Creates or restores a document version.

Requires ALL permissions: 

* knowledge:documentVersion:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Globally unique identifier for the knowledge base.
            var documentId = documentId_example;  // string | Globally unique identifier for the document.
            var body = new KnowledgeDocumentVersion(); // KnowledgeDocumentVersion | 

            try
            { 
                // Creates or restores a document version.
                KnowledgeDocumentVersion result = apiInstance.PostKnowledgeKnowledgebaseDocumentVersions(knowledgeBaseId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Globally unique identifier for the knowledge base. |  |
| **documentId** | **string**| Globally unique identifier for the document. |  |
| **body** | [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion)|  |  |

### Return type

[**KnowledgeDocumentVersion**](KnowledgeDocumentVersion)


## PostKnowledgeKnowledgebaseDocumentViews

> void PostKnowledgeKnowledgebaseDocumentViews (string knowledgeBaseId, string documentId, KnowledgeDocumentView body = null)


Create view for a document.

Requires ALL permissions: 

* knowledge:documentView:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentViewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var documentId = documentId_example;  // string | Document ID.
            var body = new KnowledgeDocumentView(); // KnowledgeDocumentView |  (optional) 

            try
            { 
                // Create view for a document.
                apiInstance.PostKnowledgeKnowledgebaseDocumentViews(knowledgeBaseId, documentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentViews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **documentId** | **string**| Document ID. |  |
| **body** | [**KnowledgeDocumentView**](KnowledgeDocumentView)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeKnowledgebaseDocuments

> [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse) PostKnowledgeKnowledgebaseDocuments (string knowledgeBaseId, KnowledgeDocumentCreateRequest body)


Create document.

Requires ALL permissions: 

* knowledge:document:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeDocumentCreateRequest(); // KnowledgeDocumentCreateRequest | 

            try
            { 
                // Create document.
                KnowledgeDocumentResponse result = apiInstance.PostKnowledgeKnowledgebaseDocuments(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeDocumentCreateRequest**](KnowledgeDocumentCreateRequest)|  |  |

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse)


## PostKnowledgeKnowledgebaseDocumentsAnswers

> [**KnowledgeAnswerDocumentsResponse**](KnowledgeAnswerDocumentsResponse) PostKnowledgeKnowledgebaseDocumentsAnswers (string knowledgeBaseId, KnowledgeDocumentsAnswerFilter body)


Answer documents.

Requires ALL permissions: 

* knowledge:document:view
* knowledge:documentAnswer:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsAnswersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeDocumentsAnswerFilter(); // KnowledgeDocumentsAnswerFilter | 

            try
            { 
                // Answer documents.
                KnowledgeAnswerDocumentsResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentsAnswers(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeDocumentsAnswerFilter**](KnowledgeDocumentsAnswerFilter)|  |  |

### Return type

[**KnowledgeAnswerDocumentsResponse**](KnowledgeAnswerDocumentsResponse)


## PostKnowledgeKnowledgebaseDocumentsBulkRemove

> [**BulkResponse**](BulkResponse) PostKnowledgeKnowledgebaseDocumentsBulkRemove (string knowledgeBaseId, KnowledgeDocumentBulkRemoveRequest body)


Bulk remove documents.

Requires ALL permissions: 

* knowledge:document:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeDocumentBulkRemoveRequest(); // KnowledgeDocumentBulkRemoveRequest | 

            try
            { 
                // Bulk remove documents.
                BulkResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentsBulkRemove(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeDocumentBulkRemoveRequest**](KnowledgeDocumentBulkRemoveRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostKnowledgeKnowledgebaseDocumentsBulkUpdate

> [**BulkResponse**](BulkResponse) PostKnowledgeKnowledgebaseDocumentsBulkUpdate (string knowledgeBaseId, KnowledgeDocumentBulkUpdateRequest body)


Bulk update documents.

Requires ALL permissions: 

* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsBulkUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeDocumentBulkUpdateRequest(); // KnowledgeDocumentBulkUpdateRequest | 

            try
            { 
                // Bulk update documents.
                BulkResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentsBulkUpdate(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsBulkUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeDocumentBulkUpdateRequest**](KnowledgeDocumentBulkUpdateRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostKnowledgeKnowledgebaseDocumentsPresentations

> void PostKnowledgeKnowledgebaseDocumentsPresentations (string knowledgeBaseId, KnowledgeDocumentPresentation body = null)


Indicate that documents were presented to the user.

Requires ALL permissions: 

* knowledge:documentPresentation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsPresentationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID.
            var body = new KnowledgeDocumentPresentation(); // KnowledgeDocumentPresentation |  (optional) 

            try
            { 
                // Indicate that documents were presented to the user.
                apiInstance.PostKnowledgeKnowledgebaseDocumentsPresentations(knowledgeBaseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsPresentations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID. |  |
| **body** | [**KnowledgeDocumentPresentation**](KnowledgeDocumentPresentation)|  | [optional]  |

### Return type

void (empty response body)


## PostKnowledgeKnowledgebaseDocumentsQuery

> [**KnowledgeDocumentQueryResponse**](KnowledgeDocumentQueryResponse) PostKnowledgeKnowledgebaseDocumentsQuery (string knowledgeBaseId, List<string> expand = null, KnowledgeDocumentQuery body = null)


Query for knowledge documents.

Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge Base ID
            var expand = new List<string>(); // List<string> | Fields, if any, to expand for each document in the search result matching the query. (optional) 
            var body = new KnowledgeDocumentQuery(); // KnowledgeDocumentQuery |  (optional) 

            try
            { 
                // Query for knowledge documents.
                KnowledgeDocumentQueryResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentsQuery(knowledgeBaseId, expand, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge Base ID |  |
| **expand** | [**List<string>**](string)| Fields, if any, to expand for each document in the search result matching the query. | [optional] <br />**Values**: documentVariations, documentAlternatives, knowledgeBaseLanguageCode, variationChunks |
| **body** | [**KnowledgeDocumentQuery**](KnowledgeDocumentQuery)|  | [optional]  |

### Return type

[**KnowledgeDocumentQueryResponse**](KnowledgeDocumentQueryResponse)


## PostKnowledgeKnowledgebaseDocumentsSearch

> [**KnowledgeDocumentSearch**](KnowledgeDocumentSearch) PostKnowledgeKnowledgebaseDocumentsSearch (string knowledgeBaseId, List<string> expand = null, KnowledgeDocumentSearchRequest body = null)


Search the documents in a knowledge base.

Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | The ID of knowledge base containing the documents to query.
            var expand = new List<string>(); // List<string> | Fields, if any, to expand for each document in the search result matching the query. (optional) 
            var body = new KnowledgeDocumentSearchRequest(); // KnowledgeDocumentSearchRequest |  (optional) 

            try
            { 
                // Search the documents in a knowledge base.
                KnowledgeDocumentSearch result = apiInstance.PostKnowledgeKnowledgebaseDocumentsSearch(knowledgeBaseId, expand, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| The ID of knowledge base containing the documents to query. |  |
| **expand** | [**List<string>**](string)| Fields, if any, to expand for each document in the search result matching the query. | [optional] <br />**Values**: documentVariations, documentAlternatives, knowledgeBaseLanguageCode, variationChunks |
| **body** | [**KnowledgeDocumentSearchRequest**](KnowledgeDocumentSearchRequest)|  | [optional]  |

### Return type

[**KnowledgeDocumentSearch**](KnowledgeDocumentSearch)


## PostKnowledgeKnowledgebaseDocumentsSearchSuggestions

> [**KnowledgeDocumentSuggestion**](KnowledgeDocumentSuggestion) PostKnowledgeKnowledgebaseDocumentsSearchSuggestions (string knowledgeBaseId, KnowledgeDocumentSuggestionRequest body = null)


Query the knowledge documents to provide suggestions for auto completion.

Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsSearchSuggestionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | The ID of knowledge base containing the documents to query.
            var body = new KnowledgeDocumentSuggestionRequest(); // KnowledgeDocumentSuggestionRequest |  (optional) 

            try
            { 
                // Query the knowledge documents to provide suggestions for auto completion.
                KnowledgeDocumentSuggestion result = apiInstance.PostKnowledgeKnowledgebaseDocumentsSearchSuggestions(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsSearchSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| The ID of knowledge base containing the documents to query. |  |
| **body** | [**KnowledgeDocumentSuggestionRequest**](KnowledgeDocumentSuggestionRequest)|  | [optional]  |

### Return type

[**KnowledgeDocumentSuggestion**](KnowledgeDocumentSuggestion)


## PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd

> [**BulkResponse**](BulkResponse) PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd (string knowledgeBaseId, KnowledgeDocumentBulkVersionAddRequest body)


Bulk add document versions.

Requires ALL permissions: 

* knowledge:documentVersion:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseDocumentsVersionsBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeDocumentBulkVersionAddRequest(); // KnowledgeDocumentBulkVersionAddRequest | 

            try
            { 
                // Bulk add document versions.
                BulkResponse result = apiInstance.PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeDocumentBulkVersionAddRequest**](KnowledgeDocumentBulkVersionAddRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostKnowledgeKnowledgebaseExportJobs

> [**KnowledgeExportJobResponse**](KnowledgeExportJobResponse) PostKnowledgeKnowledgebaseExportJobs (string knowledgeBaseId, KnowledgeExportJobRequest body)


Create export job

Requires ALL permissions: 

* knowledge:exportJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseExportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeExportJobRequest(); // KnowledgeExportJobRequest | 

            try
            { 
                // Create export job
                KnowledgeExportJobResponse result = apiInstance.PostKnowledgeKnowledgebaseExportJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseExportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeExportJobRequest**](KnowledgeExportJobRequest)|  |  |

### Return type

[**KnowledgeExportJobResponse**](KnowledgeExportJobResponse)


## PostKnowledgeKnowledgebaseImportJobs

> [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse) PostKnowledgeKnowledgebaseImportJobs (string knowledgeBaseId, KnowledgeImportJobRequest body)


Create import job

Requires ALL permissions: 

* knowledge:importJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseImportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeImportJobRequest(); // KnowledgeImportJobRequest | 

            try
            { 
                // Create import job
                KnowledgeImportJobResponse result = apiInstance.PostKnowledgeKnowledgebaseImportJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeImportJobRequest**](KnowledgeImportJobRequest)|  |  |

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse)


## PostKnowledgeKnowledgebaseLabels

> [**LabelResponse**](LabelResponse) PostKnowledgeKnowledgebaseLabels (string knowledgeBaseId, LabelCreateRequest body)


Create new label

Requires ALL permissions: 

* knowledge:label:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLabelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new LabelCreateRequest(); // LabelCreateRequest | 

            try
            { 
                // Create new label
                LabelResponse result = apiInstance.PostKnowledgeKnowledgebaseLabels(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**LabelCreateRequest**](LabelCreateRequest)|  |  |

### Return type

[**LabelResponse**](LabelResponse)


## PostKnowledgeKnowledgebaseParseJobImport

> void PostKnowledgeKnowledgebaseParseJobImport (string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestImport body)


Import the parsed articles

Requires ALL permissions: 

* knowledge:importJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseParseJobImportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var parseJobId = parseJobId_example;  // string | Parse job ID
            var body = new KnowledgeParseJobRequestImport(); // KnowledgeParseJobRequestImport | 

            try
            { 
                // Import the parsed articles
                apiInstance.PostKnowledgeKnowledgebaseParseJobImport(knowledgeBaseId, parseJobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseParseJobImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **parseJobId** | **string**| Parse job ID |  |
| **body** | [**KnowledgeParseJobRequestImport**](KnowledgeParseJobRequestImport)|  |  |

### Return type

void (empty response body)


## PostKnowledgeKnowledgebaseParseJobs

> [**KnowledgeParseJobResponse**](KnowledgeParseJobResponse) PostKnowledgeKnowledgebaseParseJobs (string knowledgeBaseId, KnowledgeParseJobRequest body)


Create parse job

Requires ALL permissions: 

* knowledge:importJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseParseJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeParseJobRequest(); // KnowledgeParseJobRequest | 

            try
            { 
                // Create parse job
                KnowledgeParseJobResponse result = apiInstance.PostKnowledgeKnowledgebaseParseJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseParseJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeParseJobRequest**](KnowledgeParseJobRequest)|  |  |

### Return type

[**KnowledgeParseJobResponse**](KnowledgeParseJobResponse)


## PostKnowledgeKnowledgebaseSourcesSalesforce

> [**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse) PostKnowledgeKnowledgebaseSourcesSalesforce (string knowledgeBaseId, SalesforceSourceRequest body)


Create Salesforce Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSourcesSalesforceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new SalesforceSourceRequest(); // SalesforceSourceRequest | 

            try
            { 
                // Create Salesforce Knowledge integration source
                KnowledgeSyncJobResponse result = apiInstance.PostKnowledgeKnowledgebaseSourcesSalesforce(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSourcesSalesforce: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**SalesforceSourceRequest**](SalesforceSourceRequest)|  |  |

### Return type

[**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse)


## PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync

> [**SourceSyncResponse**](SourceSyncResponse) PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync (string knowledgeBaseId, string sourceId, Object body = null)


Start sync on Salesforce Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSyncExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var body = ;  // Object |  (optional) 

            try
            { 
                // Start sync on Salesforce Knowledge integration source
                SourceSyncResponse result = apiInstance.PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync(knowledgeBaseId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSync: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **body** | **Object**|  | [optional]  |

### Return type

[**SourceSyncResponse**](SourceSyncResponse)


## PostKnowledgeKnowledgebaseSourcesServicenow

> [**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse) PostKnowledgeKnowledgebaseSourcesServicenow (string knowledgeBaseId, ServiceNowSourceRequest body)


Create ServiceNow Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSourcesServicenowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new ServiceNowSourceRequest(); // ServiceNowSourceRequest | 

            try
            { 
                // Create ServiceNow Knowledge integration source
                KnowledgeSyncJobResponse result = apiInstance.PostKnowledgeKnowledgebaseSourcesServicenow(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSourcesServicenow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**ServiceNowSourceRequest**](ServiceNowSourceRequest)|  |  |

### Return type

[**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse)


## PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync

> [**SourceSyncResponse**](SourceSyncResponse) PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync (string knowledgeBaseId, string sourceId, Object body = null)


Start synchronization on ServiceNow Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSyncExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var body = ;  // Object |  (optional) 

            try
            { 
                // Start synchronization on ServiceNow Knowledge integration source
                SourceSyncResponse result = apiInstance.PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync(knowledgeBaseId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSync: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **body** | **Object**|  | [optional]  |

### Return type

[**SourceSyncResponse**](SourceSyncResponse)


## PostKnowledgeKnowledgebaseSynchronizeJobs

> [**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse) PostKnowledgeKnowledgebaseSynchronizeJobs (string knowledgeBaseId, KnowledgeSyncJobRequest body)


Create synchronization job

Requires ALL permissions: 

* knowledge:syncJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSynchronizeJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeSyncJobRequest(); // KnowledgeSyncJobRequest | 

            try
            { 
                // Create synchronization job
                KnowledgeSyncJobResponse result = apiInstance.PostKnowledgeKnowledgebaseSynchronizeJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSynchronizeJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeSyncJobRequest**](KnowledgeSyncJobRequest)|  |  |

### Return type

[**KnowledgeSyncJobResponse**](KnowledgeSyncJobResponse)


## PostKnowledgeKnowledgebaseUploadsUrlsJobs

> [**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse) PostKnowledgeKnowledgebaseUploadsUrlsJobs (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)


Create content upload from URL job

Requires ALL permissions: 

* knowledge:uploadSourceUrlJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseUploadsUrlsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new CreateUploadSourceUrlJobRequest(); // CreateUploadSourceUrlJobRequest | uploadRequest

            try
            { 
                // Create content upload from URL job
                CreateUploadSourceUrlJobResponse result = apiInstance.PostKnowledgeKnowledgebaseUploadsUrlsJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**CreateUploadSourceUrlJobRequest**](CreateUploadSourceUrlJobRequest)| uploadRequest |  |

### Return type

[**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse)


## PostKnowledgeKnowledgebases

> [**KnowledgeBase**](KnowledgeBase) PostKnowledgeKnowledgebases (KnowledgeBaseCreateRequest body)


Create new knowledge base

Requires ALL permissions: 

* knowledge:knowledgebase:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var body = new KnowledgeBaseCreateRequest(); // KnowledgeBaseCreateRequest | 

            try
            { 
                // Create new knowledge base
                KnowledgeBase result = apiInstance.PostKnowledgeKnowledgebases(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeBaseCreateRequest**](KnowledgeBaseCreateRequest)|  |  |

### Return type

[**KnowledgeBase**](KnowledgeBase)


## PostKnowledgeSearchPreview

> [**KnowledgeSearchPreviewResponse**](KnowledgeSearchPreviewResponse) PostKnowledgeSearchPreview (KnowledgeSearchPreviewRequest body = null)


Get Knowledge Search Preview

Requires ALL permissions: 

* knowledge:knowledgeSetting:searchPreview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeSearchPreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var body = new KnowledgeSearchPreviewRequest(); // KnowledgeSearchPreviewRequest |  (optional) 

            try
            { 
                // Get Knowledge Search Preview
                KnowledgeSearchPreviewResponse result = apiInstance.PostKnowledgeSearchPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeSearchPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeSearchPreviewRequest**](KnowledgeSearchPreviewRequest)|  | [optional]  |

### Return type

[**KnowledgeSearchPreviewResponse**](KnowledgeSearchPreviewResponse)


## PostKnowledgeSettings

> [**KnowledgeSettingsResponse**](KnowledgeSettingsResponse) PostKnowledgeSettings (KnowledgeSettingsRequest body = null)


Create Knowledge setting.

Requires ALL permissions: 

* knowledge:knowledgeSetting:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var body = new KnowledgeSettingsRequest(); // KnowledgeSettingsRequest |  (optional) 

            try
            { 
                // Create Knowledge setting.
                KnowledgeSettingsResponse result = apiInstance.PostKnowledgeSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeSettingsRequest**](KnowledgeSettingsRequest)|  | [optional]  |

### Return type

[**KnowledgeSettingsResponse**](KnowledgeSettingsResponse)


## PutKnowledgeKnowledgebaseSourcesSalesforceSourceId

> [**SalesforceSourceResponse**](SalesforceSourceResponse) PutKnowledgeKnowledgebaseSourcesSalesforceSourceId (string knowledgeBaseId, string sourceId, SalesforceSourceRequest body)


Update Salesforce Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var body = new SalesforceSourceRequest(); // SalesforceSourceRequest | 

            try
            { 
                // Update Salesforce Knowledge integration source
                SalesforceSourceResponse result = apiInstance.PutKnowledgeKnowledgebaseSourcesSalesforceSourceId(knowledgeBaseId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PutKnowledgeKnowledgebaseSourcesSalesforceSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **body** | [**SalesforceSourceRequest**](SalesforceSourceRequest)|  |  |

### Return type

[**SalesforceSourceResponse**](SalesforceSourceResponse)


## PutKnowledgeKnowledgebaseSourcesServicenowSourceId

> [**ServiceNowSourceResponse**](ServiceNowSourceResponse) PutKnowledgeKnowledgebaseSourcesServicenowSourceId (string knowledgeBaseId, string sourceId, ServiceNowSourceRequest body)


Update ServiceNow Knowledge integration source

Requires ALL permissions: 

* knowledge:integrationSource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutKnowledgeKnowledgebaseSourcesServicenowSourceIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var sourceId = sourceId_example;  // string | Source ID
            var body = new ServiceNowSourceRequest(); // ServiceNowSourceRequest | 

            try
            { 
                // Update ServiceNow Knowledge integration source
                ServiceNowSourceResponse result = apiInstance.PutKnowledgeKnowledgebaseSourcesServicenowSourceId(knowledgeBaseId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PutKnowledgeKnowledgebaseSourcesServicenowSourceId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **sourceId** | **string**| Source ID |  |
| **body** | [**ServiceNowSourceRequest**](ServiceNowSourceRequest)|  |  |

### Return type

[**ServiceNowSourceResponse**](ServiceNowSourceResponse)


_PureCloudPlatform.Client.V2 258.0.0_
