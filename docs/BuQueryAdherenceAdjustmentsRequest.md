# BuQueryAdherenceAdjustmentsRequest

## ININ.PureCloudApi.Model.BuQueryAdherenceAdjustmentsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start timestamp of the range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end timestamp of the range to query in ISO-8601 format | |
| **ReasonCodeIds** | **List&lt;string&gt;** | A filter for the reason codes to include. Leave empty or omit entirely for all reason codes | [optional] |
| **Statuses** | **List&lt;string&gt;** | A filter for which adherence adjustment statuses to include. Leave empty or omit entirely for all statuses | [optional] |
| **UserIds** | **List&lt;string&gt;** | A filter for which users within the business unit to query. Leave empty or omit entirely for all users | [optional] |
| **ManagementUnitIds** | **List&lt;string&gt;** | A filter for which management units to query. Leave empty or omit entirely for all management units in the business unit | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
