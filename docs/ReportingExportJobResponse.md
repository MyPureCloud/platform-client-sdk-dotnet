# ReportingExportJobResponse

## ININ.PureCloudApi.Model.ReportingExportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **RunId** | **string** | The unique run id of the export schedule execute | |
| **Status** | **string** | The current status of the export request | |
| **TimeZone** | **string** | The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | |
| **ExportFormat** | **string** | The requested format of the exported data | |
| **Interval** | **string** | The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **DownloadUrl** | **string** | The url to download the request if it&#39;s status is completed | [optional] |
| **ViewType** | **string** | The type of view export job to be created | |
| **ExportErrorMessagesType** | **string** | The error message in case the export request failed | [optional] |
| **Period** | **string** | The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H | |
| **Filter** | [**ViewFilter**](ViewFilter) | Filters to apply to create the view | |
| **Read** | **bool?** | Indicates if the request has been marked as read | |
| **CreatedDateTime** | **DateTime?** | The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ModifiedDateTime** | **DateTime?** | The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Locale** | **string** | The locale use for localization of the exported data, i.e. en-us, es-mx   | |
| **PercentageComplete** | **double?** | The percentage of the job that has completed processing | |
| **HasFormatDurations** | **bool?** | Indicates if durations are formatted in hh:mm:ss format instead of ms | [optional] |
| **HasSplitFilters** | **bool?** | Indicates if filters will be split in aggregate detail exports | [optional] |
| **ExcludeEmptyRows** | **bool?** | Excludes empty rows from the exports | [optional] |
| **HasSplitByMedia** | **bool?** | Indicates if media type will be split in aggregate detail exports | [optional] |
| **HasSummaryRow** | **bool?** | Indicates if summary row needs to be present in exports | [optional] |
| **CsvDelimiter** | **string** | The user supplied csv delimiter string value either of type &#39;comma&#39; or &#39;semicolon&#39; permitted for the export request | [optional] |
| **SelectedColumns** | [**List&lt;SelectedColumns&gt;**](SelectedColumns) | The list of ordered selected columns from the export view by the user | [optional] |
| **HasCustomParticipantAttributes** | **bool?** | Indicates if custom participant attributes will be exported | [optional] |
| **RecipientEmails** | **List&lt;string&gt;** | The list of email recipients for the exports | [optional] |
| **EmailStatuses** | **Dictionary&lt;string, string&gt;** | The status of individual email addresses as a map | [optional] |
| **EmailErrorDescription** | **string** | The optional error message in case the export fail to email | [optional] |
| **IncludeDurationFormatInHeader** | **bool?** | Indicates whether to include selected duration format to the column headers | [optional] |
| **DurationFormat** | **string** | Indicates the duration format for the exports | [optional] |
| **ExportAllowedToRerun** | **bool?** | Indicates whether the export run is allowed to rerun | [optional] |
| **ChartColumns** | [**List&lt;ChartColumn&gt;**](ChartColumn) | The list of columns for which chart is going to be displayed in export | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
