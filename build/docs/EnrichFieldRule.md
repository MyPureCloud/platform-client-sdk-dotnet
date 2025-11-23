# EnrichFieldRule

## ININ.PureCloudApi.Model.EnrichFieldRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Field** | **string** | A restricted JSONPath naming the specific field this combining behavior should apply to. Only dot notation with alphanumeric characters and underscores (e.g., $.address.address1, $.externalOrganization, $.tickers) are allowed. Bracket notation, array indexing, wildcards, sublists, and filter expressions are not permitted. | [optional] |
| **Action** | **string** | The behavior for how to combine data from the request body and the database. | [optional] |
| **ArrayAction** | **string** | The behavior for how to combine items in array field from the request body and the database. | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
