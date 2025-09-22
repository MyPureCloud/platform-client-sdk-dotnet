# BillingContract

## ININ.PureCloudApi.Model.BillingContract

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ExternalNumber** | **string** | Unique external number. | [optional] |
| **Status** | **string** | The status of the contract. | [optional] |
| **CommercialModel** | **string** | The type of commercial model. | [optional] |
| **GetpurchaseOrderNumbers** | **List&lt;string&gt;** | List of po numbers periods for this contract. | [optional] |
| **BillToCustomer** | [**Customer**](Customer) | The bill to customer. | [optional] |
| **SoldToCustomer** | [**Customer**](Customer) | The sold to customer. | [optional] |
| **EndCustomer** | [**Customer**](Customer) | The end customer. | [optional] |
| **DateStart** | **String** | The start date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEnd** | **String** | The end date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateRampStart** | **String** | the date when the first revenue or quantity in a ramped deal begins. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateRampEnd** | **String** | the date when the first revenue or quantity in a ramped deal ends. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **BillingPeriods** | [**List&lt;BillingContractPeriod&gt;**](BillingContractPeriod) | List of billing periods for the contract. | [optional] |
| **Plans** | [**List&lt;BillingPlan&gt;**](BillingPlan) | The collection of prices for the related organizations. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
