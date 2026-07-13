# NotesExportFilter

## ININ.PureCloudApi.Model.NotesExportFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Eq** | [**NotesExportFieldFilter**](NotesExportFieldFilter) | Filtered field should have the same value | [optional] |
| **In** | [**NotesExportFieldListFilter**](NotesExportFieldListFilter) | Filtered field should match one of the listed values | [optional] |
| **Lte** | [**NotesExportComparisonFieldFilter**](NotesExportComparisonFieldFilter) | Filtered field should be less than or equal to the value | [optional] |
| **Gte** | [**NotesExportComparisonFieldFilter**](NotesExportComparisonFieldFilter) | Filtered field should be greater than or equal to the value | [optional] |
| **And** | [**List&lt;NotesExportFilter&gt;**](NotesExportFilter) | Boolean AND combination of filters | [optional] |
| **Or** | [**List&lt;NotesExportFilter&gt;**](NotesExportFilter) | Boolean OR combination of filters | [optional] |
| **Not** | [**NotesExportFilter**](NotesExportFilter) | Boolean negation of filters | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
