# AuditQueryExecutionStatusResponse

## ININ.PureCloudApi.Model.AuditQueryExecutionStatusResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the audit query execution request. | [optional] |
| **State** | **string** | Status of the audit query execution request. | [optional] |
| **StartDate** | **DateTime?** | Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Interval** | **string** | Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **ServiceName** | **string** | Service name for the audit query. | [optional] |
| **Filters** | [**List&lt;AuditQueryFilter&gt;**](AuditQueryFilter) | Filters for the audit query. | [optional] |
| **Sort** | [**List&lt;AuditQuerySort&gt;**](AuditQuerySort) | Sort parameter for the audit query. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
