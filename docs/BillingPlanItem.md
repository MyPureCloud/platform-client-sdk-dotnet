# BillingPlanItem

## ININ.PureCloudApi.Model.BillingPlanItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ItemNumber** | **string** | Item number. | [optional] |
| **Name** | **string** | Name of the item. | [optional] |
| **Type** | **string** | Type of the item. | [optional] |
| **Function** | **string** | Function of the item. | [optional] |
| **Description** | **string** | Detailed description of the item. | [optional] |
| **DateChargedThrough** | **String** | The date through which a customer has been billed for the charge. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **CurrencyIsoCode** | **string** | Contains the ISO code for any currency allowed by the organization. | [optional] |
| **DiscountAmount** | **double?** | The amount of the discount. | [optional] |
| **DateEffectiveStart** | **String** | The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEffectiveEnd** | **String** | The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **OveragePrice** | **double?** | The price for units over the allowed amount. | [optional] |
| **Price** | **double?** | The price associated with the item expressed as a decimal. | [optional] |
| **Quantity** | **int?** | The quantity of units. | [optional] |
| **UnitOfMeasure** | **string** | The unit of measure for the wallet. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
