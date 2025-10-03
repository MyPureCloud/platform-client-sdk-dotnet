# AuditTopicAuditLogMessage

## ININ.PureCloudApi.Model.AuditTopicAuditLogMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **UserId** | **string** |  | [optional] |
| **UserHomeOrgId** | **string** |  | [optional] |
| **Username** | [**AuditTopicDomainEntityRef**](AuditTopicDomainEntityRef) |  | [optional] |
| **UserDisplay** | **string** |  | [optional] |
| **ClientId** | [**AuditTopicAddressableEntityRef**](AuditTopicAddressableEntityRef) |  | [optional] |
| **RemoteIp** | **List&lt;string&gt;** |  | [optional] |
| **ServiceName** | **string** |  | [optional] |
| **Level** | **string** |  | [optional] |
| **EventTime** | **DateTime?** |  | [optional] |
| **Message** | [**AuditTopicMessageInfo**](AuditTopicMessageInfo) |  | [optional] |
| **Action** | **string** |  | [optional] |
| **EntityType** | **string** |  | [optional] |
| **Entity** | [**AuditTopicDomainEntityRef**](AuditTopicDomainEntityRef) |  | [optional] |
| **PropertyChanges** | [**List&lt;AuditTopicPropertyChange&gt;**](AuditTopicPropertyChange) |  | [optional] |
| **Context** | **Dictionary&lt;string, string&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
