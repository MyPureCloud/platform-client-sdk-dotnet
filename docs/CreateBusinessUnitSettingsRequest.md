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
| **Learning** | [**BuActivitySettingsRequest**](BuActivitySettingsRequest) | Learning settings | [optional] |
| **Coaching** | [**BuActivitySettingsRequest**](BuActivitySettingsRequest) | Coaching settings | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
