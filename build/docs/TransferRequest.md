---
title: TransferRequest
---
## ININ.PureCloudApi.Model.TransferRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The user ID of the transfer target. | [optional] |
| **Address** | **string** | The user ID or queue ID of the transfer target. Address like a phone number can not be used for callbacks, but they can be used for other forms of communication. | [optional] |
| **UserName** | **string** | The user name of the transfer target. | [optional] |
| **QueueId** | **string** | The queue ID of the transfer target. | [optional] |
| **Voicemail** | **bool?** | If true, transfer to the voicemail inbox of the participant that is being replaced. | [optional] |
| **TransferType** | **string** | The type of transfer to perform. | [optional] |
{: class="table table-striped"}


