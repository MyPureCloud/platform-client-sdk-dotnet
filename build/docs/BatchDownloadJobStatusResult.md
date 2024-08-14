---
title: BatchDownloadJobStatusResult
---
## ININ.PureCloudApi.Model.BatchDownloadJobStatusResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **JobId** | **string** | JobId returned when job was initially submitted. | [optional] |
| **ExpectedResultCount** | **int?** | Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed. | [optional] |
| **ResultCount** | **int?** | Current number of results available, this includes both success and error results. | [optional] |
| **ErrorCount** | **int?** | Current number of error results. | [optional] |
| **Results** | [**List&lt;BatchDownloadJobResult&gt;**](BatchDownloadJobResult.html) | Current set of results for the job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


