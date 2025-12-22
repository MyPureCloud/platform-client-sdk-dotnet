# ObservationMetricData

## ININ.PureCloudApi.Model.ObservationMetricData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | **string** |  | [optional] |
| **Qualifier** | **string** |  | [optional] |
| **Stats** | [**StatisticalSummary**](StatisticalSummary) |  | [optional] |
| **Truncated** | **bool?** | Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations. | [optional] |
| **Observations** | [**List&lt;ObservationValue&gt;**](ObservationValue) | List of observations sorted by timestamp in ascending order. This list may be truncated. | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
