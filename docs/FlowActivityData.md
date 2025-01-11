# FlowActivityData

## ININ.PureCloudApi.Model.FlowActivityData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Group** | **Dictionary&lt;string, string&gt;** | A mapping from grouping dimension to value | [optional] |
| **Data** | [**List&lt;FlowActivityMetricValue&gt;**](FlowActivityMetricValue) | Data for metrics | [optional] |
| **Truncated** | **bool?** | Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities. | [optional] |
| **Entities** | [**List&lt;FlowActivityEntityData&gt;**](FlowActivityEntityData) | Details for active entities | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
