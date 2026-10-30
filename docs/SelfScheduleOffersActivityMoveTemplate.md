# SelfScheduleOffersActivityMoveTemplate

## ININ.PureCloudApi.Model.SelfScheduleOffersActivityMoveTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schedule** | [**BuScheduleReference**](BuScheduleReference) | The schedule associated with the shift the agent wants to edit. | |
| **ShiftId** | **string** | The ID of the shift to which the self-schedule activity move is associated | |
| **ReferenceKey** | **string** | The unique identifier for the offered shift edit that was used for this shift edit | |
| **StartDate** | **DateTime?** | The start date/time for the shift in ISO-8601 format | |
| **LengthMinutes** | **int?** | The duration of this shift in minutes | |
| **ActivityCode** | [**ActivityCodeReference**](ActivityCodeReference) | The activity related to this shift | |
| **AlternateStartDates** | **List&lt;DateTime?&gt;** | The alternative start dates for this shift | |



_PureCloudPlatform.Client.V2 276.0.0_
