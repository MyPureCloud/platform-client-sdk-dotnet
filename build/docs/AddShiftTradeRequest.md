---
title: AddShiftTradeRequest
---
## ININ.PureCloudApi.Model.AddShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ScheduleId** | **string** | The ID of the schedule to which the initiating and receiving shifts belong | |
| **InitiatingShiftId** | **string** | The ID of the shift that the initiating user wants to give up | |
| **ReceivingUserId** | **string** | The ID of the user to whom to send the request (for use in direct trade requests) | [optional] |
| **Expiration** | **DateTime?** | When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **AcceptableIntervals** | [**List&lt;ShiftTradeResponseAcceptableIntervals&gt;**](ShiftTradeResponseAcceptableIntervals.html) |  | [optional] |
{: class="table table-striped"}


