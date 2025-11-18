# AgentWorkPlanBid

## ININ.PureCloudApi.Model.AgentWorkPlanBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the work plan bid | |
| **Name** | **string** |  | [optional] |
| **BidWindowStartDate** | **String** | The date when agents can start participating in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **BidWindowEndDate** | **String** | The inclusive end date of a bid window. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EffectiveDate** | **String** | The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Status** | **string** | The state of the bid | |
| **WorkPlanFieldsVisibleToAgents** | **List&lt;string&gt;** | The work plan fields visible to agents whenever work plan preferences are made | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
