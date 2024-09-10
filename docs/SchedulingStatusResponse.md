# SchedulingStatusResponse

## ININ.PureCloudApi.Model.SchedulingStatusResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID generated for the scheduling job.  Use to GET result when job is completed. | [optional] |
| **Status** | **string** | The status of the scheduling job. | [optional] |
| **ErrorDetails** | [**List&lt;SchedulingProcessingError&gt;**](SchedulingProcessingError) | If the request could not be properly processed, error details will be given here. | [optional] |
| **SchedulingResultUri** | **string** | The uri of the scheduling result. It has a value if the status is &#39;Success&#39;. | [optional] |
| **PercentComplete** | **int?** | The percentage of the job that is complete. | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
