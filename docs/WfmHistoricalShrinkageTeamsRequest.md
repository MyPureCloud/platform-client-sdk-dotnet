# WfmHistoricalShrinkageTeamsRequest

## ININ.PureCloudApi.Model.WfmHistoricalShrinkageTeamsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time | [optional] |
| **TimeZone** | **string** | The time zone, in olson format, to use in defining days when computing shrinkage for requested granularity. The results will be returned as UTC timestamps regardless of the time zone input. | |
| **Granularity** | **string** | Shrinkage aggregation interval granularity | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
