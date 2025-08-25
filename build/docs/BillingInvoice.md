# BillingInvoice

## ININ.PureCloudApi.Model.BillingInvoice

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **BillToCustomer** | [**Customer**](Customer) | The bill to customer. | [optional] |
| **ShipToCustomer** | [**Customer**](Customer) | The ship to customer. | [optional] |
| **SoldToCustomer** | [**Customer**](Customer) | The sold to customer. | [optional] |
| **DateInvoiced** | **String** | Date when the invoice was issued. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **BillToAddress** | [**InvoiceAddress**](InvoiceAddress) | Details of the bill to address. | [optional] |
| **ShipToAddress** | [**InvoiceAddress**](InvoiceAddress) | Details of the ship to address. | [optional] |
| **CurrencyIsoCode** | **string** | Contains the ISO code for any currency allowed by the organization. | [optional] |
| **PaymentStatus** | **string** | Status of the payment. | [optional] |
| **PaymentTerms** | **string** | Payment terms. | [optional] |
| **PaymentLink** | **string** | Payment link. | [optional] |
| **CustomerPoNumber** | **string** | Purchase Order Number. | [optional] |
| **CustomerInvoiceType** | **string** | Type of the invoice. | [optional] |
| **Amount** | **double?** | Amount. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
