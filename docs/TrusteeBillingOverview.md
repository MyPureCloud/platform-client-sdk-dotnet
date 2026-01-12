# TrusteeBillingOverview

## ININ.PureCloudApi.Model.TrusteeBillingOverview

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Organization** | [**NamedEntity**](NamedEntity) | Organization | |
| **Currency** | **string** | The currency type. | |
| **EnabledProducts** | **List&lt;string&gt;** | The charge short names for products enabled during the specified period. | |
| **SubscriptionType** | **string** | The subscription type. | |
| **RampPeriodStartDate** | **DateTime?** | Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RampPeriodEndDate** | **DateTime?** | Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **BillingPeriodStartDate** | **DateTime?** | Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **BillingPeriodEndDate** | **DateTime?** | Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Usages** | [**List&lt;SubscriptionOverviewUsage&gt;**](SubscriptionOverviewUsage) | Usages for the specified period. | |
| **ContractAmendmentDate** | **DateTime?** | Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ContractEffectiveDate** | **DateTime?** | Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ContractEndDate** | **DateTime?** | Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MinimumMonthlyAmount** | **string** | Minimum amount that will be charged for the month | [optional] |
| **InRampPeriod** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
