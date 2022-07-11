---
title: TimeOffRequest
---
## ININ.PureCloudApi.Model.TimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the time off request | |
| **User** | [**UserReference**](UserReference.html) | The user that the time off request belongs to | |
| **IsFullDayRequest** | **bool?** | Whether this is a full day request (false means partial day) | [optional] |
| **MarkedAsRead** | **bool?** | Whether this request has been marked as read by the agent | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category | [optional] |
| **Paid** | **bool?** | Whether this is a paid time off request | [optional] |
| **Status** | **string** | The status of this time off request | [optional] |
| **Substatus** | **string** | The substatus of this time off request | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true | [optional] |
| **DailyDurationMinutes** | **int?** | The daily duration of this time off request in minutes | [optional] |
| **Notes** | **string** | Notes about the time off request | [optional] |
| **SubmittedBy** | [**UserReference**](UserReference.html) | The user who submitted this time off request | [optional] |
| **SubmittedDate** | **DateTime?** | The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference.html) | The user who reviewed this time off request | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | The version metadata of the time off request | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


