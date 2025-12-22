# Conversation

## ININ.PureCloudApi.Model.Conversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ExternalTag** | **string** | The external tag associated with the conversation. | [optional] |
| **StartTime** | **DateTime?** | The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndTime** | **DateTime?** | The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Address** | **string** | The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound. | [optional] |
| **Participants** | [**List&lt;Participant&gt;**](Participant) | The list of all participants in the conversation. | |
| **ConversationIds** | **List&lt;string&gt;** | A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference. | [optional] |
| **MaxParticipants** | **int?** | If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference. | [optional] |
| **RecordingState** | **string** | On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording. | [optional] |
| **State** | **string** | On update, &#39;disconnected&#39; will disconnect the conversation. No other values are valid. When reading conversations, this field will never have a value present. | [optional] |
| **Divisions** | [**List&lt;ConversationDivisionMembership&gt;**](ConversationDivisionMembership) | Identifiers of divisions associated with this conversation | [optional] |
| **RecentTransfers** | [**List&lt;TransferResponse&gt;**](TransferResponse) | The list of the most recent 20 transfer commands applied to this conversation. | [optional] |
| **SecurePause** | **bool?** | True when the recording of this conversation is in secure pause status. | [optional] |
| **UtilizationLabelId** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **InactivityTimeout** | **DateTime?** | The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
