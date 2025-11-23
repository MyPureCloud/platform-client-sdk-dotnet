# ChatConversation

## ININ.PureCloudApi.Model.ChatConversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Participants** | [**List&lt;ChatMediaParticipant&gt;**](ChatMediaParticipant) | The list of participants involved in the conversation. | [optional] |
| **OtherMediaUris** | **List&lt;string&gt;** | The list of other media channels involved in the conversation. | [optional] |
| **RecentTransfers** | [**List&lt;TransferResponse&gt;**](TransferResponse) | The list of the most recent 20 transfer commands applied to this conversation. | [optional] |
| **UtilizationLabelId** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **InactivityTimeout** | **DateTime?** | The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Divisions** | [**List&lt;ConversationDivisionMembership&gt;**](ConversationDivisionMembership) | Identifiers of divisions associated with this conversation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
