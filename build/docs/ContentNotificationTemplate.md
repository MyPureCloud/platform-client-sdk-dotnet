# ContentNotificationTemplate

## ININ.PureCloudApi.Model.ContentNotificationTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;. | [optional] |
| **Language** | **string** | Template language. | [optional] |
| **Header** | [**NotificationTemplateHeader**](NotificationTemplateHeader) | The template header. | [optional] |
| **Body** | [**NotificationTemplateBody**](NotificationTemplateBody) | The template body. | |
| **Buttons** | [**List&lt;NotificationTemplateButton&gt;**](NotificationTemplateButton) | Template buttons | [optional] |
| **Footer** | [**NotificationTemplateFooter**](NotificationTemplateFooter) | The template footer. | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
