---
title: SpeechTextAnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.SpeechTextAnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSpeechandtextanalyticsProgram**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticsprogram) | **GET** /api/v2/speechandtextanalytics/programs/{programId} | Get a Speech &amp; Text Analytics program by id |
| [**GetSpeechandtextanalyticsTopic**](SpeechTextAnalyticsApi.html#getspeechandtextanalyticstopic) | **GET** /api/v2/speechandtextanalytics/topics/{topicId} | Get a Speech &amp; Text Analytics topic by id |
| [**PostSpeechandtextanalyticsTopics**](SpeechTextAnalyticsApi.html#postspeechandtextanalyticstopics) | **POST** /api/v2/speechandtextanalytics/topics | Create new Speech &amp; Text Analytics topic |
{: class="table table-striped"}

<a name="getspeechandtextanalyticsprogram"></a>

## [**Program**](Program.html) GetSpeechandtextanalyticsProgram (string programId)



Get a Speech & Text Analytics program by id



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpeechTextAnalyticsApi();
            var programId = programId_example;  // string | The id of the topic to get

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
| **programId** | **string**| The id of the topic to get |  |
{: class="table table-striped"}

### Return type

[**Program**](Program.html)

<a name="getspeechandtextanalyticstopic"></a>

## [**Topic**](Topic.html) GetSpeechandtextanalyticsTopic (string topicId)



Get a Speech & Text Analytics topic by id



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpeechTextAnalyticsApi();
            var topicId = topicId_example;  // string | The id of the topic to get

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
| **topicId** | **string**| The id of the topic to get |  |
{: class="table table-striped"}

### Return type

[**Topic**](Topic.html)

<a name="postspeechandtextanalyticstopics"></a>

## [**Topic**](Topic.html) PostSpeechandtextanalyticsTopics (CreateTopicRequest body)



Create new Speech & Text Analytics topic



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpeechTextAnalyticsApi();
            var body = new CreateTopicRequest(); // CreateTopicRequest | The topic to create

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
| **body** | [**CreateTopicRequest**](CreateTopicRequest.html)| The topic to create |  |
{: class="table table-striped"}

### Return type

[**Topic**](Topic.html)

