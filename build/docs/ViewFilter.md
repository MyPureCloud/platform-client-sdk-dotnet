# ViewFilter

## ININ.PureCloudApi.Model.ViewFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaTypes** | **List&lt;string&gt;** | The media types are used to filter the view | [optional] |
| **QueueIds** | **List&lt;string&gt;** | The queue ids are used to filter the view | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The skill ids are used to filter the view | [optional] |
| **AssignedSkillIds** | **List&lt;string&gt;** | The assigned user skill ids are used to filter the view | [optional] |
| **SkillGroups** | **List&lt;string&gt;** | The skill groups used to filter the view | [optional] |
| **LanguageIds** | **List&lt;string&gt;** | The language ids are used to filter the view | [optional] |
| **AssignedLanguageIds** | **List&lt;string&gt;** | The assigned user language ids are used to filter the view | [optional] |
| **LanguageGroups** | **List&lt;string&gt;** | The language groups used to filter the view | [optional] |
| **Directions** | **List&lt;string&gt;** | The directions are used to filter the view | [optional] |
| **OriginatingDirections** | **List&lt;string&gt;** | The list of orginating directions used to filter the view | [optional] |
| **WrapUpCodes** | **List&lt;string&gt;** | The wrap up codes are used to filter the view | [optional] |
| **DnisList** | **List&lt;string&gt;** | The dnis list is used to filter the view | [optional] |
| **SessionDnisList** | **List&lt;string&gt;** | The list of session dnis used to filter the view | [optional] |
| **FilterQueuesByUserIds** | **List&lt;string&gt;** | The user ids are used to fetch associated queues for the view | [optional] |
| **FilterUsersByQueueIds** | **List&lt;string&gt;** | The queue ids are used to fetch associated users for the view | [optional] |
| **UserIds** | **List&lt;string&gt;** | The user ids are used to filter the view | [optional] |
| **ManagementUnitIds** | **List&lt;string&gt;** | The management unit ids are used to filter the view | [optional] |
| **AddressTos** | **List&lt;string&gt;** | The address To values are used to filter the view | [optional] |
| **AddressFroms** | **List&lt;string&gt;** | The address from values are used to filter the view | [optional] |
| **OutboundCampaignIds** | **List&lt;string&gt;** | The outbound campaign ids are used to filter the view | [optional] |
| **OutboundContactListIds** | **List&lt;string&gt;** | The outbound contact list ids are used to filter the view | [optional] |
| **ContactIds** | **List&lt;string&gt;** | The contact ids are used to filter the view | [optional] |
| **ExternalContactIds** | **List&lt;string&gt;** | The external contact ids are used to filter the view | [optional] |
| **ExternalOrgIds** | **List&lt;string&gt;** | The external org ids are used to filter the view | [optional] |
| **AniList** | **List&lt;string&gt;** | The ani list ids are used to filter the view | [optional] |
| **DurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The durations in milliseconds used to filter the view | [optional] |
| **AcdDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The acd durations in milliseconds used to filter the view | [optional] |
| **TalkDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The talk durations in milliseconds used to filter the view | [optional] |
| **AcwDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The acw durations in milliseconds used to filter the view | [optional] |
| **HandleDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The handle durations in milliseconds used to filter the view | [optional] |
| **HoldDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The hold durations in milliseconds used to filter the view | [optional] |
| **AbandonDurationsMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The abandon durations in milliseconds used to filter the view | [optional] |
| **EvaluationScore** | [**NumericRange**](NumericRange) | The evaluationScore is used to filter the view | [optional] |
| **EvaluationCriticalScore** | [**NumericRange**](NumericRange) | The evaluationCriticalScore is used to filter the view | [optional] |
| **EvaluationFormIds** | **List&lt;string&gt;** | The evaluation form ids are used to filter the view | [optional] |
| **EvaluatedAgentIds** | **List&lt;string&gt;** | The evaluated agent ids are used to filter the view | [optional] |
| **EvaluatorIds** | **List&lt;string&gt;** | The evaluator ids are used to filter the view | [optional] |
| **Transferred** | **bool?** | Indicates filtering for transfers | [optional] |
| **Abandoned** | **bool?** | Indicates filtering for abandons | [optional] |
| **Answered** | **bool?** | Indicates filtering for answered interactions | [optional] |
| **MessageTypes** | **List&lt;string&gt;** | The message media types used to filter the view | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | The divison Ids used to filter the view | [optional] |
| **SurveyFormIds** | **List&lt;string&gt;** | The survey form ids used to filter the view | [optional] |
| **SurveyTotalScore** | [**NumericRange**](NumericRange) | The survey total score used to filter the view | [optional] |
| **SurveyNpsScore** | [**NumericRange**](NumericRange) | The survey NPS score used to filter the view | [optional] |
| **Mos** | [**NumericRange**](NumericRange) | The desired range for mos values | [optional] |
| **SurveyQuestionGroupScore** | [**NumericRange**](NumericRange) | The survey question group score used to filter the view | [optional] |
| **SurveyPromoterScore** | [**NumericRange**](NumericRange) | The survey promoter score used to filter the view | [optional] |
| **SurveyFormContextIds** | **List&lt;string&gt;** | The list of survey form context ids used to filter the view | [optional] |
| **ConversationIds** | **List&lt;string&gt;** | The list of conversation ids used to filter the view | [optional] |
| **SipCallIds** | **List&lt;string&gt;** | The list of SIP call ids used to filter the view | [optional] |
| **IsEnded** | **bool?** | Indicates filtering for ended | [optional] |
| **IsSurveyed** | **bool?** | Indicates filtering for survey | [optional] |
| **SurveyScores** | [**List&lt;NumericRange&gt;**](NumericRange) | The list of survey score ranges used to filter the view | [optional] |
| **PromoterScores** | [**List&lt;NumericRange&gt;**](NumericRange) | The list of promoter score ranges used to filter the view | [optional] |
| **IsCampaign** | **bool?** | Indicates filtering for campaign | [optional] |
| **SurveyStatuses** | **List&lt;string&gt;** | The list of survey statuses used to filter the view | [optional] |
| **ConversationProperties** | [**ConversationProperties**](ConversationProperties) | A grouping of conversation level filters | [optional] |
| **IsBlindTransferred** | **bool?** | Indicates filtering for blind transferred | [optional] |
| **IsConsulted** | **bool?** | Indicates filtering for consulted | [optional] |
| **IsConsultTransferred** | **bool?** | Indicates filtering for consult transferred | [optional] |
| **RemoteParticipants** | **List&lt;string&gt;** | The list of remote participants used to filter the view | [optional] |
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
| **HasMedia** | **bool?** | Indicates filtering for presence of MMS media | [optional] |
| **RoleIds** | **List&lt;string&gt;** | The role Ids used to filter the view | [optional] |
| **ReportsTos** | **List&lt;string&gt;** | The report to user IDs used to filter the view | [optional] |
| **LocationIds** | **List&lt;string&gt;** | The location Ids used to filter the view | [optional] |
| **FlowOutTypes** | **List&lt;string&gt;** | A list of flow out types | [optional] |
| **ProviderList** | **List&lt;string&gt;** | A list of providers | [optional] |
| **CallbackNumberList** | **List&lt;string&gt;** | A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;]) | [optional] |
| **CallbackInterval** | **string** | An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **UsedRoutingTypes** | **List&lt;string&gt;** | A list of routing types used | [optional] |
| **RequestedRoutingTypes** | **List&lt;string&gt;** | A list of routing types requested | [optional] |
| **HasAgentAssistId** | **bool?** | Indicates filtering for agent assist id | [optional] |
| **Transcripts** | [**List&lt;Transcripts&gt;**](Transcripts) | A list of transcript contents requested | [optional] |
| **TranscriptLanguages** | **List&lt;string&gt;** | A list of transcript languages requested | [optional] |
| **ParticipantPurposes** | **List&lt;string&gt;** | A list of participant purpose requested | [optional] |
| **ShowFirstQueue** | **bool?** | Indicates filtering for first queue data | [optional] |
| **TeamIds** | **List&lt;string&gt;** | The team ids used to filter the view data | [optional] |
| **FilterUsersByTeamIds** | **List&lt;string&gt;** | The team ids are used to fetch associated users for the view | [optional] |
| **JourneyActionMapIds** | **List&lt;string&gt;** | The journey action map ids are used to fetch action maps for the associated view | [optional] |
| **JourneyOutcomeIds** | **List&lt;string&gt;** | The journey outcome ids are used to fetch outcomes for the associated view | [optional] |
| **JourneySegmentIds** | **List&lt;string&gt;** | The journey segment ids are used to fetch segments for the associated view | [optional] |
| **JourneyActionMapTypes** | **List&lt;string&gt;** | The journey action map types are used to filter action map data for the associated view | [optional] |
| **DevelopmentRoleList** | **List&lt;string&gt;** | The list of development roles used to filter agent development view | [optional] |
| **DevelopmentTypeList** | **List&lt;string&gt;** | The list of development types used to filter agent development view | [optional] |
| **DevelopmentStatusList** | **List&lt;string&gt;** | The list of development status used to filter agent development view | [optional] |
| **DevelopmentModuleIds** | **List&lt;string&gt;** | The list of development moduleIds used to filter agent development view | [optional] |
| **DevelopmentActivityOverdue** | **bool?** | Indicates filtering for development activities | [optional] |
| **CustomerSentimentScore** | [**NumericRange**](NumericRange) | The customer sentiment score used to filter the view | [optional] |
| **CustomerSentimentTrend** | [**NumericRange**](NumericRange) | The customer sentiment trend used to filter the view | [optional] |
| **FlowTransferTargets** | **List&lt;string&gt;** | The list of transfer targets used to filter flow data | [optional] |
| **DevelopmentName** | **string** | Filter for development name | [optional] |
| **TopicIds** | **List&lt;string&gt;** | Represents the topics detected in the transcript | [optional] |
| **ExternalTags** | **List&lt;string&gt;** | The list of external Tags used to filter conversation data | [optional] |
| **IsNotResponding** | **bool?** | Indicates filtering for not responding users | [optional] |
| **IsAuthenticated** | **bool?** | Indicates filtering for the authenticated chat | [optional] |
| **BotIds** | **List&lt;string&gt;** | The list of bot IDs used to filter bot views | [optional] |
| **BotVersions** | **List&lt;string&gt;** | The list of bot versions used to filter bot views | [optional] |
| **BotMessageTypes** | **List&lt;string&gt;** | The list of bot message types used to filter bot views | [optional] |
| **BotProviderList** | **List&lt;string&gt;** | The list of bot providers used to filter bot views | [optional] |
| **BotProductList** | **List&lt;string&gt;** | The list of bot products used to filter bot views | [optional] |
| **BotRecognitionFailureReasonList** | **List&lt;string&gt;** | The list of bot recognition failure reasons used to filter bot views | [optional] |
| **BotIntentList** | **List&lt;string&gt;** | The list of bot intents used to filter bot views | [optional] |
| **BotFinalIntentList** | **List&lt;string&gt;** | The list of bot final intents used to filter bot views | [optional] |
| **BotSlotList** | **List&lt;string&gt;** | The list of bot slots used to filter bot views | [optional] |
| **BotResultList** | **List&lt;string&gt;** | The list of bot results used to filter bot views | [optional] |
| **BlockedReasons** | **List&lt;string&gt;** | The list of blocked reason used to filter action map constraints views | [optional] |
| **IsRecorded** | **bool?** | Indicates filtering for recorded | [optional] |
| **HasEvaluation** | **bool?** | Indicates filtering for evaluation | [optional] |
| **HasScoredEvaluation** | **bool?** | Indicates filtering for scored evaluation | [optional] |
| **EmailDeliveryStatusList** | **List&lt;string&gt;** | The list of email delivery statuses used to filter views | [optional] |
| **IsAgentOwnedCallback** | **bool?** | Indicates filtering for agent owned callback interactions | [optional] |
| **AgentCallbackOwnerIds** | **List&lt;string&gt;** | The list of callback owners used to filter interactions | [optional] |
| **TranscriptTopics** | [**List&lt;TranscriptTopics&gt;**](TranscriptTopics) | The list of transcript topics requested in filter | [optional] |
| **JourneyFrequencyCapReasons** | **List&lt;string&gt;** | The list of frequency cap reasons to filter offer constraints | [optional] |
| **JourneyBlockingActionMapIds** | **List&lt;string&gt;** | The list of blocking action maps to filter offer constraints | [optional] |
| **JourneyActionTargetIds** | **List&lt;string&gt;** | The list of action targets to filter offer constraints | [optional] |
| **JourneyBlockingScheduleGroupIds** | **List&lt;string&gt;** | The list of blocking schedule groups to filter offer constraints | [optional] |
| **JourneyBlockingEmergencyScheduleGroupIds** | **List&lt;string&gt;** | The list of emergency schedule groups to filter offer constraints | [optional] |
| **JourneyUrlEqualConditions** | **List&lt;string&gt;** | The list of url equal conditions to filter offer constraints | [optional] |
| **JourneyUrlNotEqualConditions** | **List&lt;string&gt;** | The list of url not equal conditions to filter offer constraints | [optional] |
| **JourneyUrlStartsWithConditions** | **List&lt;string&gt;** | The list of url starts with conditions to filter offer constraints | [optional] |
| **JourneyUrlEndsWithConditions** | **List&lt;string&gt;** | The list of url ends with conditions to filter offer constraints | [optional] |
| **JourneyUrlContainsAnyConditions** | **List&lt;string&gt;** | The list of url contains any conditions to filter offer constraints | [optional] |
| **JourneyUrlNotContainsAnyConditions** | **List&lt;string&gt;** | The list of url not contains any conditions to filter offer constraints | [optional] |
| **JourneyUrlContainsAllConditions** | **List&lt;string&gt;** | The list of url contains all conditions to filter offer constraints | [optional] |
| **JourneyUrlNotContainsAllConditions** | **List&lt;string&gt;** | The list of url not contains all conditions to filter offer constraints | [optional] |
| **FlowMilestoneIds** | **List&lt;string&gt;** | The list of flow milestones to filter exports | [optional] |
| **IsAssessmentPassed** | **bool?** | Filter to indicate if Agent passed assessment or not | [optional] |
| **ConversationInitiators** | **List&lt;string&gt;** | The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation | [optional] |
| **HasCustomerParticipated** | **bool?** | Indicates if the customer has participated in an initiated conversation | [optional] |
| **IsAcdInteraction** | **bool?** | Filter to indicate if interaction was ACD or non-ACD | [optional] |
| **HasFax** | **bool?** | Filters to indicate if interaction has FAX | [optional] |
| **DataActionIds** | **List&lt;string&gt;** | The list of Data Action IDs  | [optional] |
| **ActionCategoryName** | **string** | Deprecated - Please use integrationIds instead | [optional] |
| **IntegrationIds** | **List&lt;string&gt;** | The list of integration IDs for Data Action | [optional] |
| **ResponseStatuses** | **List&lt;string&gt;** | The list of Response codes for Data Action | [optional] |
| **AvailableDashboard** | **string** | Filter to indicate the availability of the dashboard is public or private. | [optional] |
| **FavouriteDashboard** | **bool?** | Filter to indicate whether the dashboard is favorite or unfavorite. | [optional] |
| **MyDashboard** | **bool?** | Filter to indicate the dashboard owned by the user. | [optional] |
| **StationErrors** | **List&lt;string&gt;** | The list of agent errors that are related to station | [optional] |
| **CanonicalContactIds** | **List&lt;string&gt;** | The canonical contact ids are used to filter the view | [optional] |
| **AlertRuleIds** | **List&lt;string&gt;** | The list of Alert Rule IDs | [optional] |
| **EvaluationFormContextIds** | **List&lt;string&gt;** | The list of Evaluation Form Context IDs | [optional] |
| **EvaluationStatuses** | **List&lt;string&gt;** | The evaluation statuses that are used to filter the view | [optional] |
| **WorkbinIds** | **List&lt;string&gt;** | The list of Workbin IDs | [optional] |
| **WorktypeIds** | **List&lt;string&gt;** | The list of Worktype IDs | [optional] |
| **WorkitemIds** | **List&lt;string&gt;** | The list of Workitem IDs | [optional] |
| **WorkitemAssigneeIds** | **List&lt;string&gt;** | The list of Workitem Assignee IDs | [optional] |
| **WorkitemStatuses** | **List&lt;string&gt;** | The list of Workitem Statuses IDs | [optional] |
| **IsAnalyzedForSensitiveData** | **bool?** | Deprecated - Use hasPciData or hasPiiData instead. | [optional] |
| **HasSensitiveData** | **bool?** | Deprecated. Use hasPciData or hasPiiData instead. | [optional] |
| **HasPciData** | **bool?** | Filter to indicate the transcript contains Pci data. | [optional] |
| **HasPiiData** | **bool?** | Filter to indicate the transcript contains Pii data. | [optional] |
| **SubPath** | **string** | Filter for Sub Path | [optional] |
| **UserState** | **string** | The user supplied state value in the view | [optional] |
| **IsClearedByCustomer** | **bool?** | Filter to indicate if the customer cleared the conversation. | [optional] |
| **EvaluationAssigneeIds** | **List&lt;string&gt;** | The evaluation assignee ids that are used to filter the view. | [optional] |
| **EvaluationAssigned** | **bool?** | Filter to indicate that the user has no assigned evaluation. | [optional] |
| **AssistantIds** | **List&lt;string&gt;** | The assistant ids that are used to filter the view. | [optional] |
| **KnowledgeBaseIds** | **List&lt;string&gt;** | The knowledge base ids that are used to filter the view. | [optional] |
| **IsParked** | **bool?** | Filter to indicate if the interactions are parked. | [optional] |
| **AgentEmpathyScore** | [**NumericRange**](NumericRange) | The agentEmpathyScore is used to filter the view | [optional] |
| **SurveyTypes** | **List&lt;string&gt;** | The surveyTypes is used to filter the view | [optional] |
| **SurveyResponseStatuses** | **List&lt;string&gt;** | The list of Survey Response Status | [optional] |
| **BotFlowTypes** | **List&lt;string&gt;** | The botFlowTypes is used to filter the view | [optional] |
| **AgentTalkDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The agent talk durations in milliseconds used to filter the view | [optional] |
| **CustomerTalkDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The customer talk durations in milliseconds used to filter the view | [optional] |
| **OvertalkDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The overtalk durations in milliseconds used to filter the view | [optional] |
| **SilenceDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The silence durations in milliseconds used to filter the view | [optional] |
| **AcdDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The acd durations in milliseconds used to filter the view | [optional] |
| **IvrDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The ivr durations in milliseconds used to filter the view | [optional] |
| **OtherDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The other (hold/music) durations in milliseconds used to filter the view | [optional] |
| **AgentTalkPercentage** | [**NumericRange**](NumericRange) | The agent talk percentage used to filter the view | [optional] |
| **CustomerTalkPercentage** | [**NumericRange**](NumericRange) | The customer talk percentage used to filter the view | [optional] |
| **OvertalkPercentage** | [**NumericRange**](NumericRange) | The overtalk percentage used to filter the view | [optional] |
| **SilencePercentage** | [**NumericRange**](NumericRange) | The silence percentage used to filter the view | [optional] |
| **AcdPercentage** | [**NumericRange**](NumericRange) | The acd percentage used to filter the view | [optional] |
| **IvrPercentage** | [**NumericRange**](NumericRange) | The ivr percentage used to filter the view | [optional] |
| **OtherPercentage** | [**NumericRange**](NumericRange) | The other (hold/music percentage used to filter the view | [optional] |
| **OvertalkInstances** | [**NumericRange**](NumericRange) | The overtalk instance range used to filter the view | [optional] |
| **IsScreenRecorded** | **bool?** | Filter to indicate if the screen is recorded | [optional] |
| **ScreenMonitorUserIds** | **List&lt;string&gt;** | The list of Screen Monitor User Ids | [optional] |
| **DashboardState** | **string** | The state of dashboard being filtered | [optional] |
| **DashboardType** | **string** | The type of dashboard being filtered | [optional] |
| **DashboardAccessFilter** | **string** | The type of dashboard access being filtered | [optional] |
| **TranscriptDurationMilliseconds** | [**List&lt;NumericRange&gt;**](NumericRange) | The transcript durations in milliseconds used to filter the view | [optional] |
| **WorkitemsStatuses** | [**List&lt;WorkitemStatusFilter&gt;**](WorkitemStatusFilter) | The list of workitem status with worktype | [optional] |
| **SocialCountries** | **List&lt;string&gt;** | List of countries for social filtering | [optional] |
| **SocialLanguages** | **List&lt;string&gt;** | List of languages for social filtering | [optional] |
| **SocialChannels** | **List&lt;string&gt;** | List of channels for social filtering | [optional] |
| **SocialSentimentCategory** | **List&lt;string&gt;** | The sentiment of the social post | [optional] |
| **SocialTopicIds** | **List&lt;string&gt;** | The list of topicIds for social filtering | [optional] |
| **SocialIngestionRuleIds** | **List&lt;string&gt;** | The list of ingestion ruleIds for social filtering | [optional] |
| **SocialConversationCreated** | **bool?** | Filter to indicate if the post has created a conversation | [optional] |
| **SocialContentType** | **List&lt;string&gt;** | The list of content Type for social filtering | [optional] |
| **SocialKeywords** | [**List&lt;SocialKeyword&gt;**](SocialKeyword) | The list of keywords for social filtering | [optional] |
| **SocialPostEscalated** | **bool?** | Filter to indicate if the post is escalated | [optional] |
| **SocialClassifications** | **List&lt;string&gt;** | Indicates if a social message was public or private | [optional] |
| **FilterUsersByManagerIds** | **List&lt;string&gt;** | The manager ids used to fetch associated users for the view | [optional] |
| **SlideshowIds** | **List&lt;string&gt;** | List of Dashboard slideshowIds to be filtered | [optional] |
| **Conferenced** | **bool?** | Filter to indicate if the conversation has conference | [optional] |
| **Video** | **bool?** | Filter to indicate if the conversation has video | [optional] |
| **LinkedInteraction** | **bool?** | Filter to indicate if the conversation has linked interaction | [optional] |
| **RecommendationSources** | **List&lt;string&gt;** | List of recommendation sources for filtering recommendation details pane | [optional] |
| **EvaluationRole** | **string** | Sets the role when viewing agent evaluations | [optional] |
| **ComparisonQueueIds** | **List&lt;string&gt;** | The queue ids are used to for comparison to the primary queue filter in reporting | [optional] |
| **ViewMetrics** | **List&lt;string&gt;** | A list of metrics selected for the view | [optional] |
| **TimelineCategories** | **List&lt;string&gt;** | A list of timeline categories | [optional] |
| **Acw** | **bool?** | Filter to indicate for acw state | [optional] |
| **SegmentTypes** | **List&lt;string&gt;** | A list of filtered segment types | [optional] |
| **ProgramIds** | **List&lt;string&gt;** | A list of program ids for filtering | [optional] |
| **CategoryIds** | **List&lt;string&gt;** | A list of category ids for filtering | [optional] |
| **DeliveryPushed** | **bool?** | Filter to indicate if push notification is sent | [optional] |
| **SocialRatings** | **List&lt;float?&gt;** | A set of ratings for Google Business Profile | [optional] |
| **VirtualAgentIds** | **List&lt;string&gt;** | A list of virtual agent ids for filtering. | [optional] |
| **EmpathyScoreCategories** | **List&lt;string&gt;** | A set of Empathy Score Categories for filtering | [optional] |
| **SentimentScoreCategories** | **List&lt;string&gt;** | A set of Sentiment Score Categories  for filtering | [optional] |
| **SentimentTrendCategories** | **List&lt;string&gt;** | A set of Sentiment Trend Categories for filtering | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
