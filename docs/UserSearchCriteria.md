# UserSearchCriteria

## ININ.PureCloudApi.Model.UserSearchCriteria

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EndValue** | **string** | The end value of the range. This field is used for range search types. | [optional] |
| **Values** | **List&lt;string&gt;** | A list of values for the search to match against | [optional] |
| **StartValue** | **string** | The start value of the range. This field is used for range search types. | [optional] |
| **Value** | **string** | A value for the search to match against | [optional] |
| **Operator** | **string** | How to apply this search criteria against other criteria | [optional] |
| **Group** | [**List&lt;UserSearchCriteria&gt;**](UserSearchCriteria) | Groups multiple conditions | [optional] |
| **DateFormat** | **string** | Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX. | [optional] |
| **Fields** | **List&lt;string&gt;** | Field names to search against | [optional] |
| **Type** | **string** | Search Type | |



_PureCloudPlatform.Client.V2 224.1.0_