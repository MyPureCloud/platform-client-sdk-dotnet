# SpeechTextAnalyticsConversationSummary

## ININ.PureCloudApi.Model.SpeechTextAnalyticsConversationSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SummaryType** | **string** | The type of summary | [optional] |
| **MediaType** | **string** | The media type of the associated interaction | [optional] |
| **Language** | **string** | Language of the summary | [optional] |
| **SourceId** | **string** | The id of the source (program, agent assistant, or flow) from which summarization is triggered | [optional] |
| **Summary** | **string** | A summarization of the conversation transcription | [optional] |
| **Generated** | **bool?** | Indicates whether or not the summary was generated by AI | [optional] |
| **DateCreated** | **DateTime?** | Timestamp of when the summary was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
