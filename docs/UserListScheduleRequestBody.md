# UserListScheduleRequestBody

## ININ.PureCloudApi.Model.UserListScheduleRequestBody

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserIds** | **List&lt;string&gt;** | The user ids for which to fetch schedules | |
| **StartDate** | **DateTime?** | Beginning of the range of schedules to fetch, in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the range of schedules to fetch, in ISO-8601 format | |
| **LoadFullWeeks** | **bool?** | Whether to load the full week&#39;s schedule (for the requested users) of any week overlapping the start/end date query parameters, defaults to false | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
