# Copilot

## ININ.PureCloudApi.Model.Copilot

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Copilot is enabled. | [optional] |
| **LiveOnQueue** | **bool?** | Copilot is live on selected queue. | |
| **DefaultLanguage** | **string** | Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified. | |
| **KnowledgeAnswerConfig** | [**KnowledgeAnswerConfig**](KnowledgeAnswerConfig) | Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead. | [optional] |
| **SummaryGenerationConfig** | [**SummaryGenerationConfig**](SummaryGenerationConfig) | Copilot generated summary configuration. | [optional] |
| **WrapupCodePredictionConfig** | [**WrapupCodePredictionConfig**](WrapupCodePredictionConfig) | Copilot generated wrapup code prediction configuration. | [optional] |
| **AnswerGenerationConfig** | [**AnswerGenerationConfig**](AnswerGenerationConfig) | Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead. | [optional] |
| **NluEngineType** | **string** | Language understanding engine type. | [optional] |
| **NluConfig** | [**NluConfig**](NluConfig) | NLU configuration. | [optional] |
| **RuleEngineConfig** | [**RuleEngineConfig**](RuleEngineConfig) | Rule engine configuration. | [optional] |
| **AutoSearchConfig** | [**AutoSearchConfig**](AutoSearchConfig) | Auto search configuration. | [optional] |
| **ManualSearchConfig** | [**ManualSearchConfig**](ManualSearchConfig) | Manual Search configuration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
