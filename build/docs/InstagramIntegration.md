---
title: InstagramIntegration
---
## ININ.PureCloudApi.Model.InstagramIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration ID. | |
| **Name** | **string** | The name of the Instagram Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference.html) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference.html) |  | [optional] |
| **AppId** | **string** | The App ID from Facebook | |
| **PageId** | **string** | The Page ID from Instagram messenger | [optional] |
| **InstagramId** | **string** | The ID from Instagram messenger | [optional] |
| **InstagramUsername** | **string** | The Username from Instagram messenger | [optional] |
| **InstagramName** | **string** | The name from Instagram messenger | [optional] |
| **InstagramProfileImageUrl** | **string** | The url of the profile image from Instagram messenger | [optional] |
| **Status** | **string** | The status of the Instagram Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef.html) | The recipient reference associated to the Instagram Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody.html) | Error information returned, if createStatus is set to Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


