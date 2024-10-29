# DialerRulesetConfigChangeDataActionConditionPredicate

## ININ.PureCloudApi.Model.DialerRulesetConfigChangeDataActionConditionPredicate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutputField** | **string** | The name of an output field from the data action&#39;s output to use for this condition | [optional] |
| **OutputOperator** | **string** | The operation with which to evaluate this condition | [optional] |
| **ComparisonValue** | **string** | The value to compare against for this condition | [optional] |
| **OutputFieldMissingResolution** | **bool?** | The result of this predicate if the requested output field is missing from the data action&#39;s result | [optional] |
| **Inverted** | **bool?** | If true, inverts the result of evaluating this Predicate. Default is false. | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
