---
title: SendAgentlessOutboundMessageResponse
---
## ININ.PureCloudApi.Model.SendAgentlessOutboundMessageResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ConversationId** | **string** | The identifier of the conversation. | [optional] |
| **FromAddress** | **string** | The sender of the message. | [optional] |
| **ToAddress** | **string** | The recipient of the message. | [optional] |
| **MessengerType** | **string** | Type of messenger. | [optional] |
| **TextBody** | **string** | The body of the text message. | [optional] |
| **MessagingTemplate** | [**MessagingTemplateRequest**](MessagingTemplateRequest.html) | The messaging template sent | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef.html) | Details of the user created the job | [optional] |
{: class="table table-striped"}


