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



_PureCloudPlatform.Client.V2 243.0.0_
