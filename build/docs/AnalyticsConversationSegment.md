# AnalyticsConversationSegment

## ININ.PureCloudApi.Model.AnalyticsConversationSegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AudioMuted** | **bool?** | Flag indicating if audio is muted or not (true/false) | [optional] |
| **Conference** | **bool?** | Indicates whether the segment was a conference | [optional] |
| **DestinationConversationId** | **string** | The unique identifier of a new conversation when a conversation is ended for a conference | [optional] |
| **DestinationSessionId** | **string** | The unique identifier of a new session when a session is ended for a conference | [optional] |
| **DisconnectType** | **string** | The session disconnect type | [optional] |
| **ErrorCode** | **string** | A code corresponding to the error that occurred | [optional] |
| **GroupId** | **string** | Unique identifier for a Genesys Cloud group | [optional] |
| **Q850ResponseCodes** | **List&lt;long?&gt;** | Q.850 response code(s) | [optional] |
| **QueueId** | **string** | Queue identifier | [optional] |
| **RequestedLanguageId** | **string** | Unique identifier for the language requested for an interaction | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** | Unique identifier(s) for skill(s) requested for an interaction | [optional] |
| **RequestedRoutingUserIds** | **List&lt;string&gt;** | Unique identifier(s) for agent(s) requested for an interaction | [optional] |
| **SegmentEnd** | **DateTime?** | The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SegmentStart** | **DateTime?** | The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SegmentType** | **string** | The activity that takes place in the segment, such as hold or interact | [optional] |
| **SipResponseCodes** | **List&lt;long?&gt;** | SIP response code(s) | [optional] |
| **SourceConversationId** | **string** | The unique identifier of the previous conversation when a new conversation is created for a conference | [optional] |
| **SourceSessionId** | **string** | The unique identifier of the previous session when a new session is created for a conference | [optional] |
| **Subject** | **string** | The subject for the initial email that started this conversation | [optional] |
| **VideoMuted** | **bool?** | Flag indicating if video is muted/paused or not (true/false) | [optional] |
| **WrapUpCode** | **string** | Wrap up code | [optional] |
| **WrapUpNote** | **string** | Note entered by an agent during after-call work | [optional] |
| **WrapUpTags** | **List&lt;string&gt;** | Tag(s) assigned during after-call work | [optional] |
| **ScoredAgents** | [**List&lt;AnalyticsScoredAgent&gt;**](AnalyticsScoredAgent) | Scored agents | [optional] |
| **Properties** | [**List&lt;AnalyticsProperty&gt;**](AnalyticsProperty) | Additional segment properties | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
