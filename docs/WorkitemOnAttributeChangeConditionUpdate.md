# WorkitemOnAttributeChangeConditionUpdate

## ININ.PureCloudApi.Model.WorkitemOnAttributeChangeConditionUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Attribute** | **string** | The name of the workitem attribute whose change will be evaluated as part of the rule. | |
| **NewValue** | **string** | The value the attribute&#39;s new value is compared against. Compared for equality unless an operator is supplied. Null matches the attribute having been cleared, on clearable attributes. | [optional] |
| **OldValue** | **string** | The value the attribute is transitioning from. Not permitted for the priority attribute. Omitted or null matches any previous value. | [optional] |
| **Operator** | **string** | How the attribute&#39;s new value is compared against newValue. Only supported for the priority attribute. | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
