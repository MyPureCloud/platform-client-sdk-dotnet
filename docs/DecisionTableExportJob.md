# DecisionTableExportJob

## ININ.PureCloudApi.Model.DecisionTableExportJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TableVersion** | **int?** | The version of the decision table that was exported. | [optional] |
| **Status** | **string** | Current status of the export job. | [optional] |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user who created the export job. | [optional] |
| **DateCreated** | **DateTime?** | Date when this export job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when this export job was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FileName** | **string** | Name of the exported file. | [optional] |
| **Download** | [**AddressableEntityRef**](AddressableEntityRef) | Reference to the download resource for obtaining the exported file. | [optional] |
| **DateDownloadExpires** | **DateTime?** | Date when the download link expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportType** | **string** | The type of export that was performed. | [optional] |
| **TotalRows** | **int?** | Total number of rows to export (set when row loading begins). | [optional] |
| **RowsExported** | **int?** | The number of rows exported. | [optional] |
| **Format** | **string** | The format of the exported file. | [optional] |
| **Error** | [**DecisionTableExportJobError**](DecisionTableExportJobError) | Error details if the export job failed. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
