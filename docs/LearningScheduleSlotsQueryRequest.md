# LearningScheduleSlotsQueryRequest

## ININ.PureCloudApi.Model.LearningScheduleSlotsQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Range of time to get slots for scheduling learning activities. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **LengthInMinutes** | **int?** | The duration of Learning Assignment to schedule in 15 minutes granularity | |
| **UserIds** | **List&lt;string&gt;** | The user IDs for which to fetch schedules. Must be only 1. | |
| **InterruptibleAssignmentId** | **string** | Assignment ID to exclude from consideration when determining blocked slots | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
