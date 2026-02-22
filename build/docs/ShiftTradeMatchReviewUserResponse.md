# ShiftTradeMatchReviewUserResponse

## ININ.PureCloudApi.Model.ShiftTradeMatchReviewUserResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeeklyMinimumPaidMinutes** | **int?** | The minimum weekly paid minutes for this user per the work plan tied to the agent schedule | [optional] |
| **WeeklyMaximumPaidMinutes** | **int?** | The maximum weekly paid minutes for this user per the work plan tied to the agent schedule | [optional] |
| **PreTradeSchedulePaidMinutes** | **int?** | The paid minutes on the week schedule for this user prior to the shift trade | [optional] |
| **PostTradeSchedulePaidMinutes** | **int?** | The paid minutes on the week schedule for this user if the shift trade is approved | [optional] |
| **PostTradeNewShift** | [**ShiftTradePreviewResponse**](ShiftTradePreviewResponse) | Preview of what the shift will look like for the opposite side of this trade after the match is approved | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
