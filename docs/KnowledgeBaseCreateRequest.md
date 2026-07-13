# KnowledgeBaseCreateRequest

## ININ.PureCloudApi.Model.KnowledgeBaseCreateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Knowledge base name | |
| **Description** | **string** | Knowledge base description | [optional] |
| **CoreLanguage** | **string** | Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with &#39;early preview&#39; language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy. | |
| **ContentSearchEnabled** | **bool?** | Flag that indicates the search on content is enabled for the knowledge base. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
