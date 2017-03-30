---
title: CreateCallRequest
---
## ININ.PureCloudApi.Model.CreateCallRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PhoneNumber** | **string** | The phone number to dial. | [optional] |
| **CallFromQueueId** | **string** | The queue ID to call on behalf of. | [optional] |
| **CallQueueId** | **string** | The queue ID to call. | [optional] |
| **CallUserId** | **string** | The user ID to call. | [optional] |
| **Priority** | **int?** | The priority to assign to this call (if calling a queue). | [optional] |
| **LanguageId** | **string** | The language skill ID to use for routing this call (if calling a queue). | [optional] |
| **RoutingSkillsIds** | **List&lt;string&gt;** | The skill ID&#39;s to use for routing this call (if calling a queue). | [optional] |
| **ConversationIds** | **List&lt;string&gt;** | The list of existing call conversations to merge into a new ad-hoc conference. | [optional] |
| **Participants** | [**List&lt;Destination&gt;**](Destination.html) | The list of participants to call to create a new ad-hoc conference. | [optional] |
{: class="table table-striped"}


