---
title: AuditMessage
---
## ININ.PureCloudApi.Model.AuditMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | AuditMessage ID. | |
| **User** | [**AuditUser**](AuditUser.html) |  | [optional] |
| **CorrelationId** | **string** | Correlation ID. | [optional] |
| **TransactionId** | **string** | Transaction ID. | [optional] |
| **TransactionInitiator** | **bool?** | Whether or not this audit can be considered the initiator of the transaction it is a part of. | [optional] |
| **Application** | **string** | The application through which the action of this AuditMessage was initiated. | [optional] |
| **ServiceName** | **string** | The name of the service which sent this AuditMessage. | |
| **Level** | **string** | The level of this audit. USER or SYSTEM. | |
| **Timestamp** | **string** | The time at which the action of this AuditMessage was initiated. | [optional] |
| **ReceivedTimestamp** | **string** | The time at which this AuditMessage was received. | |
| **Status** | **string** | The status of the action of this AuditMessage | |
| **ActionContext** | **string** | The context of a system-level action | [optional] |
| **Action** | **string** | A string representing the action that took place | [optional] |
| **Changes** | [**List&lt;Change&gt;**](Change.html) | Details about any changes that occurred in this audit | [optional] |
| **Entity** | [**AuditEntity**](AuditEntity.html) |  | [optional] |
| **ServiceContext** | [**ServiceContext**](ServiceContext.html) | The service-specific context associated with this AuditMessage. | [optional] |
{: class="table table-striped"}


