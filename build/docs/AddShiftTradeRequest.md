# AddShiftTradeRequest

## ININ.PureCloudApi.Model.AddShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ScheduleId** | **string** | The ID of the schedule to which the initiating and receiving shifts belong | |
| **InitiatingShiftId** | **string** | The ID of the shift that the initiating user wants to give up | |
| **ReceivingUserId** | **string** | The ID of the user to whom to send the request (for use in direct trade requests) | [optional] |
| **Expiration** | **DateTime?** | When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AcceptableIntervals** | **List&lt;string&gt;** | The acceptable intervals the initiating user is willing to accept in trade.  Empty indicates the user is giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
