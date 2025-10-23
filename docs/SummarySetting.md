# SummarySetting

## ININ.PureCloudApi.Model.SummarySetting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the summary setting. | |
| **Language** | **string** | Language of the generated summary, e.g. en-US, it-IT. | |
| **SummaryType** | **string** | Level of detail of the generated summary. | [optional] |
| **Format** | **string** | Format of the generated summary. | [optional] |
| **MaskPII** | [**SummarySettingPII**](SummarySettingPII) | Displaying PII in the generated summary. | [optional] |
| **ParticipantLabels** | [**SummarySettingParticipantLabels**](SummarySettingParticipantLabels) | How to refer to interaction participants in the generated summary. | [optional] |
| **PredefinedInsights** | **List&lt;string&gt;** | Set which insights to include in the generated summary by default. | [optional] |
| **CustomEntities** | [**List&lt;SummarySettingCustomEntity&gt;**](SummarySettingCustomEntity) | Custom entity definition. | [optional] |
| **SettingType** | **string** | Type of the summary setting. | [optional] |
| **Prompt** | **string** | Custom prompt of summary setting. | [optional] |
| **DateCreated** | **DateTime?** | The date and time the setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date and time the setting was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
