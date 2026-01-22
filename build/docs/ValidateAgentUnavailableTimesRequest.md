# ValidateAgentUnavailableTimesRequest

## ININ.PureCloudApi.Model.ValidateAgentUnavailableTimesRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ValidationWeekDate** | **String** | The ID of the week to validate. Must correspond to the start day of week of the business unit to which the agent belongs in the format YYYY-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **UnavailableTimes** | [**List&lt;UpdateUnavailableTime&gt;**](UpdateUnavailableTime) | Proposed changes to agent&#39;s unavailable time spans to be validated | |



_PureCloudPlatform.Client.V2 255.0.0_
