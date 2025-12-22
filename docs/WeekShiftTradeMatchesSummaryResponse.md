# WeekShiftTradeMatchesSummaryResponse

## ININ.PureCloudApi.Model.WeekShiftTradeMatchesSummaryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekDate** | **String** | The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Count** | **int?** | The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week | [optional] |
| **CrossWeekReceivingCount** | **int?** | The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
