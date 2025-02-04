# BuAgentScheduleActivity

## ININ.PureCloudApi.Model.BuAgentScheduleActivity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthMinutes** | **int?** | The length of this activity in minutes | [optional] |
| **Description** | **string** | The description of this activity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this activity | [optional] |
| **Paid** | **bool?** | Whether this activity is paid | [optional] |
| **PayableMinutes** | **int?** | Payable minutes for this activity | [optional] |
| **TimeOffRequestId** | **string** | The ID of the time off request associated with this activity, if applicable | [optional] |
| **TimeOffRequestSyncVersion** | **int?** | The sync version of the partial day time off request for which the scheduled activity is associated, if applicable | [optional] |
| **ExternalActivityId** | **string** | The ID of the external activity associated with this activity, if applicable | [optional] |
| **ExternalActivityType** | **string** | The type of the external activity associated with this activity, if applicable | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
