# WfmHistoricalAdherenceQueryForUsers

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceQueryForUsers

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time | [optional] |
| **TimeZone** | **string** | The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input. | |
| **UserIds** | **List&lt;string&gt;** | The userIds to report on | |
| **IncludeExceptions** | **bool?** | Whether user exceptions should be returned as part of the results | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
