# AnalyticsConversationWithoutAttributes

## ININ.PureCloudApi.Model.AnalyticsConversationWithoutAttributes

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConferenceStart** | **DateTime?** | The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationEnd** | **DateTime?** | The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **ConversationInitiator** | **string** | Indicates the participant purpose of the participant initiating a message conversation | [optional] |
| **ConversationStart** | **DateTime?** | The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CustomerParticipation** | **bool?** | Indicates a messaging conversation in which the customer participated by sending at least one message | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Identifier(s) of division(s) associated with a conversation | [optional] |
| **ExternalTag** | **string** | External tag for the conversation | [optional] |
| **KnowledgeBaseIds** | **List&lt;string&gt;** | The unique identifier(s) of the knowledge base(s) used | [optional] |
| **MediaStatsMinConversationMos** | **double?** | The lowest estimated average MOS among all the audio streams belonging to this conversation | [optional] |
| **MediaStatsMinConversationRFactor** | **double?** | The lowest R-factor value among all of the audio streams belonging to this conversation | [optional] |
| **OriginatingDirection** | **string** | The original direction of the conversation | [optional] |
| **SelfServed** | **bool?** | Indicates whether all flow sessions were self serviced | [optional] |
| **Evaluations** | [**List&lt;AnalyticsEvaluation&gt;**](AnalyticsEvaluation) | Evaluations associated with this conversation | [optional] |
| **Surveys** | [**List&lt;AnalyticsSurvey&gt;**](AnalyticsSurvey) | Surveys associated with this conversation | [optional] |
| **Resolutions** | [**List&lt;AnalyticsResolution&gt;**](AnalyticsResolution) | Resolutions associated with this conversation | [optional] |
| **Participants** | [**List&lt;AnalyticsParticipantWithoutAttributes&gt;**](AnalyticsParticipantWithoutAttributes) | Participants in the conversation | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
