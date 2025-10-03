# UpdateWorkPlanRotationAgentRequest

## ININ.PureCloudApi.Model.UpdateWorkPlanRotationAgentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of an agent in this work plan rotation | |
| **DateRange** | [**DateRangeWithOptionalEnd**](DateRangeWithOptionalEnd) | The date range to which this agent is effective in the work plan rotation | [optional] |
| **Position** | **int?** | Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0 | [optional] |
| **Delete** | **bool?** | If marked true for this agent when updating, then this agent will be removed from this work plan rotation | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
