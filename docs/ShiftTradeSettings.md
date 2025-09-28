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
| **ExternalActivityRules** | [**List&lt;ShiftTradeExternalActivityRule&gt;**](ShiftTradeExternalActivityRule) | Rules that specify what to do with external activities that are part of a shift | [optional] |
| **ExternalActivityRuleIgnoresActivityCategoryRule** | **bool?** | Whether external activity rules ignore activity category rules | [optional] |
| **MaxTradeSpanWeeks** | **int?** | The maximum number of weeks a shift trade can span | [optional] |
| **MaxTradesPerAgentPerWeek** | **int?** | The maximum number of shift trades an agent can submit per week | [optional] |
| **MinMinutesBetweenShifts** | **int?** | The minimum number of minutes between shifts | [optional] |
| **PlanningPeriodMinPaidViolations** | **string** | How to handle shift trades which result in violations of planning period minimum paid time constraint | [optional] |
| **PlanningPeriodMaxPaidViolations** | **string** | How to handle shift trades which result in violations of planning period maximum paid time constraint | [optional] |
| **MinMinutesBetweenShiftsViolations** | **string** | How to handle shift trades which result in violations of minimum number of minutes between shifts constraint | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
