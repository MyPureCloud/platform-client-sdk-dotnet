# LogCaptureDownloadExecutionResponse

## ININ.PureCloudApi.Model.LogCaptureDownloadExecutionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of file download job. | |
| **State** | **string** | Execution state of the download. | |
| **DateStart** | **DateTime?** | Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **FileUrl** | **string** | Url of a file with query result. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef) | Details of the user that created the job | |



_PureCloudPlatform.Client.V2 235.0.0_
