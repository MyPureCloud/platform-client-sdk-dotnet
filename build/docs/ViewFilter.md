---
title: ViewFilter
---
## ININ.PureCloudApi.Model.ViewFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaTypes** | **List&lt;string&gt;** | The media types are used to filter the view | [optional] |
| **QueueIds** | **List&lt;string&gt;** | The queue ids are used to filter the view | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The skill ids are used to filter the view | [optional] |
| **SkillGroups** | **List&lt;string&gt;** | The skill groups used to filter the view | [optional] |
| **LanguageIds** | **List&lt;string&gt;** | The language ids are used to filter the view | [optional] |
| **LanguageGroups** | **List&lt;string&gt;** | The language groups used to filter the view | [optional] |
| **Directions** | **List&lt;string&gt;** | The directions are used to filter the view | [optional] |
| **OriginatingDirections** | **List&lt;string&gt;** | The list of orginating directions used to filter the view | [optional] |
| **WrapUpCodes** | **List&lt;string&gt;** | The wrap up codes are used to filter the view | [optional] |
| **DnisList** | **List&lt;string&gt;** | The dnis list is used to filter the view | [optional] |
| **SessionDnisList** | **List&lt;string&gt;** | The list of session dnis used to filter the view | [optional] |
| **FilterQueuesByUserIds** | **List&lt;string&gt;** | The user ids are used to fetch associated queues for the view | [optional] |
| **FilterUsersByQueueIds** | **List&lt;string&gt;** | The queue ids are used to fetch associated users for the view | [optional] |
| **UserIds** | **List&lt;string&gt;** | The user ids are used to filter the view | [optional] |
| **AddressTos** | **List&lt;string&gt;** | The address To values are used to filter the view | [optional] |
| **AddressFroms** | **List&lt;string&gt;** | The address from values are used to filter the view | [optional] |
| **OutboundCampaignIds** | **List&lt;string&gt;** | The outbound campaign ids are used to filter the view | [optional] |
| **OutboundContactListIds** | **List&lt;string&gt;** | The outbound contact list ids are used to filter the view | [optional] |
| **ContactIds** | **List&lt;string&gt;** | The contact ids are used to filter the view | [optional] |
| **ExternalContactIds** | **List&lt;string&gt;** | The external contact ids are used to filter the view | [optional] |
| **ExternalOrgIds** | **List&lt;string&gt;** | The external org ids are used to filter the view | [optional] |
| **AniList** | **List&lt;string&gt;** | The ani list ids are used to filter the view | [optional] |
| **DurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The durations in milliseconds used to filter the view | [optional] |
| **AcdDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The acd durations in milliseconds used to filter the view | [optional] |
| **TalkDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The talk durations in milliseconds used to filter the view | [optional] |
| **AcwDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The acw durations in milliseconds used to filter the view | [optional] |
| **HandleDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The handle durations in milliseconds used to filter the view | [optional] |
| **HoldDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The hold durations in milliseconds used to filter the view | [optional] |
| **AbandonDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The abandon durations in milliseconds used to filter the view | [optional] |
| **EvaluationScore** | [**NumericRange**](NumericRange.html) | The evaluationScore is used to filter the view | [optional] |
| **EvaluationCriticalScore** | [**NumericRange**](NumericRange.html) | The evaluationCriticalScore is used to filter the view | [optional] |
| **EvaluationFormIds** | **List&lt;string&gt;** | The evaluation form ids are used to filter the view | [optional] |
| **EvaluatedAgentIds** | **List&lt;string&gt;** | The evaluated agent ids are used to filter the view | [optional] |
| **EvaluatorIds** | **List&lt;string&gt;** | The evaluator ids are used to filter the view | [optional] |
| **Transferred** | **bool?** | Indicates filtering for transfers | [optional] |
| **Abandoned** | **bool?** | Indicates filtering for abandons | [optional] |
| **MessageTypes** | **List&lt;string&gt;** | The message media types used to filter the view | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | The divison Ids used to filter the view | [optional] |
| **SurveyFormIds** | **List&lt;string&gt;** | The survey form ids used to filter the view | [optional] |
| **SurveyTotalScore** | [**NumericRange**](NumericRange.html) | The survey total score used to filter the view | [optional] |
| **SurveyNpsScore** | [**NumericRange**](NumericRange.html) | The survey NPS score used to filter the view | [optional] |
| **ShowSecondaryStatus** | **bool?** | Indicates if the Secondary Status should be shown | [optional] |
| **AgentDurationSortOrder** | **string** | Provides the agent duration sort order | [optional] |
| **WaitingDurationSortOrder** | **string** | Provides the waiting duration sort order | [optional] |
| **InteractingDurationSortOrder** | **string** | Provides the interacting duration sort order | [optional] |
| **AgentName** | **string** | Displays the Agent name as provided by the user | [optional] |
| **SkillsList** | **List&lt;string&gt;** | The list of skill strings as free form text | [optional] |
| **LanguageList** | **List&lt;string&gt;** | The list of language strings as free form text | [optional] |
| **Mos** | [**NumericRange**](NumericRange.html) | The desired range for mos values | [optional] |
| **SurveyQuestionGroupScore** | [**NumericRange**](NumericRange.html) | The survey question group score used to filter the view | [optional] |
| **SurveyPromoterScore** | [**NumericRange**](NumericRange.html) | The survey promoter score used to filter the view | [optional] |
| **SurveyFormContextIds** | **List&lt;string&gt;** | The list of survey form context ids used to filter the view | [optional] |
| **ConversationIds** | **List&lt;string&gt;** | The list of conversation ids used to filter the view | [optional] |
| **SipCallIds** | **List&lt;string&gt;** | The list of SIP call ids used to filter the view | [optional] |
| **IsEnded** | **bool?** | Indicates filtering for ended | [optional] |
| **IsSurveyed** | **bool?** | Indicates filtering for survey | [optional] |
| **SurveyScores** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The list of survey score ranges used to filter the view | [optional] |
| **PromoterScores** | [**List&lt;NumericRange&gt;**](NumericRange.html) | The list of promoter score ranges used to filter the view | [optional] |
| **IsCampaign** | **bool?** | Indicates filtering for campaign | [optional] |
| **SurveyStatuses** | **List&lt;string&gt;** | The list of survey statuses used to filter the view | [optional] |
| **ConversationProperties** | [**ConversationProperties**](ConversationProperties.html) | A grouping of conversation level filters | [optional] |
| **IsBlindTransferred** | **bool?** | Indicates filtering for blind transferred | [optional] |
| **IsConsulted** | **bool?** | Indicates filtering for consulted | [optional] |
| **IsConsultTransferred** | **bool?** | Indicates filtering for consult transferred | [optional] |
| **RemoteParticipants** | **List&lt;string&gt;** | The list of remote participants used to filter the view | [optional] |
| **StatusList** | **List&lt;string&gt;** | A list of status for the configuration view | [optional] |
| **FlowIds** | **List&lt;string&gt;** | The list of flow Ids | [optional] |
| **FlowOutcomeIds** | **List&lt;string&gt;** | A list of outcome ids of the flow | [optional] |
| **FlowOutcomeValues** | **List&lt;string&gt;** | A list of outcome values of the flow | [optional] |
| **FlowDestinationTypes** | **List&lt;string&gt;** | The list of destination types of the flow | [optional] |
| **FlowDisconnectReasons** | **List&lt;string&gt;** | The list of reasons for the flow to disconnect | [optional] |
| **FlowTypes** | **List&lt;string&gt;** | A list of types of the flow | [optional] |
| **FlowEntryTypes** | **List&lt;string&gt;** | A list of types of the flow entry | [optional] |
| **FlowEntryReasons** | **List&lt;string&gt;** | A list of reasons of flow entry | [optional] |
| **FlowVersions** | **List&lt;string&gt;** | A list of versions of a flow | [optional] |
| **GroupIds** | **List&lt;string&gt;** | A list of directory group ids | [optional] |
| **HasJourneyCustomerId** | **bool?** | Indicates filtering for journey customer id | [optional] |
| **HasJourneyActionMapId** | **bool?** | Indicates filtering for Journey action map id | [optional] |
| **HasJourneyVisitId** | **bool?** | Indicates filtering for Journey visit id | [optional] |
| **OauthClientIds** | **List&lt;string&gt;** | A list of OAuth client IDs | [optional] |
| **ApiOperations** | **List&lt;string&gt;** | A list of API operations (ex: [\&quot;GET /api/v2/users/{userId}/queues\&quot;]) | [optional] |
| **HasMedia** | **bool?** | Indicates filtering for presence of MMS media | [optional] |
| **RoleIds** | **List&lt;string&gt;** | The role Ids used to filter the view | [optional] |
| **ReportsTos** | **List&lt;string&gt;** | The report to user IDs used to filter the view | [optional] |
| **LocationIds** | **List&lt;string&gt;** | The location Ids used to filter the view | [optional] |
{: class="table table-striped"}


