# ActivityPlanRunJobResponse

## ININ.PureCloudApi.Model.ActivityPlanRunJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ActivityPlan** | [**ActivityPlanReference**](ActivityPlanReference) | The activity plan associated with this job | |
| **Status** | **string** | The status of the job | |
| **Exceptions** | [**List&lt;ActivityPlanJobException&gt;**](ActivityPlanJobException) | The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing | |
| **Error** | [**ErrorBody**](ErrorBody) | Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
