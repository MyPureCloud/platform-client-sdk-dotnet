---
title: MatchShiftTradeResponse
---
## ININ.PureCloudApi.Model.MatchShiftTradeResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Trade** | [**ShiftTradeResponse**](ShiftTradeResponse.html) | The associated shift trade | [optional] |
| **Violations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation.html) | Constraint violations which disallow this shift trade | [optional] |
| **AdminReviewViolations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation.html) | Constraint violations for this shift trade which require shift trade administrator review | [optional] |
{: class="table table-striped"}


