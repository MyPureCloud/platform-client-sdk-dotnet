# TimeOffRequestListItem

## ININ.PureCloudApi.Model.TimeOffRequestListItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **User** | [**UserReference**](UserReference) | The user that the time off request belongs to | |
| **IsFullDayRequest** | **bool?** | Whether this is a full day request (false means partial day) | |
| **MarkedAsRead** | **bool?** | Deprecated - Always returns true. | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category | |
| **Paid** | **bool?** | Whether this is a paid time off request | [optional] |
| **Status** | **string** | The status of this time off request | |
| **Substatus** | **string** | The substatus of this time off request | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests.  Will be not empty if isFullDayRequest &#x3D;&#x3D; false | |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone.  Will be not empty if isFullDayRequest &#x3D;&#x3D; true | |
| **DailyDurationMinutes** | **int?** | The daily duration of this time off request in minutes | |
| **DurationMinutes** | **List&lt;int?&gt;** | Daily durations for each day of this time off request in minutes | |
| **PayableMinutes** | **List&lt;int?&gt;** | Payable minutes for each day of this time off request | |
| **FullDayEarliestStartOffsetMinutes** | **List&lt;int?&gt;** | Earliest start offset in minutes for each full-day request date. Values may be null when time-off estimation is disabled or no estimate is available | |
| **FullDayLatestEndOffsetMinutes** | **List&lt;int?&gt;** | Latest end offset in minutes for each full-day request date. Values may be null when time-off estimation is disabled or no estimate is available | |
| **Notes** | **string** | Notes about the time off request | |
| **SubmittedBy** | [**UserReference**](UserReference) | The user who submitted this time off request. The id may be &#39;System&#39; if it was an automated process | |
| **SubmittedDate** | **DateTime?** | The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ReviewedBy** | [**UserReference**](UserReference) | The user who reviewed this time off request. The id may be &#39;System&#39; if it was an automated process | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SyncVersion** | **int?** | The sync version of this time off request for which the scheduled activity is associated | |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | The version metadata of the time off request | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
