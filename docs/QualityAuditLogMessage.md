# QualityAuditLogMessage

## ININ.PureCloudApi.Model.QualityAuditLogMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the audit message. | [optional] |
| **UserHomeOrgId** | **string** | Home Organization Id associated with this audit message. | [optional] |
| **UserTrusteeOrgId** | **string** | Trustee Organization Id if this audit message is from trustee access. | [optional] |
| **User** | [**DomainEntityRef**](DomainEntityRef) | User associated with this audit message. | [optional] |
| **Client** | [**AddressableEntityRef**](AddressableEntityRef) | Client associated with this audit message. | [optional] |
| **RemoteIps** | **List&lt;string&gt;** | List of IP addresses of systems that originated or handled the request. | [optional] |
| **ServiceName** | **string** | Name of the service that logged this audit message. | [optional] |
| **Level** | **string** | The level of this audit message. | [optional] |
| **Status** | **string** | The status of the action of this audit message. | [optional] |
| **EventDate** | **DateTime?** | Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MessageInfo** | [**MessageInfo**](MessageInfo) | Message describing the event being audited. | [optional] |
| **Action** | **string** | Action that took place. | [optional] |
| **Entity** | [**DomainEntityRef**](DomainEntityRef) | Entity that was impacted. | [optional] |
| **EntityType** | **string** | Type of the entity that was impacted. | [optional] |
| **PropertyChanges** | [**List&lt;PropertyChange&gt;**](PropertyChange) | List of properties that were changed and changes made to those properties. | [optional] |
| **Context** | **Dictionary&lt;string, string&gt;** | Additional context for this message. | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
