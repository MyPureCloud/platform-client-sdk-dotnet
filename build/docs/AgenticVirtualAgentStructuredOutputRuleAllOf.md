# AgenticVirtualAgentStructuredOutputRuleAllOf

## ININ.PureCloudApi.Model.AgenticVirtualAgentStructuredOutputRuleAllOf

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Mapping** | **List&lt;Object&gt;** | Path into the tool output type this rule applies to. Each element is a field name (string) or an array index (integer). | |
| **Operator** | **string** | Operator to apply to the value at the mapped path. | |
| **Value** | **Object** | Value to compare against. May be a string, integer, number, boolean, or null. Not required for &#39;IsNull&#39;, &#39;IsNotNull&#39;, &#39;IsEmpty&#39;, or &#39;IsNotEmpty&#39; operators. | [optional] |



_PureCloudPlatform.Client.V2 274.0.0_
