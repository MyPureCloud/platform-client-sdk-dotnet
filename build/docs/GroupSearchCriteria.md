---
title: GroupSearchCriteria
---
## ININ.PureCloudApi.Model.GroupSearchCriteria

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EndValue** | **string** | The end value of the range. This field is used for range search types. | [optional] |
| **Values** | **List&lt;string&gt;** | A list of values for the search to match against | [optional] |
| **StartValue** | **string** | The start value of the range. This field is used for range search types. | [optional] |
| **Fields** | **List&lt;string&gt;** | Field names to search against | [optional] |
| **Value** | **string** | A value for the search to match against | [optional] |
| **_Operator** | **string** | How to apply this search criteria against other criteria | [optional] |
| **Group** | [**List&lt;GroupSearchCriteria&gt;**](GroupSearchCriteria.html) | Groups multiple conditions | [optional] |
| **DateFormat** | **string** | Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX. | [optional] |
| **Type** | **string** | Search Type | |
{: class="table table-striped"}


