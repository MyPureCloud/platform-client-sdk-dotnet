# CampaignRuleDayOfMonthParameters

## ININ.PureCloudApi.Model.CampaignRuleDayOfMonthParameters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ThresholdValue** | **string** | The operand for the \&quot;before\&quot; and \&quot;after\&quot; operators, can be either exact day (1-31) or \&quot;LAST_DAY\&quot; | [optional] |
| **InSet** | **List&lt;string&gt;** | The operand for the \&quot;in\&quot; operator, each element can be either exact day (1,31) or \&quot;LAST_DAY\&quot;, \&quot;EVEN_DAY\&quot;, \&quot;ODD_DAY\&quot; | [optional] |
| **Interval** | [**CampaignRuleDayOfMonthInterval**](CampaignRuleDayOfMonthInterval) | The interval operand for the \&quot;between\&quot; operator | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
