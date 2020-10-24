---
title: AnalyticsConversationSegment
---
## ININ.PureCloudApi.Model.AnalyticsConversationSegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SegmentStart** | **DateTime?** | The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SegmentEnd** | **DateTime?** | The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **QueueId** | **string** | Queue identifier | [optional] |
| **WrapUpCode** | **string** | Wrapup Code id | [optional] |
| **WrapUpNote** | **string** | Note entered by an agent during after-call work | [optional] |
| **WrapUpTags** | **List&lt;string&gt;** |  | [optional] |
| **ErrorCode** | **string** |  | [optional] |
| **DisconnectType** | **string** | A description of the event that disconnected the segment | [optional] |
| **SegmentType** | **string** | The activity taking place for the participant in the segment | [optional] |
| **RequestedRoutingUserIds** | **List&lt;string&gt;** |  | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** |  | [optional] |
| **RequestedLanguageId** | **string** | A unique identifier for the language requested for an interaction. | [optional] |
| **ScoredAgents** | [**List&lt;AnalyticsScoredAgent&gt;**](AnalyticsScoredAgent.html) |  | [optional] |
| **Properties** | [**List&lt;AnalyticsProperty&gt;**](AnalyticsProperty.html) |  | [optional] |
| **SourceConversationId** | **string** |  | [optional] |
| **DestinationConversationId** | **string** |  | [optional] |
| **SourceSessionId** | **string** |  | [optional] |
| **DestinationSessionId** | **string** |  | [optional] |
| **SipResponseCodes** | **List&lt;long?&gt;** |  | [optional] |
| **Q850ResponseCodes** | **List&lt;long?&gt;** |  | [optional] |
| **Conference** | **bool?** | Indicates whether the segment was a conference | [optional] |
| **GroupId** | **string** |  | [optional] |
| **Subject** | **string** |  | [optional] |
| **AudioMuted** | **bool?** |  | [optional] |
| **VideoMuted** | **bool?** |  | [optional] |
{: class="table table-striped"}


