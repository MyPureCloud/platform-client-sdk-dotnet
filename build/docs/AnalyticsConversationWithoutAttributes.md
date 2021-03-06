---
title: AnalyticsConversationWithoutAttributes
---
## ININ.PureCloudApi.Model.AnalyticsConversationWithoutAttributes

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationEnd** | **DateTime?** | The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **ConversationStart** | **DateTime?** | The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Identifier(s) of division(s) associated with a conversation | [optional] |
| **ExternalTag** | **string** | External tag for the conversation | [optional] |
| **MediaStatsMinConversationMos** | **double?** | The lowest estimated average MOS among all the audio streams belonging to this conversation | [optional] |
| **MediaStatsMinConversationRFactor** | **double?** | The lowest R-factor value among all of the audio streams belonging to this conversation | [optional] |
| **OriginatingDirection** | **string** | The original direction of the conversation | [optional] |
| **Evaluations** | [**List&lt;AnalyticsEvaluation&gt;**](AnalyticsEvaluation.html) | Evaluations associated with this conversation | [optional] |
| **Surveys** | [**List&lt;AnalyticsSurvey&gt;**](AnalyticsSurvey.html) | Surveys associated with this conversation | [optional] |
| **Resolutions** | [**List&lt;AnalyticsResolution&gt;**](AnalyticsResolution.html) | Resolutions associated with this conversation | [optional] |
| **Participants** | [**List&lt;AnalyticsParticipantWithoutAttributes&gt;**](AnalyticsParticipantWithoutAttributes.html) | Participants in the conversation | [optional] |
{: class="table table-striped"}


