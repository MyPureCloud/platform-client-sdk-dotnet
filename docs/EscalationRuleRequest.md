# EscalationRuleRequest

## ININ.PureCloudApi.Model.EscalationRuleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the escalation rule. | |
| **MatchCriteria** | **string** | The criteria that defines when a social media message should be escalated. | |
| **Priority** | **int?** | The priority of the escalation rule. The lower the number the higer the priority. Once a rule is matched others are skipped. | |
| **DivisionId** | **string** | The ID of the division the social escalation rule belongs to. | |
| **Description** | **string** | A description of the social escalation rule. | [optional] |
| **Status** | **string** | The status of the escalation rule. | [optional] |
| **OpenEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for an open social media message if the match criteria returns true. | [optional] |
| **FacebookEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for a Facebook social media message if the match criteria returns true. | [optional] |
| **InstagramEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for an Instagram social media message if the match criteria returns true. | [optional] |
| **TwitterEscalation** | [**EscalationTarget**](EscalationTarget) | The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true. | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
