# CobrowseConversation

## ININ.PureCloudApi.Model.CobrowseConversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Participants** | [**List&lt;CobrowseMediaParticipant&gt;**](CobrowseMediaParticipant) | The list of participants involved in the conversation. | [optional] |
| **OtherMediaUris** | **List&lt;string&gt;** | The list of other media channels involved in the conversation. | [optional] |
| **RecentTransfers** | [**List&lt;TransferResponse&gt;**](TransferResponse) | The list of the most recent 20 transfer commands applied to this conversation. | [optional] |
| **UtilizationLabelId** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
