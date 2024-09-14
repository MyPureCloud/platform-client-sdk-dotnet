# SmsPhoneNumber

## ININ.PureCloudApi.Model.SmsPhoneNumber

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **PhoneNumber** | **string** | A phone number provisioned for SMS communications. | |
| **PhoneNumberType** | **string** | Type of the phone number provisioned. | [optional] |
| **ProvisionedThroughPureCloud** | **bool?** | Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud | [optional] |
| **PhoneNumberStatus** | **string** | Status of the provisioned phone number. | [optional] |
| **Capabilities** | **List&lt;string&gt;** | The capabilities of the phone number available for provisioning. | [optional] |
| **CountryCode** | **string** | The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. | [optional] |
| **DateCreated** | **DateTime?** | Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**User**](User) | User that provisioned this phone number | [optional] |
| **ModifiedBy** | [**User**](User) | User that last modified this phone number | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **PurchaseDate** | **DateTime?** | Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CancellationDate** | **DateTime?** | Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RenewalDate** | **DateTime?** | Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AutoRenewable** | **string** | Renewal time period of this phone number, if the phoneNumberType is shortcode. | [optional] |
| **AddressId** | [**SmsAddress**](SmsAddress) | The id of an address attached to this phone number. | [optional] |
| **ShortCodeBillingType** | **string** | BillingType of this phone number, if the phoneNumberType is shortcode. | [optional] |
| **ProvisioningStatus** | [**SmsProvisioningStatus**](SmsProvisioningStatus) | Status of latest asynchronous provisioning action | [optional] |
| **Country** | **string** | Localized country name for the country code this phone number belongs too | [optional] |
| **SupportsSms** | **bool?** | Set to true if this phone number has the capability to support SMS | [optional] |
| **SupportsMms** | **bool?** | Set to true if this phone number has the capability to support MMS | [optional] |
| **SupportsVoice** | **bool?** | Set to true if this phone number has the capability to support voice | [optional] |
| **Integration** | [**DomainEntityRef**](DomainEntityRef) | The Genesys Cloud integration this phone number belongs to. | [optional] |
| **Compliance** | [**Compliance**](Compliance) | Compliance configuration for short codes, including help, stop and opt in. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
