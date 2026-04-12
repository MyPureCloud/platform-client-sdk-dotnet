# AddShiftTradeJobRequest

## ININ.PureCloudApi.Model.AddShiftTradeJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **InitiatingShift** | [**InitiatingShiftRequestItem**](InitiatingShiftRequestItem) | The shift that the initiating user wants to give up in this trade | |
| **AcceptableIntervals** | [**List&lt;RequiredDateRange&gt;**](RequiredDateRange) | Time frames when the initiating user is willing to accept a shift in exchange. Empty means giving up the shift without taking on another one | [optional] |
| **Target** | [**ShiftTradeTargetRequestItem**](ShiftTradeTargetRequestItem) | Optional shift trade target, can be used for example for direct user to user trade | [optional] |
| **ExpirationDate** | **DateTime?** | When this shift trade will expire. Date time is represented as an ISO-8601 string | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
