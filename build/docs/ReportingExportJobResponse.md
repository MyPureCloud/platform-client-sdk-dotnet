---
title: ReportingExportJobResponse
---
## ININ.PureCloudApi.Model.ReportingExportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Status** | **string** | The current status of the export request | |
| **TimeZone** | **string** | The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | |
| **ExportFormat** | **string** | The requested format of the exported data | |
| **Interval** | **string** | The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **DownloadUrl** | **string** | The url to download the request if it&#39;s status is completed | [optional] |
| **ViewType** | **string** | The type of view export job to be created | |
| **ExportErrorMessagesType** | **string** | The error message in case the export request failed | [optional] |
| **Period** | **string** | The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | |
| **Filter** | [**ViewFilter**](ViewFilter.html) | Filters to apply to create the view | |
| **Read** | **bool?** | Indicates if the request has been marked as read | |
| **CreatedDateTime** | **DateTime?** | The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **ModifiedDateTime** | **DateTime?** | The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **Locale** | **string** | The locale use for localization of the exported data, i.e. en-us, es-mx   | |
| **PercentageComplete** | **double?** | The percentage of the job that has completed processing | |
| **HasFormatDurations** | **bool?** | Indicates if durations are formatted in hh:mm:ss format instead of ms | [optional] |
| **HasSplitFilters** | **bool?** | Indicates if filters will be split in aggregate detail exports | [optional] |
| **SelectedColumns** | [**List&lt;SelectedColumns&gt;**](SelectedColumns.html) | The list of ordered selected columns from the export view by the user | [optional] |
| **HasCustomParticipantAttributes** | **bool?** | Indicates if custom participant attributes will be exported | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


