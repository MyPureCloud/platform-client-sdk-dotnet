---
title: PatchShiftTradeRequest
---
## ININ.PureCloudApi.Model.PatchShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReceivingUserId** | [**ValueWrapperString**](ValueWrapperString.html) | Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user. | [optional] |
| **Expiration** | [**ValueWrapperDate**](ValueWrapperDate.html) | Update the expiration time for this shift trade. | [optional] |
| **AcceptableIntervals** | [**ListWrapperInterval**](ListWrapperInterval.html) | Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata | |
{: class="table table-striped"}


