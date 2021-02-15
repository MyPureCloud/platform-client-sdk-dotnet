---
title: SendAgentlessOutboundMessageRequest
---
## ININ.PureCloudApi.Model.SendAgentlessOutboundMessageRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FromAddress** | **string** | The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned sms phone number. | |
| **ToAddress** | **string** | The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. | |
| **ToAddressMessengerType** | **string** | The recipient messaging address messenger type. Currently SMS is the only supported type. | |
| **TextBody** | **string** | The text of the message to send | |
{: class="table table-striped"}


