---
title: SmsPhoneNumber
---
## ININ.PureCloudApi.Model.SmsPhoneNumber

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **PhoneNumber** | **string** | A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234 | |
| **PhoneNumberType** | **string** | Type of the phone number provisioned. | [optional] |
| **ProvisionedThroughPureCloud** | **bool?** | Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud | [optional] |
| **PhoneNumberStatus** | **string** | Status of the provisioned phone number. | [optional] |
| **CountryCode** | **string** | The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. | [optional] |
| **DateCreated** | **DateTime?** | Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**User**](User.html) | User that provisioned this phone number | [optional] |
| **ModifiedBy** | [**User**](User.html) | User that last modified this phone number | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **PurchaseDate** | **DateTime?** | Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CancellationDate** | **DateTime?** | Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **RenewalDate** | **DateTime?** | Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **AutoRenewable** | **string** | Renewal time period of this phone number, if the phoneNumberType is shortcode. | [optional] |
| **AddressId** | [**SmsAddress**](SmsAddress.html) | The id of an address attached to this phone number. | [optional] |
| **ShortCodeBillingType** | **string** | BillingType of this phone number, if the phoneNumberType is shortcode. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


