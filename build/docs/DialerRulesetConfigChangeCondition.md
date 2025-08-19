# DialerRulesetConfigChangeCondition

## ININ.PureCloudApi.Model.DialerRulesetConfigChangeCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DataAction** | [**DialerRulesetConfigChangeUriReference**](DialerRulesetConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Type** | **string** | The type of the condition | [optional] |
| **Inverted** | **bool?** | Indicates whether to evaluate for the opposite of the stated condition; default is false | [optional] |
| **AttributeName** | **string** | An attribute name associated with the condition (applies only to certain rule conditions) | [optional] |
| **Value** | **string** | A value associated with the condition | [optional] |
| **ValueType** | **string** | Determines the type of the value associated with the condition | [optional] |
| **Operator** | **string** | An operation type for condition evaluation | [optional] |
| **Codes** | **List&lt;string&gt;** | List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;) | [optional] |
| **PropertyType** | **string** | Determines the type of the property associated with the condition | [optional] |
| **Property** | **string** | A value associated with the property type of this condition | [optional] |
| **DataNotFoundResolution** | **bool?** | The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition. | [optional] |
| **ContactIdField** | **string** | The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition. | [optional] |
| **CallAnalysisResultField** | **string** | The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition. | [optional] |
| **AgentWrapupField** | **string** | The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition. | [optional] |
| **ContactColumnToDataActionFieldMappings** | [**List&lt;DialerRulesetConfigChangeContactColumnToDataActionFieldMapping&gt;**](DialerRulesetConfigChangeContactColumnToDataActionFieldMapping) | A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition. | [optional] |
| **Predicates** | [**List&lt;DialerRulesetConfigChangeDataActionConditionPredicate&gt;**](DialerRulesetConfigChangeDataActionConditionPredicate) | A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition. | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
