# ContactsExportFilter

## ININ.PureCloudApi.Model.ContactsExportFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Eq** | [**ContactsExportFieldFilter**](ContactsExportFieldFilter) | Filtered field should have the same value | [optional] |
| **In** | [**ContactsExportFieldListFilter**](ContactsExportFieldListFilter) | Filtered field should match one of the listed values | [optional] |
| **And** | [**List&lt;ContactsExportFilter&gt;**](ContactsExportFilter) | Boolean AND combination of filters | [optional] |
| **Or** | [**List&lt;ContactsExportFilter&gt;**](ContactsExportFilter) | Boolean OR combination of filters | [optional] |
| **Not** | [**ContactsExportFilter**](ContactsExportFilter) | Boolean negation of filters | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
