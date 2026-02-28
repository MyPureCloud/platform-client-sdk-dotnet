# EvaluationSearchCriteriaDTO

## ININ.PureCloudApi.Model.EvaluationSearchCriteriaDTO

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of query Operation to Perform | |
| **Field** | **string** | Field name to search against | |
| **EndValue** | **string** | The end value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. | [optional] |
| **Values** | **List&lt;string&gt;** | A list of values for the search to match against. Only for Type: EXACT | [optional] |
| **StartValue** | **string** | The start value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. | [optional] |
| **Value** | **string** | A value for the search to match against | [optional] |
| **Operator** | **string** | How to apply this search criteria against other criteria | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
