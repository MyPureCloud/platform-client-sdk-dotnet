# MediaStatisticsPostRequest

## ININ.PureCloudApi.Model.MediaStatisticsPostRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SourceType** | **string** | Source type of media endpoint | |
| **ClientInfo** | [**MediaStatisticsClientInfo**](MediaStatisticsClientInfo) | Client information associated with media endpoint | [optional] |
| **Rtp** | [**MediaRtpStatistics**](MediaRtpStatistics) | Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550 | |
| **ReconnectAttempts** | **int?** | Media reconnect attempt count | [optional] |
| **DateCreated** | **DateTime?** | Media endpoint statistics creation time. Format: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 248.0.0_
