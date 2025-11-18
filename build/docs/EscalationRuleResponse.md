# EscalationRuleResponse

## ININ.PureCloudApi.Model.EscalationRuleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the escalation rule. | [optional] |
| **Name** | **string** | The name of the escalation rule. | [optional] |
| **MatchCriteria** | **string** | The criteria that defines when a social media message should be escalated. | |
| **Priority** | **int?** | The priority of the escalation rule. | [optional] |
| **DivisionId** | **string** | The ID of the division the social escalation rule belongs to. | |
| **Description** | **string** | A description of the social escalation rule. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The status of the escalation rule. | [optional] |
| **OpenEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for an open message escalation. | [optional] |
| **FacebookEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for a Facebook message escalation. | [optional] |
| **InstagramEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for an Instagram message escalation. | [optional] |
| **TwitterEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for a X (formerly Twitter) message escalation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
