---
title: SpeechTextAnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.SpeechTextAnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSpeechandtextanalyticsConversation**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversation) | **GET** /api/v2/speechandtextanalytics/conversations/{conversationId} | Get Speech and Text Analytics for a specific conversation |
| [**GetSpeechandtextanalyticsConversationCommunicationTranscripturl**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsconversationcommunicationtranscripturl) | **GET** /api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl | Get the pre-signed S3 URL for the transcript of a specific communication of a conversation |
{: class="table table-striped"}

<a name="getspeechandtextanalyticsconversation"></a>

## [**ConversationMetrics**](ConversationMetrics.html) GetSpeechandtextanalyticsConversation (string conversationId)



Get Speech and Text Analytics for a specific conversation



Requires ANY permissions: 

* recording:recording:view

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**ConversationMetrics**](ConversationMetrics.html)

<a name="getspeechandtextanalyticsconversationcommunicationtranscripturl"></a>

## [**TranscriptUrl**](TranscriptUrl.html) GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId)



Get the pre-signed S3 URL for the transcript of a specific communication of a conversation



Requires ANY permissions: 

* recording:recording:view

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**TranscriptUrl**](TranscriptUrl.html)

