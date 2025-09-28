# QualityAuditQueryExecutionStatusResponse

## ININ.PureCloudApi.Model.QualityAuditQueryExecutionStatusResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the audit query execution request. | [optional] |
| **State** | **string** | Status of the audit query execution request. | [optional] |
| **DateStart** | **DateTime?** | Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Interval** | **string** | Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **Filters** | [**List&lt;QualityAuditQueryFilter&gt;**](QualityAuditQueryFilter) | Filters for the audit query. | [optional] |
| **Sort** | [**List&lt;AuditQuerySort&gt;**](AuditQuerySort) | Sort parameter for the audit query. | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
