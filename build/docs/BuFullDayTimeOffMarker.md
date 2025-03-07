# BuFullDayTimeOffMarker

## ININ.PureCloudApi.Model.BuFullDayTimeOffMarker

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BusinessUnitDate** | **String** | The date of the time off marker, interpreted in the business unit&#39;s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **LengthMinutes** | **int?** | The length of the time off marker in minutes | [optional] |
| **Description** | **string** | The description of the time off marker | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the time off marker | [optional] |
| **Paid** | **bool?** | Whether the time off marker is paid | [optional] |
| **PayableMinutes** | **int?** | Payable minutes for the time off marker | [optional] |
| **TimeOffRequestId** | **string** | The ID of the time off request | [optional] |
| **TimeOffRequestSyncVersion** | **int?** | The sync version of the full day time off request for which the scheduled activity is associated | [optional] |
| **Delete** | **bool?** | Set to &#39;true&#39; to delete this time off marker. Will always be null on responses, only has an effect on schedule update | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
