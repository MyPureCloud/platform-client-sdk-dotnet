# TeamActivityData

## ININ.PureCloudApi.Model.TeamActivityData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Group** | **Dictionary&lt;string, string&gt;** | A mapping from grouping dimension to value | [optional] |
| **Data** | [**List&lt;TeamActivityMetricValue&gt;**](TeamActivityMetricValue) | Data for metrics | [optional] |
| **Truncated** | **bool?** | Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities. | [optional] |
| **Entities** | [**List&lt;TeamActivityEntityData&gt;**](TeamActivityEntityData) | Details for active entities | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
