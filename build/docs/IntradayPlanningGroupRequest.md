# IntradayPlanningGroupRequest

## ININ.PureCloudApi.Model.IntradayPlanningGroupRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BusinessUnitDate** | **String** | Requested date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Categories** | **List&lt;string&gt;** | The metric categories | |
| **PlanningGroupIds** | **List&lt;string&gt;** | The IDs of the planning groups for which to fetch data.  Omitting or passing an empty list will return all available planning groups | [optional] |
| **IntervalLengthMinutes** | **int?** | The period/interval in minutes for which to aggregate the data. Required, defaults to 15 | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
