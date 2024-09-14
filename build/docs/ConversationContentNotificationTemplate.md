# ConversationContentNotificationTemplate

## ININ.PureCloudApi.Model.ConversationContentNotificationTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The identifier of the message template in &#39;your-namespace@your-template-id/name&#39; format. For External vendor (e.g WhatsApp), &#39;your-namespace@your-template-name&#39;. For GenesysCloud canned response message template use &#39;cannedresponse&#39; as your-namespace and use response ID as your-template-id (e.g. response ID&#x3D;1234 then &#39;cannedresponse@1234&#39;) | [optional] |
| **Language** | **string** | Template language. | [optional] |
| **Header** | [**ConversationNotificationTemplateHeader**](ConversationNotificationTemplateHeader) | The template header. | [optional] |
| **Body** | [**ConversationNotificationTemplateBody**](ConversationNotificationTemplateBody) | The template body. | |
| **Footer** | [**ConversationNotificationTemplateFooter**](ConversationNotificationTemplateFooter) | The template footer. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
