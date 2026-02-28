# TimeOffSettingsRequest

## ININ.PureCloudApi.Model.TimeOffSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SubmissionRangeEnforced** | **bool?** | Whether to enforce a submission range for agent time off requests | [optional] |
| **SubmissionRangeType** | **string** | The type of the submission range | [optional] |
| **SubmissionEarliestDaysFromNow** | **int?** | The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past | [optional] |
| **SubmissionLatestDaysFromNow** | **int?** | The latest number of days from now for which an agent can submit a time off request | [optional] |
| **SubmissionLatestDate** | [**ValueWrapperLocalDate**](ValueWrapperLocalDate) | The latest date for the time off request submission interpreted in the business unit time zone in yyyy-MM-dd format | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
