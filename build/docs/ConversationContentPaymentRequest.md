# ConversationContentPaymentRequest

## ININ.PureCloudApi.Model.ConversationContentPaymentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PaymentPlatform** | **string** | The payment platform being used (e.g. Apple Pay) | |
| **CountryCode** | **string** | The merchant&#39;s two-letter ISO 3166 country code. | |
| **CurrencyCode** | **string** | The three-letter ISO 4217 currency code for the payment. | |
| **OrderTotal** | **double?** | The total price of the order. | |
| **LineItems** | [**List&lt;ConversationContentLineItem&gt;**](ConversationContentLineItem) | The items that make up the order. | [optional] |
| **ShippingOptions** | [**List&lt;ConversationContentLineItem&gt;**](ConversationContentLineItem) | The available shipping options. | [optional] |
| **RequiredContactFields** | [**List&lt;ConversationContentRequiredContactField&gt;**](ConversationContentRequiredContactField) | Contact fields required to complete the order. | [optional] |
| **ReceivedMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The message prompt to complete a payment transaction. | [optional] |
| **ReplyMessage** | [**ConversationContentReceivedReplyMessage**](ConversationContentReceivedReplyMessage) | The reply message after the user has completed the payment transaction. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
