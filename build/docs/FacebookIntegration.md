# FacebookIntegration

## ININ.PureCloudApi.Model.FacebookIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration Id. | |
| **Name** | **string** | The name of the Facebook Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference) |  | [optional] |
| **AppId** | **string** | The App Id from Facebook messenger | |
| **PageId** | **string** | The Page Id from Facebook messenger | [optional] |
| **PageName** | **string** | The name of the Facebook page | [optional] |
| **PageProfileImageUrl** | **string** | The url of the profile image of the Facebook page | [optional] |
| **Status** | **string** | The status of the Facebook Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef) | The recipient reference associated to the Facebook Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody) | Error information returned, if createStatus is set to Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
