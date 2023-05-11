---
title: TransferResponse
---
## ININ.PureCloudApi.Model.TransferResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the command. | [optional] |
| **State** | **string** | The state of the command. | [optional] |
| **DateIssued** | **DateTime?** | The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Initiator** | [**TransferInitiator**](TransferInitiator.html) | The initiator of the command. | [optional] |
| **ModifiedBy** | [**TransferResponseModifiedBy**](TransferResponseModifiedBy.html) | The user or entity that modified the command. | [optional] |
| **Destination** | [**TransferDestination**](TransferDestination.html) | The destination of the command. | [optional] |
| **TransferType** | **string** | The type of transfer to perform. | [optional] |
{: class="table table-striped"}


