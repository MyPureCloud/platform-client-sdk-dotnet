# DataTableExportJob

## ININ.PureCloudApi.Model.DataTableExportJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Owner** | [**AddressableEntityRef**](AddressableEntityRef) | The PureCloud user who started the export job | [optional] |
| **Status** | **string** | The status of the export job | |
| **DateCreated** | **DateTime?** | The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DownloadURI** | **string** | The URL of the location at which the caller can download the export file, when available | [optional] |
| **ErrorInformation** | [**ErrorBody**](ErrorBody) | Any error information, or null of the processing is not in an error state | [optional] |
| **CountRecordsProcessed** | **int?** | The current count of the number of records processed | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
