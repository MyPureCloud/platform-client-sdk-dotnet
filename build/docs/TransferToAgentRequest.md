---
title: TransferToAgentRequest
---
## ININ.PureCloudApi.Model.TransferToAgentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TransferType** | **string** | The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended. | [optional] |
| **UserId** | **string** | The id of the internal user. | [optional] |
| **UserName** | **string** | The userName (like user’s email) of the internal user. | [optional] |
| **UserDisplayName** | **string** | The name of the internal user. | [optional] |
| **Voicemail** | **bool?** | If true, transfer to the voicemail inbox of the participant that is being replaced. | [optional] |
{: class="table table-striped"}


