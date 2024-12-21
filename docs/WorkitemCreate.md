# WorkitemCreate

## ININ.PureCloudApi.Model.WorkitemCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Workitem. Valid length between 3 and 256 characters. | |
| **Priority** | **int?** | The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000. | [optional] |
| **DateDue** | **DateTime?** | The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpires** | **DateTime?** | The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DurationSeconds** | **int?** | The estimated duration in seconds to complete the Workitem. Maximum of 365 days. | [optional] |
| **Ttl** | **int?** | The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time. | [optional] |
| **StatusId** | **string** | The ID of the Status of the Workitem. | [optional] |
| **WorkbinId** | **string** | The ID of Workbin that contains the Workitem. | [optional] |
| **AutoStatusTransition** | **bool?** | Set it to false to disable auto status transition. By default, it is enabled. | [optional] |
| **Description** | **string** | The description of the Workitem. Maximum length of 512 characters. | [optional] |
| **TypeId** | **string** | The ID of the Worktype of the Workitem. | |
| **CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields defined in the schema referenced by the worktype of the workitem. | [optional] |
| **QueueId** | **string** | The ID of the Workitems queue. Must be a valid UUID. | [optional] |
| **AssigneeId** | **string** | The ID of the assignee of the Workitem. Must be a valid UUID. | [optional] |
| **LanguageId** | **string** | The ID of language of the Workitem. Must be a valid UUID. | [optional] |
| **ExternalContactId** | **string** | The ID of the external contact of the Workitem. Must be a valid UUID. | [optional] |
| **ExternalTag** | **string** | The external tag of the Workitem. | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The skill IDs of the Workitem. Must be valid UUIDs. | [optional] |
| **WrapupCode** | **string** | The ID of the wrapup. Must be a valid UUID. | [optional] |
| **UtilizationLabelId** | **string** | The ID of utilization label of the Workitem. Must be a valid UUID. | [optional] |
| **ScoredAgents** | [**List&lt;WorkitemScoredAgentRequest&gt;**](WorkitemScoredAgentRequest) | A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents. | [optional] |
| **PreferredAgentIds** | **List&lt;string&gt;** | The preferred agent IDs of the Workitem. Must be valid UUIDs. | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
