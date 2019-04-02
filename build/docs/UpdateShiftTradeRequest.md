---
title: UpdateShiftTradeRequest
---
## ININ.PureCloudApi.Model.UpdateShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReceivingUserId** | **string** | Update the ID of the receiving user to direct the request at a specific user, or set to null to open up a trade to be matched by any user | [optional] |
| **Expiration** | **DateTime?** | Update the expiration time for this shift trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **AcceptableIntervals** | [**List&lt;ShiftTradeResponseAcceptableIntervals&gt;**](ShiftTradeResponseAcceptableIntervals.html) |  | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata | |
{: class="table table-striped"}


