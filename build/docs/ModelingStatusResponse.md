---
title: ModelingStatusResponse
---
## ININ.PureCloudApi.Model.ModelingStatusResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID generated for the modeling job.  Use to GET result when job is completed. | [optional] |
| **Status** | **string** | The status of the modeling job. | [optional] |
| **ErrorDetails** | [**List&lt;ModelingProcessingError&gt;**](ModelingProcessingError.html) | If the request could not be properly processed, error details will be given here. | [optional] |
| **ModelingResultUri** | **string** | The uri of the modeling result. It has a value if the status is either &#39;Success&#39;, &#39;PartialFailure&#39;, or &#39;Failed&#39;. | [optional] |
{: class="table table-striped"}


