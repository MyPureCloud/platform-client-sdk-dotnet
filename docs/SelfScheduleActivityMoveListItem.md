# SelfScheduleActivityMoveListItem

## ININ.PureCloudApi.Model.SelfScheduleActivityMoveListItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Schedule** | [**BuScheduleReference**](BuScheduleReference) | The schedule to which the shift and activity are associated | |
| **ShiftId** | **string** | The ID of the shift to which this activity is associated | |
| **State** | **string** | The state of the self-schedule operation | |
| **WorkflowStatus** | **string** | The processing status of this self-schedule operation | [optional] |
| **StartDate** | **DateTime?** | The original start date of this activity in ISO-8601 format | |
| **NewDate** | **DateTime?** | The new start date of this activity in ISO-8601 format | |
| **LengthMinutes** | **int?** | The length of this activity in minutes | |
| **ActivityCode** | [**ActivityCodeReference**](ActivityCodeReference) | The activity code related to this shift | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
