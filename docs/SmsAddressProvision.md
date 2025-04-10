# SmsAddressProvision

## ININ.PureCloudApi.Model.SmsAddressProvision

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name associated with this address | |
| **Street** | **string** | The number and street address where this address is located. | |
| **City** | **string** | The city in which this address is in | |
| **Region** | **string** | The state or region this address is in | |
| **PostalCode** | **string** | The postal code this address is in | |
| **CountryCode** | **string** | The ISO country code of this address | |
| **AutoCorrectAddress** | **bool?** | This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
