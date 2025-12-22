# ReportingExportJobRequest

## ININ.PureCloudApi.Model.ReportingExportJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The user supplied name of the export request | |
| **TimeZone** | **string** | The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | |
| **ExportFormat** | **string** | The requested format of the exported data | |
| **Interval** | **string** | The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Period** | **string** | The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | |
| **ViewType** | **string** | The type of view export job to be created | |
| **Filter** | [**ViewFilter**](ViewFilter) | Filters to apply to create the view | |
| **Read** | **bool?** | Indicates if the request has been marked as read | [optional] |
| **Locale** | **string** | The locale used for localization of the exported data, i.e. en-US, es | |
| **HasFormatDurations** | **bool?** | Indicates if durations are formatted in hh:mm:ss format instead of ms | [optional] |
| **HasSplitFilters** | **bool?** | Indicates if filters will be split in aggregate detail exports | [optional] |
| **ExcludeEmptyRows** | **bool?** | Excludes empty rows from the exports | [optional] |
| **HasSplitByMedia** | **bool?** | Indicates if media type will be split in aggregate detail exports | [optional] |
| **HasSummaryRow** | **bool?** | Indicates if summary row needs to be present in exports | [optional] |
| **CsvDelimiter** | **string** | The user supplied csv delimiter string value either of type &#39;comma&#39; or &#39;semicolon&#39; permitted for the export request | [optional] |
| **SelectedColumns** | [**List&lt;SelectedColumns&gt;**](SelectedColumns) | The list of ordered selected columns from the export view by the user | [optional] |
| **HasCustomParticipantAttributes** | **bool?** | Indicates if custom participant attributes will be exported | [optional] |
| **RecipientEmails** | **List&lt;string&gt;** | The list of email recipients for the exports | [optional] |
| **IncludeDurationFormatInHeader** | **bool?** | Indicates whether to include selected duration format to the column headers | [optional] |
| **DurationFormat** | **string** | Indicates the duration format for the exports | [optional] |
| **ChartColumns** | [**List&lt;ChartColumn&gt;**](ChartColumn) | The list of columns for which chart is going to be displayed in export | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
