# MetricDefinition

## ININ.PureCloudApi.Model.MetricDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UnitType** | **string** | The type of associated metric unit | [optional] |
| **ShortName** | **string** | An alternate name for this metric definition, often abbreviation | [optional] |
| **DividendMetrics** | **List&lt;string&gt;** | Metric names used as dividend | [optional] |
| **DivisorMetrics** | **List&lt;string&gt;** | Metric names used as divisor | [optional] |
| **DefaultObjective** | [**DefaultObjective**](DefaultObjective) | A predefined default objective for this metric | [optional] |
| **LockTemplateId** | **string** | An optional field to specify if this metric definition is locked to certain template. e.g. punctuality | [optional] |
| **MediaTypeFilteringAllowed** | **bool?** | Flag to indicate if this metricDefinition allows filter based on media types | [optional] |
| **InitialDirectionFilteringAllowed** | **bool?** | Flag to indicate if this metricDefinition allows filter based on initial direction | [optional] |
| **QueueFilteringAllowed** | **bool?** | Flag to indicate if this metricDefinition allows filter based on queues | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
