# CampaignRuleSpecificDateParameters

## ININ.PureCloudApi.Model.CampaignRuleSpecificDateParameters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IncludeYear** | **bool?** | If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true.  | [optional] |
| **ThresholdValue** | **string** | The operand for the \&quot;equals\&quot;, \&quot;after\&quot; and \&quot;before\&quot; operators in yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false) format. | [optional] |
| **Interval** | [**CampaignRuleSpecificDateInterval**](CampaignRuleSpecificDateInterval) | The operand for the \&quot;between\&quot; operator | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
