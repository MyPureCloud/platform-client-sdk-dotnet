---
title: BatchDownloadJobStatusResult
---
## ININ.PureCloudApi.Model.BatchDownloadJobStatusResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **JobId** | **string** | JobId returned when job was initially submitted | [optional] |
| **ExpectedResultCount** | **int?** | Number of results expected when job is completed | [optional] |
| **ResultCount** | **int?** | Current number of results available | [optional] |
| **ErrorCount** | **int?** | Number of error results produced so far | [optional] |
| **Results** | [**List&lt;BatchDownloadJobResult&gt;**](BatchDownloadJobResult.html) | Current set of results for the job | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


