# KnowledgeSettingsResponse

## ININ.PureCloudApi.Model.KnowledgeSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Knowledge Setting Id. | [optional] |
| **Name** | **string** | Knowledge Setting Name. | [optional] |
| **Description** | **string** | Knowledge setting description. | [optional] |
| **Sources** | [**List&lt;V3SourceRef&gt;**](V3SourceRef) | Knowledge source information searched upon. | [optional] |
| **GenerationSetting** | [**KnowledgeGenerationSetting**](KnowledgeGenerationSetting) | Settings for answer generation. | [optional] |
| **Stateful** | **bool?** | Indicates if stateful search and generation is enabled for the knowledge setting. | [optional] |
| **DateCreated** | **DateTime?** | Knowledge setting created date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Knowledge setting last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who modified the knowledge setting. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
