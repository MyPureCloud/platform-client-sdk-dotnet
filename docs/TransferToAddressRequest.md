# TransferToAddressRequest

## ININ.PureCloudApi.Model.TransferToAddressRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **KeepInternalMessageAlive** | **bool?** | If true, the digital internal message will NOT be terminated. | [optional] |
| **Address** | **string** | User&#39;s name, queue&#39;s name, destination&#39;s address or phone number. | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
