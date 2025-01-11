# WorkdayValuesMetricItem

## ININ.PureCloudApi.Model.WorkdayValuesMetricItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef) | Gamification metric for the average and the trend | [optional] |
| **MetricDefinition** | [**DomainEntityRef**](DomainEntityRef) | Gamification metric definition for the average and the trend | [optional] |
| **Average** | **double?** | The average value of the metric | [optional] |
| **UnitType** | **string** | The unit type of the metric value | [optional] |
| **Trend** | [**List&lt;WorkdayValuesTrendItem&gt;**](WorkdayValuesTrendItem) | The metric value trend | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
