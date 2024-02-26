---
title: KnowledgeApi
---
## PureCloudPlatform.Client.V2.Api.KnowledgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteKnowledgeKnowledgebase**](KnowledgeApi.html#deleteknowledgeknowledgebase) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Delete knowledge base |
| [**DeleteKnowledgeKnowledgebaseCategory**](KnowledgeApi.html#deleteknowledgeknowledgebasecategory) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Delete category |
| [**DeleteKnowledgeKnowledgebaseDocument**](KnowledgeApi.html#deleteknowledgeknowledgebasedocument) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Delete document. |
| [**DeleteKnowledgeKnowledgebaseDocumentVariation**](KnowledgeApi.html#deleteknowledgeknowledgebasedocumentvariation) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Delete a variation for a document. |
| [**DeleteKnowledgeKnowledgebaseExportJob**](KnowledgeApi.html#deleteknowledgeknowledgebaseexportjob) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId} | Delete export job |
| [**DeleteKnowledgeKnowledgebaseImportJob**](KnowledgeApi.html#deleteknowledgeknowledgebaseimportjob) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Delete import job |
| [**DeleteKnowledgeKnowledgebaseLabel**](KnowledgeApi.html#deleteknowledgeknowledgebaselabel) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Delete label |
| [**DeleteKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#deleteknowledgeknowledgebaselanguagecategory) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Delete category |
| [**DeleteKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#deleteknowledgeknowledgebaselanguagedocument) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Delete document |
| [**DeleteKnowledgeKnowledgebaseLanguageDocumentsImport**](KnowledgeApi.html#deleteknowledgeknowledgebaselanguagedocumentsimport) | **Delete** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/imports/{importId} | Delete import operation |
| [**GetKnowledgeGuestSessionCategories**](KnowledgeApi.html#getknowledgeguestsessioncategories) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/categories | Get categories |
| [**GetKnowledgeGuestSessionDocument**](KnowledgeApi.html#getknowledgeguestsessiondocument) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId} | Get a knowledge document by ID. |
| [**GetKnowledgeGuestSessionDocuments**](KnowledgeApi.html#getknowledgeguestsessiondocuments) | **Get** /api/v2/knowledge/guest/sessions/{sessionId}/documents | Get documents. |
| [**GetKnowledgeKnowledgebase**](KnowledgeApi.html#getknowledgeknowledgebase) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Get knowledge base |
| [**GetKnowledgeKnowledgebaseCategories**](KnowledgeApi.html#getknowledgeknowledgebasecategories) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories | Get categories |
| [**GetKnowledgeKnowledgebaseCategory**](KnowledgeApi.html#getknowledgeknowledgebasecategory) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Get category |
| [**GetKnowledgeKnowledgebaseDocument**](KnowledgeApi.html#getknowledgeknowledgebasedocument) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Get document. |
| [**GetKnowledgeKnowledgebaseDocumentFeedback**](KnowledgeApi.html#getknowledgeknowledgebasedocumentfeedback) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback | Get a list of feedback records given on a document |
| [**GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId**](KnowledgeApi.html#getknowledgeknowledgebasedocumentfeedbackfeedbackid) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback/{feedbackId} | Get a single feedback record given on a document |
| [**GetKnowledgeKnowledgebaseDocumentVariation**](KnowledgeApi.html#getknowledgeknowledgebasedocumentvariation) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Get a variation for a document. |
| [**GetKnowledgeKnowledgebaseDocumentVariations**](KnowledgeApi.html#getknowledgeknowledgebasedocumentvariations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations | Get variations for a document. |
| [**GetKnowledgeKnowledgebaseDocumentVersion**](KnowledgeApi.html#getknowledgeknowledgebasedocumentversion) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId} | Get document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersionVariation**](KnowledgeApi.html#getknowledgeknowledgebasedocumentversionvariation) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId}/variations/{variationId} | Get variation for the given document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersionVariations**](KnowledgeApi.html#getknowledgeknowledgebasedocumentversionvariations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions/{versionId}/variations | Get variations for the given document version. |
| [**GetKnowledgeKnowledgebaseDocumentVersions**](KnowledgeApi.html#getknowledgeknowledgebasedocumentversions) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions | Get document versions. |
| [**GetKnowledgeKnowledgebaseDocuments**](KnowledgeApi.html#getknowledgeknowledgebasedocuments) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents | Get documents. |
| [**GetKnowledgeKnowledgebaseExportJob**](KnowledgeApi.html#getknowledgeknowledgebaseexportjob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId} | Get export job report |
| [**GetKnowledgeKnowledgebaseImportJob**](KnowledgeApi.html#getknowledgeknowledgebaseimportjob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Get import job report |
| [**GetKnowledgeKnowledgebaseLabel**](KnowledgeApi.html#getknowledgeknowledgebaselabel) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Get label |
| [**GetKnowledgeKnowledgebaseLabels**](KnowledgeApi.html#getknowledgeknowledgebaselabels) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels | Get labels |
| [**GetKnowledgeKnowledgebaseLanguageCategories**](KnowledgeApi.html#getknowledgeknowledgebaselanguagecategories) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories | Get categories |
| [**GetKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#getknowledgeknowledgebaselanguagecategory) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Get category |
| [**GetKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocument) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Get document |
| [**GetKnowledgeKnowledgebaseLanguageDocumentUpload**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocumentupload) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}/uploads/{uploadId} | Get document content upload status |
| [**GetKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocuments) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Get documents |
| [**GetKnowledgeKnowledgebaseLanguageDocumentsImport**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocumentsimport) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/imports/{importId} | Get import operation report |
| [**GetKnowledgeKnowledgebaseLanguageTraining**](KnowledgeApi.html#getknowledgeknowledgebaselanguagetraining) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId} | Get training detail |
| [**GetKnowledgeKnowledgebaseLanguageTrainings**](KnowledgeApi.html#getknowledgeknowledgebaselanguagetrainings) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings | Get all trainings information for a knowledgebase |
| [**GetKnowledgeKnowledgebaseOperations**](KnowledgeApi.html#getknowledgeknowledgebaseoperations) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations | Get operations |
| [**GetKnowledgeKnowledgebaseOperationsUsersQuery**](KnowledgeApi.html#getknowledgeknowledgebaseoperationsusersquery) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations/users/query | Get ids of operation creator users and oauth clients |
| [**GetKnowledgeKnowledgebaseParseJob**](KnowledgeApi.html#getknowledgeknowledgebaseparsejob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId} | Get parse job report |
| [**GetKnowledgeKnowledgebaseUnansweredGroup**](KnowledgeApi.html#getknowledgeknowledgebaseunansweredgroup) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId} | Get knowledge base unanswered group for a particular groupId |
| [**GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup**](KnowledgeApi.html#getknowledgeknowledgebaseunansweredgroupphrasegroup) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId}/phrasegroups/{phraseGroupId} | Get knowledge base unanswered phrase group for a particular phraseGroupId |
| [**GetKnowledgeKnowledgebaseUnansweredGroups**](KnowledgeApi.html#getknowledgeknowledgebaseunansweredgroups) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups | Get knowledge base unanswered groups |
| [**GetKnowledgeKnowledgebaseUploadsUrlsJob**](KnowledgeApi.html#getknowledgeknowledgebaseuploadsurlsjob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId} | Get content upload from URL job status |
| [**GetKnowledgeKnowledgebases**](KnowledgeApi.html#getknowledgeknowledgebases) | **Get** /api/v2/knowledge/knowledgebases | Get knowledge bases |
| [**PatchKnowledgeGuestSessionDocumentsSearchSearchId**](KnowledgeApi.html#patchknowledgeguestsessiondocumentssearchsearchid) | **Patch** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search/{searchId} | Update search result. |
| [**PatchKnowledgeKnowledgebase**](KnowledgeApi.html#patchknowledgeknowledgebase) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Update knowledge base |
| [**PatchKnowledgeKnowledgebaseCategory**](KnowledgeApi.html#patchknowledgeknowledgebasecategory) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId} | Update category |
| [**PatchKnowledgeKnowledgebaseDocument**](KnowledgeApi.html#patchknowledgeknowledgebasedocument) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId} | Update document. |
| [**PatchKnowledgeKnowledgebaseDocumentVariation**](KnowledgeApi.html#patchknowledgeknowledgebasedocumentvariation) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId} | Update a variation for a document. |
| [**PatchKnowledgeKnowledgebaseDocumentsSearchSearchId**](KnowledgeApi.html#patchknowledgeknowledgebasedocumentssearchsearchid) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search/{searchId} | Update search result. |
| [**PatchKnowledgeKnowledgebaseImportJob**](KnowledgeApi.html#patchknowledgeknowledgebaseimportjob) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId} | Start import job |
| [**PatchKnowledgeKnowledgebaseLabel**](KnowledgeApi.html#patchknowledgeknowledgebaselabel) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId} | Update label |
| [**PatchKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagecategory) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Update category |
| [**PatchKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagedocument) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Update document |
| [**PatchKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagedocuments) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Update documents collection |
| [**PatchKnowledgeKnowledgebaseLanguageDocumentsImport**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagedocumentsimport) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/imports/{importId} | Start import operation |
| [**PatchKnowledgeKnowledgebaseParseJob**](KnowledgeApi.html#patchknowledgeknowledgebaseparsejob) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId} | Send update to the parse operation |
| [**PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup**](KnowledgeApi.html#patchknowledgeknowledgebaseunansweredgroupphrasegroup) | **Patch** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/unanswered/groups/{groupId}/phrasegroups/{phraseGroupId} | Update a Knowledge base unanswered phrase group |
| [**PostKnowledgeDocumentuploads**](KnowledgeApi.html#postknowledgedocumentuploads) | **Post** /api/v2/knowledge/documentuploads | Creates a presigned URL for uploading a knowledge import file with a set of documents |
| [**PostKnowledgeGuestSessionDocumentCopies**](KnowledgeApi.html#postknowledgeguestsessiondocumentcopies) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/copies | Indicate that the document was copied by the user. |
| [**PostKnowledgeGuestSessionDocumentFeedback**](KnowledgeApi.html#postknowledgeguestsessiondocumentfeedback) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/feedback | Give feedback on a document |
| [**PostKnowledgeGuestSessionDocumentViews**](KnowledgeApi.html#postknowledgeguestsessiondocumentviews) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}/views | Create view event for a document. |
| [**PostKnowledgeGuestSessionDocumentsPresentations**](KnowledgeApi.html#postknowledgeguestsessiondocumentspresentations) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/presentations | Indicate that documents were presented to the user. |
| [**PostKnowledgeGuestSessionDocumentsSearch**](KnowledgeApi.html#postknowledgeguestsessiondocumentssearch) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search | Search the documents in a guest session. |
| [**PostKnowledgeGuestSessionDocumentsSearchSuggestions**](KnowledgeApi.html#postknowledgeguestsessiondocumentssearchsuggestions) | **Post** /api/v2/knowledge/guest/sessions/{sessionId}/documents/search/suggestions | Query the knowledge documents to provide suggestions for auto completion. |
| [**PostKnowledgeGuestSessions**](KnowledgeApi.html#postknowledgeguestsessions) | **Post** /api/v2/knowledge/guest/sessions | Create guest session |
| [**PostKnowledgeKnowledgebaseCategories**](KnowledgeApi.html#postknowledgeknowledgebasecategories) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories | Create new category |
| [**PostKnowledgeKnowledgebaseDocumentCopies**](KnowledgeApi.html#postknowledgeknowledgebasedocumentcopies) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/copies | Indicate that the document was copied by the user. |
| [**PostKnowledgeKnowledgebaseDocumentFeedback**](KnowledgeApi.html#postknowledgeknowledgebasedocumentfeedback) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/feedback | Give feedback on a document |
| [**PostKnowledgeKnowledgebaseDocumentVariations**](KnowledgeApi.html#postknowledgeknowledgebasedocumentvariations) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations | Create a variation for a document. |
| [**PostKnowledgeKnowledgebaseDocumentVersions**](KnowledgeApi.html#postknowledgeknowledgebasedocumentversions) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/versions | Creates or restores a document version. |
| [**PostKnowledgeKnowledgebaseDocumentViews**](KnowledgeApi.html#postknowledgeknowledgebasedocumentviews) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/views | Create view for a document. |
| [**PostKnowledgeKnowledgebaseDocuments**](KnowledgeApi.html#postknowledgeknowledgebasedocuments) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents | Create document. |
| [**PostKnowledgeKnowledgebaseDocumentsBulkRemove**](KnowledgeApi.html#postknowledgeknowledgebasedocumentsbulkremove) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/bulk/remove | Bulk remove documents. |
| [**PostKnowledgeKnowledgebaseDocumentsBulkUpdate**](KnowledgeApi.html#postknowledgeknowledgebasedocumentsbulkupdate) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/bulk/update | Bulk update documents. |
| [**PostKnowledgeKnowledgebaseDocumentsPresentations**](KnowledgeApi.html#postknowledgeknowledgebasedocumentspresentations) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/presentations | Indicate that documents were presented to the user. |
| [**PostKnowledgeKnowledgebaseDocumentsSearch**](KnowledgeApi.html#postknowledgeknowledgebasedocumentssearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search | Search the documents in a knowledge base. |
| [**PostKnowledgeKnowledgebaseDocumentsSearchSuggestions**](KnowledgeApi.html#postknowledgeknowledgebasedocumentssearchsuggestions) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search/suggestions | Query the knowledge documents to provide suggestions for auto completion. |
| [**PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd**](KnowledgeApi.html#postknowledgeknowledgebasedocumentsversionsbulkadd) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/versions/bulk/add | Bulk add document versions. |
| [**PostKnowledgeKnowledgebaseExportJobs**](KnowledgeApi.html#postknowledgeknowledgebaseexportjobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs | Create export job |
| [**PostKnowledgeKnowledgebaseImportJobs**](KnowledgeApi.html#postknowledgeknowledgebaseimportjobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs | Create import job |
| [**PostKnowledgeKnowledgebaseLabels**](KnowledgeApi.html#postknowledgeknowledgebaselabels) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels | Create new label |
| [**PostKnowledgeKnowledgebaseLanguageCategories**](KnowledgeApi.html#postknowledgeknowledgebaselanguagecategories) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories | Create new category |
| [**PostKnowledgeKnowledgebaseLanguageDocumentUploads**](KnowledgeApi.html#postknowledgeknowledgebaselanguagedocumentuploads) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}/uploads | Upload Article Content |
| [**PostKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#postknowledgeknowledgebaselanguagedocuments) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Create document |
| [**PostKnowledgeKnowledgebaseLanguageDocumentsImports**](KnowledgeApi.html#postknowledgeknowledgebaselanguagedocumentsimports) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/imports | Create import operation |
| [**PostKnowledgeKnowledgebaseLanguageTrainingPromote**](KnowledgeApi.html#postknowledgeknowledgebaselanguagetrainingpromote) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}/promote | Promote trained documents from draft state to active. |
| [**PostKnowledgeKnowledgebaseLanguageTrainings**](KnowledgeApi.html#postknowledgeknowledgebaselanguagetrainings) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings | Trigger training |
| [**PostKnowledgeKnowledgebaseParseJobImport**](KnowledgeApi.html#postknowledgeknowledgebaseparsejobimport) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs/{parseJobId}/import | Import the parsed articles |
| [**PostKnowledgeKnowledgebaseParseJobs**](KnowledgeApi.html#postknowledgeknowledgebaseparsejobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/parse/jobs | Create parse job |
| [**PostKnowledgeKnowledgebaseSearch**](KnowledgeApi.html#postknowledgeknowledgebasesearch) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search | Search Documents |
| [**PostKnowledgeKnowledgebaseUploadsUrlsJobs**](KnowledgeApi.html#postknowledgeknowledgebaseuploadsurlsjobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs | Create content upload from URL job |
| [**PostKnowledgeKnowledgebases**](KnowledgeApi.html#postknowledgeknowledgebases) | **Post** /api/v2/knowledge/knowledgebases | Create new knowledge base |
{: class="table table-striped"}

<a name="deleteknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) DeleteKnowledgeKnowledgebase (string knowledgeBaseId)



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
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="deleteknowledgeknowledgebasecategory"></a>

## [**CategoryResponse**](CategoryResponse.html) DeleteKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId)



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
{: class="table table-striped"}

### Return type

[**CategoryResponse**](CategoryResponse.html)

<a name="deleteknowledgeknowledgebasedocument"></a>

## void DeleteKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteknowledgeknowledgebasedocumentvariation"></a>

## void DeleteKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteknowledgeknowledgebaseexportjob"></a>

## void DeleteKnowledgeKnowledgebaseExportJob (string knowledgeBaseId, string exportJobId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteknowledgeknowledgebaseimportjob"></a>

## void DeleteKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteknowledgeknowledgebaselabel"></a>

## [**LabelResponse**](LabelResponse.html) DeleteKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId)



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
{: class="table table-striped"}

### Return type

[**LabelResponse**](LabelResponse.html)

<a name="deleteknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeCategory**](KnowledgeCategory.html) DeleteKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
    public class DeleteKnowledgeKnowledgebaseLanguageCategoryExample
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
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Delete category
                KnowledgeCategory result = apiInstance.DeleteKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
{: class="table table-striped"}

### Return type

[**KnowledgeCategory**](KnowledgeCategory.html)

<a name="deleteknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) DeleteKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete document

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
    public class DeleteKnowledgeKnowledgebaseLanguageDocumentExample
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
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Delete document
                KnowledgeDocument result = apiInstance.DeleteKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="deleteknowledgeknowledgebaselanguagedocumentsimport"></a>

## void DeleteKnowledgeKnowledgebaseLanguageDocumentsImport (string knowledgeBaseId, string languageCode, string importId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete import operation

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
    public class DeleteKnowledgeKnowledgebaseLanguageDocumentsImportExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var importId = importId_example;  // string | Import ID

            try
            { 
                // Delete import operation
                apiInstance.DeleteKnowledgeKnowledgebaseLanguageDocumentsImport(knowledgeBaseId, languageCode, importId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLanguageDocumentsImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **importId** | **string**| Import ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getknowledgeguestsessioncategories"></a>

## [**GuestCategoryResponseListing**](GuestCategoryResponseListing.html) GetKnowledgeGuestSessionCategories (string sessionId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null)



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
{: class="table table-striped"}

### Return type

[**GuestCategoryResponseListing**](GuestCategoryResponseListing.html)

<a name="getknowledgeguestsessiondocument"></a>

## [**KnowledgeGuestDocument**](KnowledgeGuestDocument.html) GetKnowledgeGuestSessionDocument (string sessionId, string documentId)



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
                KnowledgeGuestDocument result = apiInstance.GetKnowledgeGuestSessionDocument(sessionId, documentId);
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
{: class="table table-striped"}

### Return type

[**KnowledgeGuestDocument**](KnowledgeGuestDocument.html)

<a name="getknowledgeguestsessiondocuments"></a>

## [**KnowledgeGuestDocumentResponseListing**](KnowledgeGuestDocumentResponseListing.html) GetKnowledgeGuestSessionDocuments (string sessionId, List<string> categoryId = null, int? pageSize = null)



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
| **categoryId** | [**List<string>**](string.html)| If specified, retrieves documents associated with category ids, comma separated values expected. | [optional]  |
| **pageSize** | **int?**| Number of entities to return. Maximum of 200. | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeGuestDocumentResponseListing**](KnowledgeGuestDocumentResponseListing.html)

<a name="getknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) GetKnowledgeKnowledgebase (string knowledgeBaseId)



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
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="getknowledgeknowledgebasecategories"></a>

## [**CategoryResponseListing**](CategoryResponseListing.html) GetKnowledgeKnowledgebaseCategories (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null)



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
{: class="table table-striped"}

### Return type

[**CategoryResponseListing**](CategoryResponseListing.html)

<a name="getknowledgeknowledgebasecategory"></a>

## [**CategoryResponse**](CategoryResponse.html) GetKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId)



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
{: class="table table-striped"}

### Return type

[**CategoryResponse**](CategoryResponse.html)

<a name="getknowledgeknowledgebasedocument"></a>

## [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html) GetKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId, List<string> expand = null, string state = null)



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
| **expand** | [**List<string>**](string.html)| The specified entity attributes will be filled. Comma separated values expected. Max No. of variations that can be returned on expand is 20. | [optional] <br />**Values**: category, labels, variations |
| **state** | **string**| \&quot;when state is \&quot;Draft\&quot;, draft version of the document is returned,otherwise by default published version is returned in the response. | [optional] <br />**Values**: Draft, Published |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html)

<a name="getknowledgeknowledgebasedocumentfeedback"></a>

## [**KnowledgeDocumentFeedbackResponseListing**](KnowledgeDocumentFeedbackResponseListing.html) GetKnowledgeKnowledgebaseDocumentFeedback (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, bool? onlyCommented = null, string documentVersionId = null, string documentVariationId = null, string appType = null, string queryType = null, string userId = null, string queueId = null, string state = null)



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
| **queryType** | **string**| Query type to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional] <br />**Values**: Unknown, Article, AutoSearch, Category, ManualSearch, Recommendation, Suggestion |
| **userId** | **string**| The ID of the user, who created the feedback, to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **queueId** | **string**| Queue ID to filter by. Supported only if onlyCommented&#x3D;true is set. | [optional]  |
| **state** | **string**| State to filter by. Supported only if onlyCommented&#x3D;true is set. Default: Final | [optional] <br />**Values**: All, Draft, Final |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentFeedbackResponseListing**](KnowledgeDocumentFeedbackResponseListing.html)

<a name="getknowledgeknowledgebasedocumentfeedbackfeedbackid"></a>

## [**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse.html) GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackId (string knowledgeBaseId, string documentId, string feedbackId)



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
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse.html)

<a name="getknowledgeknowledgebasedocumentvariation"></a>

## [**DocumentVariation**](DocumentVariation.html) GetKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId, string documentState = null)



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

            try
            { 
                // Get a variation for a document.
                DocumentVariation result = apiInstance.GetKnowledgeKnowledgebaseDocumentVariation(documentVariationId, documentId, knowledgeBaseId, documentState);
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
{: class="table table-striped"}

### Return type

[**DocumentVariation**](DocumentVariation.html)

<a name="getknowledgeknowledgebasedocumentvariations"></a>

## [**DocumentVariationListing**](DocumentVariationListing.html) GetKnowledgeKnowledgebaseDocumentVariations (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, string documentState = null)



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

            try
            { 
                // Get variations for a document.
                DocumentVariationListing result = apiInstance.GetKnowledgeKnowledgebaseDocumentVariations(knowledgeBaseId, documentId, before, after, pageSize, documentState);
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
{: class="table table-striped"}

### Return type

[**DocumentVariationListing**](DocumentVariationListing.html)

<a name="getknowledgeknowledgebasedocumentversion"></a>

## [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion.html) GetKnowledgeKnowledgebaseDocumentVersion (string knowledgeBaseId, string documentId, string versionId, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentVersion**](KnowledgeDocumentVersion.html)

<a name="getknowledgeknowledgebasedocumentversionvariation"></a>

## [**KnowledgeDocumentVersionVariation**](KnowledgeDocumentVersionVariation.html) GetKnowledgeKnowledgebaseDocumentVersionVariation (string knowledgeBaseId, string documentId, string versionId, string variationId)



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
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentVersionVariation**](KnowledgeDocumentVersionVariation.html)

<a name="getknowledgeknowledgebasedocumentversionvariations"></a>

## [**KnowledgeDocumentVersionVariationListing**](KnowledgeDocumentVersionVariationListing.html) GetKnowledgeKnowledgebaseDocumentVersionVariations (string knowledgeBaseId, string documentId, string versionId, string before = null, string after = null, string pageSize = null)



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
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentVersionVariationListing**](KnowledgeDocumentVersionVariationListing.html)

<a name="getknowledgeknowledgebasedocumentversions"></a>

## [**KnowledgeDocumentVersionListing**](KnowledgeDocumentVersionListing.html) GetKnowledgeKnowledgebaseDocumentVersions (string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentVersionListing**](KnowledgeDocumentVersionListing.html)

<a name="getknowledgeknowledgebasedocuments"></a>

## [**KnowledgeDocumentResponseListing**](KnowledgeDocumentResponseListing.html) GetKnowledgeKnowledgebaseDocuments (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, List<string> documentId = null, List<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, List<string> labelIds = null, List<string> expand = null, List<string> externalIds = null)



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
| **documentId** | [**List<string>**](string.html)| Retrieves the specified documents, comma separated values expected. | [optional]  |
| **categoryId** | [**List<string>**](string.html)| If specified, retrieves documents associated with category ids, comma separated values expected. | [optional]  |
| **includeSubcategories** | **bool?**| Works along with &#39;categoryId&#39; query parameter. If specified, retrieves documents associated with category ids and its children categories. | [optional]  |
| **includeDrafts** | **bool?**| If includeDrafts is true, Documents in the draft state are also returned in the response. | [optional]  |
| **labelIds** | [**List<string>**](string.html)| If specified, retrieves documents associated with label ids, comma separated values expected. | [optional]  |
| **expand** | [**List<string>**](string.html)| The specified entity attributes will be filled. Comma separated values expected. | [optional] <br />**Values**: category, labels, variations |
| **externalIds** | [**List<string>**](string.html)| If specified, retrieves documents associated with external ids, comma separated values expected. | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentResponseListing**](KnowledgeDocumentResponseListing.html)

<a name="getknowledgeknowledgebaseexportjob"></a>

## [**KnowledgeExportJobResponse**](KnowledgeExportJobResponse.html) GetKnowledgeKnowledgebaseExportJob (string knowledgeBaseId, string exportJobId)



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
{: class="table table-striped"}

### Return type

[**KnowledgeExportJobResponse**](KnowledgeExportJobResponse.html)

<a name="getknowledgeknowledgebaseimportjob"></a>

## [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html) GetKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| If expand contains &#39;urls&#39; downloadURL and failedEntitiesURL will be filled. | [optional] <br />**Values**: urls |
{: class="table table-striped"}

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html)

<a name="getknowledgeknowledgebaselabel"></a>

## [**LabelResponse**](LabelResponse.html) GetKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId)



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
{: class="table table-striped"}

### Return type

[**LabelResponse**](LabelResponse.html)

<a name="getknowledgeknowledgebaselabels"></a>

## [**LabelListing**](LabelListing.html) GetKnowledgeKnowledgebaseLabels (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null)



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
{: class="table table-striped"}

### Return type

[**LabelListing**](LabelListing.html)

<a name="getknowledgeknowledgebaselanguagecategories"></a>

## [**CategoryListing**](CategoryListing.html) GetKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
    public class GetKnowledgeKnowledgebaseLanguageCategoriesExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Filter to return the categories that starts with the given category name. (optional) 

            try
            { 
                // Get categories
                CategoryListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageCategories(knowledgeBaseId, languageCode, before, after, limit, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Filter to return the categories that starts with the given category name. | [optional]  |
{: class="table table-striped"}

### Return type

[**CategoryListing**](CategoryListing.html)

<a name="getknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) GetKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
    public class GetKnowledgeKnowledgebaseLanguageCategoryExample
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
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Get category
                KnowledgeExtendedCategory result = apiInstance.GetKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="getknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) GetKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get document

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
    public class GetKnowledgeKnowledgebaseLanguageDocumentExample
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
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Get document
                KnowledgeDocument result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="getknowledgeknowledgebaselanguagedocumentupload"></a>

## [**KnowledgeDocumentContentUpload**](KnowledgeDocumentContentUpload.html) GetKnowledgeKnowledgebaseLanguageDocumentUpload (string documentId, string knowledgeBaseId, string languageCode, string uploadId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get document content upload status

GetKnowledgeKnowledgebaseLanguageDocumentUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetKnowledgeKnowledgebaseLanguageDocumentUploadExample
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
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var uploadId = uploadId_example;  // string | UploadId

            try
            { 
                // Get document content upload status
                KnowledgeDocumentContentUpload result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocumentUpload(documentId, knowledgeBaseId, languageCode, uploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocumentUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **uploadId** | **string**| UploadId |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentContentUpload**](KnowledgeDocumentContentUpload.html)

<a name="getknowledgeknowledgebaselanguagedocuments"></a>

## [**DocumentListing**](DocumentListing.html) GetKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null, string sortBy = null, string sortOrder = null, List<string> documentIds = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get documents

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
    public class GetKnowledgeKnowledgebaseLanguageDocumentsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var categories = categories_example;  // string | Filter by categories ids, comma separated values expected. (optional) 
            var title = title_example;  // string | Filter by document title. (optional) 
            var sortBy = sortBy_example;  // string | Sort by. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort Order. (optional) 
            var documentIds = new List<string>(); // List<string> | Comma-separated list of document identifiers to fetch by. (optional) 

            try
            { 
                // Get documents
                DocumentListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, before, after, limit, pageSize, categories, title, sortBy, sortOrder, documentIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **categories** | **string**| Filter by categories ids, comma separated values expected. | [optional]  |
| **title** | **string**| Filter by document title. | [optional]  |
| **sortBy** | **string**| Sort by. | [optional] <br />**Values**: Title, Date |
| **sortOrder** | **string**| Sort Order. | [optional] <br />**Values**: ASC, ascending, DESC, descending |
| **documentIds** | [**List<string>**](string.html)| Comma-separated list of document identifiers to fetch by. | [optional]  |
{: class="table table-striped"}

### Return type

[**DocumentListing**](DocumentListing.html)

<a name="getknowledgeknowledgebaselanguagedocumentsimport"></a>

## [**KnowledgeImport**](KnowledgeImport.html) GetKnowledgeKnowledgebaseLanguageDocumentsImport (string knowledgeBaseId, string languageCode, string importId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get import operation report

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
    public class GetKnowledgeKnowledgebaseLanguageDocumentsImportExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var importId = importId_example;  // string | Import ID

            try
            { 
                // Get import operation report
                KnowledgeImport result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocumentsImport(knowledgeBaseId, languageCode, importId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocumentsImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **importId** | **string**| Import ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeImport**](KnowledgeImport.html)

<a name="getknowledgeknowledgebaselanguagetraining"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) GetKnowledgeKnowledgebaseLanguageTraining (string knowledgeBaseId, string languageCode, string trainingId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get training detail

Requires ALL permissions: 

* knowledge:training:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageTrainingExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var trainingId = trainingId_example;  // string | Training ID

            try
            { 
                // Get training detail
                KnowledgeTraining result = apiInstance.GetKnowledgeKnowledgebaseLanguageTraining(knowledgeBaseId, languageCode, trainingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageTraining: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **trainingId** | **string**| Training ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="getknowledgeknowledgebaselanguagetrainings"></a>

## [**TrainingListing**](TrainingListing.html) GetKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get all trainings information for a knowledgebase

Requires ALL permissions: 

* knowledge:training:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageTrainingsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var knowledgeDocumentsState = knowledgeDocumentsState_example;  // string | Return the training with the specified state of the trained documents. (optional) 

            try
            { 
                // Get all trainings information for a knowledgebase
                TrainingListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageTrainings(knowledgeBaseId, languageCode, before, after, limit, pageSize, knowledgeDocumentsState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageTrainings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **knowledgeDocumentsState** | **string**| Return the training with the specified state of the trained documents. | [optional] <br />**Values**: Draft, Active, Discarded, Archived |
{: class="table table-striped"}

### Return type

[**TrainingListing**](TrainingListing.html)

<a name="getknowledgeknowledgebaseoperations"></a>

## [**OperationListing**](OperationListing.html) GetKnowledgeKnowledgebaseOperations (string knowledgeBaseId, string before = null, string after = null, string pageSize = null, List<string> userId = null, List<string> type = null, List<string> status = null, string interval = null)



Get operations

GetKnowledgeKnowledgebaseOperations is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

            try
            { 
                // Get operations
                OperationListing result = apiInstance.GetKnowledgeKnowledgebaseOperations(knowledgeBaseId, before, after, pageSize, userId, type, status, interval);
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
| **userId** | [**List<string>**](string.html)| If specified, retrieves operations associated with user ids, comma separated values expected. | [optional]  |
| **type** | [**List<string>**](string.html)| If specified, retrieves operations with specified operation type, comma separated values expected. | [optional] <br />**Values**: Export, Import, Parse, Sync |
| **status** | [**List<string>**](string.html)| If specified, retrieves operations with specified operation status, comma separated values expected. | [optional]  |
| **interval** | **string**| Retrieves the operations modified in specified date and time range. If the after and before cursor parameters are within this interval, it would return valid data, otherwise it throws an error.The dates in the interval are represented in ISO-8601 format: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ | [optional]  |
{: class="table table-striped"}

### Return type

[**OperationListing**](OperationListing.html)

<a name="getknowledgeknowledgebaseoperationsusersquery"></a>

## [**OperationCreatorUserResponse**](OperationCreatorUserResponse.html) GetKnowledgeKnowledgebaseOperationsUsersQuery (string knowledgeBaseId)



Get ids of operation creator users and oauth clients

GetKnowledgeKnowledgebaseOperationsUsersQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

[**OperationCreatorUserResponse**](OperationCreatorUserResponse.html)

<a name="getknowledgeknowledgebaseparsejob"></a>

## [**KnowledgeParseJobResponse**](KnowledgeParseJobResponse.html) GetKnowledgeKnowledgebaseParseJob (string knowledgeBaseId, string parseJobId, List<string> expand = null)



Get parse job report

GetKnowledgeKnowledgebaseParseJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **expand** | [**List<string>**](string.html)| If expand contains &#39;urls&#39; downloadURL and failedEntitiesURL will be filled. | [optional] <br />**Values**: urls |
{: class="table table-striped"}

### Return type

[**KnowledgeParseJobResponse**](KnowledgeParseJobResponse.html)

<a name="getknowledgeknowledgebaseunansweredgroup"></a>

## [**UnansweredGroup**](UnansweredGroup.html) GetKnowledgeKnowledgebaseUnansweredGroup (string knowledgeBaseId, string groupId, string app = null, String dateStart = null, String dateEnd = null)



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
{: class="table table-striped"}

### Return type

[**UnansweredGroup**](UnansweredGroup.html)

<a name="getknowledgeknowledgebaseunansweredgroupphrasegroup"></a>

## [**UnansweredPhraseGroup**](UnansweredPhraseGroup.html) GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroup (string knowledgeBaseId, string groupId, string phraseGroupId, string app = null, String dateStart = null, String dateEnd = null)



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
{: class="table table-striped"}

### Return type

[**UnansweredPhraseGroup**](UnansweredPhraseGroup.html)

<a name="getknowledgeknowledgebaseunansweredgroups"></a>

## [**UnansweredGroups**](UnansweredGroups.html) GetKnowledgeKnowledgebaseUnansweredGroups (string knowledgeBaseId, string app = null, String dateStart = null, String dateEnd = null)



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
{: class="table table-striped"}

### Return type

[**UnansweredGroups**](UnansweredGroups.html)

<a name="getknowledgeknowledgebaseuploadsurlsjob"></a>

## [**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse.html) GetKnowledgeKnowledgebaseUploadsUrlsJob (string knowledgeBaseId, string jobId)



Get content upload from URL job status

GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

[**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse.html)

<a name="getknowledgeknowledgebases"></a>

## [**KnowledgeBaseListing**](KnowledgeBaseListing.html) GetKnowledgeKnowledgebases (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null)



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
| **coreLanguage** | **string**| Filter by core language. | [optional] <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **published** | **bool?**| Filter by published status. | [optional]  |
| **sortBy** | **string**| Sort by. | [optional] <br />**Values**: Name, Date |
| **sortOrder** | **string**| Sort Order. | [optional] <br />**Values**: ASC, ascending, DESC, descending |
{: class="table table-striped"}

### Return type

[**KnowledgeBaseListing**](KnowledgeBaseListing.html)

<a name="patchknowledgeguestsessiondocumentssearchsearchid"></a>

## void PatchKnowledgeGuestSessionDocumentsSearchSearchId (string sessionId, string searchId, SearchUpdateRequest body)



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
| **body** | [**SearchUpdateRequest**](SearchUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) PatchKnowledgeKnowledgebase (string knowledgeBaseId, KnowledgeBaseUpdateRequest body)



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
| **body** | [**KnowledgeBaseUpdateRequest**](KnowledgeBaseUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="patchknowledgeknowledgebasecategory"></a>

## [**CategoryResponse**](CategoryResponse.html) PatchKnowledgeKnowledgebaseCategory (string knowledgeBaseId, string categoryId, CategoryUpdateRequest body)



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
| **body** | [**CategoryUpdateRequest**](CategoryUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**CategoryResponse**](CategoryResponse.html)

<a name="patchknowledgeknowledgebasedocument"></a>

## [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html) PatchKnowledgeKnowledgebaseDocument (string knowledgeBaseId, string documentId, KnowledgeDocumentReq body)



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
| **body** | [**KnowledgeDocumentReq**](KnowledgeDocumentReq.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html)

<a name="patchknowledgeknowledgebasedocumentvariation"></a>

## [**DocumentVariation**](DocumentVariation.html) PatchKnowledgeKnowledgebaseDocumentVariation (string documentVariationId, string documentId, string knowledgeBaseId, DocumentVariation body)



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
            var body = new DocumentVariation(); // DocumentVariation | 

            try
            { 
                // Update a variation for a document.
                DocumentVariation result = apiInstance.PatchKnowledgeKnowledgebaseDocumentVariation(documentVariationId, documentId, knowledgeBaseId, body);
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
| **body** | [**DocumentVariation**](DocumentVariation.html)|  |  |
{: class="table table-striped"}

### Return type

[**DocumentVariation**](DocumentVariation.html)

<a name="patchknowledgeknowledgebasedocumentssearchsearchid"></a>

## void PatchKnowledgeKnowledgebaseDocumentsSearchSearchId (string knowledgeBaseId, string searchId, SearchUpdateRequest body = null)



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
| **body** | [**SearchUpdateRequest**](SearchUpdateRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchknowledgeknowledgebaseimportjob"></a>

## [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html) PatchKnowledgeKnowledgebaseImportJob (string knowledgeBaseId, string importJobId, ImportStatusRequest body)



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
| **body** | [**ImportStatusRequest**](ImportStatusRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html)

<a name="patchknowledgeknowledgebaselabel"></a>

## [**LabelResponse**](LabelResponse.html) PatchKnowledgeKnowledgebaseLabel (string knowledgeBaseId, string labelId, LabelUpdateRequest body)



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
| **body** | [**LabelUpdateRequest**](LabelUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**LabelResponse**](LabelResponse.html)

<a name="patchknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) PatchKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
    public class PatchKnowledgeKnowledgebaseLanguageCategoryExample
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
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeCategoryRequest(); // KnowledgeCategoryRequest | 

            try
            { 
                // Update category
                KnowledgeExtendedCategory result = apiInstance.PatchKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeCategoryRequest**](KnowledgeCategoryRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="patchknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) PatchKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update document

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
    public class PatchKnowledgeKnowledgebaseLanguageDocumentExample
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
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeDocumentRequest(); // KnowledgeDocumentRequest | 

            try
            { 
                // Update document
                KnowledgeDocument result = apiInstance.PatchKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeDocumentRequest**](KnowledgeDocumentRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="patchknowledgeknowledgebaselanguagedocuments"></a>

## [**DocumentListing**](DocumentListing.html) PatchKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update documents collection

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
    public class PatchKnowledgeKnowledgebaseLanguageDocumentsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new List<KnowledgeDocumentBulkRequest>(); // List<KnowledgeDocumentBulkRequest> | 

            try
            { 
                // Update documents collection
                DocumentListing result = apiInstance.PatchKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**List<KnowledgeDocumentBulkRequest>**](KnowledgeDocumentBulkRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**DocumentListing**](DocumentListing.html)

<a name="patchknowledgeknowledgebaselanguagedocumentsimport"></a>

## [**KnowledgeImport**](KnowledgeImport.html) PatchKnowledgeKnowledgebaseLanguageDocumentsImport (string knowledgeBaseId, string languageCode, string importId, ImportStatusRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Start import operation

Requires ALL permissions: 

* knowledge:document:edit
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
    public class PatchKnowledgeKnowledgebaseLanguageDocumentsImportExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var importId = importId_example;  // string | Import ID
            var body = new ImportStatusRequest(); // ImportStatusRequest | 

            try
            { 
                // Start import operation
                KnowledgeImport result = apiInstance.PatchKnowledgeKnowledgebaseLanguageDocumentsImport(knowledgeBaseId, languageCode, importId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageDocumentsImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **importId** | **string**| Import ID |  |
| **body** | [**ImportStatusRequest**](ImportStatusRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeImport**](KnowledgeImport.html)

<a name="patchknowledgeknowledgebaseparsejob"></a>

## void PatchKnowledgeKnowledgebaseParseJob (string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestPatch body)



Send update to the parse operation

PatchKnowledgeKnowledgebaseParseJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeParseJobRequestPatch**](KnowledgeParseJobRequestPatch.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchknowledgeknowledgebaseunansweredgroupphrasegroup"></a>

## [**UnansweredPhraseGroupUpdateResponse**](UnansweredPhraseGroupUpdateResponse.html) PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroup (string knowledgeBaseId, string groupId, string phraseGroupId, UnansweredPhraseGroupPatchRequestBody body)



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
| **body** | [**UnansweredPhraseGroupPatchRequestBody**](UnansweredPhraseGroupPatchRequestBody.html)| Request body of the update unanswered group endpoint. |  |
{: class="table table-striped"}

### Return type

[**UnansweredPhraseGroupUpdateResponse**](UnansweredPhraseGroupUpdateResponse.html)

<a name="postknowledgedocumentuploads"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostKnowledgeDocumentuploads (UploadUrlRequest body)



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
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postknowledgeguestsessiondocumentcopies"></a>

## void PostKnowledgeGuestSessionDocumentCopies (string sessionId, string documentId, KnowledgeGuestDocumentCopy body = null)



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
| **body** | [**KnowledgeGuestDocumentCopy**](KnowledgeGuestDocumentCopy.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeguestsessiondocumentfeedback"></a>

## [**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback.html) PostKnowledgeGuestSessionDocumentFeedback (string sessionId, string documentId, KnowledgeGuestDocumentFeedback body = null)



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
| **body** | [**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeGuestDocumentFeedback**](KnowledgeGuestDocumentFeedback.html)

<a name="postknowledgeguestsessiondocumentviews"></a>

## void PostKnowledgeGuestSessionDocumentViews (string sessionId, string documentId, KnowledgeGuestDocumentView body = null)



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
| **body** | [**KnowledgeGuestDocumentView**](KnowledgeGuestDocumentView.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeguestsessiondocumentspresentations"></a>

## void PostKnowledgeGuestSessionDocumentsPresentations (string sessionId, KnowledgeGuestDocumentPresentation body = null)



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
| **body** | [**KnowledgeGuestDocumentPresentation**](KnowledgeGuestDocumentPresentation.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeguestsessiondocumentssearch"></a>

## [**KnowledgeDocumentGuestSearch**](KnowledgeDocumentGuestSearch.html) PostKnowledgeGuestSessionDocumentsSearch (string sessionId, List<string> expand = null, KnowledgeDocumentGuestSearchRequest body = null)



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
| **expand** | [**List<string>**](string.html)| Fields, if any, to expand for each document in the search result matching the query. | [optional] <br />**Values**: documentVariations, documentAlternatives |
| **body** | [**KnowledgeDocumentGuestSearchRequest**](KnowledgeDocumentGuestSearchRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentGuestSearch**](KnowledgeDocumentGuestSearch.html)

<a name="postknowledgeguestsessiondocumentssearchsuggestions"></a>

## [**KnowledgeGuestDocumentSuggestion**](KnowledgeGuestDocumentSuggestion.html) PostKnowledgeGuestSessionDocumentsSearchSuggestions (string sessionId, KnowledgeGuestDocumentSuggestionRequest body = null)



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
| **body** | [**KnowledgeGuestDocumentSuggestionRequest**](KnowledgeGuestDocumentSuggestionRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeGuestDocumentSuggestion**](KnowledgeGuestDocumentSuggestion.html)

<a name="postknowledgeguestsessions"></a>

## [**KnowledgeGuestSession**](KnowledgeGuestSession.html) PostKnowledgeGuestSessions (KnowledgeGuestSession body)



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
| **body** | [**KnowledgeGuestSession**](KnowledgeGuestSession.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeGuestSession**](KnowledgeGuestSession.html)

<a name="postknowledgeknowledgebasecategories"></a>

## [**CategoryResponse**](CategoryResponse.html) PostKnowledgeKnowledgebaseCategories (string knowledgeBaseId, CategoryCreateRequest body)



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
| **body** | [**CategoryCreateRequest**](CategoryCreateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**CategoryResponse**](CategoryResponse.html)

<a name="postknowledgeknowledgebasedocumentcopies"></a>

## void PostKnowledgeKnowledgebaseDocumentCopies (string knowledgeBaseId, string documentId, KnowledgeDocumentCopy body = null)



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
| **body** | [**KnowledgeDocumentCopy**](KnowledgeDocumentCopy.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeknowledgebasedocumentfeedback"></a>

## [**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse.html) PostKnowledgeKnowledgebaseDocumentFeedback (string knowledgeBaseId, string documentId, KnowledgeDocumentFeedback body = null)



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
| **body** | [**KnowledgeDocumentFeedback**](KnowledgeDocumentFeedback.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentFeedbackResponse**](KnowledgeDocumentFeedbackResponse.html)

<a name="postknowledgeknowledgebasedocumentvariations"></a>

## [**DocumentVariation**](DocumentVariation.html) PostKnowledgeKnowledgebaseDocumentVariations (string knowledgeBaseId, string documentId, DocumentVariation body)



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
            var body = new DocumentVariation(); // DocumentVariation | 

            try
            { 
                // Create a variation for a document.
                DocumentVariation result = apiInstance.PostKnowledgeKnowledgebaseDocumentVariations(knowledgeBaseId, documentId, body);
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
| **body** | [**DocumentVariation**](DocumentVariation.html)|  |  |
{: class="table table-striped"}

### Return type

[**DocumentVariation**](DocumentVariation.html)

<a name="postknowledgeknowledgebasedocumentversions"></a>

## [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion.html) PostKnowledgeKnowledgebaseDocumentVersions (string knowledgeBaseId, string documentId, KnowledgeDocumentVersion body)



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
| **body** | [**KnowledgeDocumentVersion**](KnowledgeDocumentVersion.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentVersion**](KnowledgeDocumentVersion.html)

<a name="postknowledgeknowledgebasedocumentviews"></a>

## void PostKnowledgeKnowledgebaseDocumentViews (string knowledgeBaseId, string documentId, KnowledgeDocumentView body = null)



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
| **body** | [**KnowledgeDocumentView**](KnowledgeDocumentView.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeknowledgebasedocuments"></a>

## [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html) PostKnowledgeKnowledgebaseDocuments (string knowledgeBaseId, KnowledgeDocumentReq body)



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
            var body = new KnowledgeDocumentReq(); // KnowledgeDocumentReq | 

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
| **body** | [**KnowledgeDocumentReq**](KnowledgeDocumentReq.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentResponse**](KnowledgeDocumentResponse.html)

<a name="postknowledgeknowledgebasedocumentsbulkremove"></a>

## [**BulkResponse**](BulkResponse.html) PostKnowledgeKnowledgebaseDocumentsBulkRemove (string knowledgeBaseId, KnowledgeDocumentBulkRemoveRequest body)



Bulk remove documents.

PostKnowledgeKnowledgebaseDocumentsBulkRemove is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeDocumentBulkRemoveRequest**](KnowledgeDocumentBulkRemoveRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="postknowledgeknowledgebasedocumentsbulkupdate"></a>

## [**BulkResponse**](BulkResponse.html) PostKnowledgeKnowledgebaseDocumentsBulkUpdate (string knowledgeBaseId, KnowledgeDocumentBulkUpdateRequest body)



Bulk update documents.

PostKnowledgeKnowledgebaseDocumentsBulkUpdate is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeDocumentBulkUpdateRequest**](KnowledgeDocumentBulkUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="postknowledgeknowledgebasedocumentspresentations"></a>

## void PostKnowledgeKnowledgebaseDocumentsPresentations (string knowledgeBaseId, KnowledgeDocumentPresentation body = null)



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
| **body** | [**KnowledgeDocumentPresentation**](KnowledgeDocumentPresentation.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeknowledgebasedocumentssearch"></a>

## [**KnowledgeDocumentSearch**](KnowledgeDocumentSearch.html) PostKnowledgeKnowledgebaseDocumentsSearch (string knowledgeBaseId, List<string> expand = null, KnowledgeDocumentSearchRequest body = null)



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
| **expand** | [**List<string>**](string.html)| Fields, if any, to expand for each document in the search result matching the query. | [optional] <br />**Values**: documentVariations, documentAlternatives |
| **body** | [**KnowledgeDocumentSearchRequest**](KnowledgeDocumentSearchRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentSearch**](KnowledgeDocumentSearch.html)

<a name="postknowledgeknowledgebasedocumentssearchsuggestions"></a>

## [**KnowledgeDocumentSuggestion**](KnowledgeDocumentSuggestion.html) PostKnowledgeKnowledgebaseDocumentsSearchSuggestions (string knowledgeBaseId, KnowledgeDocumentSuggestionRequest body = null)



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
| **body** | [**KnowledgeDocumentSuggestionRequest**](KnowledgeDocumentSuggestionRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentSuggestion**](KnowledgeDocumentSuggestion.html)

<a name="postknowledgeknowledgebasedocumentsversionsbulkadd"></a>

## [**BulkResponse**](BulkResponse.html) PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd (string knowledgeBaseId, KnowledgeDocumentBulkVersionAddRequest body)



Bulk add document versions.

PostKnowledgeKnowledgebaseDocumentsVersionsBulkAdd is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeDocumentBulkVersionAddRequest**](KnowledgeDocumentBulkVersionAddRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="postknowledgeknowledgebaseexportjobs"></a>

## [**KnowledgeExportJobResponse**](KnowledgeExportJobResponse.html) PostKnowledgeKnowledgebaseExportJobs (string knowledgeBaseId, KnowledgeExportJobRequest body)



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
| **body** | [**KnowledgeExportJobRequest**](KnowledgeExportJobRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeExportJobResponse**](KnowledgeExportJobResponse.html)

<a name="postknowledgeknowledgebaseimportjobs"></a>

## [**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html) PostKnowledgeKnowledgebaseImportJobs (string knowledgeBaseId, KnowledgeImportJobRequest body)



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
| **body** | [**KnowledgeImportJobRequest**](KnowledgeImportJobRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeImportJobResponse**](KnowledgeImportJobResponse.html)

<a name="postknowledgeknowledgebaselabels"></a>

## [**LabelResponse**](LabelResponse.html) PostKnowledgeKnowledgebaseLabels (string knowledgeBaseId, LabelCreateRequest body)



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
| **body** | [**LabelCreateRequest**](LabelCreateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**LabelResponse**](LabelResponse.html)

<a name="postknowledgeknowledgebaselanguagecategories"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) PostKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
    public class PostKnowledgeKnowledgebaseLanguageCategoriesExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeCategoryRequest(); // KnowledgeCategoryRequest | 

            try
            { 
                // Create new category
                KnowledgeExtendedCategory result = apiInstance.PostKnowledgeKnowledgebaseLanguageCategories(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeCategoryRequest**](KnowledgeCategoryRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="postknowledgeknowledgebaselanguagedocumentuploads"></a>

## [**KnowledgeDocumentContentUpload**](KnowledgeDocumentContentUpload.html) PostKnowledgeKnowledgebaseLanguageDocumentUploads (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentContentUpload body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Upload Article Content

PostKnowledgeKnowledgebaseLanguageDocumentUploads is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostKnowledgeKnowledgebaseLanguageDocumentUploadsExample
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
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeDocumentContentUpload(); // KnowledgeDocumentContentUpload | 

            try
            { 
                // Upload Article Content
                KnowledgeDocumentContentUpload result = apiInstance.PostKnowledgeKnowledgebaseLanguageDocumentUploads(documentId, knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageDocumentUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeDocumentContentUpload**](KnowledgeDocumentContentUpload.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocumentContentUpload**](KnowledgeDocumentContentUpload.html)

<a name="postknowledgeknowledgebaselanguagedocuments"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) PostKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create document

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
    public class PostKnowledgeKnowledgebaseLanguageDocumentsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeDocumentRequest(); // KnowledgeDocumentRequest | 

            try
            { 
                // Create document
                KnowledgeDocument result = apiInstance.PostKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeDocumentRequest**](KnowledgeDocumentRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="postknowledgeknowledgebaselanguagedocumentsimports"></a>

## [**KnowledgeImport**](KnowledgeImport.html) PostKnowledgeKnowledgebaseLanguageDocumentsImports (string knowledgeBaseId, string languageCode, KnowledgeImport body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create import operation

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
    public class PostKnowledgeKnowledgebaseLanguageDocumentsImportsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeImport(); // KnowledgeImport | 

            try
            { 
                // Create import operation
                KnowledgeImport result = apiInstance.PostKnowledgeKnowledgebaseLanguageDocumentsImports(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageDocumentsImports: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **body** | [**KnowledgeImport**](KnowledgeImport.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeImport**](KnowledgeImport.html)

<a name="postknowledgeknowledgebaselanguagetrainingpromote"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) PostKnowledgeKnowledgebaseLanguageTrainingPromote (string knowledgeBaseId, string languageCode, string trainingId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Promote trained documents from draft state to active.

Requires ALL permissions: 

* knowledge:training:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageTrainingPromoteExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var trainingId = trainingId_example;  // string | Training ID

            try
            { 
                // Promote trained documents from draft state to active.
                KnowledgeTraining result = apiInstance.PostKnowledgeKnowledgebaseLanguageTrainingPromote(knowledgeBaseId, languageCode, trainingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
| **trainingId** | **string**| Training ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="postknowledgeknowledgebaselanguagetrainings"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) PostKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Trigger training

Requires ALL permissions: 

* knowledge:training:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageTrainingsExample
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
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Trigger training
                KnowledgeTraining result = apiInstance.PostKnowledgeKnowledgebaseLanguageTrainings(knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageTrainings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, en-UK, en-AU, en-CA, en-HK, en-IN, en-IE, en-NZ, en-PH, en-SG, en-ZA, de-DE, de-AT, de-CH, es-AR, es-CO, es-MX, es-US, es-ES, fr-FR, fr-BE, fr-CA, fr-CH, pt-BR, pt-PT, nl-NL, nl-BE, it-IT, ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="postknowledgeknowledgebaseparsejobimport"></a>

## void PostKnowledgeKnowledgebaseParseJobImport (string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestImport body)



Import the parsed articles

PostKnowledgeKnowledgebaseParseJobImport is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeParseJobRequestImport**](KnowledgeParseJobRequestImport.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postknowledgeknowledgebaseparsejobs"></a>

## [**KnowledgeParseJobResponse**](KnowledgeParseJobResponse.html) PostKnowledgeKnowledgebaseParseJobs (string knowledgeBaseId, KnowledgeParseJobRequest body)



Create parse job

PostKnowledgeKnowledgebaseParseJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**KnowledgeParseJobRequest**](KnowledgeParseJobRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeParseJobResponse**](KnowledgeParseJobResponse.html)

<a name="postknowledgeknowledgebasesearch"></a>

## [**KnowledgeSearchResponse**](KnowledgeSearchResponse.html) PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Search Documents

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
    public class PostKnowledgeKnowledgebaseSearchExample
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
            var body = new KnowledgeSearchRequest(); // KnowledgeSearchRequest |  (optional) 

            try
            { 
                // Search Documents
                KnowledgeSearchResponse result = apiInstance.PostKnowledgeKnowledgebaseSearch(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeSearchRequest**](KnowledgeSearchRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeSearchResponse**](KnowledgeSearchResponse.html)

<a name="postknowledgeknowledgebaseuploadsurlsjobs"></a>

## [**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse.html) PostKnowledgeKnowledgebaseUploadsUrlsJobs (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)



Create content upload from URL job

PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**CreateUploadSourceUrlJobRequest**](CreateUploadSourceUrlJobRequest.html)| uploadRequest |  |
{: class="table table-striped"}

### Return type

[**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse.html)

<a name="postknowledgeknowledgebases"></a>

## [**KnowledgeBase**](KnowledgeBase.html) PostKnowledgeKnowledgebases (KnowledgeBaseCreateRequest body)



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
| **body** | [**KnowledgeBaseCreateRequest**](KnowledgeBaseCreateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

