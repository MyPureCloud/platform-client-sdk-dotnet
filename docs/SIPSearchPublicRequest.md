# SIPSearchPublicRequest

## ININ.PureCloudApi.Model.SIPSearchPublicRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CallId** | **string** | unique identification of the placed call | [optional] |
| **ToUser** | **string** | SIP user to who the call was placed | [optional] |
| **FromUser** | **string** | SIP user who placed the call | [optional] |
| **ConversationId** | **string** | Unique identification of the conversation | [optional] |
| **ParticipantId** | **string** | Unique identification of the participant | [optional] |
| **DateStart** | **DateTime?** | Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateEnd** | **DateTime?** | End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
