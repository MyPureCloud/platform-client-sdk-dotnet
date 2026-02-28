# AlternativeShiftNotification

## ININ.PureCloudApi.Model.AlternativeShiftNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **String** | The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Granularity** | **string** | The granularity of alternative shifts to be traded | |
| **NewState** | **string** | The new state of the alternative shift trade, null if there was no change | [optional] |
| **InitiatingUser** | [**UserReference**](UserReference) | The user who initiated the alternative shift trade | |
| **InitiatingShiftDate** | **DateTime?** | The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ReceivingUser** | [**UserReference**](UserReference) | The user on the receiving side of this alternative shift trade | [optional] |
| **ReceivingShiftDate** | **DateTime?** | The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
