# ConversationContentListPicker

## ININ.PureCloudApi.Model.ConversationContentListPicker

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Optional unique identifier to help map component replies to form messages where multiple ListPickers can be present. | [optional] |
| **Sections** | [**List&lt;ConversationContentListPickerSection&gt;**](ConversationContentListPickerSection) | An array of sections in the List Picker. | [optional] |
| **ReplyMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The reply message after the user has selected the options from the List Picker. | [optional] |
| **ReceivedMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The message prompt to select options in the List Picker sections. | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
