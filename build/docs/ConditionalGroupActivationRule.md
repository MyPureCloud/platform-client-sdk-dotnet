# ConditionalGroupActivationRule

## ININ.PureCloudApi.Model.ConditionalGroupActivationRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Conditions** | [**List&lt;ConditionalGroupActivationCondition&gt;**](ConditionalGroupActivationCondition) | The list of conditions used in this rule | [optional] |
| **ConditionExpression** | **string** | A string expression that defines the relationships of conditions in this rule | [optional] |
| **Groups** | [**List&lt;MemberGroup&gt;**](MemberGroup) | The group(s) that this rule activates (if rule evaluates as true) or deactivates (if rule evaluates as false) | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
