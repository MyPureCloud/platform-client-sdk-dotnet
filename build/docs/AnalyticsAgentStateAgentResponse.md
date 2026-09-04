# AnalyticsAgentStateAgentResponse

## ININ.PureCloudApi.Model.AnalyticsAgentStateAgentResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | User Id - only returned if division is covered by agentStateNames permission | [optional] |
| **DivisionId** | **string** | Division Id | [optional] |
| **UserName** | **string** | User name - only returned if division is covered by agentStateNames permission | [optional] |
| **ManagerId** | **string** | The user that this user reports to | [optional] |
| **SessionCount** | **int?** | The count of sessions | [optional] |
| **Sessions** | [**List&lt;AnalyticsAgentStateAgentSessionResult&gt;**](AnalyticsAgentStateAgentSessionResult) | List of sessions | [optional] |
| **SystemPresence** | **string** | The user&#39;s system presence | [optional] |
| **OrganizationPresenceId** | **string** | The identifier for the user&#39;s organization presence | [optional] |
| **PresenceDate** | **DateTime?** | The timestamp for when the user&#39;s presence began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RoutingStatus** | **string** | The user&#39;s routing status | [optional] |
| **RoutingStatusDate** | **DateTime?** | The timestamp for when the user&#39;s routing status began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IsOutOfOffice** | **bool?** | Whether the user is out of office | [optional] |
| **ManagementUnitId** | **string** | The id of the user&#39;s management unit | [optional] |
| **BusinessUnitId** | **string** | The id of the user&#39;s business unit | [optional] |
| **AdherenceState** | **string** | The user&#39;s adherence state | [optional] |
| **AdherenceImpact** | **string** | The user&#39;s adherence impact | [optional] |
| **AdherenceDate** | **DateTime?** | The timestamp for when the user&#39;s adherence state began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ScheduledActivityCodeId** | **string** | The id of the user&#39;s scheduled activity code | [optional] |
| **ScheduledActivityCategory** | **string** | The user&#39;s scheduled activity category | [optional] |
| **ActualActivityCategory** | **string** | The user&#39;s actual activity category | [optional] |



_PureCloudPlatform.Client.V2 272.0.0_
