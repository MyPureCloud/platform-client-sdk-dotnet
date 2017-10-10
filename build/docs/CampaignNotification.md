---
title: CampaignNotification
---
## ININ.PureCloudApi.Model.CampaignNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** |  | [optional] |
| **DateModified** | **DateTime?** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **ContactList** | [**DocumentDataV2NotificationCreatedBy**](DocumentDataV2NotificationCreatedBy.html) |  | [optional] |
| **Queue** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **DialingMode** | **string** |  | [optional] |
| **Script** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **EdgeGroup** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **Site** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **CampaignStatus** | **string** |  | [optional] |
| **PhoneColumns** | [**List&lt;CampaignNotificationPhoneColumns&gt;**](CampaignNotificationPhoneColumns.html) |  | [optional] |
| **AbandonRate** | **double?** |  | [optional] |
| **DncLists** | [**List&lt;CampaignNotificationUriReference&gt;**](CampaignNotificationUriReference.html) |  | [optional] |
| **CallableTimeSet** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **CallAnalysisResponseSet** | [**CampaignNotificationUriReference**](CampaignNotificationUriReference.html) |  | [optional] |
| **CallerName** | **string** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **OutboundLineCount** | **int?** |  | [optional] |
| **Errors** | [**List&lt;CampaignNotificationErrors&gt;**](CampaignNotificationErrors.html) |  | [optional] |
| **RuleSets** | [**List&lt;CampaignNotificationUriReference&gt;**](CampaignNotificationUriReference.html) |  | [optional] |
| **SkipPreviewDisabled** | **bool?** |  | [optional] |
| **PreviewTimeOutSeconds** | **int?** |  | [optional] |
| **SingleNumberPreview** | **bool?** |  | [optional] |
| **ContactSort** | [**CampaignNotificationContactSort**](CampaignNotificationContactSort.html) |  | [optional] |
| **ContactSorts** | [**List&lt;CampaignNotificationContactSort&gt;**](CampaignNotificationContactSort.html) |  | [optional] |
| **NoAnswerTimeout** | **int?** |  | [optional] |
| **CallAnalysisLanguage** | **string** |  | [optional] |
| **Priority** | **int?** |  | [optional] |
| **ContactListFilters** | [**List&lt;CampaignNotificationUriReference&gt;**](CampaignNotificationUriReference.html) |  | [optional] |
| **AdditionalProperties** | **Object** |  | [optional] |
{: class="table table-striped"}


