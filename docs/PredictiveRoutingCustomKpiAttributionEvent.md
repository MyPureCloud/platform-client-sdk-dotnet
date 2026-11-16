# PredictiveRoutingCustomKpiAttributionEvent

## ININ.PureCloudApi.Model.PredictiveRoutingCustomKpiAttributionEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique UUID v4 used to identify each attribution event uniquely | |
| **EventDateTime** | **DateTime?** | The date and time at which the attributed business result was achieved, in UTC, formatted as an ISO-8601 string. For example, 2023-01-07T08:30:00.123Z. Use the time the business result actually occurred or was confirmed, not a later ingestion, synchronisation, reporting, or batch-processing time. When conversationId is supplied, this timestamp must fall within the conversation attribution window, or the event is rejected. This means eventDateTime must be no earlier than the conversation start time, and no later than the conversation end time plus the grace period for the conversation&#39;s media type (1 hour for voice, message and email). | |
| **ExternalContactId** | **string** | The id of the External Contact of the customer who was involved in the KPI attribution. If this field is populated, we will retrieve the relevant conversation internally - thus this field is not compatible with conversationId. You must chose to use either externalContactId or conversationId but not both on the same event. | [optional] |
| **ConversationId** | **string** | The id of the conversation. This field must be omitted if externalContactId is already populated on the event. | [optional] |
| **AgentId** | **string** | The id of the agent who achieved the KPI attribution that is getting the attribution. | [optional] |
| **KpiId** | **string** | The id of the relevant revenue KPI within the Genesys Platform - this id can be retrieved from the Revenue KPI Admin UI. | |
| **AssociatedValue** | **double?** | For Sales Conversion, Retention and Churn KPI type, the numeric value expected is \&quot;1\&quot;. For SalesValue KPI type, a numeric value representing the aggregated value of all KPI attributions achieved by an agent during a conversation, we do not allow multiple event uploads for the same conversationId and agentId pair. | |



_PureCloudPlatform.Client.V2 277.0.0_
