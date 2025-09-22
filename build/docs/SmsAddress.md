# SmsAddress

## ININ.PureCloudApi.Model.SmsAddress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of this address. | [optional] |
| **Name** | **string** |  | [optional] |
| **Street** | **string** | The number and street address where this address is located. | [optional] |
| **City** | **string** | The city in which this address is in | [optional] |
| **Region** | **string** | The state or region this address is in | [optional] |
| **PostalCode** | **string** | The postal code this address is in | [optional] |
| **CountryCode** | **string** | The ISO country code of this address | [optional] |
| **Validated** | **bool?** | In some countries, addresses are validated to comply with local regulation. In those countries, if the address you provide does not pass validation, it will not be accepted as an Address. This value will be true if the Address has been validated, or false for countries that don&#39;t require validation or if the Address is non-compliant. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
