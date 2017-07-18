---
title: ScheduleGroup
---
## ININ.PureCloudApi.Model.ScheduleGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **TimeZone** | **string** | The timezone the schedules are a part of.  This is not a schedule property to allow a schedule to be used in multiple timezones. | [optional] |
| **OpenSchedules** | [**List&lt;UriReference&gt;**](UriReference.html) | The schedules defining the hours an organization is open. | [optional] |
| **ClosedSchedules** | [**List&lt;UriReference&gt;**](UriReference.html) | The schedules defining the hours an organization is closed. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


