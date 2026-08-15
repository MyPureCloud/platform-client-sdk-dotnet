# ArchitectJobMessageDetail

## ININ.PureCloudApi.Model.ArchitectJobMessageDetail

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The kind of information carried by this entry, which determines which of the other properties are set. | [optional] |
| **Url** | **string** | The URL of the request. | [optional] |
| **Method** | **string** | The HTTP method of the request. | [optional] |
| **RequestBody** | **string** | The body of the request, reported as sent and without redaction. Omitted when the request had no body, so it is absent for ordinary GET lookups and present for calls such as POST searches. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer. | [optional] |
| **StatusCode** | **int?** | The HTTP status code of the response. Set only when a response was received, and never alongside errorCode. | [optional] |
| **StatusMessage** | **string** | The HTTP status message of the response. Set only when a response was received, and never alongside errorMessage. | [optional] |
| **CorrelationId** | **string** | The Genesys Cloud correlation id of the response, to quote when escalating to Genesys Cloud support. Set only when a response was received. | [optional] |
| **ResponseBody** | **string** | The body of the response, reported as received and without redaction. Because entries are captured for requests that succeeded as well, this can carry data returned by a lookup that was unrelated to the failure. Omitted when the response had no body. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer. | [optional] |
| **ErrorCode** | **string** | The transport error code, such as ECONNRESET. Set only when the request failed before any HTTP response was received, and never alongside statusCode. | [optional] |
| **ErrorMessage** | **string** | The transport error message. Set only when the request failed before any HTTP response was received, and never alongside statusMessage. | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
