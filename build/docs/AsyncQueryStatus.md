# AsyncQueryStatus

## ININ.PureCloudApi.Model.AsyncQueryStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The current state of the asynchronous query | [optional] |
| **ErrorMessage** | **string** | The error associated with the current query, if the state is FAILED | [optional] |
| **ExpirationDate** | **DateTime?** | The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SubmissionDate** | **DateTime?** | The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CompletionDate** | **DateTime?** | The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
