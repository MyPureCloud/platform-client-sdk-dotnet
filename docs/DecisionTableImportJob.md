# DecisionTableImportJob

## ININ.PureCloudApi.Model.DecisionTableImportJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TableVersion** | **int?** | The table version to be replaced by this import | [optional] |
| **Status** | **string** | Current status of the import job | |
| **UploadUrl** | **string** | Pre-signed URL to upload the import file (PUT) | [optional] |
| **UploadHeaders** | **Dictionary&lt;string, string&gt;** | Headers required when uploading file with data to be imported to uploadUrl | [optional] |
| **ImportMode** | **string** | Whether rows are appended to existing rows or rows are replaced | |
| **FileName** | **string** | Original file name supplied when the job was created, including the file extension | [optional] |
| **CreatedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user who created the job | [optional] |
| **DateCreated** | **DateTime?** | When the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | When the job was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | When processing finished, successfully or not. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpires** | **DateTime?** | When upload credentials expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RowMetrics** | [**DecisionTableImportRowMetrics**](DecisionTableImportRowMetrics) | Row-level metrics populated incrementally during import processing | [optional] |
| **Error** | [**DecisionTableImportJobError**](DecisionTableImportJobError) | Present when the import job could not be successfully finished | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
