# BuConvertTimeOffLimitGranularityJobRequest

## ININ.PureCloudApi.Model.BuConvertTimeOffLimitGranularityJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Granularity** | **string** | Granularity to convert the time-off limit to | |
| **FullDayTimeOffStartTime** | **string** | The start time of full day time-off requests associated with this limit interval in HH:mm format.The value can be set only once when converting the time-off limit from daily granularity to fifteen minutes.Setting this value is allowed only for time-off limit with fifteen minutes granularity.When converting time-off limit from fifteen minutes to daily granularity, the existing value is reset. | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
