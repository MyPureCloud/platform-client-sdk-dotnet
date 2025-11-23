# ConversationBasic

## ININ.PureCloudApi.Model.ConversationBasic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ExternalTag** | **string** | The external tag associated with the conversation. | [optional] |
| **StartTime** | **DateTime?** | The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndTime** | **DateTime?** | The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Divisions** | [**List&lt;ConversationDivisionMembership&gt;**](ConversationDivisionMembership) | Identifiers of divisions associated with this conversation | [optional] |
| **SecurePause** | **bool?** | True when the recording of this conversation is in secure pause status. | [optional] |
| **UtilizationLabelId** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **InactivityTimeout** | **DateTime?** | The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Participants** | [**List&lt;ParticipantBasic&gt;**](ParticipantBasic) |  | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
