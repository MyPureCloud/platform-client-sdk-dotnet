# EvaluationAggregationQueryMe

## ININ.PureCloudApi.Model.EvaluationAggregationQueryMe

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **TimeZone** | **string** | Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | [optional] |
| **GroupBy** | **List&lt;string&gt;** | Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group. | [optional] |
| **Metrics** | **List&lt;string&gt;** | Behaves like a SQL SELECT clause. Only named metrics will be retrieved. | |
| **AlternateTimeDimension** | **string** | Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event. | [optional] |
| **ContextId** | **string** | Evaluation context Id | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_