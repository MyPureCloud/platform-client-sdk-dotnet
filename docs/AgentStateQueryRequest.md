# AgentStateQueryRequest

## ININ.PureCloudApi.Model.AgentStateQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserFilter** | [**AgentStateUserFilter**](AgentStateUserFilter) | Filters that target user-level data | [optional] |
| **SessionFilter** | [**AgentStateSessionFilter**](AgentStateSessionFilter) | Filters that target session-level data | [optional] |
| **UserOrderBy** | **string** | Search user order dimension names; default to userName | [optional] |
| **UserOrder** | **string** | Search user order direction; default to asc | [optional] |
| **SessionOrderBy** | **string** | Search session order dimension names; default to segmentStart | [optional] |
| **SessionOrder** | **string** | Search session order direction; default to asc | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
