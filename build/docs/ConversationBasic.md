---
title: ConversationBasic
---
## ININ.PureCloudApi.Model.ConversationBasic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **StartTime** | **DateTime?** | The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndTime** | **DateTime?** | The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Divisions** | [**List&lt;ConversationDivisionMembership&gt;**](ConversationDivisionMembership.html) | Identifiers of divisions associated with this conversation | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Participants** | [**List&lt;ParticipantBasic&gt;**](ParticipantBasic.html) |  | [optional] |
{: class="table table-striped"}


