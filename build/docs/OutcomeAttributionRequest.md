# OutcomeAttributionRequest

## ININ.PureCloudApi.Model.OutcomeAttributionRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutcomeId** | **string** | ID of Outcome. | |
| **ExternalContactId** | **string** | The external contact ID of the customer who achieved the outcome. | [optional] |
| **AssociatedValue** | **double?** | The total value associated with the customer&#39;s outcome. | |
| **Touchpoints** | [**List&lt;Touchpoint&gt;**](Touchpoint) | List of interactions that led to this outcome being achieved. | |
| **CreatedDate** | **DateTime?** | Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 253.0.0_
