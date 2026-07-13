# PatchCallbackRequest

## ININ.PureCloudApi.Model.PatchCallbackRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationId** | **string** | The conversationId. | |
| **QueueId** | **string** | The identifier of the queue to be used for the callback. | [optional] |
| **AgentId** | **string** | The agentId. | |
| **CallbackScheduledTime** | **DateTime?** | The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CountryCode** | **string** | The countryCode | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | The callbackNumbers | [optional] |
| **ValidateCallbackNumbers** | **bool?** | validateCallbackNumbers | [optional] |
| **CustomerFirstCallbackDeliveryMode** | **string** | How customer-first callback agent reservation is applied for this callback. useAgentReservation forces reservation on; noAgentReservation forces it off; useQueueSetting uses the queue configuration. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
