# EmailMediaSettings

## ININ.PureCloudApi.Model.EmailMediaSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnableAutoAnswer** | **bool?** | Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings. | [optional] |
| **AlertingTimeoutSeconds** | **int?** | The alerting timeout for the media type, in seconds | [optional] |
| **ServiceLevel** | [**ServiceLevel**](ServiceLevel) | The targeted service level for the media type | [optional] |
| **AutoAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for an auto-answer interaction | [optional] |
| **ManualAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for a manual-answer interaction | [optional] |
| **AllOutboundEmailAddresses** | [**List&lt;QueueEmailAddress&gt;**](QueueEmailAddress) | The list of email addresses that are assigned to the queue and can be used by agents as an outbound email address. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
