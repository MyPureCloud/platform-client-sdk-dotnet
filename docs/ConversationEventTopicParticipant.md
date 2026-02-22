# ConversationEventTopicParticipant

## ININ.PureCloudApi.Model.ConversationEventTopicParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this conversation. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this participant was connected to the conversation in the provider clock. | [optional] |
| **EndTime** | **DateTime?** | The timestamp when this participant disconnected from the conversation in the provider clock. | [optional] |
| **UserId** | **string** | If this participant represents a user, then this will be the globally unique identifier for the user. | [optional] |
| **ExternalContactId** | **string** | If this participant represents an external contact, then this will be the globally unique identifier for the external contact. | [optional] |
| **ExternalContactInitialDivisionId** | **string** | If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned. | [optional] |
| **ExternalOrganizationId** | **string** | If this participant represents an external org, then this will be the globally unique identifier for the external org. | [optional] |
| **Name** | **string** | A human readable name identifying the participant. | [optional] |
| **QueueId** | **string** | If present, the queue id that the communication channel came in on. | [optional] |
| **GroupId** | **string** | If present, the group id that the participant represents. | [optional] |
| **TeamId** | **string** | The team id that this participant is a member of when added to the conversation. | [optional] |
| **Purpose** | **string** | A well known string that specifies the purpose or type of this participant. | [optional] |
| **ConsultParticipantId** | **string** | If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred. | [optional] |
| **Address** | **string** | The address for the this participant. For a phone call this will be the ANI. | [optional] |
| **WrapupRequired** | **bool?** | True iff this participant is required to enter wrapup for this conversation. | [optional] |
| **WrapupExpected** | **bool?** | True when a participant is expected to enter a wrapup code once the call connects. | [optional] |
| **WrapupPrompt** | **string** | This field controls how the UI prompts the agent for a wrapup. | [optional] |
| **WrapupTimeoutMs** | **long?** | Specifies how long a timed ACW session will last. | [optional] |
| **Wrapup** | [**ConversationEventTopicWrapup**](ConversationEventTopicWrapup) |  | [optional] |
| **StartAcwTime** | **DateTime?** | The timestamp when this participant started after-call work. | [optional] |
| **EndAcwTime** | **DateTime?** | The timestamp when this participant ended after-call work. | [optional] |
| **ConversationRoutingData** | [**ConversationEventTopicConversationRoutingData**](ConversationEventTopicConversationRoutingData) |  | [optional] |
| **AlertingTimeoutMs** | **long?** | Specifies how long the agent has to answer an interaction before being marked as not responding. | [optional] |
| **MonitoredParticipantId** | **string** | If this participant is a monitor, then this will be the id of the participant that is being monitored. | [optional] |
| **CoachedParticipantId** | **string** | If this participant is a coach, then this will be the id of the participant that is being coached. | [optional] |
| **BargedParticipantId** | **string** | If this participant created a barge in conference, then this will be the id of the participant that is barged in. | [optional] |
| **MediaRoles** | **List&lt;string&gt;** | List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc. | [optional] |
| **ScreenRecordingState** | **string** | The current screen recording state for this participant. | [optional] |
| **FlaggedReason** | **string** | If this participant has flagged the conversation, the reason code given. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | Additional participant attributes | [optional] |
| **Calls** | [**List&lt;ConversationEventTopicCall&gt;**](ConversationEventTopicCall) |  | [optional] |
| **Callbacks** | [**List&lt;ConversationEventTopicCallback&gt;**](ConversationEventTopicCallback) |  | [optional] |
| **Chats** | [**List&lt;ConversationEventTopicChat&gt;**](ConversationEventTopicChat) |  | [optional] |
| **Cobrowsesessions** | [**List&lt;ConversationEventTopicCobrowse&gt;**](ConversationEventTopicCobrowse) |  | [optional] |
| **Emails** | [**List&lt;ConversationEventTopicEmail&gt;**](ConversationEventTopicEmail) |  | [optional] |
| **Messages** | [**List&lt;ConversationEventTopicMessage&gt;**](ConversationEventTopicMessage) |  | [optional] |
| **InternalMessages** | [**List&lt;ConversationEventTopicInternalMessage&gt;**](ConversationEventTopicInternalMessage) |  | [optional] |
| **ScreenMonitorings** | [**List&lt;ConversationEventTopicScreenMonitoring&gt;**](ConversationEventTopicScreenMonitoring) |  | [optional] |
| **Screenshares** | [**List&lt;ConversationEventTopicScreenShare&gt;**](ConversationEventTopicScreenShare) |  | [optional] |
| **SocialExpressions** | [**List&lt;ConversationEventTopicSocialExpression&gt;**](ConversationEventTopicSocialExpression) |  | [optional] |
| **Videos** | [**List&lt;ConversationEventTopicVideo&gt;**](ConversationEventTopicVideo) |  | [optional] |
| **Workflow** | [**ConversationEventTopicWorkflow**](ConversationEventTopicWorkflow) |  | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
