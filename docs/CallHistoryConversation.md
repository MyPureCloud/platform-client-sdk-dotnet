# CallHistoryConversation

## ININ.PureCloudApi.Model.CallHistoryConversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Participants** | [**List&lt;CallHistoryParticipant&gt;**](CallHistoryParticipant) | The list of participants involved in the conversation. | [optional] |
| **Direction** | **string** | The direction of the call relating to the current user | [optional] |
| **WentToVoicemail** | **bool?** | Did the call end in the current user&#39;s voicemail | [optional] |
| **MissedCall** | **bool?** | Did the user not answer this conversation | [optional] |
| **StartTime** | **DateTime?** | The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **WasConference** | **bool?** | Was this conversation a conference | [optional] |
| **WasCallback** | **bool?** | Was this conversation a callback | [optional] |
| **HadScreenShare** | **bool?** | Did this conversation have a screen share session | [optional] |
| **HadCobrowse** | **bool?** | Did this conversation have a cobrowse session | [optional] |
| **WasOutboundCampaign** | **bool?** | Was this conversation associated with an outbound campaign | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
