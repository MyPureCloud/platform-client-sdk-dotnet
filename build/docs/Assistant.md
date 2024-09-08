---
title: Assistant
---
## ININ.PureCloudApi.Model.Assistant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the assistant that will assist the agent. | |
| **DateCreated** | **DateTime?** | Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the assistant. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The user who last modified the assistant. | [optional] |
| **GoogleDialogflowConfig** | [**GoogleDialogflowConfig**](GoogleDialogflowConfig.html) | Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions. | [optional] |
| **TranscriptionConfig** | [**TranscriptionConfig**](TranscriptionConfig.html) | Configuration for speech transcription used to assist the agent. | |
| **KnowledgeSuggestionConfig** | [**KnowledgeSuggestionConfig**](KnowledgeSuggestionConfig.html) | Configuration that defines how to produce knowledge suggestions. | |
| **State** | **string** | State of the assistant. | [optional] |
| **Copilot** | [**Copilot**](Copilot.html) | Agent copilot configuration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


