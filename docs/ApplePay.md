# ApplePay

## ININ.PureCloudApi.Model.ApplePay

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StoreName** | **string** | The name of the store. | |
| **MerchantId** | **string** | The stores merchant identifier. | |
| **DomainName** | **string** | The domain name associated with the merchant account. | |
| **PaymentCapabilities** | **List&lt;string&gt;** | The payment capabilities supported by the merchant. | |
| **SupportedPaymentNetworks** | **List&lt;string&gt;** | The payment networks supported by the merchant. | |
| **PaymentCertificateCredentialId** | **string** | The Genesys credentialId the payment certificates are stored under. | |
| **PaymentGatewayUrl** | **string** | The url used to process payments. | |
| **FallbackUrl** | **string** | The url opened in a web browser if the customers device is unable to make payments using Apple Pay. | [optional] |
| **ShippingMethodUpdateUrl** | **string** | The url called when the customer changes the shipping method. | [optional] |
| **ShippingContactUpdateUrl** | **string** | The url called when the customer changes their shipping address information. | [optional] |
| **PaymentMethodUpdateUrl** | **string** | The url called when the customer changes their payment method. | [optional] |
| **OrderTrackingUrl** | **string** | The url called after completing the order to update the order information in your system | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
