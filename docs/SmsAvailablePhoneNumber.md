# SmsAvailablePhoneNumber

## ININ.PureCloudApi.Model.SmsAvailablePhoneNumber

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **PhoneNumber** | **string** | A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234 | [optional] |
| **CountryCode** | **string** | The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. | [optional] |
| **Region** | **string** | The region/province/state the phone number is associated with. | [optional] |
| **City** | **string** | The city the phone number is associated with. | [optional] |
| **Capabilities** | **List&lt;string&gt;** | The capabilities of the phone number available for provisioning. | [optional] |
| **PhoneNumberType** | **string** | The type of phone number available for provisioning. | [optional] |
| **AddressRequirement** | **string** | The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
