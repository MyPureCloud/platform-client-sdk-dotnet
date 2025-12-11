# KeyPerformanceIndicator

## ININ.PureCloudApi.Model.KeyPerformanceIndicator

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Key Performance Indicator. | [optional] |
| **OptimizationType** | **string** | The optimization type of the Key Performance Indicator. | [optional] |
| **ProblemType** | **string** | The problem type of the Key Performance Indicator. | [optional] |
| **DateCreated** | **DateTime?** | DateTime indicating when the Key Performance Indicator was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | DateTime indicating when the Key Performance Indicator was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Description** | **string** | The description of the Key Performance Indicator. | [optional] |
| **KpiType** | **string** | The type of Key Performance Indicator. | [optional] |
| **Source** | **string** | Source of values for Key Performance Indicator. | [optional] |
| **WrapUpCodeConfig** | [**WrapUpCodeConfig**](WrapUpCodeConfig) | Defines what wrap up codes are mapped to Key Performance Indicator. | [optional] |
| **OutcomeConfig** | [**OutcomeConfig**](OutcomeConfig) | Defines what outcome ids are mapped to Key Performance Indicator. | [optional] |
| **Status** | **string** | The status of the Key Performance Indicator. | [optional] |
| **KpiGroup** | **string** | The group the Key Performance Indicator belongs to. | [optional] |
| **Queues** | **List&lt;string&gt;** | Queue IDs on which KPI specification is used. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
