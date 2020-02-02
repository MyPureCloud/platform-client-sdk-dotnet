---
title: AnalyticsConversation
---
## ININ.PureCloudApi.Model.AnalyticsConversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **ConversationStart** | **DateTime?** | Date/time the conversation started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConversationEnd** | **DateTime?** | Date/time the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MediaStatsMinConversationMos** | **double?** | The lowest estimated average MOS among all the audio streams belonging to this conversation | [optional] |
| **MediaStatsMinConversationRFactor** | **double?** | The lowest R-factor value among all of the audio streams belonging to this conversation | [optional] |
| **OriginatingDirection** | **string** | The original direction of the conversation | [optional] |
| **Evaluations** | [**List&lt;AnalyticsEvaluation&gt;**](AnalyticsEvaluation.html) | Evaluations tied to this conversation | [optional] |
| **Surveys** | [**List&lt;AnalyticsSurvey&gt;**](AnalyticsSurvey.html) | Surveys tied to this conversation | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Identifiers of divisions associated with this conversation | [optional] |
| **Participants** | [**List&lt;AnalyticsParticipant&gt;**](AnalyticsParticipant.html) | Participants in the conversation | [optional] |
{: class="table table-striped"}


