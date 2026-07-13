# WhatsAppDefinition

## ININ.PureCloudApi.Model.WhatsAppDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The messaging template name. | |
| **Namespace** | **string** | The messaging template namespace. | [optional] |
| **Language** | **string** | The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39; | |
| **Buttons** | [**List&lt;Button&gt;**](Button) | List of buttons to be included in the standard WhatsApp messages channel | [optional] |
| **MessageFooter** | [**MessageFooter**](MessageFooter) | Footer for the message in the standard WhatsApp messages channel | [optional] |
| **Header** | [**MessageHeader**](MessageHeader) | Header for the message in the standard WhatsApp messages channel | [optional] |
| **IntegrationId** | **string** | WhatsApp integration ID for whatsApp carousels | [optional] |
| **Category** | **string** | Category of whatsApp carousels template. | [optional] |
| **TemplateStatus** | **string** | Template status of whatsApp carousels template. | [optional] |
| **StatusInfo** | [**StatusInfo**](StatusInfo) | Status information about the template | [optional] |
| **Carousel** | [**Carousel**](Carousel) | Definition for whatsApp carousels template. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
