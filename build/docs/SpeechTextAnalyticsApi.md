---
title: SpeechTextAnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.SpeechTextAnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetConversationTranscriptproperty**](SpeechTextAnalyticsApi.html#getconversationtranscriptproperty) | **GET** /api/v2/conversations/{conversationId}/transcriptproperties/{communicationId} | Get the pre-signed S3 URL for the transcript of a specific communication of a conversation |
{: class="table table-striped"}

<a name="getconversationtranscriptproperty"></a>

## [**TranscriptProperty**](TranscriptProperty.html) GetConversationTranscriptproperty (string conversationId, string communicationId)



Get the pre-signed S3 URL for the transcript of a specific communication of a conversation



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
    public class GetConversationTranscriptpropertyExample
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
                TranscriptProperty result = apiInstance.GetConversationTranscriptproperty(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechTextAnalyticsApi.GetConversationTranscriptproperty: " + e.Message );
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

[**TranscriptProperty**](TranscriptProperty.html)

