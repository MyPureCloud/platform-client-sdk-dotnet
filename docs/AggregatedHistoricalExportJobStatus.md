# AggregatedHistoricalExportJobStatus

## ININ.PureCloudApi.Model.AggregatedHistoricalExportJobStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Status** | **string** | The status of the export job | |
| **DownloadUrl** | **string** | The download URL for the completed export. Populated when status is Complete | [optional] |
| **Error** | [**CsvExportErrorDetails**](CsvExportErrorDetails) | Error details if the export failed. Populated when status is Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
