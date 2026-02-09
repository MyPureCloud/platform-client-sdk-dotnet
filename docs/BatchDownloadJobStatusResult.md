# BatchDownloadJobStatusResult

## ININ.PureCloudApi.Model.BatchDownloadJobStatusResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **JobId** | **string** | JobId returned when job was initially submitted. | [optional] |
| **ExpectedResultCount** | **int?** | Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed. | [optional] |
| **ResultCount** | **int?** | Current number of results available, this includes both success and error results. | [optional] |
| **ErrorCount** | **int?** | Current number of error results. | [optional] |
| **Status** | **string** | Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled. | [optional] |
| **Results** | [**List&lt;BatchDownloadJobResult&gt;**](BatchDownloadJobResult) | Current set of results for the job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
