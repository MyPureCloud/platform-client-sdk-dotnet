# ExportDetails

## ININ.PureCloudApi.Model.ExportDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Flow** | [**ArchitectFlowReference**](ArchitectFlowReference) | The flow to export. If you do not provide the flow ID, you must provide both the name and type. | |
| **FileName** | **string** | Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens. | [optional] |
| **ExportType** | **string** | The export type for the flow. Default: &#39;Yaml&#39;. | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
