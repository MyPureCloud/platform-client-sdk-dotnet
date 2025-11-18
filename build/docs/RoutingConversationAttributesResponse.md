# RoutingConversationAttributesResponse

## ININ.PureCloudApi.Model.RoutingConversationAttributesResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Priority** | **int?** | Current priority value on in-queue conversation. Range:[-25000000, 25000000] | [optional] |
| **Skills** | [**List&lt;RoutingSkill&gt;**](RoutingSkill) | Current routing skills on in-queue conversation | [optional] |
| **Language** | [**Language**](Language) | Current language on in-queue conversation | [optional] |
| **Label** | [**UtilizationLabel**](UtilizationLabel) | Current label on in-queue conversation | [optional] |
| **ScoredAgents** | [**List&lt;ScoredAgent&gt;**](ScoredAgent) | Current scored agents on in-queue conversation | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
