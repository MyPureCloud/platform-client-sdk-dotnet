# ApiUsageRow

## ININ.PureCloudApi.Model.ApiUsageRow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ClientId** | **string** | Client Id associated with this query result | [optional] |
| **ClientName** | **string** | Client Name associated with this query result | [optional] |
| **OrganizationId** | **string** | Organization Id associated with this query result | [optional] |
| **UserId** | **string** | User Id associated with this query result | [optional] |
| **TemplateUri** | **string** | Template Uri associated with this query result | [optional] |
| **HttpMethod** | **string** | HTTP Method associated with this query result | [optional] |
| **Status200** | **long?** | Number of requests resulting in a 2xx HTTP status code | [optional] |
| **Status300** | **long?** | Number of requests resulting in a 3xx HTTP status code | [optional] |
| **Status400** | **long?** | Number of requests resulting in a 4xx HTTP status code | [optional] |
| **Status500** | **long?** | Number of requests resulting in a 5xx HTTP status code | [optional] |
| **Status429** | **long?** | Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400 | [optional] |
| **Requests** | **long?** | Total number of requests | [optional] |
| **Date** | **DateTime?** | Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
