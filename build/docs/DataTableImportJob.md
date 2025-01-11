# DataTableImportJob

## ININ.PureCloudApi.Model.DataTableImportJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Owner** | [**AddressableEntityRef**](AddressableEntityRef) | The PureCloud user who started the import job | [optional] |
| **Status** | **string** | The status of the import job | |
| **DateCreated** | **DateTime?** | The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **UploadURI** | **string** | The URL of the location at which the caller can upload the file to be imported | [optional] |
| **ImportMode** | **string** | The indication of whether the processing should remove rows that don&#39;t appear in the import file | [optional] |
| **ErrorInformation** | [**ErrorBody**](ErrorBody) | Any error information, or null of the processing is not in an error state | [optional] |
| **CountRecordsUpdated** | **int?** | The current count of the number of records processed | [optional] |
| **CountRecordsDeleted** | **int?** | The current count of the number of records deleted | [optional] |
| **CountRecordsFailed** | **int?** | The current count of the number of records that failed to import | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
