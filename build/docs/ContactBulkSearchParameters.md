# ContactBulkSearchParameters

## ININ.PureCloudApi.Model.ContactBulkSearchParameters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactListFilterId** | **string** | Contact List Filter ID. Either this property or criteria is required. | [optional] |
| **Criteria** | [**ContactBulkSearchCriteria**](ContactBulkSearchCriteria) | Criteria to filter the contacts by. Either this property or contactListFilterId is required. | [optional] |
| **GenerateDownloadURI** | **bool?** | Whether to do backup export as part of Bulk Operation or not. Default: true. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
