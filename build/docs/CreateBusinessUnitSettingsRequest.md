# CreateBusinessUnitSettingsRequest

## ININ.PureCloudApi.Model.CreateBusinessUnitSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDayOfWeek** | **string** | The start day of week for this business unit | |
| **TimeZone** | **string** | The time zone for this business unit, using the Olsen tz database format | |
| **ShortTermForecasting** | [**BuShortTermForecastingSettings**](BuShortTermForecastingSettings) | Short term forecasting settings | [optional] |
| **Scheduling** | [**BuSchedulingSettingsRequest**](BuSchedulingSettingsRequest) | Scheduling settings | [optional] |
| **Notifications** | [**BuNotificationSettingsRequest**](BuNotificationSettingsRequest) | Notification settings | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
