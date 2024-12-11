# DraftTopics

## ININ.PureCloudApi.Model.DraftTopics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id for a topic. | |
| **Name** | **string** | Topic name. | [optional] |
| **Miner** | [**Miner**](Miner) | The miner to which the topic belongs. | [optional] |
| **ConversationCount** | **int?** | Number of conversations where a topic has occurred. | [optional] |
| **ConversationPercent** | **float?** | Percentage of conversations where a topic has occurred. | [optional] |
| **UtteranceCount** | **int?** | Number of unique utterances where a topic has occurred. | [optional] |
| **PhraseCount** | **int?** | Number of unique phrases (sub-utterances) where a topic has occurred. | [optional] |
| **Phrases** | **List&lt;string&gt;** | The phrases that are extracted for a topic. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
