# AgentQueryAdherenceAdjustmentsRequest

## ININ.PureCloudApi.Model.AgentQueryAdherenceAdjustmentsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start timestamp of the range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end timestamp of the range to query in ISO-8601 format | |
| **ReasonCodeIds** | **List&lt;string&gt;** | A filter for the reason codes to include. Leave empty or omit entirely for all reason codes | [optional] |
| **Statuses** | **List&lt;string&gt;** | A filter for which adherence adjustment statuses to include. Leave empty or omit entirely for all statuses | [optional] |



_PureCloudPlatform.Client.V2 274.0.0_
