---
title: AuditLogMessage
---
## ININ.PureCloudApi.Model.AuditLogMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the audit message. | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef.html) | User associated with this audit message. | [optional] |
| **Client** | [**AddressableEntityRef**](AddressableEntityRef.html) | Client associated with this audit message. | [optional] |
| **RemoteIp** | **List&lt;string&gt;** | List of IP addresses of systems that originated or handled the request. | [optional] |
| **ServiceName** | **string** | Name of the service that logged this audit message. | [optional] |
| **EventDate** | **DateTime?** | Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Message** | [**MessageInfo**](MessageInfo.html) | Message describing the event being audited. | [optional] |
| **Action** | **string** | Action that took place. | [optional] |
| **Entity** | [**AddressableEntityRef**](AddressableEntityRef.html) | Entity that was impacted. | [optional] |
| **EntityType** | **string** | Type of the entity that was impacted. | [optional] |
| **PropertyChanges** | [**List&lt;PropertyChange&gt;**](PropertyChange.html) | List of properties that were changed and changes made to those properties. | [optional] |
| **Context** | **Dictionary&lt;string, string&gt;** | Additional context for this message. | [optional] |
{: class="table table-striped"}


