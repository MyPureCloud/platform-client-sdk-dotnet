# CreateWebChatRequest

## ININ.PureCloudApi.Model.CreateWebChatRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The ID of the queue to use for routing the chat conversation. | |
| **Provider** | **string** | The name of the provider that is sourcing the web chat. | |
| **SkillIds** | **List&lt;string&gt;** | The list of skill ID&#39;s to use for routing. | [optional] |
| **LanguageId** | **string** | The ID of the langauge to use for routing. | [optional] |
| **Priority** | **long?** | The priority to assign to the conversation for routing. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | The list of attributes to associate with the customer participant. | [optional] |
| **CustomerName** | **string** | The name of the customer participating in the web chat. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
