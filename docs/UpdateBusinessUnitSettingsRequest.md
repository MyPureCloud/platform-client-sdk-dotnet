# UpdateBusinessUnitSettingsRequest

## ININ.PureCloudApi.Model.UpdateBusinessUnitSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDayOfWeek** | **string** | The start day of week for this business unit | [optional] |
| **TimeZone** | **string** | The time zone for this business unit, using the Olsen tz database format | [optional] |
| **ShortTermForecasting** | [**BuShortTermForecastingSettings**](BuShortTermForecastingSettings) | Short term forecasting settings | [optional] |
| **Scheduling** | [**BuSchedulingSettingsRequest**](BuSchedulingSettingsRequest) | Scheduling settings | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this business unit | |



_PureCloudPlatform.Client.V2 214.0.0_
