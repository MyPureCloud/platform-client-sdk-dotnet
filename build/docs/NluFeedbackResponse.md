---
title: NluFeedbackResponse
---
## ININ.PureCloudApi.Model.NluFeedbackResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Text** | **string** | The feedback text. | [optional] |
| **Intents** | [**List&lt;IntentFeedback&gt;**](IntentFeedback.html) | Detected intent of the utterance | [optional] |
| **Version** | [**NluDomainVersion**](NluDomainVersion.html) | The domain version of the feedback. | [optional] |
| **DateCreated** | **DateTime?** | The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


