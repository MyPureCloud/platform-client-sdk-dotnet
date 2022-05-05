---
title: MessagingIntegration
---
## ININ.PureCloudApi.Model.MessagingIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration Id | |
| **Name** | **string** | The name of the Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference.html) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference.html) |  | [optional] |
| **Status** | **string** | The status of the Integration | [optional] |
| **MessengerType** | **string** | The type of Messaging Integration | |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef.html) | The recipient associated to the Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


