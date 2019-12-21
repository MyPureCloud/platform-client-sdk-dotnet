---
title: AuditQueryExecutionResultsResponse
---
## ININ.PureCloudApi.Model.AuditQueryExecutionResultsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the audit query execution request. | [optional] |
| **PageSize** | **int?** | Number of results in a page. | [optional] |
| **Cursor** | **string** | Optional cursor to indicate where to resume the results. | [optional] |
| **Entities** | [**List&lt;AuditLogMessage&gt;**](AuditLogMessage.html) | List of audit messages. | [optional] |
{: class="table table-striped"}


