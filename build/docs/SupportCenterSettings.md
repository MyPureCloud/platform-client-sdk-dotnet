---
title: SupportCenterSettings
---
## ININ.PureCloudApi.Model.SupportCenterSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether or not support center is enabled | [optional] |
| **KnowledgeBase** | [**AddressableEntityRef**](AddressableEntityRef.html) | The knowledge base for support center | [optional] |
| **CustomMessages** | [**List&lt;SupportCenterCustomMessage&gt;**](SupportCenterCustomMessage.html) | Customizable display texts for support center | [optional] |
| **RouterType** | **string** | Router type for support center | [optional] |
| **Screens** | [**List&lt;SupportCenterScreen&gt;**](SupportCenterScreen.html) | Available screens for the support center with its modules | [optional] |
| **EnabledCategories** | [**List&lt;SupportCenterCategory&gt;**](SupportCenterCategory.html) | Enabled article categories for support center | [optional] |
| **StyleSetting** | [**SupportCenterStyleSetting**](SupportCenterStyleSetting.html) | Style attributes for support center | [optional] |
| **Feedback** | [**SupportCenterFeedbackSettings**](SupportCenterFeedbackSettings.html) | Customer feedback settings | [optional] |
{: class="table table-striped"}


