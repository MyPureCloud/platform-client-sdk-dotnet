# TransferResponse

## ININ.PureCloudApi.Model.TransferResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the command. | [optional] |
| **State** | **string** | The state of the command. | [optional] |
| **DateIssued** | **DateTime?** | The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Initiator** | [**TransferInitiator**](TransferInitiator) | The initiator of the command. | [optional] |
| **ModifiedBy** | [**TransferResponseModifiedBy**](TransferResponseModifiedBy) | The user or entity that modified the command. | [optional] |
| **Destination** | [**TransferDestination**](TransferDestination) | The destination of the command. | [optional] |
| **TransferType** | **string** | The type of transfer to perform. | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
