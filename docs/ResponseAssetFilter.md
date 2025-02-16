# ResponseAssetFilter

## ININ.PureCloudApi.Model.ResponseAssetFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EndValue** | **string** | The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format | [optional] |
| **Values** | **List&lt;string&gt;** | A list of values for the search to match against | [optional] |
| **StartValue** | **string** | The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format | [optional] |
| **Fields** | **List&lt;string&gt;** | Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated | [optional] |
| **Value** | **string** | A value for the search to match against | [optional] |
| **Type** | **string** | How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE] | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
