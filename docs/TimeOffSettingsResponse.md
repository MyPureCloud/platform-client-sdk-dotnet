# TimeOffSettingsResponse

## ININ.PureCloudApi.Model.TimeOffSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SubmissionRangeEnforced** | **bool?** | Whether to enforce a submission range for agent time off requests | [optional] |
| **SubmissionRangeType** | **string** | The type of the submission range | [optional] |
| **SubmissionEarliestDaysFromNow** | **int?** | The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past | [optional] |
| **SubmissionLatestDaysFromNow** | **int?** | The latest number of days from now for which an agent can submit a time off request | [optional] |
| **SubmissionLatestDate** | **String** | The latest date for the time off request submission interpreted in the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
