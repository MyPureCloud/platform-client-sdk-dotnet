# OrganizationsExportFilter

## ININ.PureCloudApi.Model.OrganizationsExportFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Eq** | [**OrganizationsExportFieldFilter**](OrganizationsExportFieldFilter) | Filtered field should have the same value | [optional] |
| **In** | [**OrganizationsExportFieldListFilter**](OrganizationsExportFieldListFilter) | Filtered field should match one of the listed values | [optional] |
| **Lte** | [**OrganizationsExportComparisonFieldFilter**](OrganizationsExportComparisonFieldFilter) | Filtered field should be less than or equal to the value | [optional] |
| **Gte** | [**OrganizationsExportComparisonFieldFilter**](OrganizationsExportComparisonFieldFilter) | Filtered field should be greater than or equal to the value | [optional] |
| **And** | [**List&lt;OrganizationsExportFilter&gt;**](OrganizationsExportFilter) | Boolean AND combination of filters | [optional] |
| **Or** | [**List&lt;OrganizationsExportFilter&gt;**](OrganizationsExportFilter) | Boolean OR combination of filters | [optional] |
| **Not** | [**OrganizationsExportFilter**](OrganizationsExportFilter) | Boolean negation of filters | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
