# WhatsAppDefinition

## ININ.PureCloudApi.Model.WhatsAppDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The messaging template name. | |
| **Namespace** | **string** | The messaging template namespace. | [optional] |
| **Language** | **string** | The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39; | |
| **Buttons** | [**List&lt;Button&gt;**](Button) | List of buttons to be included in the WhatsApp messages channel | [optional] |
| **MessageFooter** | [**MessageFooter**](MessageFooter) | Footer for the message in the WhatsApp messages channel | [optional] |
| **Header** | [**MessageHeader**](MessageHeader) | Header for the message in the WhatsApp messages channel | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
