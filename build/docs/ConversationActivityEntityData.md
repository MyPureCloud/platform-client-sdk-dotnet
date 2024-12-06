# ConversationActivityEntityData

## ININ.PureCloudApi.Model.ConversationActivityEntityData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActivityDate** | **DateTime?** | The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Metric** | **string** | Activity metric | [optional] |
| **ActiveRouting** | **string** | Active routing method | [optional] |
| **AddressFrom** | **string** | The address that initiated an action | [optional] |
| **AddressTo** | **string** | The address receiving an action | [optional] |
| **Ani** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **ConvertedFrom** | **string** | Session media type that was converted from in case of a media type conversion | [optional] |
| **ConvertedTo** | **string** | Session media type that was converted to in case of a media type conversion | [optional] |
| **Direction** | **string** | The direction of the communication | [optional] |
| **Dnis** | **string** | Dialed number identification service (number dialed by the calling party) | [optional] |
| **MediaType** | **string** | The session media type | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **QueueId** | **string** | Queue identifier | [optional] |
| **RequestedLanguageId** | **string** | Unique identifier for the language requested for an interaction | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** | Unique identifier(s) for skill(s) requested for an interaction | [optional] |
| **RequestedRoutings** | **List&lt;string&gt;** | Routing type(s) for requested/attempted routing methods. | [optional] |
| **RoutingPriority** | **long?** | Routing priority for the current interaction | [optional] |
| **SessionId** | **string** | The unique identifier of this session | [optional] |
| **TeamId** | **string** | The team ID the user is a member of | [optional] |
| **UsedRouting** | **string** | Complete routing method | [optional] |
| **UserId** | **string** | Unique identifier for the user | [optional] |
| **ScoredAgents** | [**List&lt;ConversationActivityScoredAgent&gt;**](ConversationActivityScoredAgent) | Scored agents | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
