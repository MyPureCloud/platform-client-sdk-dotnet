# BusinessUnitSettingsResponse

## ININ.PureCloudApi.Model.BusinessUnitSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDayOfWeek** | **string** | The start day of week for this business unit | |
| **TimeZone** | **string** | The time zone for this business unit, using the Olsen tz database format | |
| **ShortTermForecasting** | [**BuShortTermForecastingSettings**](BuShortTermForecastingSettings) | Short term forecasting settings | [optional] |
| **Scheduling** | [**BuSchedulingSettingsResponse**](BuSchedulingSettingsResponse) | Scheduling settings | [optional] |
| **Notifications** | [**BuNotificationSettingsResponse**](BuNotificationSettingsResponse) | Notification settings | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this business unit | |



_PureCloudPlatform.Client.V2 232.0.0_
