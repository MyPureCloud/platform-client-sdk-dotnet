# ContactBulkEditRequest

## ININ.PureCloudApi.Model.ContactBulkEditRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactListFilterId** | **string** | Contact List Filter ID. | [optional] |
| **Criteria** | [**ContactBulkSearchCriteria**](ContactBulkSearchCriteria) | Criteria to filter the contacts by. | [optional] |
| **ContactIds** | **List&lt;string&gt;** | Contact IDs to be bulk edited. | [optional] |
| **Contact** | [**DialerContact**](DialerContact) | Contact object with details of fields used for patching. | [optional] |
| **GenerateDownloadURI** | **bool?** | Whether to do backup export as part of Bulk Operation or not. Default: true. | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
