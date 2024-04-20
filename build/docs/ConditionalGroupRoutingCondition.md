---
title: ConditionalGroupRoutingCondition
---
## ININ.PureCloudApi.Model.ConditionalGroupRoutingCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**DomainEntityRef**](DomainEntityRef.html) | The queue being evaluated for this rule.  If null, the current queue will be used. | [optional] |
| **Metric** | **string** | The queue metric being evaluated | [optional] |
| **Operator** | **string** | The operator that compares the actual value against the condition value | [optional] |
| **Value** | **double?** | The limit value, beyond which a rule evaluates as true | [optional] |
{: class="table table-striped"}


