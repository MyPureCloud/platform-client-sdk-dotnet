# ApiUsageSimpleSearch

## ININ.PureCloudApi.Model.ApiUsageSimpleSearch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Metrics** | **List&lt;string&gt;** | Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *). | [optional] |
| **OauthClientNames** | **List&lt;string&gt;** | Behaves like a SQL WHERE with multiple IN operators. Specifies a list of OAuth client names to be queried. | [optional] |
| **HttpMethods** | **List&lt;string&gt;** | Behaves like a SQL WHERE with multiple IN operators. Specifies a list of HTTP methods to be queried. | [optional] |
| **TemplateUris** | **List&lt;string&gt;** | Behaves like a SQL WHERE with multiple IN operators. Specifies a list of Template Uris to be queried. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
