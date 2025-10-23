# BillingInvoiceItem

## ININ.PureCloudApi.Model.BillingInvoiceItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Product** | [**BillingProduct**](BillingProduct) | Represents the details of a product. | [optional] |
| **Description** | **string** | Line Item Description. | [optional] |
| **DateTransacted** | **String** | Invoice transaction date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateStart** | **String** | Invoice start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEnd** | **String** | Invoice end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Organization** | [**NamedEntity**](NamedEntity) | A Genesys Cloud Organization. | [optional] |
| **Quantity** | **int?** | Quantity of the item. | [optional] |
| **UnitOfMeasure** | **string** | Unit of Measure. | [optional] |
| **Amount** | **double?** | Amount. | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
