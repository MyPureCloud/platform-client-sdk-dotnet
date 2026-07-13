# RelationshipsExportFilter

## ININ.PureCloudApi.Model.RelationshipsExportFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Eq** | [**RelationshipsExportFieldFilter**](RelationshipsExportFieldFilter) | Filtered field should have the same value | [optional] |
| **In** | [**RelationshipsExportFieldListFilter**](RelationshipsExportFieldListFilter) | Filtered field should match one of the listed values | [optional] |
| **Lte** | [**RelationshipsExportComparisonFieldFilter**](RelationshipsExportComparisonFieldFilter) | Filtered field should be less than or equal to the value | [optional] |
| **Gte** | [**RelationshipsExportComparisonFieldFilter**](RelationshipsExportComparisonFieldFilter) | Filtered field should be greater than or equal to the value | [optional] |
| **And** | [**List&lt;RelationshipsExportFilter&gt;**](RelationshipsExportFilter) | Boolean AND combination of filters | [optional] |
| **Or** | [**List&lt;RelationshipsExportFilter&gt;**](RelationshipsExportFilter) | Boolean OR combination of filters | [optional] |
| **Not** | [**RelationshipsExportFilter**](RelationshipsExportFilter) | Boolean negation of filters | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
