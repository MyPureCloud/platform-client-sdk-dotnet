---
title: AuditRealtimeQueryRequest
---
## ININ.PureCloudApi.Model.AuditRealtimeQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ssZ/YYYY-MM-DDThh:mm:ssZ | |
| **ServiceName** | **string** | Name of the service to query audits for. | |
| **Filters** | [**List&lt;AuditQueryFilter&gt;**](AuditQueryFilter.html) | Additional filters for the query. | [optional] |
| **Sort** | [**List&lt;AuditQuerySort&gt;**](AuditQuerySort.html) | Sort parameter for the query. | [optional] |
| **PageNumber** | **int?** | Page number | [optional] |
| **PageSize** | **int?** | Page size | [optional] |
{: class="table table-striped"}


