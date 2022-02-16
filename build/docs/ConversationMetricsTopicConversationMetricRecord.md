---
title: ConversationMetricsTopicConversationMetricRecord
---
## ININ.PureCloudApi.Model.ConversationMetricsTopicConversationMetricRecord

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | **string** | Metric name | [optional] |
| **MetricDate** | **DateTime?** | The date and time of metric creation | [optional] |
| **Value** | **int?** | Metric value | [optional] |
| **RecordId** | **string** | Record identifier | [optional] |
| **ActiveSkillIds** | **List&lt;string&gt;** | ID(s) of Skill(s) that are active on the conversation | [optional] |
| **AddressFrom** | **string** | The address that initiated an action | [optional] |
| **AddressTo** | **string** | The address receiving an action | [optional] |
| **AgentAssistantId** | **string** | Unique identifier of the active virtual agent assistant | [optional] |
| **AgentBullseyeRing** | **int?** | Bullseye ring of the targeted agent | [optional] |
| **AgentOwned** | **bool?** | Flag indicating an agent-owned callback | [optional] |
| **Ani** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **AssignerId** | **string** | ID of the user that manually assigned a conversation | [optional] |
| **Authenticated** | **bool?** | Flag that indicates that the identity of the customer has been asserted as verified by the provider. | [optional] |
| **ConversationId** | **string** | Unique identifier for the conversation | [optional] |
| **ConversationInitiator** | **string** | Indicates the participant purpose of the participant initiating a message conversation | [optional] |
| **ConvertedFrom** | **string** | Session media type that was converted from in case of a media type conversion | [optional] |
| **ConvertedTo** | **string** | Session media type that was converted to in case of a media type conversion | [optional] |
| **DeliveryStatus** | **string** | The email or SMS delivery status | [optional] |
| **DestinationAddresses** | **List&lt;string&gt;** | Destination address(es) of transfers or consults | [optional] |
| **Direction** | **string** | The direction of the communication | [optional] |
| **DisconnectType** | **string** | The session disconnect type | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Identifier(s) of division(s) associated with a conversation | [optional] |
| **Dnis** | **string** | Dialed number identification service (number dialed by the calling party) | [optional] |
| **EdgeId** | **string** | Unique identifier of the edge device | [optional] |
| **EligibleAgentCounts** | **List&lt;int?&gt;** | Number of eligible agents for each predictive routing attempt | [optional] |
| **ExtendedDeliveryStatus** | **string** | Extended email delivery status | [optional] |
| **ExternalContactId** | **string** | External contact identifier | [optional] |
| **ExternalMediaCount** | **int?** | Count of any media (images, files, etc) included on the external session | [optional] |
| **ExternalOrganizationId** | **string** | External organization identifier | [optional] |
| **ExternalTag** | **string** | External tag for the conversation | [optional] |
| **FirstQueue** | **bool?** | Marker that is set if the current queue is the first queue in a conversation | [optional] |
| **FlaggedReason** | **string** | Reason for which participant flagged conversation | [optional] |
| **FlowInType** | **string** | Type of flow in that occurred when entering ACD. | [optional] |
| **FlowOutType** | **string** | Type of flow out that occurred when emitting tFlowOut. | [optional] |
| **GroupId** | **string** | Unique identifier for a PureCloud group | [optional] |
| **InteractionType** | **string** | The interaction type (enterprise or contactCenter) | [optional] |
| **JourneyActionId** | **string** | Identifier of the journey action. | [optional] |
| **JourneyActionMapId** | **string** | Identifier of the journey action map that triggered the action. | [optional] |
| **JourneyActionMapVersion** | **int?** | Version of the journey action map that triggered the action. | [optional] |
| **JourneyCustomerId** | **string** | Primary identifier of the journey customer in the source where the activities originate from. | [optional] |
| **JourneyCustomerIdType** | **string** | Type of primary identifier of the journey customer (e.g. cookie). | [optional] |
| **JourneyCustomerSessionId** | **string** | Unique identifier of the journey session. | [optional] |
| **JourneyCustomerSessionIdType** | **string** | Type or category of journey sessions (e.g. web, ticket, delivery, atm). | [optional] |
| **KnowledgeBaseIds** | **List&lt;string&gt;** | The unique identifier(s) of the knowledge base(s) used | [optional] |
| **MediaCount** | **int?** | Count of any media (images, files, etc) included in this session | [optional] |
| **MediaType** | **string** | The session media type | [optional] |
| **MessageType** | **string** | Message type for messaging services. E.g.: sms, facebook, twitter, line | [optional] |
| **OriginatingDirection** | **string** | The original direction of the conversation | [optional] |
| **OutboundCampaignId** | **string** | (Dialer) Unique identifier of the outbound campaign | [optional] |
| **OutboundContactId** | **string** | (Dialer) Unique identifier of the contact | [optional] |
| **OutboundContactListId** | **string** | (Dialer) Unique identifier of the contact list that this contact belongs to | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **PeerId** | **string** | This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session. | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose | [optional] |
| **QueueId** | **string** | Queue identifier | [optional] |
| **Remote** | **string** | Name, phone number, or email address of the remote party. | [optional] |
| **RemovedSkillIds** | **List&lt;string&gt;** | ID(s) of Skill(s) that have been removed by bullseye routing | [optional] |
| **Reoffered** | **bool?** | Marker for an interaction that got reoffered to the same queue by an in-queue flow | [optional] |
| **RequestedLanguageId** | **string** | Unique identifier for the language requested for an interaction | [optional] |
| **RequestedRoutingSkillIds** | **List&lt;string&gt;** | Unique identifier(s) for skill(s) requested for an interaction | [optional] |
| **RequestedRoutings** | **List&lt;string&gt;** | Routing type(s) for requested/attempted routing methods. | [optional] |
| **RoomId** | **string** | Unique identifier for the room | [optional] |
| **RoutingPriority** | **int?** | Routing priority for the current interaction | [optional] |
| **RoutingRing** | **int?** | Routing ring for bullseye or preferred agent routing | [optional] |
| **SelectedAgentId** | **string** | Selected agent ID | [optional] |
| **SelectedAgentRank** | **int?** | Selected agent GPR rank | [optional] |
| **SelfServed** | **bool?** | Indicates whether all flow sessions were self serviced | [optional] |
| **SessionDnis** | **string** | Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred | [optional] |
| **SessionId** | **string** | The unique identifier of this session | [optional] |
| **StationId** | **string** | Unique identifier for a phone | [optional] |
| **TeamId** | **string** | The team ID the user is a member of | [optional] |
| **UsedRouting** | **string** | Complete routing method | [optional] |
| **UserId** | **string** | Unique identifier for the user | [optional] |
| **WaitingInteractionCounts** | **List&lt;int?&gt;** | Number of waiting interactions for each predictive routing attempt | [optional] |
| **WrapUpCode** | **string** | Wrap up code | [optional] |
| **ProposedAgents** | [**List&lt;ConversationMetricsTopicConversationProposedAgent&gt;**](ConversationMetricsTopicConversationProposedAgent.html) | Proposed agents | [optional] |
| **ScoredAgents** | [**List&lt;ConversationMetricsTopicConversationScoredAgent&gt;**](ConversationMetricsTopicConversationScoredAgent.html) | Scored agents | [optional] |
{: class="table table-striped"}


