---
title: AuditTopicAuditLogMessage
---
## ININ.PureCloudApi.Model.AuditTopicAuditLogMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **UserId** | **string** |  | [optional] |
| **UserHomeOrgId** | **string** |  | [optional] |
| **Username** | [**AuditTopicDomainEntityRef**](AuditTopicDomainEntityRef.html) |  | [optional] |
| **UserDisplay** | **string** |  | [optional] |
| **ClientId** | [**AuditTopicAddressableEntityRef**](AuditTopicAddressableEntityRef.html) |  | [optional] |
| **RemoteIp** | **List&lt;string&gt;** |  | [optional] |
| **ServiceName** | **string** |  | [optional] |
| **Level** | **string** |  | [optional] |
| **EventTime** | **DateTime?** |  | [optional] |
| **Message** | [**AuditTopicMessageInfo**](AuditTopicMessageInfo.html) |  | [optional] |
| **Action** | **string** |  | [optional] |
| **EntityType** | **string** |  | [optional] |
| **Entity** | [**AuditTopicDomainEntityRef**](AuditTopicDomainEntityRef.html) |  | [optional] |
| **PropertyChanges** | [**List&lt;AuditTopicPropertyChange&gt;**](AuditTopicPropertyChange.html) |  | [optional] |
| **Context** | **Dictionary&lt;string, string&gt;** |  | [optional] |
{: class="table table-striped"}


