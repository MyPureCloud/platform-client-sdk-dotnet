# OpenIntegration

## ININ.PureCloudApi.Model.OpenIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration Id. | |
| **Name** | **string** | The name of the Open messaging integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference) |  | [optional] |
| **OutboundNotificationWebhookUrl** | **string** | The outbound notification webhook URL for the Open messaging integration. | |
| **OutboundNotificationWebhookSignatureSecretToken** | **string** | The outbound notification webhook signature secret token. | |
| **WebhookHeaders** | **Dictionary&lt;string, string&gt;** | The user specified headers for the Open messaging integration. | [optional] |
| **Status** | **string** | The status of the Open Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef) | The recipient associated to the Open messaging Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that last modified this Integration | [optional] |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody) | Error information returned, if createStatus is set to Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
