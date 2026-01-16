# BillingContractPeriodDetail

## ININ.PureCloudApi.Model.BillingContractPeriodDetail

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateStart** | **String** | The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEnd** | **String** | The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Status** | **string** | The type of address. | [optional] |
| **Charges** | [**List&lt;BillingCharge&gt;**](BillingCharge) | Represents usage metrics including prepaid, actual, and overage quantities along with associated charges. | [optional] |
| **Wallets** | [**List&lt;BillingWallet&gt;**](BillingWallet) | Represents usage metrics including prepaid, actual, and overage quantities along with associated charges. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
