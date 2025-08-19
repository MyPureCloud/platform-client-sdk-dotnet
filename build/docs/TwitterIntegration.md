# TwitterIntegration

## ININ.PureCloudApi.Model.TwitterIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration ID | |
| **Name** | **string** | The name of the Twitter Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference) |  | [optional] |
| **Status** | **string** | The status of the Twitter Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef) | The recipient reference associated with the Twitter Integration This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates | |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody) | Error information returned, if createStatus is set to Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
