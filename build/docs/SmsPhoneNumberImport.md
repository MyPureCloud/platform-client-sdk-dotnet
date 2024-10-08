# SmsPhoneNumberImport

## ININ.PureCloudApi.Model.SmsPhoneNumberImport

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **PhoneNumber** | **string** | A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234 | |
| **PhoneNumberType** | **string** | Type of the phone number provisioned. | |
| **CountryCode** | **string** | The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. | |
| **IntegrationId** | **string** | The id of the Genesys Cloud integration this phone number belongs to. | |
| **Compliance** | [**Compliance**](Compliance) | Compliance configuration for short codes, including help, stop and opt in. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
