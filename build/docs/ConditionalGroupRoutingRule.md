---
title: ConditionalGroupRoutingRule
---
## ININ.PureCloudApi.Model.ConditionalGroupRoutingRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**DomainEntityRef**](DomainEntityRef.html) | The queue being evaluated for this rule.  For rule 1, this is always the current queue, so should not be specified. | [optional] |
| **Metric** | **string** | The queue metric being evaluated | [optional] |
| **Operator** | **string** | The operator that compares the actual value against the condition value | [optional] |
| **ConditionValue** | **double?** | The limit value, beyond which a rule evaluates as true | [optional] |
| **Groups** | [**List&lt;MemberGroup&gt;**](MemberGroup.html) | The group(s) to activate if the rule evaluates as true | [optional] |
| **WaitSeconds** | **int?** | The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified. | [optional] |
{: class="table table-striped"}


