# ListedDictionaryFeedback

## ININ.PureCloudApi.Model.ListedDictionaryFeedback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Term** | **string** | The dictionary term which needs to be added to dictionary feedback system | |
| **Dialect** | **string** | The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard | |
| **BoostValue** | **float?** | A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0 | [optional] |
| **Source** | **string** | The source of the given dictionary feedback | [optional] |
| **DateCreated** | **DateTime?** | The Timestamp when dictionary feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The Id of the user who created the dictionary feedback | [optional] |
| **DateModified** | **DateTime?** | The Timestamp when dictionary feedback modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The Id of the user who modified the dictionary feedback | [optional] |
| **TranscriptionEngine** | **string** | The transcription engine for the dictionary feedback. Only returned when GenesysExtended feature is enabled. | [optional] |
| **Status** | **string** | The status of the dictionary feedback. Only returned when GenesysExtended feature is enabled. | [optional] |
| **DisplayAs** | **string** | The display name for the dictionary feedback. Only returned when GenesysExtended feature is enabled. This field is only valid for Extended Services transcription engine. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
