# ManagementUnitSettingsResponse

## ININ.PureCloudApi.Model.ManagementUnitSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Adherence** | [**AdherenceSettings**](AdherenceSettings) | Adherence settings for this management unit | [optional] |
| **ShortTermForecasting** | [**ShortTermForecastingSettings**](ShortTermForecastingSettings) | Short term forecasting settings for this management unit | [optional] |
| **TimeOff** | [**TimeOffRequestSettings**](TimeOffRequestSettings) | Time off request settings for this management unit | [optional] |
| **Scheduling** | [**SchedulingSettingsResponse**](SchedulingSettingsResponse) | Scheduling settings for this management unit. These settings are only available if you have the permission wfm:managementUnit:view | [optional] |
| **ShiftTrading** | [**ShiftTradeSettings**](ShiftTradeSettings) | Shift trade settings for this management unit | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version info metadata for the associated management unit | |



_PureCloudPlatform.Client.V2 227.0.0_
