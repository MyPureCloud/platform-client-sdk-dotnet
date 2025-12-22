# BuCreateBlankScheduleRequest

## ININ.PureCloudApi.Model.BuCreateBlankScheduleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | The description for the schedule | |
| **ShortTermForecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count | [optional] |
| **WeekCount** | **int?** | The number of weeks in the schedule. One extra day is added at the end | |



_PureCloudPlatform.Client.V2 252.1.0_
