# OrganizationPublicApiUsage

## ININ.PureCloudApi.Model.OrganizationPublicApiUsage

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
| **OauthClient** | [**DomainEntityRef**](DomainEntityRef) | The id of the oauthClient that made the request(s). | [optional] |
| **User** | [**UserReference**](UserReference) | The id of the user who made the request(s). | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
