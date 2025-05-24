# WhatsAppIntegration

## ININ.PureCloudApi.Model.WhatsAppIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration Id. | |
| **Name** | **string** | The name of the WhatsApp integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference) |  | [optional] |
| **PhoneNumber** | **string** | The phone number associated to the WhatsApp integration. | |
| **AvailablePhoneNumbers** | [**WhatsAppAvailablePhoneNumberDetailsListing**](WhatsAppAvailablePhoneNumberDetailsListing) | The list of available WhatsApp phone numbers for this account. Please select one phone number from this list to use with the created integration. | [optional] |
| **Status** | **string** | The status of the WhatsApp Integration | [optional] |
| **Recipient** | [**DomainEntityRef**](DomainEntityRef) | The recipient associated to the WhatsApp Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **ActivationStatusCode** | **string** | The status code of WhatsApp Integration activation process | [optional] |
| **ActivationErrorInfo** | [**ErrorBody**](ErrorBody) | The error information of WhatsApp Integration activation process | [optional] |
| **CreateStatus** | **string** | Status of asynchronous create operation | [optional] |
| **CreateError** | [**ErrorBody**](ErrorBody) | Error information returned, if createStatus is set to Error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
