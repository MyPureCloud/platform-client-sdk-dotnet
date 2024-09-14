# SuggestionContext

## ININ.PureCloudApi.Model.SuggestionContext

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | The queue used to assign the interaction to the user, if any. | [optional] |
| **MediaType** | **string** | The media type of the conversation in which the suggestion event was raised. | [optional] |
| **User** | [**UserReference**](UserReference) | The agent participant who received the raised suggestion, if any. | [optional] |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef) | The external contact of the end-user participant, if any. | [optional] |
| **Utterance** | [**Entity**](Entity) | The utterance in the voice conversation, after which the suggestion was raised, if any. | [optional] |
| **Message** | [**AddressableEntityRef**](AddressableEntityRef) | The message in the digital conversation, after which the suggestion was raised, if any. | [optional] |
| **QueryStatement** | **string** | The query statement used when generating the suggestion, if any. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
