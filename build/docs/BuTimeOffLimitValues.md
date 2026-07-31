# BuTimeOffLimitValues

## ININ.PureCloudApi.Model.BuTimeOffLimitValues

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **String** | Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists | |
| **ValuesPerDay** | [**TimeOffLimitValues**](TimeOffLimitValues) | Time-off limit values specified in per day granularity. Set only if granularity is &#39;Daily&#39; | [optional] |
| **ValuesPerFifteenMinutes** | [**TimeOffLimitValues**](TimeOffLimitValues) | Time-off limit values specified in per fifteen minutes granularity. Set only if granularity is &#39;FifteenMinutes&#39; | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
