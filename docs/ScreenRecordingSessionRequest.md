# ScreenRecordingSessionRequest

## ININ.PureCloudApi.Model.ScreenRecordingSessionRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The screen recording session&#39;s state.  Values can be: &#39;stopped&#39; | [optional] |
| **ArchiveDate** | **DateTime?** | The screen recording session&#39;s archive date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DeleteDate** | **DateTime?** | The screen recording session&#39;s delete date. Must be greater than archiveDate if set, otherwise one day from now. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
