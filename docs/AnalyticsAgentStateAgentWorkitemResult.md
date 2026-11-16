# AnalyticsAgentStateAgentWorkitemResult

## ININ.PureCloudApi.Model.AnalyticsAgentStateAgentWorkitemResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Workitem Id | [optional] |
| **QueueId** | **string** | The Id of the queue used for routing the workitem | [optional] |
| **DivisionId** | **string** | The Id of the division the workitem belongs to | [optional] |
| **TypeId** | **string** | The Id of the worktype of the workitem | [optional] |
| **WorkbinId** | **string** | The Id of the workbin the workitem is placed in | [optional] |
| **DateDue** | **DateTime?** | Due datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpires** | **DateTime?** | Expiry datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StatusId** | **string** | The Id of the current status of the workitem | [optional] |
| **StatusCategory** | **string** | The category of the current status of the workitem | [optional] |
| **DateStatusChanged** | **DateTime?** | Datetime the status of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Priority** | **int?** | Priority of the workitem | [optional] |
| **AssignmentState** | **string** | Assignment state of the workitem | [optional] |
| **DateAssignmentStateChanged** | **DateTime?** | Datetime the assignment state of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCreated** | **DateTime?** | Creation datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
