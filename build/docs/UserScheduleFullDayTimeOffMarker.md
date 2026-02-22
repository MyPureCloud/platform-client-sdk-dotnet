# UserScheduleFullDayTimeOffMarker

## ININ.PureCloudApi.Model.UserScheduleFullDayTimeOffMarker

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitDate** | **string** | The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format. | [optional] |
| **ActivityCodeId** | **string** | The id for the activity code.  Look up a map of activity codes with the activities route | [optional] |
| **IsPaid** | **bool?** | Whether this is paid time off | [optional] |
| **LengthInMinutes** | **int?** | The length in minutes of this time off marker | [optional] |
| **Description** | **string** | The description associated with the time off request that this marker corresponds to | [optional] |
| **Delete** | **bool?** | If marked true for updating an existing full day time off marker, it will be deleted | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
