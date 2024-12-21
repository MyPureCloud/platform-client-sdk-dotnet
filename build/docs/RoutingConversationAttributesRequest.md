# RoutingConversationAttributesRequest

## ININ.PureCloudApi.Model.RoutingConversationAttributesRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Priority** | **int?** | Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0. | [optional] |
| **SkillIds** | **List&lt;string&gt;** | Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. []. | [optional] |
| **LanguageId** | **string** | Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;. | [optional] |
| **LabelId** | **string** | Label requirement for the conversation.  To remove the label requirement (setting it to System Default Label), specify an empty string, i.e., \&quot;\&quot;. | [optional] |
| **RequestScoredAgents** | [**List&lt;RequestScoredAgent&gt;**](RequestScoredAgent) |  | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
