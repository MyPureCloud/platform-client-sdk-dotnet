# MatchShiftTradeResponse

## ININ.PureCloudApi.Model.MatchShiftTradeResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Trade** | [**ShiftTradeResponse**](ShiftTradeResponse) | The associated shift trade | [optional] |
| **Violations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation) | Constraint violations which disallow this shift trade | [optional] |
| **AdminReviewViolations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation) | Constraint violations for this shift trade which require shift trade administrator review | [optional] |
| **UnevaluatedRules** | **List&lt;string&gt;** | Unevaluated rules for this shift trade which require shift trade administrator review | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
