# WfmHistoricalShrinkageRequest

## ININ.PureCloudApi.Model.WfmHistoricalShrinkageRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time | [optional] |
| **TimeZone** | **string** | The time zone, in olson format, to use in defining days when computing shrinkage for requested granularity. If it is not set, the business unit time zone will be used. The results will be returned as UTC timestamps regardless of the time zone input. | [optional] |
| **Granularity** | **string** | Shrinkage aggregation interval granularity. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
