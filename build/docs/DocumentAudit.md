---
title: DocumentAudit
---
## ININ.PureCloudApi.Model.DocumentAudit

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**UriReference**](UriReference.html) |  | [optional] |
| **Workspace** | [**UriReference**](UriReference.html) |  | [optional] |
| **TransactionId** | **string** |  | [optional] |
| **TransactionInitiator** | **bool?** |  | [optional] |
| **Application** | **string** |  | [optional] |
| **ServiceName** | **string** |  | [optional] |
| **Level** | **string** |  | [optional] |
| **Timestamp** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Status** | **string** |  | [optional] |
| **ActionContext** | **string** |  | [optional] |
| **Action** | **string** |  | [optional] |
| **Entity** | [**AuditEntityReference**](AuditEntityReference.html) |  | [optional] |
| **Changes** | [**List&lt;AuditChange&gt;**](AuditChange.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


