---
title: SuggestionContext
---
## ININ.PureCloudApi.Model.SuggestionContext

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef.html) | The queue used to assign the interaction to the user, if any. | [optional] |
| **MediaType** | **string** | The media type of the conversation in which the suggestion event was raised. | [optional] |
| **User** | [**UserReference**](UserReference.html) | The agent participant who received the raised suggestion, if any. | [optional] |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef.html) | The external contact of the end-user participant, if any. | [optional] |
| **Utterance** | [**Entity**](Entity.html) | The utterance in the voice conversation, after which the suggestion was raised, if any. | [optional] |
| **Message** | [**AddressableEntityRef**](AddressableEntityRef.html) | The message in the digital conversation, after which the suggestion was raised, if any. | [optional] |
| **QueryStatement** | **string** | The query statement used when generating the suggestion, if any. | [optional] |
{: class="table table-striped"}


