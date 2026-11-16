# BillingCharge

## ININ.PureCloudApi.Model.BillingCharge

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the object. | [optional] |
| **Product** | [**BillingProduct**](BillingProduct) | Represents the details of a product. | [optional] |
| **Organizations** | [**List&lt;NamedEntity&gt;**](NamedEntity) | Organizations associated with this charge. | [optional] |
| **PrepaidQuantity** | **double?** | The quantity of usage that is prepaid. | [optional] |
| **FairuseAllocation** | **double?** | Quantity of usage allowed under fair-use policies. | [optional] |
| **FairuseAmount** | **double?** | Monetary value of the fair-use allocation, in the same currency as overageCurrency. | [optional] |
| **ActualQuantity** | **double?** | The actual quantity of usage. | [optional] |
| **OverageQuantity** | **double?** | The quantity of usage that exceeds prepaid or fair use limits. | [optional] |
| **OverageRate** | **double?** | The rate charged per unit of overage. | [optional] |
| **OverageCharge** | **double?** | The total charge for overage usage. | [optional] |
| **OverageCurrency** | **string** | The currency in which the overage charge is billed. | [optional] |
| **ConvertedTokenCount** | **double?** | AI Token Count after the conversion for AI Products. | [optional] |
| **TokenConversionRate** | **double?** | AI Token Conversion Rate — Units per token conversion ratio. | [optional] |
| **AiSubItems** | [**List&lt;BillingAiSubItem&gt;**](BillingAiSubItem) | Usage that makes up this AI parent bundle, including the bundle&#39;s own token usage and each child product&#39;s usage converted to tokens; the converted total is the parent&#39;s actual quantity. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
