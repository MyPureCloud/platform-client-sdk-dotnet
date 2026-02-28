# SendAgentlessOutboundMessageResponse

## ININ.PureCloudApi.Model.SendAgentlessOutboundMessageResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ConversationId** | **string** | The identifier of the conversation. | [optional] |
| **FromAddress** | **string** | The sender of the message. | [optional] |
| **ToAddress** | **string** | The recipient of the message. | [optional] |
| **MessengerType** | **string** | Type of messenger. | [optional] |
| **TextBody** | **string** | The body of the text message. (Deprecated - Instead use message.normalizedMessage.text) | [optional] |
| **MessagingTemplate** | [**SendMessagingTemplateRequest**](SendMessagingTemplateRequest) | The messaging template sent. (Deprecated - Instead use message.normalizedMessage.content[#].template) | [optional] |
| **UseExistingActiveConversation** | **bool?** | Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false | [optional] |
| **Message** | [**MessageData**](MessageData) | Sent agentless outbound message in normalized format | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef) | Details of the user created the job | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
