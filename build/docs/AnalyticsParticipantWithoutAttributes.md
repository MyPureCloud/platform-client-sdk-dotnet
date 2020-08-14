---
title: AnalyticsParticipantWithoutAttributes
---
## ININ.PureCloudApi.Model.AnalyticsParticipantWithoutAttributes

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ParticipantId** | **string** | Unique identifier for the participant | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **UserId** | **string** | If a user, then this will be the unique identifier for the user | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose | [optional] |
| **ExternalContactId** | **string** | External Contact Identifier | [optional] |
| **ExternalOrganizationId** | **string** | External Organization Identifier | [optional] |
| **FlaggedReason** | **string** | Reason for which participant flagged conversation | [optional] |
| **TeamId** | **string** | The team id the user is a member of | [optional] |
| **AgentAssistantIds** | **List&lt;string&gt;** | Unique identifiers of the active virtual agent assistants | [optional] |
| **Sessions** | [**List&lt;AnalyticsSession&gt;**](AnalyticsSession.html) | List of sessions associated to this participant | [optional] |
{: class="table table-striped"}


