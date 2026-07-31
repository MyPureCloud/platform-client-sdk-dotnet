# DecisionMetricsUpdateJobResponse

## ININ.PureCloudApi.Model.DecisionMetricsUpdateJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UploadKey** | **string** | The S3 key for the uploaded decision metrics file | |
| **Job** | [**DecisionMetricsJobReference**](DecisionMetricsJobReference) | The update job | |
| **Status** | **string** | The status of the update job | |
| **Metadata** | [**WfmEntityMetadata**](WfmEntityMetadata) | The metadata of the update job | |
| **UpdateErrors** | [**List&lt;DecisionMetricsUpdateError&gt;**](DecisionMetricsUpdateError) | Errors occurred during update process, which will be non empty when status is &#x60;Error&#x60; | |



_PureCloudPlatform.Client.V2 269.0.0_
