# MediaEndpointStatistics

## ININ.PureCloudApi.Model.MediaEndpointStatistics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Trunk** | [**MediaStatisticsTrunkInfo**](MediaStatisticsTrunkInfo) | Trunk information utilized when creating the media endpoint | [optional] |
| **Station** | [**NamedEntity**](NamedEntity) | Station information associated with media endpoint | [optional] |
| **User** | [**NamedEntity**](NamedEntity) | User information associated media endpoint | [optional] |
| **Ice** | [**MediaIceStatistics**](MediaIceStatistics) | The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245 | [optional] |
| **Rtp** | [**MediaRtpStatistics**](MediaRtpStatistics) | Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550 | [optional] |
| **ReconnectAttemptCount** | **int?** | Media reconnect attempt count | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
