# TimeOffBalanceResponse

## ININ.PureCloudApi.Model.TimeOffBalanceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActivityCodeId** | **string** | The ID for activity code associated with time off balance | |
| **HrisTimeOffTypeId** | **string** | The ID of the time off type configured in HRIS integration | |
| **HrisTimeOffTypeSecondaryId** | **string** | The secondary ID of the time off type configured in HRIS integration | [optional] |
| **StartDate** | **String** | The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **BalanceMinutesPerDay** | **List&lt;int?&gt;** | The list of available time off balance values in minutes for each day | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
