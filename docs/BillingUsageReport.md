# BillingUsageReport

## ININ.PureCloudApi.Model.BillingUsageReport

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **StartDate** | **DateTime?** | The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndDate** | **DateTime?** | The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Status** | **string** | Generation status of report | [optional] |
| **Usages** | [**List&lt;BillingUsage&gt;**](BillingUsage) | The usages for the given period. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
