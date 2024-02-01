---
title: SupportCenterSettings
---
## ININ.PureCloudApi.Model.SupportCenterSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether or not knowledge portal (previously support center) is enabled | |
| **KnowledgeBase** | [**AddressableEntityRef**](AddressableEntityRef.html) | The knowledge base for knowledge portal (previously support center) | |
| **CustomMessages** | [**List&lt;SupportCenterCustomMessage&gt;**](SupportCenterCustomMessage.html) | Customizable display texts for knowledge portal (previously support center) | [optional] |
| **RouterType** | **string** | Router type for knowledge portal (previously support center) | [optional] |
| **Screens** | [**List&lt;SupportCenterScreen&gt;**](SupportCenterScreen.html) | Available screens for the knowledge portal (previously support center) with its modules | |
| **EnabledCategories** | [**List&lt;SupportCenterCategory&gt;**](SupportCenterCategory.html) | Featured categories for knowledge portal (previously support center) home screen | |
| **StyleSetting** | [**SupportCenterStyleSetting**](SupportCenterStyleSetting.html) | Style attributes for knowledge portal (previously support center) | |
| **Feedback** | [**SupportCenterFeedbackSettings**](SupportCenterFeedbackSettings.html) | Customer feedback settings | [optional] |
{: class="table table-striped"}


