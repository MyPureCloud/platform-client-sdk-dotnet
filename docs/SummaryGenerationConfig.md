# SummaryGenerationConfig

## ININ.PureCloudApi.Model.SummaryGenerationConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Copilot generated summary is enabled. | |
| **SummarySetting** | [**SummarySettingEntity**](SummarySettingEntity) | Configured summary setting object. | [optional] |
| **RetentionSeconds** | **int?** | Summary retention time in seconds. Can only be modified on the parent assistant. | [optional] |
| **OnDemandSummaryConfig** | [**OnDemandSummaryConfig**](OnDemandSummaryConfig) | On-demand summary configuration. | [optional] |
| **ModelConfig** | [**ModelConfig**](ModelConfig) | Model configuration for summarization. | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
