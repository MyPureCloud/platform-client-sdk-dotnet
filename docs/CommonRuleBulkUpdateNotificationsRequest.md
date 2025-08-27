# CommonRuleBulkUpdateNotificationsRequest

## ININ.PureCloudApi.Model.CommonRuleBulkUpdateNotificationsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RuleIds** | **List&lt;string&gt;** | The user supplied rules ids to be updated | |
| **Properties** | [**ModifiableRuleProperties**](ModifiableRuleProperties) | The rule properties to be updated | [optional] |
| **TypesToAdd** | **List&lt;string&gt;** | Collection of alerting notification types to add for all entities in the rules | [optional] |
| **TypesToRemove** | **List&lt;string&gt;** | Collection of alerting notification types to remove for all entities in the rules | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
