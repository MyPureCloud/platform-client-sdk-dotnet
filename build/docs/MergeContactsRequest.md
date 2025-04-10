# MergeContactsRequest

## ININ.PureCloudApi.Model.MergeContactsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactIds** | **List&lt;string&gt;** | The IDs of all contacts involved in the merge operation (must be between 2 and 25). | |
| **ValueOverride** | [**ExternalContact**](ExternalContact) | Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data. | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
