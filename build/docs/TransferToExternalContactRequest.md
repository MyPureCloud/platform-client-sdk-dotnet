# TransferToExternalContactRequest

## ININ.PureCloudApi.Model.TransferToExternalContactRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **KeepInternalMessageAlive** | **bool?** | If true, the digital internal message will NOT be terminated. | [optional] |
| **ContactId** | **string** | The external contact id. | |
| **PhoneType** | **string** | The external contact phone type. | |



_PureCloudPlatform.Client.V2 241.0.0_
