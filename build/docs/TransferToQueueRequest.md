# TransferToQueueRequest

## ININ.PureCloudApi.Model.TransferToQueueRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **KeepInternalMessageAlive** | **bool?** | If true, the digital internal message will NOT be terminated. | [optional] |
| **QueueId** | **string** | The id of the queue. | [optional] |
| **QueueName** | **string** | The name of the queue. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
