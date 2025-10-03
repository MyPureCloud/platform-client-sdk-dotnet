# TouchpointResponse

## ININ.PureCloudApi.Model.TouchpointResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationId** | **string** | ID of conversation. | [optional] |
| **AgentId** | **string** | ID of agent. | |
| **AssociatedValue** | **double?** | The value attributed to this touchpoint. | |
| **MediaType** | **string** | Media Type of the touchpoint; allowed values are Email, Message and Voice. | [optional] |
| **State** | **string** | Outcome Attribution Touchpoint status. | |
| **Message** | **string** | Additional information on the state of the touchpoint entity, populated when the touchpoint has an error. | [optional] |
| **CreatedDate** | **DateTime?** | Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
