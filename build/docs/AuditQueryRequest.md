---
title: AuditQueryRequest
---
## ININ.PureCloudApi.Model.AuditQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **ServiceName** | **string** | Name of the service to query audits for. | |
| **Filters** | [**List&lt;AuditQueryFilter&gt;**](AuditQueryFilter.html) | Additional filters for the query. | [optional] |
{: class="table table-striped"}


