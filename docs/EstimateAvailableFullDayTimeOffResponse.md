# EstimateAvailableFullDayTimeOffResponse

## ININ.PureCloudApi.Model.EstimateAvailableFullDayTimeOffResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Date** | **String** | Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **DurationMinutes** | **int?** | An estimation of time off request length in minutes | |
| **PayableMinutes** | **int?** | An estimation of payable part of time off request in minutes | |
| **Flexible** | **bool?** | Whether there is flexibility for a user to choose different hours than the system estimated | |



_PureCloudPlatform.Client.V2 246.0.0_
