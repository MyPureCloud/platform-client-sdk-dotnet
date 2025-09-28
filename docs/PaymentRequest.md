# PaymentRequest

## ININ.PureCloudApi.Model.PaymentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PaymentPlatform** | **string** | The payment platform being used (e.g. Apple Pay) | [optional] |
| **CountryCode** | **string** | The merchant&#39;s two-letter ISO 3166 country code. | [optional] |
| **CurrencyCode** | **string** | The three-letter ISO 4217 currency code for the payment. | [optional] |
| **OrderTotal** | **double?** | The total price of the order. | |
| **LineItems** | [**List&lt;PaymentLineItem&gt;**](PaymentLineItem) | The items that make up the order. | [optional] |
| **ShippingOptions** | [**List&lt;PaymentLineItem&gt;**](PaymentLineItem) | The available shipping options. | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
