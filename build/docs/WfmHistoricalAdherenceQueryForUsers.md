---
title: WfmHistoricalAdherenceQueryForUsers
---
## ININ.PureCloudApi.Model.WfmHistoricalAdherenceQueryForUsers

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time | [optional] |
| **TimeZone** | **string** | The time zone to use for returned results in olson format. If it is not set, the business unit time zone will be used to compute adherence | [optional] |
| **UserIds** | **List&lt;string&gt;** | The userIds to report on | |
| **IncludeExceptions** | **bool?** | Whether user exceptions should be returned as part of the results | [optional] |
{: class="table table-striped"}


