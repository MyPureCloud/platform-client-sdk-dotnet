# BuQueryAdherenceExplanationsRequest

## ININ.PureCloudApi.Model.BuQueryAdherenceExplanationsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndDate** | **DateTime?** | The end date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ManagementUnitIds** | **List&lt;string&gt;** | A filter for which management units to query. Leave empty or omit entirely for all management units in the business unit | [optional] |
| **AgentIds** | **List&lt;string&gt;** | A filter for which agents within the business unit to query. Leave empty or omit entirely for all agents in the business unit (or management units if specified) | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
