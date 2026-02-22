# MessageMediaSettings

## ININ.PureCloudApi.Model.MessageMediaSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnableAutoAnswer** | **bool?** | Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings. | [optional] |
| **AlertingTimeoutSeconds** | **int?** | The alerting timeout for the media type, in seconds | [optional] |
| **ServiceLevel** | [**ServiceLevel**](ServiceLevel) | The targeted service level for the media type | [optional] |
| **AutoAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for an auto-answer interaction | [optional] |
| **ManualAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for a manual-answer interaction | [optional] |
| **SubTypeSettings** | [**Dictionary&lt;string, MessageSubtypeSettings&gt;**](MessageSubtypeSettings) | Map of media subtype to media subtype specific settings. | [optional] |
| **EnableInactivityTimeout** | **bool?** | Indicates if inactivity timeout is enabled for all subtypes. | [optional] |
| **InactivityTimeoutSettings** | [**InactivityTimeoutSettings**](InactivityTimeoutSettings) | Inactivity timeout settings for messages | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
