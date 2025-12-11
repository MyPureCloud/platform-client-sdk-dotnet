# SpeechTextAnalyticsApi

## PureCloudPlatform.Client.V2.Api.SpeechTextAnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteSpeechandtextanalyticsCategory**](#DeleteSpeechandtextanalyticsCategory) | **Delete** /api/v2/speechandtextanalytics/categories/{categoryId} | Delete a Speech &amp; Text Analytics category by ID |
| [**DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](#DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId) | **Delete** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Delete a Speech &amp; Text Analytics DictionaryFeedback by Id |
| [**DeleteSpeechandtextanalyticsProgram**](#DeleteSpeechandtextanalyticsProgram) | **Delete** /api/v2/speechandtextanalytics/programs/{programId} | Delete a Speech &amp; Text Analytics program by id |
| [**DeleteSpeechandtextanalyticsReprocessingJob**](#DeleteSpeechandtextanalyticsReprocessingJob) | **Delete** /api/v2/speechandtextanalytics/reprocessing/jobs/{jobId} | Delete a Speech &amp; Text Analytics Reprocessing job by Id |
| [**DeleteSpeechandtextanalyticsSentimentfeedback**](#DeleteSpeechandtextanalyticsSentimentfeedback) | **Delete** /api/v2/speechandtextanalytics/sentimentfeedback | Delete All Speech &amp; Text Analytics SentimentFeedback |
| [**DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId**](#DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId) | **Delete** /api/v2/speechandtextanalytics/sentimentfeedback/{sentimentFeedbackId} | Delete a Speech &amp; Text Analytics SentimentFeedback by Id |
| [**DeleteSpeechandtextanalyticsTopic**](#DeleteSpeechandtextanalyticsTopic) | **Delete** /api/v2/speechandtextanalytics/topics/{topicId} | Delete a Speech &amp; Text Analytics topic by id |
| [**GetSpeechandtextanalyticsCategories**](#GetSpeechandtextanalyticsCategories) | **Get** /api/v2/speechandtextanalytics/categories | Get the list of Speech and Text Analytics categories |
| [**GetSpeechandtextanalyticsCategory**](#GetSpeechandtextanalyticsCategory) | **Get** /api/v2/speechandtextanalytics/categories/{categoryId} | Get a Speech &amp; Text Analytics Category by ID |
| [**GetSpeechandtextanalyticsConversation**](#GetSpeechandtextanalyticsConversation) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId} | Get Speech and Text Analytics for a specific conversation |
| [**GetSpeechandtextanalyticsConversationCategories**](#GetSpeechandtextanalyticsConversationCategories) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/categories | Get the list of detected Speech and Text Analytics categories of conversation |
| [**GetSpeechandtextanalyticsConversationCommunicationTranscripturl**](#GetSpeechandtextanalyticsConversationCommunicationTranscripturl) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl | Get the pre-signed S3 URL for the transcript of a specific communication of a conversation |
| [**GetSpeechandtextanalyticsConversationCommunicationTranscripturls**](#GetSpeechandtextanalyticsConversationCommunicationTranscripturls) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturls | Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation |
| [**GetSpeechandtextanalyticsConversationSentiments**](#GetSpeechandtextanalyticsConversationSentiments) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/sentiments | Get sentiment data |
| [**GetSpeechandtextanalyticsConversationSummaries**](#GetSpeechandtextanalyticsConversationSummaries) | **Get** /api/v2/speechandtextanalytics/conversations/{conversationId}/summaries | Get conversation summaries by conversation id. |
| [**GetSpeechandtextanalyticsDictionaryfeedback**](#GetSpeechandtextanalyticsDictionaryfeedback) | **Get** /api/v2/speechandtextanalytics/dictionaryfeedback | Get the list of Speech &amp; Text Analytics dictionary feedbacks |
| [**GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](#GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId) | **Get** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Get a Speech &amp; Text Analytics dictionary feedback by id |
| [**GetSpeechandtextanalyticsProgram**](#GetSpeechandtextanalyticsProgram) | **Get** /api/v2/speechandtextanalytics/programs/{programId} | Get a Speech &amp; Text Analytics program by id |
| [**GetSpeechandtextanalyticsProgramMappings**](#GetSpeechandtextanalyticsProgramMappings) | **Get** /api/v2/speechandtextanalytics/programs/{programId}/mappings | Get Speech &amp; Text Analytics program mappings to queues and flows by id |
| [**GetSpeechandtextanalyticsProgramSettingsInsights**](#GetSpeechandtextanalyticsProgramSettingsInsights) | **Get** /api/v2/speechandtextanalytics/programs/{programId}/settings/insights | Get AI Insights settings of a program |
| [**GetSpeechandtextanalyticsProgramTranscriptionengines**](#GetSpeechandtextanalyticsProgramTranscriptionengines) | **Get** /api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines | Get transcription engine settings of a program |
| [**GetSpeechandtextanalyticsPrograms**](#GetSpeechandtextanalyticsPrograms) | **Get** /api/v2/speechandtextanalytics/programs | Get the list of Speech &amp; Text Analytics programs |
| [**GetSpeechandtextanalyticsProgramsGeneralJob**](#GetSpeechandtextanalyticsProgramsGeneralJob) | **Get** /api/v2/speechandtextanalytics/programs/general/jobs/{jobId} | Get a Speech &amp; Text Analytics general program job by id |
| [**GetSpeechandtextanalyticsProgramsMappings**](#GetSpeechandtextanalyticsProgramsMappings) | **Get** /api/v2/speechandtextanalytics/programs/mappings | Get the list of Speech &amp; Text Analytics programs mappings to queues and flows |
| [**GetSpeechandtextanalyticsProgramsPublishjob**](#GetSpeechandtextanalyticsProgramsPublishjob) | **Get** /api/v2/speechandtextanalytics/programs/publishjobs/{jobId} | Get a Speech &amp; Text Analytics publish programs job by id |
| [**GetSpeechandtextanalyticsProgramsSettingsInsights**](#GetSpeechandtextanalyticsProgramsSettingsInsights) | **Get** /api/v2/speechandtextanalytics/programs/settings/insights | Get the list of program AI Insights settings for the organization |
| [**GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects**](#GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects) | **Get** /api/v2/speechandtextanalytics/programs/transcriptionengines/dialects | Get supported dialects for each transcription engine |
| [**GetSpeechandtextanalyticsProgramsUnpublished**](#GetSpeechandtextanalyticsProgramsUnpublished) | **Get** /api/v2/speechandtextanalytics/programs/unpublished | Get the list of Speech &amp; Text Analytics unpublished programs |
| [**GetSpeechandtextanalyticsReprocessingJob**](#GetSpeechandtextanalyticsReprocessingJob) | **Get** /api/v2/speechandtextanalytics/reprocessing/jobs/{jobId} | Get a Speech &amp; Text Analytics reprocess job by id |
| [**GetSpeechandtextanalyticsReprocessingJobInteractions**](#GetSpeechandtextanalyticsReprocessingJobInteractions) | **Get** /api/v2/speechandtextanalytics/reprocessing/jobs/{jobId}/interactions | Get a Speech &amp; Text Analytics Reprocessing interactions statuses by job id |
| [**GetSpeechandtextanalyticsReprocessingJobs**](#GetSpeechandtextanalyticsReprocessingJobs) | **Get** /api/v2/speechandtextanalytics/reprocessing/jobs | Get the list of Speech &amp; Text Analytics reprocess jobs |
| [**GetSpeechandtextanalyticsSentimentDialects**](#GetSpeechandtextanalyticsSentimentDialects) | **Get** /api/v2/speechandtextanalytics/sentiment/dialects | Get the list of Speech &amp; Text Analytics sentiment supported dialects |
| [**GetSpeechandtextanalyticsSentimentfeedback**](#GetSpeechandtextanalyticsSentimentfeedback) | **Get** /api/v2/speechandtextanalytics/sentimentfeedback | Get the list of Speech &amp; Text Analytics SentimentFeedback |
| [**GetSpeechandtextanalyticsSettings**](#GetSpeechandtextanalyticsSettings) | **Get** /api/v2/speechandtextanalytics/settings | Get Speech And Text Analytics Settings |
| [**GetSpeechandtextanalyticsTopic**](#GetSpeechandtextanalyticsTopic) | **Get** /api/v2/speechandtextanalytics/topics/{topicId} | Get a Speech &amp; Text Analytics topic by id |
| [**GetSpeechandtextanalyticsTopics**](#GetSpeechandtextanalyticsTopics) | **Get** /api/v2/speechandtextanalytics/topics | Get the list of Speech &amp; Text Analytics topics |
| [**GetSpeechandtextanalyticsTopicsDialects**](#GetSpeechandtextanalyticsTopicsDialects) | **Get** /api/v2/speechandtextanalytics/topics/dialects | Get list of supported Speech &amp; Text Analytics topics dialects |
| [**GetSpeechandtextanalyticsTopicsGeneral**](#GetSpeechandtextanalyticsTopicsGeneral) | **Get** /api/v2/speechandtextanalytics/topics/general | Get the Speech &amp; Text Analytics general topics for a given dialect |
| [**GetSpeechandtextanalyticsTopicsGeneralStatus**](#GetSpeechandtextanalyticsTopicsGeneralStatus) | **Get** /api/v2/speechandtextanalytics/topics/general/status | Get the list of general topics from the org and the system with their current status |
| [**GetSpeechandtextanalyticsTopicsPublishjob**](#GetSpeechandtextanalyticsTopicsPublishjob) | **Get** /api/v2/speechandtextanalytics/topics/publishjobs/{jobId} | Get a Speech &amp; Text Analytics publish topics job by id |
| [**GetSpeechandtextanalyticsTopicsTestphraseJob**](#GetSpeechandtextanalyticsTopicsTestphraseJob) | **Get** /api/v2/speechandtextanalytics/topics/testphrase/jobs/{jobId} | Get a Speech &amp; Text Analytics test topics phrase job by id |
| [**GetSpeechandtextanalyticsTranslationsLanguageConversation**](#GetSpeechandtextanalyticsTranslationsLanguageConversation) | **Get** /api/v2/speechandtextanalytics/translations/languages/{languageId}/conversations/{conversationId} | Translate a single interaction recording (or an email conversation) |
| [**GetSpeechandtextanalyticsTranslationsLanguages**](#GetSpeechandtextanalyticsTranslationsLanguages) | **Get** /api/v2/speechandtextanalytics/translations/languages | Get supported translation languages |
| [**PatchSpeechandtextanalyticsSettings**](#PatchSpeechandtextanalyticsSettings) | **Patch** /api/v2/speechandtextanalytics/settings | Patch Speech And Text Analytics Settings |
| [**PostSpeechandtextanalyticsCategories**](#PostSpeechandtextanalyticsCategories) | **Post** /api/v2/speechandtextanalytics/categories | Create new Speech &amp; Text Analytics category |
| [**PostSpeechandtextanalyticsDictionaryfeedback**](#PostSpeechandtextanalyticsDictionaryfeedback) | **Post** /api/v2/speechandtextanalytics/dictionaryfeedback | Create a Speech &amp; Text Analytics DictionaryFeedback |
| [**PostSpeechandtextanalyticsPrograms**](#PostSpeechandtextanalyticsPrograms) | **Post** /api/v2/speechandtextanalytics/programs | Create new Speech &amp; Text Analytics program |
| [**PostSpeechandtextanalyticsProgramsGeneralJobs**](#PostSpeechandtextanalyticsProgramsGeneralJobs) | **Post** /api/v2/speechandtextanalytics/programs/general/jobs | Create new Speech &amp; Text Analytics general program job |
| [**PostSpeechandtextanalyticsProgramsPublishjobs**](#PostSpeechandtextanalyticsProgramsPublishjobs) | **Post** /api/v2/speechandtextanalytics/programs/publishjobs | Create new Speech &amp; Text Analytics publish programs job |
| [**PostSpeechandtextanalyticsReprocessingJobs**](#PostSpeechandtextanalyticsReprocessingJobs) | **Post** /api/v2/speechandtextanalytics/reprocessing/jobs | Create a Speech &amp; Text Analytics reprocess job. |
| [**PostSpeechandtextanalyticsSentimentfeedback**](#PostSpeechandtextanalyticsSentimentfeedback) | **Post** /api/v2/speechandtextanalytics/sentimentfeedback | Create a Speech &amp; Text Analytics SentimentFeedback |
| [**PostSpeechandtextanalyticsTopics**](#PostSpeechandtextanalyticsTopics) | **Post** /api/v2/speechandtextanalytics/topics | Create new Speech &amp; Text Analytics topic |
| [**PostSpeechandtextanalyticsTopicsPublishjobs**](#PostSpeechandtextanalyticsTopicsPublishjobs) | **Post** /api/v2/speechandtextanalytics/topics/publishjobs | Create new Speech &amp; Text Analytics publish topics job |
| [**PostSpeechandtextanalyticsTopicsTestphraseJobs**](#PostSpeechandtextanalyticsTopicsTestphraseJobs) | **Post** /api/v2/speechandtextanalytics/topics/testphrase/jobs | Create new Speech &amp; Text Analytics publish topics job |
| [**PostSpeechandtextanalyticsTranscriptsSearch**](#PostSpeechandtextanalyticsTranscriptsSearch) | **Post** /api/v2/speechandtextanalytics/transcripts/search | Search resources. |
| [**PutSpeechandtextanalyticsCategory**](#PutSpeechandtextanalyticsCategory) | **Put** /api/v2/speechandtextanalytics/categories/{categoryId} | Update a Speech &amp; Text Analytics category by ID |
| [**PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId**](#PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId) | **Put** /api/v2/speechandtextanalytics/dictionaryfeedback/{dictionaryFeedbackId} | Update existing Speech &amp; Text Analytics dictionary feedback by id |
| [**PutSpeechandtextanalyticsProgram**](#PutSpeechandtextanalyticsProgram) | **Put** /api/v2/speechandtextanalytics/programs/{programId} | Update existing Speech &amp; Text Analytics program |
| [**PutSpeechandtextanalyticsProgramMappings**](#PutSpeechandtextanalyticsProgramMappings) | **Put** /api/v2/speechandtextanalytics/programs/{programId}/mappings | Set Speech &amp; Text Analytics program mappings to queues and flows |
| [**PutSpeechandtextanalyticsProgramSettingsInsights**](#PutSpeechandtextanalyticsProgramSettingsInsights) | **Put** /api/v2/speechandtextanalytics/programs/{programId}/settings/insights | Update AI Insights settings of a program |
| [**PutSpeechandtextanalyticsProgramTranscriptionengines**](#PutSpeechandtextanalyticsProgramTranscriptionengines) | **Put** /api/v2/speechandtextanalytics/programs/{programId}/transcriptionengines | Update transcription engine settings of a program |
| [**PutSpeechandtextanalyticsSettings**](#PutSpeechandtextanalyticsSettings) | **Put** /api/v2/speechandtextanalytics/settings | Update Speech And Text Analytics Settings |
| [**PutSpeechandtextanalyticsTopic**](#PutSpeechandtextanalyticsTopic) | **Put** /api/v2/speechandtextanalytics/topics/{topicId} | Update existing Speech &amp; Text Analytics topic |



## DeleteSpeechandtextanalyticsCategory

> void DeleteSpeechandtextanalyticsCategory (string categoryId)


Delete a Speech & Text Analytics category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category

            try
            { 
                // Delete a Speech & Text Analytics category by ID
                apiInstance.DeleteSpeechandtextanalyticsCategory(categoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |

### Return type

void (empty response body)


## DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId

> void DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)


Delete a Speech & Text Analytics DictionaryFeedback by Id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback

            try
            { 
                // Delete a Speech & Text Analytics DictionaryFeedback by Id
                apiInstance.DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |

### Return type

void (empty response body)


## DeleteSpeechandtextanalyticsProgram

> [**DeleteProgramResponse**](DeleteProgramResponse) DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null)


Delete a Speech & Text Analytics program by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var forceDelete = forceDelete_example;  // bool? | Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional)  (default to false)

            try
            { 
                // Delete a Speech & Text Analytics program by id
                DeleteProgramResponse result = apiInstance.DeleteSpeechandtextanalyticsProgram(programId, forceDelete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **forceDelete** | **bool?**| Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. | [optional] [default to false]<br />**Values**: true, false |

### Return type

[**DeleteProgramResponse**](DeleteProgramResponse)


## DeleteSpeechandtextanalyticsReprocessingJob

> void DeleteSpeechandtextanalyticsReprocessingJob (string jobId)


Delete a Speech & Text Analytics Reprocessing job by Id

DeleteSpeechandtextanalyticsReprocessingJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* speechAndTextAnalytics:reprocessInteractions:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsReprocessingJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The Id of the Reprocessing job

            try
            { 
                // Delete a Speech & Text Analytics Reprocessing job by Id
                apiInstance.DeleteSpeechandtextanalyticsReprocessingJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsReprocessingJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The Id of the Reprocessing job |  |

### Return type

void (empty response body)


## DeleteSpeechandtextanalyticsSentimentfeedback

> void DeleteSpeechandtextanalyticsSentimentfeedback ()


Delete All Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Delete All Speech & Text Analytics SentimentFeedback
                apiInstance.DeleteSpeechandtextanalyticsSentimentfeedback();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId

> void DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId (string sentimentFeedbackId)


Delete a Speech & Text Analytics SentimentFeedback by Id

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var sentimentFeedbackId = sentimentFeedbackId_example;  // string | The Id of the SentimentFeedback

            try
            { 
                // Delete a Speech & Text Analytics SentimentFeedback by Id
                apiInstance.DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId(sentimentFeedbackId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsSentimentfeedbackSentimentFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sentimentFeedbackId** | **string**| The Id of the SentimentFeedback |  |

### Return type

void (empty response body)


## DeleteSpeechandtextanalyticsTopic

> void DeleteSpeechandtextanalyticsTopic (string topicId)


Delete a Speech & Text Analytics topic by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic

            try
            { 
                // Delete a Speech & Text Analytics topic by id
                apiInstance.DeleteSpeechandtextanalyticsTopic(topicId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.DeleteSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |

### Return type

void (empty response body)


## GetSpeechandtextanalyticsCategories

> [**CategoriesEntityListing**](CategoriesEntityListing) GetSpeechandtextanalyticsCategories (int? pageSize = null, int? pageNumber = null, string name = null, string sortOrder = null, string sortBy = null, List<string> ids = null)


Get the list of Speech and Text Analytics categories

Requires ALL permissions: 

* speechAndTextAnalytics:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 25. (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number for the listing (optional)  (default to 1)
            var name = name_example;  // string | The category name filter applied to the listing (optional) 
            var sortOrder = sortOrder_example;  // string | The sort order for the listing (optional)  (default to asc)
            var sortBy = sortBy_example;  // string | The field to sort by for the listing (optional)  (default to name)
            var ids = new List<string>(); // List<string> | Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. (optional) 

            try
            { 
                // Get the list of Speech and Text Analytics categories
                CategoriesEntityListing result = apiInstance.GetSpeechandtextanalyticsCategories(pageSize, pageNumber, name, sortOrder, sortBy, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 25. | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number for the listing | [optional] [default to 1] |
| **name** | **string**| The category name filter applied to the listing | [optional]  |
| **sortOrder** | **string**| The sort order for the listing | [optional] [default to asc]<br />**Values**: asc, desc |
| **sortBy** | **string**| The field to sort by for the listing | [optional] [default to name]<br />**Values**: name, description |
| **ids** | [**List<string>**](string)| Comma separated Category IDs to filter by. Cannot be used with other filters. Maximum of 25 IDs allowed. | [optional]  |

### Return type

[**CategoriesEntityListing**](CategoriesEntityListing)


## GetSpeechandtextanalyticsCategory

> [**StaCategory**](StaCategory) GetSpeechandtextanalyticsCategory (string categoryId)


Get a Speech & Text Analytics Category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category

            try
            { 
                // Get a Speech & Text Analytics Category by ID
                StaCategory result = apiInstance.GetSpeechandtextanalyticsCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |

### Return type

[**StaCategory**](StaCategory)


## GetSpeechandtextanalyticsConversation

> [**ConversationMetrics**](ConversationMetrics) GetSpeechandtextanalyticsConversation (string conversationId)


Get Speech and Text Analytics for a specific conversation

Requires ALL permissions: 

* recording:recording:view
* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation Id

            try
            { 
                // Get Speech and Text Analytics for a specific conversation
                ConversationMetrics result = apiInstance.GetSpeechandtextanalyticsConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation Id |  |

### Return type

[**ConversationMetrics**](ConversationMetrics)


## GetSpeechandtextanalyticsConversationCategories

> [**ConversationCategoriesEntityListing**](ConversationCategoriesEntityListing) GetSpeechandtextanalyticsConversationCategories (string conversationId, int? pageSize = null, int? pageNumber = null)


Get the list of detected Speech and Text Analytics categories of conversation

Requires ALL permissions: 

* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | The id of the conversation
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 50. (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number for the listing (optional)  (default to 1)

            try
            { 
                // Get the list of detected Speech and Text Analytics categories of conversation
                ConversationCategoriesEntityListing result = apiInstance.GetSpeechandtextanalyticsConversationCategories(conversationId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| The id of the conversation |  |
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 50. | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number for the listing | [optional] [default to 1] |

### Return type

[**ConversationCategoriesEntityListing**](ConversationCategoriesEntityListing)


## GetSpeechandtextanalyticsConversationCommunicationTranscripturl

> [**TranscriptUrl**](TranscriptUrl) GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId)


Get the pre-signed S3 URL for the transcript of a specific communication of a conversation

Requires ALL permissions: 

* recording:recording:view
* speechAndTextAnalytics:data:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCommunicationTranscripturlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var communicationId = communicationId_example;  // string | Communication ID

            try
            { 
                // Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
                TranscriptUrl result = apiInstance.GetSpeechandtextanalyticsConversationCommunicationTranscripturl(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **communicationId** | **string**| Communication ID |  |

### Return type

[**TranscriptUrl**](TranscriptUrl)


## GetSpeechandtextanalyticsConversationCommunicationTranscripturls

> [**TranscriptUrls**](TranscriptUrls) GetSpeechandtextanalyticsConversationCommunicationTranscripturls (string conversationId, string communicationId)


Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationCommunicationTranscripturlsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var communicationId = communicationId_example;  // string | Communication ID

            try
            { 
                // Get the list of pre-signed S3 URL for the transcripts of a specific communication of a conversation
                TranscriptUrls result = apiInstance.GetSpeechandtextanalyticsConversationCommunicationTranscripturls(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationCommunicationTranscripturls: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **communicationId** | **string**| Communication ID |  |

### Return type

[**TranscriptUrls**](TranscriptUrls)


## GetSpeechandtextanalyticsConversationSentiments

> [**SentimentData**](SentimentData) GetSpeechandtextanalyticsConversationSentiments (string conversationId)


Get sentiment data

Requires ALL permissions: 

* speechAndTextAnalytics:sentimentData:view
* speechAndTextAnalytics:data:view
* recording:recording:view
* recording:recording:viewSensitiveData

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationSentimentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | The conversation ID of the sentiment data

            try
            { 
                // Get sentiment data
                SentimentData result = apiInstance.GetSpeechandtextanalyticsConversationSentiments(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationSentiments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| The conversation ID of the sentiment data |  |

### Return type

[**SentimentData**](SentimentData)


## GetSpeechandtextanalyticsConversationSummaries

> [**SpeechTextAnalyticsConversationSummaryListing**](SpeechTextAnalyticsConversationSummaryListing) GetSpeechandtextanalyticsConversationSummaries (string conversationId)


Get conversation summaries by conversation id.

Requires ALL permissions: 

* speechAndTextAnalytics:aiSummary:view
* recording:recording:view
* recording:recording:viewSensitiveData

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsConversationSummariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var conversationId = conversationId_example;  // string | The conversation ID of the summaries

            try
            { 
                // Get conversation summaries by conversation id.
                SpeechTextAnalyticsConversationSummaryListing result = apiInstance.GetSpeechandtextanalyticsConversationSummaries(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsConversationSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| The conversation ID of the summaries |  |

### Return type

[**SpeechTextAnalyticsConversationSummaryListing**](SpeechTextAnalyticsConversationSummaryListing)


## GetSpeechandtextanalyticsDictionaryfeedback

> [**DictionaryFeedbackEntityListing**](DictionaryFeedbackEntityListing) GetSpeechandtextanalyticsDictionaryfeedback (string dialect = null, string nextPage = null, int? pageSize = null)


Get the list of Speech & Text Analytics dictionary feedbacks

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsDictionaryfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = en-US;  // string | The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 500)

            try
            { 
                // Get the list of Speech & Text Analytics dictionary feedbacks
                DictionaryFeedbackEntityListing result = apiInstance.GetSpeechandtextanalyticsDictionaryfeedback(dialect, nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsDictionaryfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional]  |
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 500] |

### Return type

[**DictionaryFeedbackEntityListing**](DictionaryFeedbackEntityListing)


## GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId

> [**DictionaryFeedback**](DictionaryFeedback) GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId)


Get a Speech & Text Analytics dictionary feedback by id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback

            try
            { 
                // Get a Speech & Text Analytics dictionary feedback by id
                DictionaryFeedback result = apiInstance.GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |

### Return type

[**DictionaryFeedback**](DictionaryFeedback)


## GetSpeechandtextanalyticsProgram

> [**Program**](Program) GetSpeechandtextanalyticsProgram (string programId)


Get a Speech & Text Analytics program by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get a Speech & Text Analytics program by id
                Program result = apiInstance.GetSpeechandtextanalyticsProgram(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |

### Return type

[**Program**](Program)


## GetSpeechandtextanalyticsProgramMappings

> [**ProgramMappings**](ProgramMappings) GetSpeechandtextanalyticsProgramMappings (string programId)


Get Speech & Text Analytics program mappings to queues and flows by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get Speech & Text Analytics program mappings to queues and flows by id
                ProgramMappings result = apiInstance.GetSpeechandtextanalyticsProgramMappings(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |

### Return type

[**ProgramMappings**](ProgramMappings)


## GetSpeechandtextanalyticsProgramSettingsInsights

> [**ProgramInsightsSettings**](ProgramInsightsSettings) GetSpeechandtextanalyticsProgramSettingsInsights (string programId)


Get AI Insights settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:view
* speechAndTextAnalytics:insightsSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramSettingsInsightsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get AI Insights settings of a program
                ProgramInsightsSettings result = apiInstance.GetSpeechandtextanalyticsProgramSettingsInsights(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramSettingsInsights: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |

### Return type

[**ProgramInsightsSettings**](ProgramInsightsSettings)


## GetSpeechandtextanalyticsProgramTranscriptionengines

> [**ProgramTranscriptionEngines**](ProgramTranscriptionEngines) GetSpeechandtextanalyticsProgramTranscriptionengines (string programId)


Get transcription engine settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramTranscriptionenginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program

            try
            { 
                // Get transcription engine settings of a program
                ProgramTranscriptionEngines result = apiInstance.GetSpeechandtextanalyticsProgramTranscriptionengines(programId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramTranscriptionengines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |

### Return type

[**ProgramTranscriptionEngines**](ProgramTranscriptionEngines)


## GetSpeechandtextanalyticsPrograms

> [**ProgramsEntityListing**](ProgramsEntityListing) GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null, string state = null)


Get the list of Speech & Text Analytics programs

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)
            var state = state_example;  // string | Program state. Defaults to Latest (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics programs
                ProgramsEntityListing result = apiInstance.GetSpeechandtextanalyticsPrograms(nextPage, pageSize, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |
| **state** | **string**| Program state. Defaults to Latest | [optional] <br />**Values**: Latest, Published |

### Return type

[**ProgramsEntityListing**](ProgramsEntityListing)


## GetSpeechandtextanalyticsProgramsGeneralJob

> [**GeneralProgramJob**](GeneralProgramJob) GetSpeechandtextanalyticsProgramsGeneralJob (string jobId)


Get a Speech & Text Analytics general program job by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:add
* speechAndTextAnalytics:program:edit
* speechAndTextAnalytics:topic:add
* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsGeneralJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish programs job

            try
            { 
                // Get a Speech & Text Analytics general program job by id
                GeneralProgramJob result = apiInstance.GetSpeechandtextanalyticsProgramsGeneralJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsGeneralJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish programs job |  |

### Return type

[**GeneralProgramJob**](GeneralProgramJob)


## GetSpeechandtextanalyticsProgramsMappings

> [**ProgramsMappingsEntityListing**](ProgramsMappingsEntityListing) GetSpeechandtextanalyticsProgramsMappings (string nextPage = null, int? pageSize = null)


Get the list of Speech & Text Analytics programs mappings to queues and flows

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)

            try
            { 
                // Get the list of Speech & Text Analytics programs mappings to queues and flows
                ProgramsMappingsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsMappings(nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |

### Return type

[**ProgramsMappingsEntityListing**](ProgramsMappingsEntityListing)


## GetSpeechandtextanalyticsProgramsPublishjob

> [**ProgramJob**](ProgramJob) GetSpeechandtextanalyticsProgramsPublishjob (string jobId)


Get a Speech & Text Analytics publish programs job by id

Requires ALL permissions: 

* speechAndTextAnalytics:program:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsPublishjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish programs job

            try
            { 
                // Get a Speech & Text Analytics publish programs job by id
                ProgramJob result = apiInstance.GetSpeechandtextanalyticsProgramsPublishjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsPublishjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish programs job |  |

### Return type

[**ProgramJob**](ProgramJob)


## GetSpeechandtextanalyticsProgramsSettingsInsights

> [**ProgramInsightsSettingsEntityListing**](ProgramInsightsSettingsEntityListing) GetSpeechandtextanalyticsProgramsSettingsInsights (int? pageSize = null, int? pageNumber = null, List<string> programIds = null)


Get the list of program AI Insights settings for the organization

Requires ALL permissions: 

* speechAndTextAnalytics:program:view
* speechAndTextAnalytics:insightsSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsSettingsInsightsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 100. (optional)  (default to 100)
            var pageNumber = 56;  // int? | The page number for the listing (optional)  (default to 1)
            var programIds = new List<string>(); // List<string> | Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. (optional) 

            try
            { 
                // Get the list of program AI Insights settings for the organization
                ProgramInsightsSettingsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsSettingsInsights(pageSize, pageNumber, programIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsSettingsInsights: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 100. | [optional] [default to 100] |
| **pageNumber** | **int?**| The page number for the listing | [optional] [default to 1] |
| **programIds** | [**List<string>**](string)| Comma separated Program IDs to filter by. Maximum of 50 IDs allowed. | [optional]  |

### Return type

[**ProgramInsightsSettingsEntityListing**](ProgramInsightsSettingsEntityListing)


## GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects

> [**SupportedDialectsEntityListing**](SupportedDialectsEntityListing) GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects ()


Get supported dialects for each transcription engine

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
    public class GetSpeechandtextanalyticsProgramsTranscriptionenginesDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get supported dialects for each transcription engine
                SupportedDialectsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsTranscriptionenginesDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**SupportedDialectsEntityListing**](SupportedDialectsEntityListing)


## GetSpeechandtextanalyticsProgramsUnpublished

> [**UnpublishedProgramsEntityListing**](UnpublishedProgramsEntityListing) GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null)


Get the list of Speech & Text Analytics unpublished programs

Requires ALL permissions: 

* speechAndTextAnalytics:program:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsProgramsUnpublishedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing (optional)  (default to 20)

            try
            { 
                // Get the list of Speech & Text Analytics unpublished programs
                UnpublishedProgramsEntityListing result = apiInstance.GetSpeechandtextanalyticsProgramsUnpublished(nextPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsProgramsUnpublished: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing | [optional] [default to 20] |

### Return type

[**UnpublishedProgramsEntityListing**](UnpublishedProgramsEntityListing)


## GetSpeechandtextanalyticsReprocessingJob

> [**ReprocessJobResponse**](ReprocessJobResponse) GetSpeechandtextanalyticsReprocessingJob (string jobId)


Get a Speech & Text Analytics reprocess job by id

GetSpeechandtextanalyticsReprocessingJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* speechAndTextAnalytics:reprocessInteractions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsReprocessingJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The Id of the Reprocessing job

            try
            { 
                // Get a Speech & Text Analytics reprocess job by id
                ReprocessJobResponse result = apiInstance.GetSpeechandtextanalyticsReprocessingJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsReprocessingJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The Id of the Reprocessing job |  |

### Return type

[**ReprocessJobResponse**](ReprocessJobResponse)


## GetSpeechandtextanalyticsReprocessingJobInteractions

> [**ReprocessInteractionsByJobIdResponse**](ReprocessInteractionsByJobIdResponse) GetSpeechandtextanalyticsReprocessingJobInteractions (string jobId)


Get a Speech & Text Analytics Reprocessing interactions statuses by job id

GetSpeechandtextanalyticsReprocessingJobInteractions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* speechAndTextAnalytics:reprocessInteractions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsReprocessingJobInteractionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The Id of the Reprocessing job

            try
            { 
                // Get a Speech & Text Analytics Reprocessing interactions statuses by job id
                ReprocessInteractionsByJobIdResponse result = apiInstance.GetSpeechandtextanalyticsReprocessingJobInteractions(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsReprocessingJobInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The Id of the Reprocessing job |  |

### Return type

[**ReprocessInteractionsByJobIdResponse**](ReprocessInteractionsByJobIdResponse)


## GetSpeechandtextanalyticsReprocessingJobs

> [**ReprocessJobEntityListingResponse**](ReprocessJobEntityListingResponse) GetSpeechandtextanalyticsReprocessingJobs (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)


Get the list of Speech & Text Analytics reprocess jobs

GetSpeechandtextanalyticsReprocessingJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* speechAndTextAnalytics:reprocessInteractions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsReprocessingJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 100. Default is 25. (optional) 
            var pageNumber = 56;  // int? | The page number for the listing. Defaults to 1. (optional) 
            var sortOrder = sortOrder_example;  // string | Results are sorted by dateCreated. Please choose the sort order. The default is descending (desc). (optional) 
            var name = name_example;  // string | Case insensitive partial name to filter by. (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics reprocess jobs
                ReprocessJobEntityListingResponse result = apiInstance.GetSpeechandtextanalyticsReprocessingJobs(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsReprocessingJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 100. Default is 25. | [optional]  |
| **pageNumber** | **int?**| The page number for the listing. Defaults to 1. | [optional]  |
| **sortOrder** | **string**| Results are sorted by dateCreated. Please choose the sort order. The default is descending (desc). | [optional] <br />**Values**: asc, desc |
| **name** | **string**| Case insensitive partial name to filter by. | [optional]  |

### Return type

[**ReprocessJobEntityListingResponse**](ReprocessJobEntityListingResponse)


## GetSpeechandtextanalyticsSentimentDialects

> [**EntityListing**](EntityListing) GetSpeechandtextanalyticsSentimentDialects ()


Get the list of Speech & Text Analytics sentiment supported dialects

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
    public class GetSpeechandtextanalyticsSentimentDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get the list of Speech & Text Analytics sentiment supported dialects
                EntityListing result = apiInstance.GetSpeechandtextanalyticsSentimentDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSentimentDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EntityListing**](EntityListing)


## GetSpeechandtextanalyticsSentimentfeedback

> [**SentimentFeedbackEntityListing**](SentimentFeedbackEntityListing) GetSpeechandtextanalyticsSentimentfeedback (string dialect = null)


Get the list of Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = en-US;  // string | The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics SentimentFeedback
                SentimentFeedbackEntityListing result = apiInstance.GetSpeechandtextanalyticsSentimentfeedback(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The key for filter the listing by dialect, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional]  |

### Return type

[**SentimentFeedbackEntityListing**](SentimentFeedbackEntityListing)


## GetSpeechandtextanalyticsSettings

> [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse) GetSpeechandtextanalyticsSettings ()


Get Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.GetSpeechandtextanalyticsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse)


## GetSpeechandtextanalyticsTopic

> [**Topic**](Topic) GetSpeechandtextanalyticsTopic (string topicId)


Get a Speech & Text Analytics topic by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic

            try
            { 
                // Get a Speech & Text Analytics topic by id
                Topic result = apiInstance.GetSpeechandtextanalyticsTopic(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |

### Return type

[**Topic**](Topic)


## GetSpeechandtextanalyticsTopics

> [**TopicsEntityListing**](TopicsEntityListing) GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null, int? pageNumber = null, string state = null, string name = null, List<string> ids = null, List<string> dialects = null, string sortBy = null, string sortOrder = null)


Get the list of Speech & Text Analytics topics

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var nextPage = nextPage_example;  // string | The key for listing the next page (optional) 
            var pageSize = 56;  // int? | The page size for the listing. The max that will be returned is 500. (optional)  (default to 20)
            var pageNumber = 56;  // int? | The page number for the listing (optional) 
            var state = state_example;  // string | Topic state. Defaults to latest (optional) 
            var name = name_example;  // string | Case insensitive partial name to filter by (optional) 
            var ids = new List<string>(); // List<string> | Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. (optional) 
            var dialects = new List<string>(); // List<string> | Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. (optional) 
            var sortBy = sortBy_example;  // string | Sort results by. Defaults to name (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order. Defaults to asc (optional) 

            try
            { 
                // Get the list of Speech & Text Analytics topics
                TopicsEntityListing result = apiInstance.GetSpeechandtextanalyticsTopics(nextPage, pageSize, pageNumber, state, name, ids, dialects, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **nextPage** | **string**| The key for listing the next page | [optional]  |
| **pageSize** | **int?**| The page size for the listing. The max that will be returned is 500. | [optional] [default to 20] |
| **pageNumber** | **int?**| The page number for the listing | [optional]  |
| **state** | **string**| Topic state. Defaults to latest | [optional] <br />**Values**: latest, published |
| **name** | **string**| Case insensitive partial name to filter by | [optional]  |
| **ids** | [**List<string>**](string)| Comma separated Topic IDs to filter by. Cannot be used with other filters. Maximum of 50 IDs allowed. | [optional]  |
| **dialects** | [**List<string>**](string)| Comma separated dialect strings to filter by. Maximum of 15 dialects allowed. | [optional] <br />**Values**: en-US, es-US, en-AU, en-GB, en-ZA, es-ES, en-IN, fr-FR, fr-CA, it-IT, de-DE, pt-BR, pl-PL, pt-PT, nl-NL, ko-KR |
| **sortBy** | **string**| Sort results by. Defaults to name | [optional] <br />**Values**: name, matchingType |
| **sortOrder** | **string**| Sort order. Defaults to asc | [optional] <br />**Values**: asc, desc |

### Return type

[**TopicsEntityListing**](TopicsEntityListing)


## GetSpeechandtextanalyticsTopicsDialects

> [**EntityListing**](EntityListing) GetSpeechandtextanalyticsTopicsDialects ()


Get list of supported Speech & Text Analytics topics dialects

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
    public class GetSpeechandtextanalyticsTopicsDialectsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get list of supported Speech & Text Analytics topics dialects
                EntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsDialects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsDialects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EntityListing**](EntityListing)


## GetSpeechandtextanalyticsTopicsGeneral

> [**GeneralTopicsEntityListing**](GeneralTopicsEntityListing) GetSpeechandtextanalyticsTopicsGeneral (string dialect = null)


Get the Speech & Text Analytics general topics for a given dialect

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsGeneralExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = dialect_example;  // string | The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the Speech & Text Analytics general topics for a given dialect
                GeneralTopicsEntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsGeneral(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsGeneral: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional] <br />**Values**: ar-001, ar-AE, ar-BH, ar-EG, ar-IL, ar-SA, ar-TN, da-DK, de-CH, de-DE, en-AU, en-GB, en-HK, en-IE, en-IN, en-NZ, en-SG, en-US, en-ZA, es-ES, es-US, fi-FI, fr-CA, fr-FR, he-IL, hi-IN, it-IT, ja-JP, ko-KR, nb-NO, nl-NL, pl-PL, pt-BR, pt-PT, sv-SE, zh-CN, zh-HK, zh-TW |

### Return type

[**GeneralTopicsEntityListing**](GeneralTopicsEntityListing)


## GetSpeechandtextanalyticsTopicsGeneralStatus

> [**UnifiedGeneralTopicEntityListing**](UnifiedGeneralTopicEntityListing) GetSpeechandtextanalyticsTopicsGeneralStatus (string dialect = null)


Get the list of general topics from the org and the system with their current status

Requires ALL permissions: 

* speechAndTextAnalytics:topic:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsGeneralStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dialect = dialect_example;  // string | The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional) 

            try
            { 
                // Get the list of general topics from the org and the system with their current status
                UnifiedGeneralTopicEntityListing result = apiInstance.GetSpeechandtextanalyticsTopicsGeneralStatus(dialect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsGeneralStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dialect** | **string**| The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | [optional] <br />**Values**: ar-001, ar-AE, ar-BH, ar-EG, ar-IL, ar-SA, ar-TN, da-DK, de-CH, de-DE, en-AU, en-GB, en-HK, en-IE, en-IN, en-NZ, en-SG, en-US, en-ZA, es-ES, es-US, fi-FI, fr-CA, fr-FR, he-IL, hi-IN, it-IT, ja-JP, ko-KR, nb-NO, nl-NL, pl-PL, pt-BR, pt-PT, sv-SE, zh-CN, zh-HK, zh-TW |

### Return type

[**UnifiedGeneralTopicEntityListing**](UnifiedGeneralTopicEntityListing)


## GetSpeechandtextanalyticsTopicsPublishjob

> [**TopicJob**](TopicJob) GetSpeechandtextanalyticsTopicsPublishjob (string jobId)


Get a Speech & Text Analytics publish topics job by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsPublishjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | The id of the publish topics job

            try
            { 
                // Get a Speech & Text Analytics publish topics job by id
                TopicJob result = apiInstance.GetSpeechandtextanalyticsTopicsPublishjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsPublishjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the publish topics job |  |

### Return type

[**TopicJob**](TopicJob)


## GetSpeechandtextanalyticsTopicsTestphraseJob

> [**TestTopicPhraseJob**](TestTopicPhraseJob) GetSpeechandtextanalyticsTopicsTestphraseJob (string jobId)


Get a Speech & Text Analytics test topics phrase job by id

Requires ALL permissions: 

* speechAndTextAnalytics:topic:testPhrase

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTopicsTestphraseJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var jobId = jobId_example;  // string | the id of the test topic phrase job

            try
            { 
                // Get a Speech & Text Analytics test topics phrase job by id
                TestTopicPhraseJob result = apiInstance.GetSpeechandtextanalyticsTopicsTestphraseJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTopicsTestphraseJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| the id of the test topic phrase job |  |

### Return type

[**TestTopicPhraseJob**](TestTopicPhraseJob)


## GetSpeechandtextanalyticsTranslationsLanguageConversation

> [**CommunicationTranslationList**](CommunicationTranslationList) GetSpeechandtextanalyticsTranslationsLanguageConversation (string languageId, string conversationId, string communicationId = null, string recordingId = null)


Translate a single interaction recording (or an email conversation)

Requires ALL permissions: 

* speechAndTextAnalytics:translation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTranslationsLanguageConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var languageId = languageId_example;  // string | Target translation language
            var conversationId = conversationId_example;  // string | Conversation id
            var communicationId = communicationId_example;  // string | Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. (optional) 
            var recordingId = recordingId_example;  // string | Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. (optional) 

            try
            { 
                // Translate a single interaction recording (or an email conversation)
                CommunicationTranslationList result = apiInstance.GetSpeechandtextanalyticsTranslationsLanguageConversation(languageId, conversationId, communicationId, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTranslationsLanguageConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Target translation language |  |
| **conversationId** | **string**| Conversation id |  |
| **communicationId** | **string**| Communication id associated with the conversation. Please provide a valid communicationId when requesting non-email interactions. | [optional]  |
| **recordingId** | **string**| Recording id associated with the communication. Please provide a valid recordingId when requesting voice interactions. | [optional]  |

### Return type

[**CommunicationTranslationList**](CommunicationTranslationList)


## GetSpeechandtextanalyticsTranslationsLanguages

> [**TranslateSupportedLanguageList**](TranslateSupportedLanguageList) GetSpeechandtextanalyticsTranslationsLanguages ()


Get supported translation languages

Requires ALL permissions: 

* speechAndTextAnalytics:translation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetSpeechandtextanalyticsTranslationsLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();

            try
            { 
                // Get supported translation languages
                TranslateSupportedLanguageList result = apiInstance.GetSpeechandtextanalyticsTranslationsLanguages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetSpeechandtextanalyticsTranslationsLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TranslateSupportedLanguageList**](TranslateSupportedLanguageList)


## PatchSpeechandtextanalyticsSettings

> [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse) PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)


Patch Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SpeechTextAnalyticsSettingsRequest(); // SpeechTextAnalyticsSettingsRequest | Speech And Text Analytics Settings

            try
            { 
                // Patch Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.PatchSpeechandtextanalyticsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PatchSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SpeechTextAnalyticsSettingsRequest**](SpeechTextAnalyticsSettingsRequest)| Speech And Text Analytics Settings |  |

### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse)


## PostSpeechandtextanalyticsCategories

> [**StaCategory**](StaCategory) PostSpeechandtextanalyticsCategories (CategoryRequest body)


Create new Speech & Text Analytics category

Requires ALL permissions: 

* speechAndTextAnalytics:category:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new CategoryRequest(); // CategoryRequest | The category to create

            try
            { 
                // Create new Speech & Text Analytics category
                StaCategory result = apiInstance.PostSpeechandtextanalyticsCategories(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CategoryRequest**](CategoryRequest)| The category to create |  |

### Return type

[**StaCategory**](StaCategory)


## PostSpeechandtextanalyticsDictionaryfeedback

> [**DictionaryFeedback**](DictionaryFeedback) PostSpeechandtextanalyticsDictionaryfeedback (DictionaryFeedback body)


Create a Speech & Text Analytics DictionaryFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsDictionaryfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new DictionaryFeedback(); // DictionaryFeedback | The DictionaryFeedback to create

            try
            { 
                // Create a Speech & Text Analytics DictionaryFeedback
                DictionaryFeedback result = apiInstance.PostSpeechandtextanalyticsDictionaryfeedback(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsDictionaryfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DictionaryFeedback**](DictionaryFeedback)| The DictionaryFeedback to create |  |

### Return type

[**DictionaryFeedback**](DictionaryFeedback)


## PostSpeechandtextanalyticsPrograms

> [**Program**](Program) PostSpeechandtextanalyticsPrograms (ProgramRequest body)


Create new Speech & Text Analytics program

Requires ALL permissions: 

* speechAndTextAnalytics:program:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new ProgramRequest(); // ProgramRequest | The program to create

            try
            { 
                // Create new Speech & Text Analytics program
                Program result = apiInstance.PostSpeechandtextanalyticsPrograms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsPrograms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ProgramRequest**](ProgramRequest)| The program to create |  |

### Return type

[**Program**](Program)


## PostSpeechandtextanalyticsProgramsGeneralJobs

> [**GeneralProgramJob**](GeneralProgramJob) PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body)


Create new Speech & Text Analytics general program job

Requires ALL permissions: 

* speechAndTextAnalytics:program:add
* speechAndTextAnalytics:program:edit
* speechAndTextAnalytics:topic:add
* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsGeneralJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new GeneralProgramJobRequest(); // GeneralProgramJobRequest | The general programs job to create

            try
            { 
                // Create new Speech & Text Analytics general program job
                GeneralProgramJob result = apiInstance.PostSpeechandtextanalyticsProgramsGeneralJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsProgramsGeneralJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GeneralProgramJobRequest**](GeneralProgramJobRequest)| The general programs job to create |  |

### Return type

[**GeneralProgramJob**](GeneralProgramJob)


## PostSpeechandtextanalyticsProgramsPublishjobs

> [**ProgramJob**](ProgramJob) PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body)


Create new Speech & Text Analytics publish programs job

Requires ALL permissions: 

* speechAndTextAnalytics:program:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsProgramsPublishjobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new ProgramJobRequest(); // ProgramJobRequest | The publish programs job to create

            try
            { 
                // Create new Speech & Text Analytics publish programs job
                ProgramJob result = apiInstance.PostSpeechandtextanalyticsProgramsPublishjobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsProgramsPublishjobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ProgramJobRequest**](ProgramJobRequest)| The publish programs job to create |  |

### Return type

[**ProgramJob**](ProgramJob)


## PostSpeechandtextanalyticsReprocessingJobs

> [**ReprocessJobResponse**](ReprocessJobResponse) PostSpeechandtextanalyticsReprocessingJobs (CreateReprocessJobRequest body)


Create a Speech & Text Analytics reprocess job.

PostSpeechandtextanalyticsReprocessingJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* speechAndTextAnalytics:reprocessInteractions:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsReprocessingJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new CreateReprocessJobRequest(); // CreateReprocessJobRequest | The ReprocessJob to create

            try
            { 
                // Create a Speech & Text Analytics reprocess job.
                ReprocessJobResponse result = apiInstance.PostSpeechandtextanalyticsReprocessingJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsReprocessingJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateReprocessJobRequest**](CreateReprocessJobRequest)| The ReprocessJob to create |  |

### Return type

[**ReprocessJobResponse**](ReprocessJobResponse)


## PostSpeechandtextanalyticsSentimentfeedback

> [**SentimentFeedback**](SentimentFeedback) PostSpeechandtextanalyticsSentimentfeedback (SentimentFeedback body)


Create a Speech & Text Analytics SentimentFeedback

Requires ALL permissions: 

* speechAndTextAnalytics:feedback:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsSentimentfeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SentimentFeedback(); // SentimentFeedback | The SentimentFeedback to create

            try
            { 
                // Create a Speech & Text Analytics SentimentFeedback
                SentimentFeedback result = apiInstance.PostSpeechandtextanalyticsSentimentfeedback(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsSentimentfeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SentimentFeedback**](SentimentFeedback)| The SentimentFeedback to create |  |

### Return type

[**SentimentFeedback**](SentimentFeedback)


## PostSpeechandtextanalyticsTopics

> [**Topic**](Topic) PostSpeechandtextanalyticsTopics (TopicRequest body)


Create new Speech & Text Analytics topic

Requires ALL permissions: 

* speechAndTextAnalytics:topic:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TopicRequest(); // TopicRequest | The topic to create

            try
            { 
                // Create new Speech & Text Analytics topic
                Topic result = apiInstance.PostSpeechandtextanalyticsTopics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TopicRequest**](TopicRequest)| The topic to create |  |

### Return type

[**Topic**](Topic)


## PostSpeechandtextanalyticsTopicsPublishjobs

> [**TopicJob**](TopicJob) PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body)


Create new Speech & Text Analytics publish topics job

Requires ALL permissions: 

* speechAndTextAnalytics:topic:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTopicsPublishjobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TopicJobRequest(); // TopicJobRequest | The publish topics job to create

            try
            { 
                // Create new Speech & Text Analytics publish topics job
                TopicJob result = apiInstance.PostSpeechandtextanalyticsTopicsPublishjobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTopicsPublishjobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TopicJobRequest**](TopicJobRequest)| The publish topics job to create |  |

### Return type

[**TopicJob**](TopicJob)


## PostSpeechandtextanalyticsTopicsTestphraseJobs

> [**TestTopicPhraseJobs**](TestTopicPhraseJobs) PostSpeechandtextanalyticsTopicsTestphraseJobs (TestTopicPhraseJobRequest body)


Create new Speech & Text Analytics publish topics job

Requires ALL permissions: 

* speechAndTextAnalytics:topic:testPhrase

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTopicsTestphraseJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TestTopicPhraseJobRequest(); // TestTopicPhraseJobRequest | The publish test topic phrase job to create

            try
            { 
                // Create new Speech & Text Analytics publish topics job
                TestTopicPhraseJobs result = apiInstance.PostSpeechandtextanalyticsTopicsTestphraseJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTopicsTestphraseJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TestTopicPhraseJobRequest**](TestTopicPhraseJobRequest)| The publish test topic phrase job to create |  |

### Return type

[**TestTopicPhraseJobs**](TestTopicPhraseJobs)


## PostSpeechandtextanalyticsTranscriptsSearch

> [**JsonSearchResponse**](JsonSearchResponse) PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)


Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view
* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSpeechandtextanalyticsTranscriptsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new TranscriptSearchRequest(); // TranscriptSearchRequest | Search request options

            try
            { 
                // Search resources.
                JsonSearchResponse result = apiInstance.PostSpeechandtextanalyticsTranscriptsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PostSpeechandtextanalyticsTranscriptsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptSearchRequest**](TranscriptSearchRequest)| Search request options |  |

### Return type

[**JsonSearchResponse**](JsonSearchResponse)


## PutSpeechandtextanalyticsCategory

> [**StaCategory**](StaCategory) PutSpeechandtextanalyticsCategory (string categoryId, CategoryRequest body)


Update a Speech & Text Analytics category by ID

Requires ALL permissions: 

* speechAndTextAnalytics:category:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var categoryId = categoryId_example;  // string | The id of the category
            var body = new CategoryRequest(); // CategoryRequest | The updated category

            try
            { 
                // Update a Speech & Text Analytics category by ID
                StaCategory result = apiInstance.PutSpeechandtextanalyticsCategory(categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| The id of the category |  |
| **body** | [**CategoryRequest**](CategoryRequest)| The updated category |  |

### Return type

[**StaCategory**](StaCategory)


## PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId

> [**DictionaryFeedback**](DictionaryFeedback) PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId (string dictionaryFeedbackId, DictionaryFeedback body = null)


Update existing Speech & Text Analytics dictionary feedback by id

Requires ALL permissions: 

* speechAndTextAnalytics:dictionaryterm:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var dictionaryFeedbackId = dictionaryFeedbackId_example;  // string | The Id of the Dictionary Feedback
            var body = new DictionaryFeedback(); // DictionaryFeedback |  (optional) 

            try
            { 
                // Update existing Speech & Text Analytics dictionary feedback by id
                DictionaryFeedback result = apiInstance.PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId(dictionaryFeedbackId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsDictionaryfeedbackDictionaryFeedbackId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dictionaryFeedbackId** | **string**| The Id of the Dictionary Feedback |  |
| **body** | [**DictionaryFeedback**](DictionaryFeedback)|  | [optional]  |

### Return type

[**DictionaryFeedback**](DictionaryFeedback)


## PutSpeechandtextanalyticsProgram

> [**Program**](Program) PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body)


Update existing Speech & Text Analytics program

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new ProgramRequest(); // ProgramRequest | The program to update

            try
            { 
                // Update existing Speech & Text Analytics program
                Program result = apiInstance.PutSpeechandtextanalyticsProgram(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**ProgramRequest**](ProgramRequest)| The program to update |  |

### Return type

[**Program**](Program)


## PutSpeechandtextanalyticsProgramMappings

> [**ProgramMappings**](ProgramMappings) PutSpeechandtextanalyticsProgramMappings (string programId, ProgramMappingsRequest body)


Set Speech & Text Analytics program mappings to queues and flows

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramMappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new ProgramMappingsRequest(); // ProgramMappingsRequest | The program to set mappings for

            try
            { 
                // Set Speech & Text Analytics program mappings to queues and flows
                ProgramMappings result = apiInstance.PutSpeechandtextanalyticsProgramMappings(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgramMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**ProgramMappingsRequest**](ProgramMappingsRequest)| The program to set mappings for |  |

### Return type

[**ProgramMappings**](ProgramMappings)


## PutSpeechandtextanalyticsProgramSettingsInsights

> [**ProgramInsightsSettings**](ProgramInsightsSettings) PutSpeechandtextanalyticsProgramSettingsInsights (string programId, InsightsSettingsRequest body)


Update AI Insights settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit
* speechAndTextAnalytics:insightsSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramSettingsInsightsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new InsightsSettingsRequest(); // InsightsSettingsRequest | Program AI Insights setting

            try
            { 
                // Update AI Insights settings of a program
                ProgramInsightsSettings result = apiInstance.PutSpeechandtextanalyticsProgramSettingsInsights(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgramSettingsInsights: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**InsightsSettingsRequest**](InsightsSettingsRequest)| Program AI Insights setting |  |

### Return type

[**ProgramInsightsSettings**](ProgramInsightsSettings)


## PutSpeechandtextanalyticsProgramTranscriptionengines

> [**ProgramTranscriptionEngines**](ProgramTranscriptionEngines) PutSpeechandtextanalyticsProgramTranscriptionengines (string programId, TranscriptionEnginesRequest body)


Update transcription engine settings of a program

Requires ALL permissions: 

* speechAndTextAnalytics:program:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsProgramTranscriptionenginesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the program
            var body = new TranscriptionEnginesRequest(); // TranscriptionEnginesRequest | Program transcription engine setting

            try
            { 
                // Update transcription engine settings of a program
                ProgramTranscriptionEngines result = apiInstance.PutSpeechandtextanalyticsProgramTranscriptionengines(programId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsProgramTranscriptionengines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **programId** | **string**| The id of the program |  |
| **body** | [**TranscriptionEnginesRequest**](TranscriptionEnginesRequest)| Program transcription engine setting |  |

### Return type

[**ProgramTranscriptionEngines**](ProgramTranscriptionEngines)


## PutSpeechandtextanalyticsSettings

> [**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse) PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)


Update Speech And Text Analytics Settings

Requires ALL permissions: 

* speechAndTextAnalytics:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new SpeechTextAnalyticsSettingsRequest(); // SpeechTextAnalyticsSettingsRequest | Speech And Text Analytics Settings

            try
            { 
                // Update Speech And Text Analytics Settings
                SpeechTextAnalyticsSettingsResponse result = apiInstance.PutSpeechandtextanalyticsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SpeechTextAnalyticsSettingsRequest**](SpeechTextAnalyticsSettingsRequest)| Speech And Text Analytics Settings |  |

### Return type

[**SpeechTextAnalyticsSettingsResponse**](SpeechTextAnalyticsSettingsResponse)


## PutSpeechandtextanalyticsTopic

> [**Topic**](Topic) PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body)


Update existing Speech & Text Analytics topic

Requires ALL permissions: 

* speechAndTextAnalytics:topic:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutSpeechandtextanalyticsTopicExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic
            var body = new TopicRequest(); // TopicRequest | The topic to update

            try
            { 
                // Update existing Speech & Text Analytics topic
                Topic result = apiInstance.PutSpeechandtextanalyticsTopic(topicId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.PutSpeechandtextanalyticsTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicId** | **string**| The id of the topic |  |
| **body** | [**TopicRequest**](TopicRequest)| The topic to update |  |

### Return type

[**Topic**](Topic)


_PureCloudPlatform.Client.V2 251.0.0_
