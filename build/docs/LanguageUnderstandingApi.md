---
title: LanguageUnderstandingApi
---
## PureCloudPlatform.Client.V2.Api.LanguageUnderstandingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLanguageunderstandingDomain**](LanguageUnderstandingApi.html#deletelanguageunderstandingdomain) | **DELETE** /api/v2/languageunderstanding/domains/{domainId} | Delete an NLU Domain. |
| [**DeleteLanguageunderstandingDomainFeedbackFeedbackId**](LanguageUnderstandingApi.html#deletelanguageunderstandingdomainfeedbackfeedbackid) | **DELETE** /api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId} | Delete the feedback on the NLU Domain Version. |
| [**DeleteLanguageunderstandingDomainVersion**](LanguageUnderstandingApi.html#deletelanguageunderstandingdomainversion) | **DELETE** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId} | Delete an NLU Domain Version |
| [**DeleteLanguageunderstandingMiner**](LanguageUnderstandingApi.html#deletelanguageunderstandingminer) | **DELETE** /api/v2/languageunderstanding/miners/{minerId} | Delete a miner. |
| [**DeleteLanguageunderstandingMinerDraft**](LanguageUnderstandingApi.html#deletelanguageunderstandingminerdraft) | **DELETE** /api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId} | Delete a draft |
| [**GetLanguageunderstandingDomain**](LanguageUnderstandingApi.html#getlanguageunderstandingdomain) | **GET** /api/v2/languageunderstanding/domains/{domainId} | Find an NLU Domain. |
| [**GetLanguageunderstandingDomainFeedback**](LanguageUnderstandingApi.html#getlanguageunderstandingdomainfeedback) | **GET** /api/v2/languageunderstanding/domains/{domainId}/feedback | Get all feedback in the given NLU Domain Version. |
| [**GetLanguageunderstandingDomainFeedbackFeedbackId**](LanguageUnderstandingApi.html#getlanguageunderstandingdomainfeedbackfeedbackid) | **GET** /api/v2/languageunderstanding/domains/{domainId}/feedback/{feedbackId} | Find a Feedback |
| [**GetLanguageunderstandingDomainVersion**](LanguageUnderstandingApi.html#getlanguageunderstandingdomainversion) | **GET** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId} | Find an NLU Domain Version. |
| [**GetLanguageunderstandingDomainVersionReport**](LanguageUnderstandingApi.html#getlanguageunderstandingdomainversionreport) | **GET** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/report | Retrieved quality report for the specified NLU Domain Version |
| [**GetLanguageunderstandingDomainVersions**](LanguageUnderstandingApi.html#getlanguageunderstandingdomainversions) | **GET** /api/v2/languageunderstanding/domains/{domainId}/versions | Get all NLU Domain Versions for a given Domain. |
| [**GetLanguageunderstandingDomains**](LanguageUnderstandingApi.html#getlanguageunderstandingdomains) | **GET** /api/v2/languageunderstanding/domains | Get all NLU Domains. |
| [**GetLanguageunderstandingMiner**](LanguageUnderstandingApi.html#getlanguageunderstandingminer) | **GET** /api/v2/languageunderstanding/miners/{minerId} | Get information about a miner. |
| [**GetLanguageunderstandingMinerDraft**](LanguageUnderstandingApi.html#getlanguageunderstandingminerdraft) | **GET** /api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId} | Get information about a draft. |
| [**GetLanguageunderstandingMinerDrafts**](LanguageUnderstandingApi.html#getlanguageunderstandingminerdrafts) | **GET** /api/v2/languageunderstanding/miners/{minerId}/drafts | Retrieve the list of drafts created. |
| [**GetLanguageunderstandingMinerIntent**](LanguageUnderstandingApi.html#getlanguageunderstandingminerintent) | **GET** /api/v2/languageunderstanding/miners/{minerId}/intents/{intentId} | Get information about a mined intent |
| [**GetLanguageunderstandingMinerIntents**](LanguageUnderstandingApi.html#getlanguageunderstandingminerintents) | **GET** /api/v2/languageunderstanding/miners/{minerId}/intents | Retrieve a list of mined intents. |
| [**GetLanguageunderstandingMiners**](LanguageUnderstandingApi.html#getlanguageunderstandingminers) | **GET** /api/v2/languageunderstanding/miners | Retrieve the list of miners created. |
| [**PatchLanguageunderstandingDomain**](LanguageUnderstandingApi.html#patchlanguageunderstandingdomain) | **PATCH** /api/v2/languageunderstanding/domains/{domainId} | Update an NLU Domain. |
| [**PatchLanguageunderstandingMinerDraft**](LanguageUnderstandingApi.html#patchlanguageunderstandingminerdraft) | **PATCH** /api/v2/languageunderstanding/miners/{minerId}/drafts/{draftId} | Save information for the draft. Either topic draft or intent draft should be sent. |
| [**PostLanguageunderstandingDomainFeedback**](LanguageUnderstandingApi.html#postlanguageunderstandingdomainfeedback) | **POST** /api/v2/languageunderstanding/domains/{domainId}/feedback | Create feedback for the NLU Domain Version. |
| [**PostLanguageunderstandingDomainVersionDetect**](LanguageUnderstandingApi.html#postlanguageunderstandingdomainversiondetect) | **POST** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/detect | Detect intent, entities, etc. in the submitted text using the specified NLU domain version. |
| [**PostLanguageunderstandingDomainVersionPublish**](LanguageUnderstandingApi.html#postlanguageunderstandingdomainversionpublish) | **POST** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/publish | Publish the draft NLU Domain Version. |
| [**PostLanguageunderstandingDomainVersionTrain**](LanguageUnderstandingApi.html#postlanguageunderstandingdomainversiontrain) | **POST** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId}/train | Train the draft NLU Domain Version. |
| [**PostLanguageunderstandingDomainVersions**](LanguageUnderstandingApi.html#postlanguageunderstandingdomainversions) | **POST** /api/v2/languageunderstanding/domains/{domainId}/versions | Create an NLU Domain Version. |
| [**PostLanguageunderstandingDomains**](LanguageUnderstandingApi.html#postlanguageunderstandingdomains) | **POST** /api/v2/languageunderstanding/domains | Create an NLU Domain. |
| [**PostLanguageunderstandingMinerDrafts**](LanguageUnderstandingApi.html#postlanguageunderstandingminerdrafts) | **POST** /api/v2/languageunderstanding/miners/{minerId}/drafts | Create a new draft resource. |
| [**PostLanguageunderstandingMinerExecute**](LanguageUnderstandingApi.html#postlanguageunderstandingminerexecute) | **POST** /api/v2/languageunderstanding/miners/{minerId}/execute | Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file. |
| [**PostLanguageunderstandingMiners**](LanguageUnderstandingApi.html#postlanguageunderstandingminers) | **POST** /api/v2/languageunderstanding/miners | Create a unique miner. |
| [**PutLanguageunderstandingDomainVersion**](LanguageUnderstandingApi.html#putlanguageunderstandingdomainversion) | **PUT** /api/v2/languageunderstanding/domains/{domainId}/versions/{domainVersionId} | Update an NLU Domain Version. |
{: class="table table-striped"}

<a name="deletelanguageunderstandingdomain"></a>

## void DeleteLanguageunderstandingDomain (string domainId)



Delete an NLU Domain.



Requires ANY permissions: 

* languageUnderstanding:nluDomain:delete
* dialog:bot:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageunderstandingDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.

            try
            { 
                // Delete an NLU Domain.
                apiInstance.DeleteLanguageunderstandingDomain(domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.DeleteLanguageunderstandingDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelanguageunderstandingdomainfeedbackfeedbackid"></a>

## void DeleteLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId)



Delete the feedback on the NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:feedback:delete
* dialog:bot:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageunderstandingDomainFeedbackFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var feedbackId = feedbackId_example;  // string | ID of the Feedback

            try
            { 
                // Delete the feedback on the NLU Domain Version.
                apiInstance.DeleteLanguageunderstandingDomainFeedbackFeedbackId(domainId, feedbackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.DeleteLanguageunderstandingDomainFeedbackFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **feedbackId** | **string**| ID of the Feedback |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelanguageunderstandingdomainversion"></a>

## void DeleteLanguageunderstandingDomainVersion (string domainId, string domainVersionId)



Delete an NLU Domain Version



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:delete
* dialog:botVersion:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageunderstandingDomainVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.

            try
            { 
                // Delete an NLU Domain Version
                apiInstance.DeleteLanguageunderstandingDomainVersion(domainId, domainVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.DeleteLanguageunderstandingDomainVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelanguageunderstandingminer"></a>

## void DeleteLanguageunderstandingMiner (string minerId)



Delete a miner.



Requires ALL permissions: 

* languageUnderstanding:miner:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageunderstandingMinerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID

            try
            { 
                // Delete a miner.
                apiInstance.DeleteLanguageunderstandingMiner(minerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.DeleteLanguageunderstandingMiner: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelanguageunderstandingminerdraft"></a>

## void DeleteLanguageunderstandingMinerDraft (string minerId, string draftId)



Delete a draft



Requires ALL permissions: 

* languageUnderstanding:draft:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLanguageunderstandingMinerDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var draftId = draftId_example;  // string | Draft ID

            try
            { 
                // Delete a draft
                apiInstance.DeleteLanguageunderstandingMinerDraft(minerId, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.DeleteLanguageunderstandingMinerDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **draftId** | **string**| Draft ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getlanguageunderstandingdomain"></a>

## [**NluDomain**](NluDomain.html) GetLanguageunderstandingDomain (string domainId)



Find an NLU Domain.



Requires ANY permissions: 

* languageUnderstanding:nluDomain:view
* dialog:bot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.

            try
            { 
                // Find an NLU Domain.
                NluDomain result = apiInstance.GetLanguageunderstandingDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
{: class="table table-striped"}

### Return type

[**NluDomain**](NluDomain.html)

<a name="getlanguageunderstandingdomainfeedback"></a>

## [**NluFeedbackListing**](NluFeedbackListing.html) GetLanguageunderstandingDomainFeedback (string domainId, string intentName = null, string assessment = null, String dateStart = null, String dateEnd = null, bool? includeDeleted = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, string after = null, List<string> fields = null)



Get all feedback in the given NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:feedback:view
* dialog:bot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var intentName = intentName_example;  // string | The top intent name to retrieve feedback for. (optional) 
            var assessment = assessment_example;  // string | The top assessment to retrieve feedback for. (optional) 
            var dateStart = 2013-10-20;  // String | Begin of time window as ISO-8601 date. (optional) 
            var dateEnd = 2013-10-20;  // String | End of time window as ISO-8601 date. (optional) 
            var includeDeleted = true;  // bool? | Whether to include soft-deleted items in the result. (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var enableCursorPagination = true;  // bool? | Enable Cursor Pagination (optional)  (default to false)
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination=true (optional) 
            var fields = new List<string>(); // List<string> | Fields and properties to get, comma-separated (optional) 

            try
            { 
                // Get all feedback in the given NLU Domain Version.
                NluFeedbackListing result = apiInstance.GetLanguageunderstandingDomainFeedback(domainId, intentName, assessment, dateStart, dateEnd, includeDeleted, pageNumber, pageSize, enableCursorPagination, after, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomainFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **intentName** | **string**| The top intent name to retrieve feedback for. | [optional]  |
| **assessment** | **string**| The top assessment to retrieve feedback for. | [optional] <br />**Values**: Incorrect, Correct, Unknown, Disabled |
| **dateStart** | **String**| Begin of time window as ISO-8601 date. | [optional]  |
| **dateEnd** | **String**| End of time window as ISO-8601 date. | [optional]  |
| **includeDeleted** | **bool?**| Whether to include soft-deleted items in the result. | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **enableCursorPagination** | **bool?**| Enable Cursor Pagination | [optional] [default to false] |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. This is considered only when enableCursorPagination&#x3D;true | [optional]  |
| **fields** | [**List<string>**](string.html)| Fields and properties to get, comma-separated | [optional] <br />**Values**: version, dateCreated, text, intents |
{: class="table table-striped"}

### Return type

[**NluFeedbackListing**](NluFeedbackListing.html)

<a name="getlanguageunderstandingdomainfeedbackfeedbackid"></a>

## [**NluFeedbackResponse**](NluFeedbackResponse.html) GetLanguageunderstandingDomainFeedbackFeedbackId (string domainId, string feedbackId, List<string> fields = null)



Find a Feedback



Requires ANY permissions: 

* languageUnderstanding:feedback:view
* dialog:bot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainFeedbackFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var feedbackId = feedbackId_example;  // string | ID of the Feedback
            var fields = new List<string>(); // List<string> | Fields and properties to get, comma-separated (optional) 

            try
            { 
                // Find a Feedback
                NluFeedbackResponse result = apiInstance.GetLanguageunderstandingDomainFeedbackFeedbackId(domainId, feedbackId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomainFeedbackFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **feedbackId** | **string**| ID of the Feedback |  |
| **fields** | [**List<string>**](string.html)| Fields and properties to get, comma-separated | [optional] <br />**Values**: version, dateCreated, text, intents |
{: class="table table-striped"}

### Return type

[**NluFeedbackResponse**](NluFeedbackResponse.html)

<a name="getlanguageunderstandingdomainversion"></a>

## [**NluDomainVersion**](NluDomainVersion.html) GetLanguageunderstandingDomainVersion (string domainId, string domainVersionId, bool? includeUtterances = null)



Find an NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:view
* dialog:botVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.
            var includeUtterances = true;  // bool? | Whether utterances for intent definition should be included when marshalling response. (optional) 

            try
            { 
                // Find an NLU Domain Version.
                NluDomainVersion result = apiInstance.GetLanguageunderstandingDomainVersion(domainId, domainVersionId, includeUtterances);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomainVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
| **includeUtterances** | **bool?**| Whether utterances for intent definition should be included when marshalling response. | [optional]  |
{: class="table table-striped"}

### Return type

[**NluDomainVersion**](NluDomainVersion.html)

<a name="getlanguageunderstandingdomainversionreport"></a>

## [**NluDomainVersionQualityReport**](NluDomainVersionQualityReport.html) GetLanguageunderstandingDomainVersionReport (string domainId, string domainVersionId)



Retrieved quality report for the specified NLU Domain Version



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:view
* dialog:botVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainVersionReportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.

            try
            { 
                // Retrieved quality report for the specified NLU Domain Version
                NluDomainVersionQualityReport result = apiInstance.GetLanguageunderstandingDomainVersionReport(domainId, domainVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomainVersionReport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
{: class="table table-striped"}

### Return type

[**NluDomainVersionQualityReport**](NluDomainVersionQualityReport.html)

<a name="getlanguageunderstandingdomainversions"></a>

## [**NluDomainVersionListing**](NluDomainVersionListing.html) GetLanguageunderstandingDomainVersions (string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null)



Get all NLU Domain Versions for a given Domain.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:view
* dialog:botVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var includeUtterances = true;  // bool? | Whether utterances for intent definition should be included when marshalling response. (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get all NLU Domain Versions for a given Domain.
                NluDomainVersionListing result = apiInstance.GetLanguageunderstandingDomainVersions(domainId, includeUtterances, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomainVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **includeUtterances** | **bool?**| Whether utterances for intent definition should be included when marshalling response. | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**NluDomainVersionListing**](NluDomainVersionListing.html)

<a name="getlanguageunderstandingdomains"></a>

## [**NluDomainListing**](NluDomainListing.html) GetLanguageunderstandingDomains (int? pageNumber = null, int? pageSize = null)



Get all NLU Domains.



Requires ANY permissions: 

* languageUnderstanding:nluDomain:view
* dialog:bot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get all NLU Domains.
                NluDomainListing result = apiInstance.GetLanguageunderstandingDomains(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingDomains: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**NluDomainListing**](NluDomainListing.html)

<a name="getlanguageunderstandingminer"></a>

## [**Miner**](Miner.html) GetLanguageunderstandingMiner (string minerId)



Get information about a miner.



Requires ALL permissions: 

* languageUnderstanding:miner:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID

            try
            { 
                // Get information about a miner.
                Miner result = apiInstance.GetLanguageunderstandingMiner(minerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMiner: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
{: class="table table-striped"}

### Return type

[**Miner**](Miner.html)

<a name="getlanguageunderstandingminerdraft"></a>

## [**Draft**](Draft.html) GetLanguageunderstandingMinerDraft (string minerId, string draftId)



Get information about a draft.



Requires ALL permissions: 

* languageUnderstanding:draft:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinerDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var draftId = draftId_example;  // string | Draft ID

            try
            { 
                // Get information about a draft.
                Draft result = apiInstance.GetLanguageunderstandingMinerDraft(minerId, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMinerDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **draftId** | **string**| Draft ID |  |
{: class="table table-striped"}

### Return type

[**Draft**](Draft.html)

<a name="getlanguageunderstandingminerdrafts"></a>

## [**DraftListing**](DraftListing.html) GetLanguageunderstandingMinerDrafts (string minerId)



Retrieve the list of drafts created.



Requires ALL permissions: 

* languageUnderstanding:draft:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinerDraftsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID

            try
            { 
                // Retrieve the list of drafts created.
                DraftListing result = apiInstance.GetLanguageunderstandingMinerDrafts(minerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMinerDrafts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
{: class="table table-striped"}

### Return type

[**DraftListing**](DraftListing.html)

<a name="getlanguageunderstandingminerintent"></a>

## [**MinerIntent**](MinerIntent.html) GetLanguageunderstandingMinerIntent (string minerId, string intentId, string expand = null)



Get information about a mined intent



Requires ALL permissions: 

* languageUnderstanding:minerIntent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinerIntentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var intentId = intentId_example;  // string | The ID of the intent to be retrieved.
            var expand = expand_example;  // string | Option to fetch utterances (optional) 

            try
            { 
                // Get information about a mined intent
                MinerIntent result = apiInstance.GetLanguageunderstandingMinerIntent(minerId, intentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMinerIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **intentId** | **string**| The ID of the intent to be retrieved. |  |
| **expand** | **string**| Option to fetch utterances | [optional] <br />**Values**: phrases, utterances |
{: class="table table-striped"}

### Return type

[**MinerIntent**](MinerIntent.html)

<a name="getlanguageunderstandingminerintents"></a>

## [**MinedIntentsListing**](MinedIntentsListing.html) GetLanguageunderstandingMinerIntents (string minerId, string expand = null)



Retrieve a list of mined intents.



Requires ALL permissions: 

* languageUnderstanding:minerIntent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinerIntentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var expand = expand_example;  // string | Option to fetch utterances. (optional) 

            try
            { 
                // Retrieve a list of mined intents.
                MinedIntentsListing result = apiInstance.GetLanguageunderstandingMinerIntents(minerId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMinerIntents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **expand** | **string**| Option to fetch utterances. | [optional] <br />**Values**: phrases, utterances |
{: class="table table-striped"}

### Return type

[**MinedIntentsListing**](MinedIntentsListing.html)

<a name="getlanguageunderstandingminers"></a>

## [**MinerListing**](MinerListing.html) GetLanguageunderstandingMiners ()



Retrieve the list of miners created.



Requires ALL permissions: 

* languageUnderstanding:miner:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLanguageunderstandingMinersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();

            try
            { 
                // Retrieve the list of miners created.
                MinerListing result = apiInstance.GetLanguageunderstandingMiners();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.GetLanguageunderstandingMiners: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**MinerListing**](MinerListing.html)

<a name="patchlanguageunderstandingdomain"></a>

## [**NluDomain**](NluDomain.html) PatchLanguageunderstandingDomain (string domainId, NluDomain body)



Update an NLU Domain.



Requires ANY permissions: 

* languageUnderstanding:nluDomain:edit
* dialog:bot:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLanguageunderstandingDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var body = new NluDomain(); // NluDomain | The updated NLU Domain.

            try
            { 
                // Update an NLU Domain.
                NluDomain result = apiInstance.PatchLanguageunderstandingDomain(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PatchLanguageunderstandingDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **body** | [**NluDomain**](NluDomain.html)| The updated NLU Domain. |  |
{: class="table table-striped"}

### Return type

[**NluDomain**](NluDomain.html)

<a name="patchlanguageunderstandingminerdraft"></a>

## [**Draft**](Draft.html) PatchLanguageunderstandingMinerDraft (string minerId, string draftId, DraftRequest body = null)



Save information for the draft. Either topic draft or intent draft should be sent.



Requires ALL permissions: 

* languageUnderstanding:draft:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLanguageunderstandingMinerDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var draftId = draftId_example;  // string | Draft ID
            var body = new DraftRequest(); // DraftRequest |  (optional) 

            try
            { 
                // Save information for the draft. Either topic draft or intent draft should be sent.
                Draft result = apiInstance.PatchLanguageunderstandingMinerDraft(minerId, draftId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PatchLanguageunderstandingMinerDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **draftId** | **string**| Draft ID |  |
| **body** | [**DraftRequest**](DraftRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Draft**](Draft.html)

<a name="postlanguageunderstandingdomainfeedback"></a>

## [**NluFeedbackResponse**](NluFeedbackResponse.html) PostLanguageunderstandingDomainFeedback (string domainId, NluFeedbackRequest body)



Create feedback for the NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:feedback:add
* dialog:bot:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var body = new NluFeedbackRequest(); // NluFeedbackRequest | The Feedback to create.

            try
            { 
                // Create feedback for the NLU Domain Version.
                NluFeedbackResponse result = apiInstance.PostLanguageunderstandingDomainFeedback(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomainFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **body** | [**NluFeedbackRequest**](NluFeedbackRequest.html)| The Feedback to create. |  |
{: class="table table-striped"}

### Return type

[**NluFeedbackResponse**](NluFeedbackResponse.html)

<a name="postlanguageunderstandingdomainversiondetect"></a>

## [**NluDetectionResponse**](NluDetectionResponse.html) PostLanguageunderstandingDomainVersionDetect (string domainId, string domainVersionId, NluDetectionRequest body)



Detect intent, entities, etc. in the submitted text using the specified NLU domain version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:view
* dialog:botVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainVersionDetectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.
            var body = new NluDetectionRequest(); // NluDetectionRequest | The input data to perform detection on.

            try
            { 
                // Detect intent, entities, etc. in the submitted text using the specified NLU domain version.
                NluDetectionResponse result = apiInstance.PostLanguageunderstandingDomainVersionDetect(domainId, domainVersionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomainVersionDetect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
| **body** | [**NluDetectionRequest**](NluDetectionRequest.html)| The input data to perform detection on. |  |
{: class="table table-striped"}

### Return type

[**NluDetectionResponse**](NluDetectionResponse.html)

<a name="postlanguageunderstandingdomainversionpublish"></a>

## [**NluDomainVersion**](NluDomainVersion.html) PostLanguageunderstandingDomainVersionPublish (string domainId, string domainVersionId)



Publish the draft NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:add
* dialog:botVersion:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainVersionPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.

            try
            { 
                // Publish the draft NLU Domain Version.
                NluDomainVersion result = apiInstance.PostLanguageunderstandingDomainVersionPublish(domainId, domainVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomainVersionPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
{: class="table table-striped"}

### Return type

[**NluDomainVersion**](NluDomainVersion.html)

<a name="postlanguageunderstandingdomainversiontrain"></a>

## [**NluDomainVersionTrainingResponse**](NluDomainVersionTrainingResponse.html) PostLanguageunderstandingDomainVersionTrain (string domainId, string domainVersionId)



Train the draft NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:edit
* dialog:botVersion:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainVersionTrainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.

            try
            { 
                // Train the draft NLU Domain Version.
                NluDomainVersionTrainingResponse result = apiInstance.PostLanguageunderstandingDomainVersionTrain(domainId, domainVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomainVersionTrain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
{: class="table table-striped"}

### Return type

[**NluDomainVersionTrainingResponse**](NluDomainVersionTrainingResponse.html)

<a name="postlanguageunderstandingdomainversions"></a>

## [**NluDomainVersion**](NluDomainVersion.html) PostLanguageunderstandingDomainVersions (string domainId, NluDomainVersion body)



Create an NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:add
* dialog:botVersion:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var body = new NluDomainVersion(); // NluDomainVersion | The NLU Domain Version to create.

            try
            { 
                // Create an NLU Domain Version.
                NluDomainVersion result = apiInstance.PostLanguageunderstandingDomainVersions(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomainVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **body** | [**NluDomainVersion**](NluDomainVersion.html)| The NLU Domain Version to create. |  |
{: class="table table-striped"}

### Return type

[**NluDomainVersion**](NluDomainVersion.html)

<a name="postlanguageunderstandingdomains"></a>

## [**NluDomain**](NluDomain.html) PostLanguageunderstandingDomains (NluDomain body)



Create an NLU Domain.



Requires ANY permissions: 

* languageUnderstanding:nluDomain:add
* dialog:bot:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var body = new NluDomain(); // NluDomain | The NLU Domain to create.

            try
            { 
                // Create an NLU Domain.
                NluDomain result = apiInstance.PostLanguageunderstandingDomains(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**NluDomain**](NluDomain.html)| The NLU Domain to create. |  |
{: class="table table-striped"}

### Return type

[**NluDomain**](NluDomain.html)

<a name="postlanguageunderstandingminerdrafts"></a>

## [**Draft**](Draft.html) PostLanguageunderstandingMinerDrafts (string minerId, Draft body)



Create a new draft resource.



Requires ALL permissions: 

* languageUnderstanding:draft:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingMinerDraftsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var body = new Draft(); // Draft | Details for creating draft resource

            try
            { 
                // Create a new draft resource.
                Draft result = apiInstance.PostLanguageunderstandingMinerDrafts(minerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingMinerDrafts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **body** | [**Draft**](Draft.html)| Details for creating draft resource |  |
{: class="table table-striped"}

### Return type

[**Draft**](Draft.html)

<a name="postlanguageunderstandingminerexecute"></a>

## [**Miner**](Miner.html) PostLanguageunderstandingMinerExecute (string minerId, MinerExecuteRequest body = null)



Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.



Requires ALL permissions: 

* languageUnderstanding:miner:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingMinerExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var minerId = minerId_example;  // string | Miner ID
            var body = new MinerExecuteRequest(); // MinerExecuteRequest |  (optional) 

            try
            { 
                // Start the mining process. Specify date range pair with mediaType, queueIds, participantType for mining data from Genesys Cloud. Specify only uploadKey for mining through an external file.
                Miner result = apiInstance.PostLanguageunderstandingMinerExecute(minerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingMinerExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **body** | [**MinerExecuteRequest**](MinerExecuteRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Miner**](Miner.html)

<a name="postlanguageunderstandingminers"></a>

## [**Miner**](Miner.html) PostLanguageunderstandingMiners (Miner body)



Create a unique miner.



Requires ALL permissions: 

* languageUnderstanding:miner:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingMinersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var body = new Miner(); // Miner | Details for creating a new miner resource.

            try
            { 
                // Create a unique miner.
                Miner result = apiInstance.PostLanguageunderstandingMiners(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PostLanguageunderstandingMiners: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Miner**](Miner.html)| Details for creating a new miner resource. |  |
{: class="table table-striped"}

### Return type

[**Miner**](Miner.html)

<a name="putlanguageunderstandingdomainversion"></a>

## [**NluDomainVersion**](NluDomainVersion.html) PutLanguageunderstandingDomainVersion (string domainId, string domainVersionId, NluDomainVersion body)



Update an NLU Domain Version.



Requires ANY permissions: 

* languageUnderstanding:nluDomainVersion:edit
* dialog:botVersion:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutLanguageunderstandingDomainVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LanguageUnderstandingApi();
            var domainId = domainId_example;  // string | ID of the NLU domain.
            var domainVersionId = domainVersionId_example;  // string | ID of the NLU domain version.
            var body = new NluDomainVersion(); // NluDomainVersion | The updated NLU Domain Version.

            try
            { 
                // Update an NLU Domain Version.
                NluDomainVersion result = apiInstance.PutLanguageunderstandingDomainVersion(domainId, domainVersionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageUnderstandingApi.PutLanguageunderstandingDomainVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| ID of the NLU domain. |  |
| **domainVersionId** | **string**| ID of the NLU domain version. |  |
| **body** | [**NluDomainVersion**](NluDomainVersion.html)| The updated NLU Domain Version. |  |
{: class="table table-striped"}

### Return type

[**NluDomainVersion**](NluDomainVersion.html)

