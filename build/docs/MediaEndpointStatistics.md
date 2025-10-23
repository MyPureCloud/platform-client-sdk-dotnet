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
| **ReconnectAttempts** | **int?** | Media reconnect attempt count | [optional] |
| **SourceType** | **string** | Source type of media endpoint | [optional] |
| **ClientInfo** | [**MediaStatisticsClientInfo**](MediaStatisticsClientInfo) | Client information associated with media endpoint | [optional] |
| **DateCreated** | **DateTime?** | Media endpoint statistics creation time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateProcessed** | **DateTime?** | Media endpoint statistics processed time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
