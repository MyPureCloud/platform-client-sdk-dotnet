---
title: Copilot
---
## ININ.PureCloudApi.Model.Copilot

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Copilot is enabled. | [optional] |
| **LiveOnQueue** | **bool?** | Copilot is live on selected queue. | |
| **DefaultLanguage** | **string** | Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified. | |
| **KnowledgeAnswerConfig** | [**KnowledgeAnswerConfig**](KnowledgeAnswerConfig.html) | Knowledge answer configuration. | [optional] |
| **SummaryGenerationConfig** | [**SummaryGenerationConfig**](SummaryGenerationConfig.html) | Copilot generated summary configuration. | [optional] |
| **WrapupCodePredictionConfig** | [**WrapupCodePredictionConfig**](WrapupCodePredictionConfig.html) | Copilot generated wrapup code prediction configuration. | [optional] |
| **AnswerGenerationConfig** | [**AnswerGenerationConfig**](AnswerGenerationConfig.html) | Answer generation configuration. | [optional] |
| **NluEngineType** | **string** | Language understanding engine type. | [optional] |
| **NluConfig** | [**NluConfig**](NluConfig.html) | NLU configuration. | [optional] |
| **RuleEngineConfig** | [**RuleEngineConfig**](RuleEngineConfig.html) | Rule engine configuration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


