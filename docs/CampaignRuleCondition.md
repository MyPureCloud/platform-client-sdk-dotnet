# CampaignRuleCondition

## ININ.PureCloudApi.Model.CampaignRuleCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Parameters** | [**CampaignRuleParameters**](CampaignRuleParameters) | The parameters for the CampaignRuleCondition. | |
| **ConditionType** | **string** | The type of condition to evaluate. | |
| **DateTimeParameters** | [**CampaignRuleDateTimeConditionParameters**](CampaignRuleDateTimeConditionParameters) | Parameters for conditions (timeOfDay, dayOfWeek, dayOfMonth, weekDayOfMonth and specificDate) | [optional] |
| **CampaignRunTimeSettings** | [**CampaignRuleCampaignRunTimeSettings**](CampaignRuleCampaignRunTimeSettings) | Settings for campaignRunTime conditions | [optional] |
| **CampaignWaitTimeSettings** | [**CampaignRuleCampaignWaitTimeSettings**](CampaignRuleCampaignWaitTimeSettings) | Settings for campaignWaitTime conditions | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
