# WaitlistPosition

## ININ.PureCloudApi.Model.WaitlistPosition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffRequest** | [**TimeOffRequestReference**](TimeOffRequestReference) | The time off request for this wait list position | [optional] |
| **TimeOffLimit** | [**TimeOffLimitReference**](TimeOffLimitReference) | The time off limit for which time off request is waitlisted | [optional] |
| **Date** | **String** | The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **_WaitlistPosition** | **int?** | The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
