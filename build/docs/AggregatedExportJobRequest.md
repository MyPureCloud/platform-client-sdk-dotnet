# AggregatedExportJobRequest

## ININ.PureCloudApi.Model.AggregatedExportJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Granularity** | **string** | Granularity of the exported data, defaults to day | [optional] |
| **TimeZone** | **string** | The requested time zone of the exported data, in Olson format. Defaults to business unit time zone | [optional] |
| **Delimiter** | **string** | The delimiter to use between fields in the export, defaults to comma | [optional] |
| **PlanningGroupIds** | **List&lt;string&gt;** | The IDs of the planning groups to include in the export, defaults to all planning groups in the business unit | [optional] |
| **DateStart** | **DateTime?** | Start date-time of the export range in ISO-8601 format | [optional] |
| **DateEnd** | **DateTime?** | End date-time of the export range in ISO-8601 format | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
