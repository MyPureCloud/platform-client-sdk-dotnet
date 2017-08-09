---
title: CreateEmailRequest
---
## ININ.PureCloudApi.Model.CreateEmailRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The ID of the queue to use for routing the chat conversation. This field is mutually exclusive with flowId | [optional] |
| **FlowId** | **string** | The ID of the flow to use for routing chat conversation. This field is mutually exclusive with queueId | [optional] |
| **Provider** | **string** | The name of the provider that is sourcing the web chat. | |
| **SkillIds** | **List&lt;string&gt;** | The list of skill ID&#39;s to use for routing. | [optional] |
| **LanguageId** | **string** | The ID of the language to use for routing. | [optional] |
| **Priority** | **long?** | The priority to assign to the conversation for routing. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | The list of attributes to associate with the customer participant. | [optional] |
| **ToAddress** | **string** | The email address of the recipient of the email. | [optional] |
| **ToName** | **string** | The name of the recipient of the email. | [optional] |
| **FromAddress** | **string** | The email address of the sender of the email. | [optional] |
| **FromName** | **string** | The name of the sender of the email. | [optional] |
| **Subject** | **string** | The subject of the email | [optional] |
| **Direction** | **string** | Specify INBOUND to create an inbound email conversation to route to a queue, or OUTBOUND to send an email on behalf of a queue. | [optional] |
{: class="table table-striped"}


