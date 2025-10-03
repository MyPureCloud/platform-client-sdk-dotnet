# V2QueueObservationMetricData

## ININ.PureCloudApi.Model.V2QueueObservationMetricData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | **string** | The observation metric | [optional] |
| **Observations** | [**List&lt;V2QueueObservationObservation&gt;**](V2QueueObservationObservation) | List of observations sorted by timestamp in ascending order. This list may be truncated. | [optional] |
| **Truncated** | **bool?** | Flag indicating whether the list of observations was truncated or not | [optional] |
| **Stats** | [**V2QueueObservationMetricStats**](V2QueueObservationMetricStats) |  | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
