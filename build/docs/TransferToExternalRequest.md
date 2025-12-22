# TransferToExternalRequest

## ININ.PureCloudApi.Model.TransferToExternalRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **KeepInternalMessageAlive** | **bool?** | If true, the digital internal message will NOT be terminated. | [optional] |
| **Address** | **string** | The address (like phone number) of the external contact. | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
