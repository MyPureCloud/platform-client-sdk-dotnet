# AlternativeShiftOffersViewResponseTemplate

## ININ.PureCloudApi.Model.AlternativeShiftOffersViewResponseTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **JobId** | **string** | The unique identifier of the async list job that created this file | |
| **BusinessUnitId** | **string** | The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created | |
| **AgentId** | **string** | The unique identifier of the agent for whom the offer was made | |
| **ManagementUnitId** | **string** | The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created | |
| **Schedule** | [**AlternativeShiftScheduleLookup**](AlternativeShiftScheduleLookup) | The existing schedule information associated with the offer | |
| **OfferWeekDate** | **String** | The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Shifts** | [**List&lt;AlternativeShiftAgentScheduledShift&gt;**](AlternativeShiftAgentScheduledShift) | The shifts the agent is scheduled for at the time the offer is created | |
| **AlternativeDays** | [**List&lt;AlternativeShiftAgentScheduledShift&gt;**](AlternativeShiftAgentScheduledShift) | The offered alternative shift days in this week at the time the offer is created | |



_PureCloudPlatform.Client.V2 240.0.0_
