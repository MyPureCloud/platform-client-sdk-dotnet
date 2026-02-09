# AgentMuScheduleItem

## ININ.PureCloudApi.Model.AgentMuScheduleItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Agent** | [**UserReference**](UserReference) | The agent to whom this schedule applies. Note: selfUri will not be populated if retrieving result via downloadUrl | |
| **Shifts** | [**List&lt;AgentMuScheduleShift&gt;**](AgentMuScheduleShift) | The shift definitions for this agent schedule | |
| **FullDayTimeOffMarkerDates** | **List&lt;String&gt;** | The full day time off marker dates which apply to this agent schedule, interpreted in the time zone of the relevant business unit | |



_PureCloudPlatform.Client.V2 256.0.0_
