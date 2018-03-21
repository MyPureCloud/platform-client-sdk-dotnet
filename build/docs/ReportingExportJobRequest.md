---
title: ReportingExportJobRequest
---
## ININ.PureCloudApi.Model.ReportingExportJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The user supplied name of the export request | |
| **TimeZone** | [**TimeZone**](TimeZone.html) | The requested timezone of the exported data | |
| **ExportFormat** | **string** | The requested format of the exported data | |
| **Interval** | **string** | The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **DataColumns** | [**List&lt;DataColumn&gt;**](DataColumn.html) | The data columns included in the export | |
| **Period** | **string** | The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | [optional] |
| **ViewType** | **string** | The type of view export job to be created | |
| **Filter** | [**ViewFilter**](ViewFilter.html) | Filters to apply to create the view | |
| **Read** | **bool?** | Indicates if the request has been marked as read | [optional] |
{: class="table table-striped"}


