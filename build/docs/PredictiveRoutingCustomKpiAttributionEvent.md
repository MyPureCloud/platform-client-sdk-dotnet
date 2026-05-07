# PredictiveRoutingCustomKpiAttributionEvent

## ININ.PureCloudApi.Model.PredictiveRoutingCustomKpiAttributionEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ExternalContactId** | **string** | The UUID of the external contact associated with this event | [optional] |
| **ConversationId** | **string** | The UUID of the conversation associated with this event | [optional] |
| **AgentId** | **string** | The UUID of the agent associated with this event | [optional] |
| **KpiId** | **string** | The UUID of the KPI associated with this event | |
| **AssociatedValue** | **double?** | The value associated with this outcome attribution | |



_PureCloudPlatform.Client.V2 263.0.0_
