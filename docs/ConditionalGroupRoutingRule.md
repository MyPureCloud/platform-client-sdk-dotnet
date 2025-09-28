# ConditionalGroupRoutingRule

## ININ.PureCloudApi.Model.ConditionalGroupRoutingRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | The queue being evaluated for this rule.  If null, the current queue will be used. | [optional] |
| **Metric** | **string** | The queue metric being evaluated | [optional] |
| **Operator** | **string** | The operator that compares the actual value against the condition value | [optional] |
| **ConditionValue** | **double?** | The limit value, beyond which a rule evaluates as true | [optional] |
| **Groups** | [**List&lt;MemberGroup&gt;**](MemberGroup) | The group(s) to activate if the rule evaluates as true | [optional] |
| **WaitSeconds** | **int?** | The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified. | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
