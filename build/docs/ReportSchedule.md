---
title: ReportSchedule
---
## ININ.PureCloudApi.Model.ReportSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **QuartzCronExpression** | **string** | Quartz Cron Expression | |
| **NextFireTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Description** | **string** |  | [optional] |
| **TimeZone** | **string** |  | [optional] |
| **TimePeriod** | **string** |  | [optional] |
| **Interval** | **string** | Interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **ReportFormat** | **string** |  | [optional] |
| **Locale** | **string** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **ReportId** | **string** | Report ID | |
| **Parameters** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **LastRun** | [**ReportRunEntry**](ReportRunEntry.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


