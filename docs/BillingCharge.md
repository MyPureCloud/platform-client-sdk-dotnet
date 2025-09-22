# BillingCharge

## ININ.PureCloudApi.Model.BillingCharge

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Product** | [**BillingProduct**](BillingProduct) | Represents the details of a product. | [optional] |
| **Organizations** | [**List&lt;NamedEntity&gt;**](NamedEntity) | List of plans within the organization. | [optional] |
| **GetprepaidQuantity** | **int?** | The quantity of usage that is prepaid. | [optional] |
| **GetfairuseQuantity** | **int?** | The quantity of usage allowed under fair use policies. | [optional] |
| **GetactualQuantity** | **int?** | The actual quantity of usage. | [optional] |
| **GetoverageQuantity** | **int?** | The quantity of usage that exceeds prepaid or fair use limits. | [optional] |
| **OverageRate** | **double?** | The rate charged per unit of overage. | [optional] |
| **OverageCharge** | **double?** | The total charge for overage usage. | [optional] |
| **OverageCurrency** | **string** | The currency in which the overage charge is billed. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
