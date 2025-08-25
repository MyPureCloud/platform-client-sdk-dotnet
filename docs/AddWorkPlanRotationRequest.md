# AddWorkPlanRotationRequest

## ININ.PureCloudApi.Model.AddWorkPlanRotationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of this work plan rotation | |
| **DateRange** | [**DateRangeWithOptionalEnd**](DateRangeWithOptionalEnd) | The date range to which this work plan rotation applies | |
| **Agents** | [**List&lt;AddWorkPlanRotationAgentRequest&gt;**](AddWorkPlanRotationAgentRequest) | Agents in this work plan rotation | [optional] |
| **Pattern** | [**WorkPlanPatternRequest**](WorkPlanPatternRequest) | Pattern with list of work plan IDs that rotate on a weekly basis | |



_PureCloudPlatform.Client.V2 240.0.0_
