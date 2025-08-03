# PatchShiftTradeRequest

## ININ.PureCloudApi.Model.PatchShiftTradeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReceivingUserId** | [**ValueWrapperString**](ValueWrapperString) | Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user. | [optional] |
| **Expiration** | [**ValueWrapperDate**](ValueWrapperDate) | Update the expiration time for this shift trade. | [optional] |
| **AcceptableIntervals** | [**ListWrapperInterval**](ListWrapperInterval) | Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata | |



_PureCloudPlatform.Client.V2 239.0.0_
