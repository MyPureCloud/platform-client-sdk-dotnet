# BuConvertTimeOffLimitGranularityJobResponse

## ININ.PureCloudApi.Model.BuConvertTimeOffLimitGranularityJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **TimeOffLimit** | [**BuTimeOffLimitReference**](BuTimeOffLimitReference) | The time-off limit associated with this job | |
| **Status** | **string** | The status of the job | |
| **Progress** | [**BuConvertTimeOffLimitGranularityJobProgress**](BuConvertTimeOffLimitGranularityJobProgress) | Progress of time-off limit granularity conversion | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Error information. Set only when status is Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
