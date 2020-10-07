---
title: Participant
---
## ININ.PureCloudApi.Model.Participant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this conversation. | [optional] |
| **StartTime** | **DateTime?** | The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Name** | **string** | A human readable name identifying the participant. | [optional] |
| **UserUri** | **string** | If this participant represents a user, then this will be an URI that can be used to fetch the user. | [optional] |
| **UserId** | **string** | If this participant represents a user, then this will be the globally unique identifier for the user. | [optional] |
| **ExternalContactId** | **string** | If this participant represents an external contact, then this will be the globally unique identifier for the external contact. | [optional] |
| **ExternalOrganizationId** | **string** | If this participant represents an external org, then this will be the globally unique identifier for the external org. | [optional] |
| **QueueId** | **string** | If present, the queue id that the communication channel came in on. | [optional] |
| **GroupId** | **string** | If present, group of users the participant represents. | [optional] |
| **TeamId** | **string** | The team id that this participant is a member of when added to the conversation. | [optional] |
| **QueueName** | **string** | If present, the queue name that the communication channel came in on. | [optional] |
| **Purpose** | **string** | A well known string that specifies the purpose of this participant. | [optional] |
| **ParticipantType** | **string** | A well known string that specifies the type of this participant. | [optional] |
| **ConsultParticipantId** | **string** | If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred. | [optional] |
| **Address** | **string** | The address for the this participant. For a phone call this will be the ANI. | [optional] |
| **Ani** | **string** | The address for the this participant. For a phone call this will be the ANI. | [optional] |
| **AniName** | **string** | The ani-based name for this participant. | [optional] |
| **Dnis** | **string** | The address for the this participant. For a phone call this will be the ANI. | [optional] |
| **Locale** | **string** | An ISO 639 language code specifying the locale for this participant | [optional] |
| **WrapupRequired** | **bool?** | True iff this participant is required to enter wrapup for this conversation. | [optional] |
| **WrapupPrompt** | **string** | This field controls how the UI prompts the agent for a wrapup. | [optional] |
| **WrapupTimeoutMs** | **int?** | Specifies how long a timed ACW session will last. | [optional] |
| **WrapupSkipped** | **bool?** | The UI sets this field when the agent chooses to skip entering a wrapup for this participant. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup.html) | Call wrap up or disposition data. | [optional] |
| **ConversationRoutingData** | [**ConversationRoutingData**](ConversationRoutingData.html) | Information on how a communication should be routed to an agent. | [optional] |
| **AlertingTimeoutMs** | **int?** | Specifies how long the agent has to answer an interaction before being marked as not responding. | [optional] |
| **MonitoredParticipantId** | **string** | If this participant is a monitor, then this will be the id of the participant that is being monitored. | [optional] |
| **CoachedParticipantId** | **string** | If this participant is a coach, then this will be the id of the participant that is being coached. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | Additional participant attributes | [optional] |
| **Calls** | [**List&lt;Call&gt;**](Call.html) |  | [optional] |
| **Callbacks** | [**List&lt;Callback&gt;**](Callback.html) |  | [optional] |
| **Chats** | [**List&lt;ConversationChat&gt;**](ConversationChat.html) |  | [optional] |
| **Cobrowsesessions** | [**List&lt;Cobrowsesession&gt;**](Cobrowsesession.html) |  | [optional] |
| **Emails** | [**List&lt;Email&gt;**](Email.html) |  | [optional] |
| **Messages** | [**List&lt;Message&gt;**](Message.html) |  | [optional] |
| **Screenshares** | [**List&lt;Screenshare&gt;**](Screenshare.html) |  | [optional] |
| **SocialExpressions** | [**List&lt;SocialExpression&gt;**](SocialExpression.html) |  | [optional] |
| **Videos** | [**List&lt;Video&gt;**](Video.html) |  | [optional] |
| **Evaluations** | [**List&lt;Evaluation&gt;**](Evaluation.html) |  | [optional] |
| **ScreenRecordingState** | **string** | The current screen recording state for this participant. | [optional] |
| **FlaggedReason** | **string** | The reason specifying why participant flagged the conversation. | [optional] |
| **StartAcwTime** | **DateTime?** | The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndAcwTime** | **DateTime?** | The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


