# SelfScheduleJob

## ININ.PureCloudApi.Model.SelfScheduleJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Status** | **string** | The status of the job | |
| **ActivityMoves** | [**List&lt;SelfScheduleActivityMoveListItem&gt;**](SelfScheduleActivityMoveListItem) | The self-schedule activity moves, if status &#x3D;&#x3D; &#39;Complete&#39; | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
