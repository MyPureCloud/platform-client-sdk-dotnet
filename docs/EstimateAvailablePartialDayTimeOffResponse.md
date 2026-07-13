# EstimateAvailablePartialDayTimeOffResponse

## ININ.PureCloudApi.Model.EstimateAvailablePartialDayTimeOffResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Date** | **DateTime?** | Start date-time in ISO-8601 format for partial day request | |
| **DurationMinutes** | **int?** | An estimation of time off request length in minutes | |
| **PayableMinutes** | **int?** | An estimation of payable part of time off request in minutes | |
| **Flexible** | **bool?** | Whether there is flexibility for a user to choose different hours than the system estimated | |
| **OverrideDateType** | **string** | The override date type, if the partial day request overlaps with an override date | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
