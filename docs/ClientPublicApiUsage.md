# ClientPublicApiUsage

## ININ.PureCloudApi.Model.ClientPublicApiUsage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Date** | **String** | The date of the usage. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Platform** | **string** | The platform the request(s) is/were made on. | [optional] |
| **HttpMethod** | **string** | The http method of the request(s) | [optional] |
| **TemplateUri** | **string** | The templateUri of the request(s). | [optional] |
| **RequestCount** | **long?** | The total number of requests. | [optional] |
| **Status200** | **long?** | The number of requests resulting in a 2xx HTTP status code. | [optional] |
| **Status300** | **long?** | The number of requests resulting in a 3xx HTTP status code. | [optional] |
| **Status400** | **long?** | The number of requests resulting in a 4xx HTTP status code. | [optional] |
| **Status429** | **long?** | The number of requests resulting in a 429 HTTP status code. | [optional] |
| **Status500** | **long?** | The number of requests resulting in a 5xx HTTP status code. | [optional] |
| **OrganizationId** | **string** | The organizationId that made the request. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
