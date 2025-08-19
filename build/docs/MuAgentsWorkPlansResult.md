# MuAgentsWorkPlansResult

## ININ.PureCloudApi.Model.MuAgentsWorkPlansResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Entities** | [**List&lt;AgentWorkPlans&gt;**](AgentWorkPlans) |  | [optional] |
| **ReferenceStartWeekDate** | **String** | The reference date in yyyy-MM-dd format rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **WorkPlanLookup** | [**Dictionary&lt;string, WorkPlanReference&gt;**](WorkPlanReference) | Map containing lookup values for agent work plans. The integer keys serves as lookup keys for effective work plan from workPlanLookupKeysPerWeek property | |



_PureCloudPlatform.Client.V2 239.1.0_
