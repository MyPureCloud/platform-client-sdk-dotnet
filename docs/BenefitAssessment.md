# BenefitAssessment

## ININ.PureCloudApi.Model.BenefitAssessment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Queues** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The list of queues that are assessed for Predictive Routing benefit. | [optional] |
| **KpiAssessments** | [**List&lt;KeyPerformanceIndicatorAssessment&gt;**](KeyPerformanceIndicatorAssessment) | A set of key performance indicators applied on the queue to determine suitability of Predictive Routing. | [optional] |
| **State** | **string** | State of the benefit assessment. | [optional] |
| **JobId** | **string** | The unique identifier of job that created this benefit assessment. | [optional] |
| **DateCreated** | **DateTime?** | Creation Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Modified Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
