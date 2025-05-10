# EnrichFieldRule

## ININ.PureCloudApi.Model.EnrichFieldRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Field** | **string** | A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;. | [optional] |
| **Action** | **string** | The behavior for how to combine data from the request body and the database. | [optional] |
| **ArrayAction** | **string** | The behavior for how to combine items in array field from the request body and the database. | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
