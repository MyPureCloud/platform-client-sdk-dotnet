# AnalyticsSession

## ININ.PureCloudApi.Model.AnalyticsSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActiveSkillIds** | **List&lt;string&gt;** | ID(s) of Skill(s) that are active on the conversation | [optional] |
| **AcwSkipped** | **bool?** | Marker for an agent that skipped after call work | [optional] |
| **AddressFrom** | **string** | The address that initiated an action | [optional] |
| **AddressOther** | **string** | The email address for the participant on the other side of the email conversation | [optional] |
| **AddressSelf** | **string** | The email address for the participant on this side of the email conversation | [optional] |
| **AddressTo** | **string** | The address receiving an action | [optional] |
| **AgentAssistantId** | **string** | Unique identifier of the active virtual agent assistant | [optional] |
| **AgentBullseyeRing** | **int?** | Bullseye ring of the targeted agent | [optional] |
| **AgentOwned** | **bool?** | Flag indicating an agent-owned callback | [optional] |
| **Ani** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **AssignerId** | **string** | ID of the user that manually assigned a conversation | [optional] |
| **Authenticated** | **bool?** | Flag that indicates that the identity of the customer has been asserted as verified by the provider. | [optional] |
| **BargedParticipantId** | **string** | The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation) | [optional] |
| **Bcc** | **List&lt;string&gt;** | Blind carbon copy email address(es) | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | Callback phone number(s) | [optional] |
| **CallbackScheduledTime** | **DateTime?** | Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CallbackUserName** | **string** | The name of the user requesting a call back | [optional] |
| **Cc** | **List&lt;string&gt;** | Carbon copy email address(es) | [optional] |
| **Cleared** | **bool?** | Flag that indicates that the conversation has been cleared by the customer | [optional] |
| **CoachedParticipantId** | **string** | The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation) | [optional] |
| **CobrowseRole** | **string** | Describes side of the cobrowse (sharer or viewer) | [optional] |
| **CobrowseRoomId** | **string** | A unique identifier for a Genesys Cloud cobrowse room | [optional] |
| **DeliveryPushed** | **bool?** | Flag that indicates that the push delivery mechanism was used | [optional] |
| **DeliveryStatus** | **string** | The email or SMS delivery status | [optional] |
| **DeliveryStatusChangeDate** | **DateTime?** | Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DestinationAddresses** | **List&lt;string&gt;** | Destination address(es) of transfers or consults | [optional] |
| **DetectedSpeechEnd** | **DateTime?** | Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DetectedSpeechStart** | **DateTime?** | Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Direction** | **string** | The direction of the communication | [optional] |
| **DispositionAnalyzer** | **string** | (Dialer) Analyzer (for example speech.person) | [optional] |
| **DispositionName** | **string** | (Dialer) Result of the analysis (for example disposition.classification.callable.machine) | [optional] |
| **Dnis** | **string** | Dialed number identification service (number dialed by the calling party) | [optional] |
| **EdgeId** | **string** | Unique identifier of the edge device | [optional] |
| **EligibleAgentCounts** | **List&lt;int?&gt;** | Number of eligible agents for each predictive routing attempt | [optional] |
| **ExtendedDeliveryStatus** | **string** | Extended delivery status | [optional] |
| **FlowInType** | **string** | Type of flow in that occurred when entering ACD. | [optional] |
| **FlowOutType** | **string** | Type of flow out that occurred when emitting tFlowOut. | [optional] |
| **JourneyActionId** | **string** | Identifier of the journey action. | [optional] |
| **JourneyActionMapId** | **string** | Identifier of the journey action map that triggered the action. | [optional] |
| **JourneyActionMapVersion** | **int?** | Version of the journey action map that triggered the action. | [optional] |
| **JourneyCustomerId** | **string** | Primary identifier of the journey customer in the source where the activities originate from. | [optional] |
| **JourneyCustomerIdType** | **string** | Type of primary identifier of the journey customer (e.g. cookie). | [optional] |
| **JourneyCustomerSessionId** | **string** | Unique identifier of the journey session. | [optional] |
| **JourneyCustomerSessionIdType** | **string** | Type or category of journey sessions (e.g. web, ticket, delivery, atm). | [optional] |
| **MediaBridgeId** | **string** | Media bridge ID for the conference session consistent across all participants | [optional] |
| **MediaCount** | **int?** | Count of any media (images, files, etc) included in this session | [optional] |
| **MediaType** | **string** | The session media type | [optional] |
| **MessageType** | **string** | Message type for messaging services. E.g.: sms, facebook, twitter, line | [optional] |
| **MonitoredParticipantId** | **string** | The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation) | [optional] |
| **OutboundCampaignId** | **string** | (Dialer) Unique identifier of the outbound campaign | [optional] |
| **OutboundContactId** | **string** | (Dialer) Unique identifier of the contact | [optional] |
| **OutboundContactListId** | **string** | (Dialer) Unique identifier of the contact list that this contact belongs to | [optional] |
| **PeerId** | **string** | This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session. | [optional] |
| **ProtocolCallId** | **string** | The original voice protocol call ID, e.g. a SIP call ID | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **Recording** | **bool?** | Flag determining if an audio recording was started or not | [optional] |
| **Remote** | **string** | Name, phone number, or email address of the remote party. | [optional] |
| **RemoteNameDisplayable** | **string** | Unique identifier for the remote party | [optional] |
| **RemovedSkillIds** | **List&lt;string&gt;** | ID(s) of Skill(s) that have been removed by bullseye routing | [optional] |
| **RequestedRoutings** | **List&lt;string&gt;** | Routing type(s) for requested/attempted routing methods. | [optional] |
| **RoomId** | **string** | Unique identifier for the room | [optional] |
| **RoutingRing** | **int?** | Routing ring for bullseye or preferred agent routing | [optional] |
| **RoutingRule** | **string** | Routing rule for preferred, conditional and predictive routing type | [optional] |
| **RoutingRuleType** | **string** | Routing rule type | [optional] |
| **ScreenShareAddressSelf** | **string** | Direct screen share address | [optional] |
| **ScreenShareRoomId** | **string** | A unique identifier for a Genesys Cloud screen share room | [optional] |
| **ScriptId** | **string** | A unique identifier for a script | [optional] |
| **SelectedAgentId** | **string** | Selected agent ID | [optional] |
| **SelectedAgentRank** | **int?** | Selected agent GPR rank | [optional] |
| **SessionDnis** | **string** | Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred | [optional] |
| **SessionId** | **string** | The unique identifier of this session | [optional] |
| **SharingScreen** | **bool?** | Flag determining if screen share is started or not (true/false) | [optional] |
| **SkipEnabled** | **bool?** | (Dialer) Whether the agent can skip the dialer contact | [optional] |
| **TimeoutSeconds** | **int?** | The number of seconds before Genesys Cloud begins the call for a call back (0 disables automatic calling) | [optional] |
| **UsedRouting** | **string** | Complete routing method | [optional] |
| **VideoAddressSelf** | **string** | Direct Video address | [optional] |
| **VideoRoomId** | **string** | A unique identifier for a Genesys Cloud video room | [optional] |
| **WaitingInteractionCounts** | **List&lt;int?&gt;** | Number of waiting interactions for each predictive routing attempt | [optional] |
| **AgentGroups** | [**List&lt;AnalyticsAgentGroup&gt;**](AnalyticsAgentGroup) | Conditional group routing agent groups | [optional] |
| **ProposedAgents** | [**List&lt;AnalyticsProposedAgent&gt;**](AnalyticsProposedAgent) | Proposed agents | [optional] |
| **MediaEndpointStats** | [**List&lt;AnalyticsMediaEndpointStat&gt;**](AnalyticsMediaEndpointStat) | MediaEndpointStats associated with this session | [optional] |
| **Flow** | [**AnalyticsFlow**](AnalyticsFlow) | IVR flow execution associated with this session | [optional] |
| **Metrics** | [**List&lt;AnalyticsSessionMetric&gt;**](AnalyticsSessionMetric) | List of metrics for this session | [optional] |
| **Segments** | [**List&lt;AnalyticsConversationSegment&gt;**](AnalyticsConversationSegment) | List of segments for this session | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
