# TransferRequest

## ININ.PureCloudApi.Model.TransferRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **KeepInternalMessageAlive** | **bool?** | If true, the digital internal message will NOT be terminated. | [optional] |
| **UserId** | **string** | The user ID of the transfer target. | [optional] |
| **Address** | **string** | The user ID or queue ID of the transfer target. Address like a phone number can not be used for callbacks, but they can be used for other forms of communication. | [optional] |
| **UserName** | **string** | The user name of the transfer target. | [optional] |
| **QueueId** | **string** | The queue ID of the transfer target. | [optional] |
| **Voicemail** | **bool?** | If true, transfer to the voicemail inbox of the participant that is being replaced. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
