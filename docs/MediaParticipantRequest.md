# MediaParticipantRequest

## ININ.PureCloudApi.Model.MediaParticipantRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Wrapup** | [**WrapupInput**](WrapupInput) | Wrap-up to assign to this participant. | [optional] |
| **State** | **string** | The state to update to set for this participant&#39;s communications.  Possible values are: &#39;connected&#39; and &#39;disconnected&#39;. | [optional] |
| **Recording** | **bool?** | True to enable ad-hoc recording of this participant, otherwise false to disable recording. | [optional] |
| **Muted** | **bool?** | True to mute this conversation participant. | [optional] |
| **Confined** | **bool?** | True to confine this conversation participant.  Should only be used for ad-hoc conferences | [optional] |
| **Held** | **bool?** | True to hold this conversation participant. | [optional] |
| **WrapupSkipped** | **bool?** | True to skip wrap-up for this participant. | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
