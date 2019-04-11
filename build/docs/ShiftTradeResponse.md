---
title: ShiftTradeResponse
---
## ININ.PureCloudApi.Model.ShiftTradeResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of this shift trade | [optional] |
| **WeekDate** | **DateTime?** | The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Schedule** | [**WeekScheduleReference**](WeekScheduleReference.html) | The ID of the associated schedule | [optional] |
| **State** | **string** | The state of this shift trade | [optional] |
| **InitiatingUser** | [**UserReference**](UserReference.html) | The user who initiated this trade | [optional] |
| **InitiatingShiftId** | **string** | The ID of the shift offered for trade by the initiating user | [optional] |
| **InitiatingShiftStart** | **DateTime?** | The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **InitiatingShiftEnd** | **DateTime?** | The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReceivingUser** | [**UserReference**](UserReference.html) | The user matching the trade, or if the state is not Matched, the user to whom the trade request was sent | [optional] |
| **ReceivingShiftId** | **string** | The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift | [optional] |
| **ReceivingShiftStart** | **DateTime?** | The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReceivingShiftEnd** | **DateTime?** | The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Expiration** | **DateTime?** | When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **OneSided** | **bool?** | Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return) | [optional] |
| **AcceptableIntervals** | **List&lt;string&gt;** |  | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference.html) | The user who reviewed this shift trade | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version data for this trade | [optional] |
{: class="table table-striped"}


