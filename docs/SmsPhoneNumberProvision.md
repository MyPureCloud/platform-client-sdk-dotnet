# SmsPhoneNumberProvision

## ININ.PureCloudApi.Model.SmsPhoneNumberProvision

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **PhoneNumber** | **string** | A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234 | |
| **PhoneNumberType** | **string** | Type of the phone number provisioned. | |
| **CountryCode** | **string** | The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. | |
| **Name** | **string** |  | [optional] |
| **AddressId** | **string** | The id of an address added on your account. Due to regulatory requirements in some countries, an address may be required when provisioning a sms number. In those cases you should provide the provisioned sms address id here | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
