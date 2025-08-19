# V2QueueObservationObservation

## ININ.PureCloudApi.Model.V2QueueObservationObservation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ObservationDate** | **DateTime?** | The timestamp when the observation started | [optional] |
| **ConversationId** | **string** | Unique identifier of the conversation to which this observation belongs | [optional] |
| **SessionId** | **string** | Unique identifier of the user session associated with this observation | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** | Unique identifiers for skills requested for an interaction | [optional] |
| **RequestedLanguageId** | **string** | Unique identifier for the language requested for an interaction | [optional] |
| **RoutingPriority** | **long?** | Routing priority for the current interaction | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **UserId** | **string** | Unique identifier for the user | [optional] |
| **Direction** | **string** | The direction of the communication | [optional] |
| **ConvertedFrom** | **string** | Session media type that was converted from in case of a media type conversion | [optional] |
| **ConvertedTo** | **string** | Session media type that was converted to in case of a media type conversion | [optional] |
| **AddressFrom** | **string** | The address that initiated an action | [optional] |
| **AddressTo** | **string** | The address receiving an action | [optional] |
| **Ani** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **Dnis** | **string** | Dialed number identification service (number dialed by the calling party) | [optional] |
| **TeamId** | **string** | The team Id the user is a member of | [optional] |
| **ScoredAgents** | [**List&lt;V2QueueObservationScoredAgent&gt;**](V2QueueObservationScoredAgent) | Scored agents for this conversation | [optional] |
| **RequestedRoutings** | **List&lt;string&gt;** | All routing types for requested/attempted routing methods. | [optional] |
| **UsedRouting** | **string** | Complete routing method | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
