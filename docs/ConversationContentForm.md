# ConversationContentForm

## ININ.PureCloudApi.Model.ConversationContentForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Introduction** | [**ConversationContentIntroduction**](ConversationContentIntroduction) | The intro component, used to give an intro into what the form entails | [optional] |
| **FormPages** | [**List&lt;ConversationFormPage&gt;**](ConversationFormPage) | Form pages | [optional] |
| **ReceivedMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The message prompt to fill out the form received. | [optional] |
| **ReplyMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The reply message after the user has filled out the form received. | [optional] |
| **ShowSummary** | **bool?** | Show summary at end of form submission. | [optional] |
| **Response** | [**List&lt;ConversationFormResponseComponent&gt;**](ConversationFormResponseComponent) | Content of the payload included in the Form response. | [optional] |
| **OriginatingMessageId** | **string** | Reference to the ID of the original message. | [optional] |
| **CannedResponseId** | **string** | The id of the canned response which was used to create the form. | |



_PureCloudPlatform.Client.V2 249.0.0_
