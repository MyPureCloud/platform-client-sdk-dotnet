# ObservationValue

## ININ.PureCloudApi.Model.ObservationValue

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ObservationDate** | **DateTime?** | The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **SessionId** | **string** | The unique identifier of this session | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** | Unique identifier for a skill requested for an interaction | [optional] |
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
| **TeamId** | **string** | The team id the user is a member of | [optional] |
| **RequestedRoutings** | **List&lt;string&gt;** | All routing types for requested/attempted routing methods | [optional] |
| **UsedRouting** | **string** | Complete routing method | [optional] |
| **ScoredAgents** | [**List&lt;AnalyticsScoredAgent&gt;**](AnalyticsScoredAgent) |  | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
