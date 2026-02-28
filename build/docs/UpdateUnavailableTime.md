# UpdateUnavailableTime

## ININ.PureCloudApi.Model.UpdateUnavailableTime

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the unavailable time span. Should be specified to update or delete an existing unavailable time span or set to null when creating a new one | [optional] |
| **TimeSpan** | [**UnavailableTimesTimeSpan**](UnavailableTimesTimeSpan) | Exact date, time and length of the unavailability time in granularity of minutes. Must be specified when creating a new unavailable time span | [optional] |
| **Notes** | **string** | Comments explaining the unavailability time span | [optional] |
| **Delete** | **bool?** | Whether the unavailable time should be deleted | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
