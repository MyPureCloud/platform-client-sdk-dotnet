# TranscriptTopic

## ININ.PureCloudApi.Model.TranscriptTopic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the object. | [optional] |
| **TopicPhrase** | **string** | The phrase which detected the topic.  | [optional] |
| **TranscriptPhrase** | **string** | The transcript phrase which detected the topic. | [optional] |
| **Confidence** | **int?** | The detection confidence of the topic. | [optional] |
| **StartTimeMilliseconds** | **long?** | The start time of the topic phrase. | [optional] |
| **Duration** | [**TopicDuration**](TopicDuration) |  | [optional] |
| **Offset** | [**TopicOffset**](TopicOffset) | Location of the phrase | [optional] |
| **RecordingLocation** | **long?** | Location of the phrase in the recording in milliseconds | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
