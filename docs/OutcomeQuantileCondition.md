# OutcomeQuantileCondition

## ININ.PureCloudApi.Model.OutcomeQuantileCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutcomeId** | **string** | The outcome ID. | |
| **MaxQuantileThreshold** | **float?** | This Outcome Quantile Condition is met when sessionMaxQuantile of the OutcomeScore is above this value, (unless fallbackQuantile is set). Range 0.00-1.00 | |
| **FallbackQuantileThreshold** | **float?** | (Optional) If set, this Condition is met when maxQuantileThreshold is met, AND the current quantile of the OutcomeScore is below this fallbackQuantileThreshold. Range 0.00-1.00 | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
