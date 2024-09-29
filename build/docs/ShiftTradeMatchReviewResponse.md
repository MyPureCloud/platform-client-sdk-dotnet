# ShiftTradeMatchReviewResponse

## ININ.PureCloudApi.Model.ShiftTradeMatchReviewResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **InitiatingUser** | [**ShiftTradeMatchReviewUserResponse**](ShiftTradeMatchReviewUserResponse) | Details for the initiatingUser side of the shift trade | [optional] |
| **ReceivingUser** | [**ShiftTradeMatchReviewUserResponse**](ShiftTradeMatchReviewUserResponse) | Details for the receivingUser side of the shift trade | [optional] |
| **Violations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation) | Constraint violations introduced after being matched that would normally disallow a trade, but which can still be overridden by the shift trade administrator | [optional] |
| **AdminReviewViolations** | [**List&lt;ShiftTradeMatchViolation&gt;**](ShiftTradeMatchViolation) | Constraint violations associated with this shift trade which require shift trade administrator review | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
