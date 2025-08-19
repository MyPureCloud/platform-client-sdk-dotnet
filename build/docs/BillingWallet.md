# BillingWallet

## ININ.PureCloudApi.Model.BillingWallet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the object. | [optional] |
| **Organizations** | [**List&lt;NamedEntity&gt;**](NamedEntity) | A Genesys Cloud Organization and it&#39;s related plans. | [optional] |
| **Product** | [**BillingProduct**](BillingProduct) | Represents the details of a product. | [optional] |
| **StartingBalance** | **double?** | The initial balance in the wallet. | [optional] |
| **EndingBalance** | **double?** | The final balance in the wallet after transactions. | [optional] |
| **BalanceIncrease** | **double?** | Total amount added to the wallet. | [optional] |
| **BalanceDecrease** | **double?** | The amount removed from the wallet due to a contract change. | [optional] |
| **BalanceConsumption** | **double?** | Total consumption deducted from the wallet. | [optional] |
| **BalanceOverage** | **double?** | The amount exceeding a predefined balance threshold. | [optional] |
| **BalanceOverageRate** | **double?** | The rate charged for an overage.. | [optional] |
| **BalanceOverageCharge** | **double?** | The amount to be charged. | [optional] |
| **BalanceOverageCurrency** | **string** | The currency in which the overage charge is invoiced. | [optional] |
| **UnitOfMeasure** | **string** | The unit of measure for the wallet. | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
