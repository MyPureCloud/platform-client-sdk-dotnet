---
title: ManagementUnitSettingsResponse
---
## ININ.PureCloudApi.Model.ManagementUnitSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Adherence** | [**AdherenceSettings**](AdherenceSettings.html) | Adherence settings for this management unit | [optional] |
| **ShortTermForecasting** | [**ShortTermForecastingSettings**](ShortTermForecastingSettings.html) | Short term forecasting settings for this management unit | [optional] |
| **TimeOff** | [**TimeOffRequestSettings**](TimeOffRequestSettings.html) | Time off request settings for this management unit | [optional] |
| **Scheduling** | [**SchedulingSettingsResponse**](SchedulingSettingsResponse.html) | Scheduling settings for this management unit. These settings are only available if you have the permission wfm:managementUnit:view | [optional] |
| **ShiftTrading** | [**ShiftTradeSettings**](ShiftTradeSettings.html) | Shift trade settings for this management unit | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version info metadata for the associated management unit | |
{: class="table table-striped"}


