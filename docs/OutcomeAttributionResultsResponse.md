# OutcomeAttributionResultsResponse

## ININ.PureCloudApi.Model.OutcomeAttributionResultsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutcomeId** | **string** | ID of Outcome. | [optional] |
| **Index** | **int?** | The index/position of the OutcomeAttribution in the original POST request. | [optional] |
| **ExternalContactId** | **string** | The external contact ID of the customer who achieved the outcome. | [optional] |
| **AssociatedValue** | **double?** | The total value associated with the customer&#39;s outcome. | [optional] |
| **State** | **string** | State of the Outcome Attribution entity. | |
| **Message** | **string** | Additional information on the state of the Outcome Attribution entity. | |
| **Touchpoints** | [**List&lt;TouchpointResponse&gt;**](TouchpointResponse) | List of interactions that led to this outcome being achieved. | [optional] |
| **CreatedDate** | **DateTime?** | Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
