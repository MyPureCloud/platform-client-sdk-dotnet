# TimeOffRequestQueryBody

## ININ.PureCloudApi.Model.TimeOffRequestQueryBody

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Ids** | **List&lt;string&gt;** | The set of ids to filter time off requests | [optional] |
| **UserIds** | **List&lt;string&gt;** | The set of user ids to filter time off requests. Omit to query all users in the management unit. Note: If teamIds is also specified, only time off requests for users in the requested teams will be returned | [optional] |
| **Statuses** | **List&lt;string&gt;** | The set of statuses to filter time off requests | [optional] |
| **Substatuses** | **List&lt;string&gt;** | The set of substatuses to filter time off requests | [optional] |
| **DateRange** | [**DateRange**](DateRange) | The inclusive range of dates to filter time off requests | [optional] |
| **TeamIds** | **List&lt;string&gt;** | The IDs of work teams to query. If null or not set, results will be queried for requested users if applicable or otherwise all users in the management unit | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
