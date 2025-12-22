# AppleIntegration

## ININ.PureCloudApi.Model.AppleIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique integration Id. | |
| **Name** | **string** | The name of the Apple messaging integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference) |  | [optional] |
| **MessagesForBusinessId** | **string** | The Apple Messages for Business Id for the Apple messaging integration. | |
| **BusinessName** | **string** | The name of the business. | [optional] |
| **LogoUrl** | **string** | The url of the businesses logo. | [optional] |
| **Status** | **string** | The status of the Apple Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef) | The recipient associated to the Apple messaging Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that last modified this Integration | [optional] |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody) | Error information returned, if createStatus is set to Error | [optional] |
| **AppleIMessageApp** | [**AppleIMessageApp**](AppleIMessageApp) | Interactive Application (iMessage App) Settings. | [optional] |
| **AppleAuthentication** | [**AppleAuthentication**](AppleAuthentication) | The Apple Messages for Business authentication setting. | [optional] |
| **ApplePay** | [**ApplePay**](ApplePay) | Apple Pay settings. | [optional] |
| **IdentityResolution** | [**AppleIdentityResolutionConfig**](AppleIdentityResolutionConfig) | The configuration to control identity resolution. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
