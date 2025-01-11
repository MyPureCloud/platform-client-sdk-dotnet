# Condition

## ININ.PureCloudApi.Model.Condition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the condition. | [optional] |
| **Inverted** | **bool?** | If true, inverts the result of evaluating this Condition. Default is false. | [optional] |
| **AttributeName** | **string** | An attribute name associated with this Condition. Required for a contactAttributeCondition. | [optional] |
| **Value** | **string** | A value associated with this Condition. This could be text, a number, or a relative time. Not used for a DataActionCondition. | [optional] |
| **ValueType** | **string** | The type of the value associated with this Condition. Not used for a DataActionCondition. | [optional] |
| **Operator** | **string** | An operation with which to evaluate the Condition. Not used for a DataActionCondition. | [optional] |
| **Codes** | **List&lt;string&gt;** | List of wrap-up code identifiers. Required for a wrapupCondition. | [optional] |
| **Property** | **string** | A value associated with the property type of this Condition. Required for a contactPropertyCondition. | [optional] |
| **PropertyType** | **string** | The type of the property associated with this Condition. Required for a contactPropertyCondition. | [optional] |
| **DataAction** | [**DomainEntityRef**](DomainEntityRef) | The Data Action to use for this condition. Required for a dataActionCondition. | [optional] |
| **DataNotFoundResolution** | **bool?** | The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition. | [optional] |
| **ContactIdField** | **string** | The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition. | [optional] |
| **CallAnalysisResultField** | **string** | The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition. | [optional] |
| **AgentWrapupField** | **string** | The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition. | [optional] |
| **ContactColumnToDataActionFieldMappings** | [**List&lt;ContactColumnToDataActionFieldMapping&gt;**](ContactColumnToDataActionFieldMapping) | A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition. | [optional] |
| **Predicates** | [**List&lt;DataActionConditionPredicate&gt;**](DataActionConditionPredicate) | A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
