# ShiftTradeSettings

## ININ.PureCloudApi.Model.ShiftTradeSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether shift trading is enabled for this management unit | [optional] |
| **AutoReview** | **bool?** | Whether automatic shift trade review is enabled according to the rules defined in for this management unit | [optional] |
| **AllowDirectTrades** | **bool?** | Whether direct shift trades between agents are allowed | [optional] |
| **MinHoursInFuture** | **int?** | The minimum number of hours in the future shift trades are allowed | [optional] |
| **UnequalPaid** | **string** | How to handle shift trades which involve unequal paid times | [optional] |
| **OneSided** | **string** | How to handle one-sided shift trades | [optional] |
| **WeeklyMinPaidViolations** | **string** | How to handle shift trades which result in violations of weekly minimum paid time constraint | [optional] |
| **WeeklyMaxPaidViolations** | **string** | How to handle shift trades which result in violations of weekly maximum paid time constraint | [optional] |
| **RequiresMatchingQueues** | **bool?** | Whether to constrain shift trades to agents with matching queues | [optional] |
| **RequiresMatchingLanguages** | **bool?** | Whether to constrain shift trades to agents with matching languages | [optional] |
| **RequiresMatchingSkills** | **bool?** | Whether to constrain shift trades to agents with matching skills | [optional] |
| **RequiresMatchingPlanningGroups** | **bool?** | Whether to constrain shift trades to agents with matching planning groups | [optional] |
| **ActivityCategoryRules** | [**List&lt;ShiftTradeActivityRule&gt;**](ShiftTradeActivityRule) | Rules that specify what to do with activity categories that are part of a shift defined in a trade | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
