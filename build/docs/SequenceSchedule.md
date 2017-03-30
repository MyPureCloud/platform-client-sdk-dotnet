---
title: SequenceSchedule
---
## ININ.PureCloudApi.Model.SequenceSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Intervals** | [**List&lt;ScheduleInterval&gt;**](ScheduleInterval.html) | a list of start and end times | |
| **TimeZone** | **string** | time zone identifier to be applied to the intervals; for example Africa/Abidjan | |
| **Sequence** | [**UriReference**](UriReference.html) | identifier of the sequence to be scheduled | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


