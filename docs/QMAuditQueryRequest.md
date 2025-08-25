# QMAuditQueryRequest

## ININ.PureCloudApi.Model.QMAuditQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Filters** | [**List&lt;QualityAuditQueryFilter&gt;**](QualityAuditQueryFilter) | List of filters for the query. | |
| **Sort** | [**List&lt;AuditQuerySort&gt;**](AuditQuerySort) | Sort parameter for the query. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
