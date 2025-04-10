# CreateCallRequest

## ININ.PureCloudApi.Model.CreateCallRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PhoneNumber** | **string** | The phone number to dial. | [optional] |
| **CallerId** | **string** | The caller id phone number for this outbound call. | [optional] |
| **CallerIdName** | **string** | The caller id name for this outbound call. | [optional] |
| **CallFromQueueId** | **string** | The queue ID to call on behalf of. | [optional] |
| **CallQueueId** | **string** | The queue ID to call. | [optional] |
| **CallUserId** | **string** | The user ID to call. | [optional] |
| **Priority** | **int?** | The priority to assign to this call (if calling a queue). | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | The list of attributes to associate with the customer participant. | [optional] |
| **LanguageId** | **string** | The language skill ID to use for routing this call (if calling a queue). | [optional] |
| **RoutingSkillsIds** | **List&lt;string&gt;** | The skill ID&#39;s to use for routing this call (if calling a queue). | [optional] |
| **ConversationIds** | **List&lt;string&gt;** | The list of existing call conversations to merge into a new ad-hoc conference. | [optional] |
| **Participants** | [**List&lt;Destination&gt;**](Destination) | The list of participants to call to create a new ad-hoc conference. | [optional] |
| **UuiData** | **string** | User to User Information (UUI) data managed by SIP session application. | [optional] |
| **ExternalContactId** | **string** | The external contact with which to associate the call. | [optional] |
| **Label** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
