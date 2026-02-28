# NluFeedbackResponse

## ININ.PureCloudApi.Model.NluFeedbackResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Text** | **string** | The feedback text. | [optional] |
| **Intents** | [**List&lt;IntentFeedback&gt;**](IntentFeedback) | Detected intent of the utterance | [optional] |
| **Version** | [**NluDomainVersion**](NluDomainVersion) | The domain version of the feedback. | [optional] |
| **DateCreated** | **DateTime?** | The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Language** | **string** | The language of the version to which feedback is linked, e.g. en-us, de-de | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
