# ContactsExportFilter

## ININ.PureCloudApi.Model.ContactsExportFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Eq** | [**ContactsExportFieldFilter**](ContactsExportFieldFilter) | Filtered field should have the same value | [optional] |
| **In** | [**ContactsExportFieldListFilter**](ContactsExportFieldListFilter) | Filtered field should match one of the listed values | [optional] |
| **Lte** | [**ContactsExportComparisonFieldFilter**](ContactsExportComparisonFieldFilter) | Filtered field should be less than or equal to the value | [optional] |
| **Gte** | [**ContactsExportComparisonFieldFilter**](ContactsExportComparisonFieldFilter) | Filtered field should be greater than or equal to the value | [optional] |
| **And** | [**List&lt;ContactsExportFilter&gt;**](ContactsExportFilter) | Boolean AND combination of filters | [optional] |
| **Or** | [**List&lt;ContactsExportFilter&gt;**](ContactsExportFilter) | Boolean OR combination of filters | [optional] |
| **Not** | [**ContactsExportFilter**](ContactsExportFilter) | Boolean negation of filters | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
