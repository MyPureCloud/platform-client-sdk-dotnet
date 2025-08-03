# MediaStatisticsPostRequest

## ININ.PureCloudApi.Model.MediaStatisticsPostRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SourceType** | **string** | Source type of media endpoint | |
| **ClientInfo** | [**MediaStatisticsClientInfo**](MediaStatisticsClientInfo) | Client information associated with media endpoint | [optional] |
| **Rtp** | [**MediaRtpStatistics**](MediaRtpStatistics) | Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550 | |
| **ReconnectAttempts** | **int?** | Media reconnect attempt count | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
