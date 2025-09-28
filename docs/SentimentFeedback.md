# SentimentFeedback

## ININ.PureCloudApi.Model.SentimentFeedback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Phrase** | **string** | The phrase for which sentiment feedback is provided | |
| **Dialect** | **string** | The dialect for the given phrase, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | |
| **FeedbackValue** | **string** | The sentiment feedback value for the given phrase | |
| **DateCreated** | **DateTime?** | The Timestamp when sentiment feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The Id of user who created the sentiment feedback | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
