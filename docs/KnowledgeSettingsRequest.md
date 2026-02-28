# KnowledgeSettingsRequest

## ININ.PureCloudApi.Model.KnowledgeSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Knowledge setting name. | |
| **Description** | **string** | Knowledge setting description. | [optional] |
| **Sources** | [**List&lt;V3SourceRef&gt;**](V3SourceRef) | Knowledge source information to search upon. | |
| **GenerationSetting** | [**KnowledgeGenerationSetting**](KnowledgeGenerationSetting) | Setting for answer generation. | [optional] |
| **Stateful** | **bool?** | Indicates if stateful search and generation is enabled for the knowledge setting. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
