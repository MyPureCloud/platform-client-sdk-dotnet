# CallbackMediaSettings

## ININ.PureCloudApi.Model.CallbackMediaSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnableAutoAnswer** | **bool?** | Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings. | [optional] |
| **AlertingTimeoutSeconds** | **int?** | The alerting timeout for the media type, in seconds | [optional] |
| **ServiceLevel** | [**ServiceLevel**](ServiceLevel) | The targeted service level for the media type | [optional] |
| **AutoAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for an auto-answer interaction | [optional] |
| **ManualAnswerAlertToneSeconds** | **double?** | How long to play the alerting tone for a manual-answer interaction | [optional] |
| **SubTypeSettings** | [**Dictionary&lt;string, BaseMediaSettings&gt;**](BaseMediaSettings) | Map of media subtype to media subtype specific settings. | [optional] |
| **EnableAutoDialAndEnd** | **bool?** | Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue. | [optional] |
| **AutoDialDelaySeconds** | **int?** | Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds. | [optional] |
| **AutoEndDelaySeconds** | **int?** | Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds. | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
