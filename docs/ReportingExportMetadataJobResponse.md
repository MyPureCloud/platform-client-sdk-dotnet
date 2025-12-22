# ReportingExportMetadataJobResponse

## ININ.PureCloudApi.Model.ReportingExportMetadataJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ViewType** | **string** | The view type of the export metadata | [optional] |
| **DateLimitations** | **string** | The date limitations of the export metadata | [optional] |
| **RequiredFilters** | **List&lt;string&gt;** | The list of required filters for the export metadata | [optional] |
| **SupportedFilters** | **List&lt;string&gt;** | The list of supported filters for the export metadata | [optional] |
| **RequiredColumnIds** | **List&lt;string&gt;** | The list of required column ids for the export metadata | [optional] |
| **DependentColumnIds** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | The list of dependent column ids for the export metadata | [optional] |
| **AvailableColumnIds** | **List&lt;string&gt;** | The list of available column ids for the export metadata | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
