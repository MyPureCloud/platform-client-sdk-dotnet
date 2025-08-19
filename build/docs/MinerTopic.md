# MinerTopic

## ININ.PureCloudApi.Model.MinerTopic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Topic name. | [optional] |
| **Miner** | [**Miner**](Miner) | The miner to which the topic belongs. | [optional] |
| **ConversationCount** | **int?** | Number of conversations where a topic has occurred. | [optional] |
| **ConversationPercent** | **float?** | Percentage of conversations where a topic has occurred. | [optional] |
| **UtteranceCount** | **int?** | Number of unique utterances where a topic has occurred. | [optional] |
| **PhraseCount** | **int?** | Number of unique phrases (sub-utterances) where a topic has occurred. | [optional] |
| **Phrases** | [**List&lt;TopicPhrase&gt;**](TopicPhrase) | Phrases associated with a topic. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
