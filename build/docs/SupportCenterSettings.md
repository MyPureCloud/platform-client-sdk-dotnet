# SupportCenterSettings

## ININ.PureCloudApi.Model.SupportCenterSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether or not knowledge portal (previously support center) is enabled | |
| **KnowledgeBase** | [**AddressableEntityRef**](AddressableEntityRef) | The knowledge base for knowledge portal (previously support center) | |
| **CustomMessages** | [**List&lt;SupportCenterCustomMessage&gt;**](SupportCenterCustomMessage) | Customizable display texts for knowledge portal (previously support center) | [optional] |
| **RouterType** | **string** | Router type for knowledge portal (previously support center) | [optional] |
| **Screens** | [**List&lt;SupportCenterScreen&gt;**](SupportCenterScreen) | Available screens for the knowledge portal (previously support center) with its modules | |
| **EnabledCategories** | [**List&lt;SupportCenterCategory&gt;**](SupportCenterCategory) | Featured categories for knowledge portal (previously support center) home screen | |
| **LabelFilter** | [**SupportCenterLabelFilter**](SupportCenterLabelFilter) | Document label filter. If set, only documents having at least one of the specified labels will be returned by knowledge document query operations. | [optional] |
| **StyleSetting** | [**SupportCenterStyleSetting**](SupportCenterStyleSetting) | Style attributes for knowledge portal (previously support center) | |
| **Feedback** | [**SupportCenterFeedbackSettings**](SupportCenterFeedbackSettings) | Customer feedback settings | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
