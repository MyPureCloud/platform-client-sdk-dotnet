# KpiResult

## ININ.PureCloudApi.Model.KpiResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **KpiTotalOn** | **long?** | Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on) | [optional] |
| **KpiTotalOff** | **long?** | Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off) | [optional] |
| **InteractionCountOn** | **long?** | Total interactions handled by predictive routing (GPR was on) | [optional] |
| **InteractionCountOff** | **long?** | Total interactions not routed by predictive routing (GPR was off) | [optional] |
| **MediaType** | **string** | Media type used for the KPI | [optional] |
| **PercentageBenefit** | **double?** | The percentage benefit for this media type for the duration of the comparison period | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
