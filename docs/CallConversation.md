# CallConversation

## ININ.PureCloudApi.Model.CallConversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Participants** | [**List&lt;CallMediaParticipant&gt;**](CallMediaParticipant) | The list of participants involved in the conversation. | [optional] |
| **OtherMediaUris** | **List&lt;string&gt;** | The list of other media channels involved in the conversation. | [optional] |
| **RecentTransfers** | [**List&lt;TransferResponse&gt;**](TransferResponse) | The list of the most recent 20 transfer commands applied to this conversation. | [optional] |
| **UtilizationLabelId** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **MaxParticipants** | **int?** | If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference. | [optional] |
| **SecurePause** | **bool?** | True when the recording of this conversation is in secure pause status. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
