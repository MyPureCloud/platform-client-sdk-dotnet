---
title: TimeOffRequest
---
## ININ.PureCloudApi.Model.TimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User.html) | The user associated with this TimeOffRequest | |
| **IsFullDayRequest** | **bool?** | Whether this is a full day request (false means partial day) | |
| **MarkedAsRead** | **bool?** | Whether this request has been marked as read by the agent | |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this TimeOffRequest | |
| **Status** | **string** | The administrative status of this TimeOffRequest | |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | The start date-times for partial day requests.  Required if isFullDayRequest == false | [optional] |
| **DailyDurationMinutes** | **int?** | The daily duration of this TimeOffRequest in minutes | |
| **Notes** | **string** | The notes as input by the one who entered the TimeOffRequest | [optional] |
| **SubmittedBy** | [**User**](User.html) | The user who submitted this TimeOffRequest | [optional] |
| **SubmittedDate** | **DateTime?** | The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReviewedBy** | [**User**](User.html) | The user who reviewed this TimeOffRequest | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**User**](User.html) | The user who last modified this TimeOffRequest | [optional] |
| **ModifiedDate** | **DateTime?** | The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | ISO-8601 date only with no timezones.  Should be interpreted in the Management Unit&#39;s configured time zone.  Required if isFullDayRequest == true | [optional] |
{: class="table table-striped"}


