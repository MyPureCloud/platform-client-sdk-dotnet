# ActionMapEstimateOutcomeCriteria

## ININ.PureCloudApi.Model.ActionMapEstimateOutcomeCriteria

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutcomeId** | **string** | ID of outcome. | |
| **MaxProbability** | **float?** | Probability value for the selected outcome at or above which the action map will trigger. | [optional] |
| **Probability** | **float?** | Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value. | [optional] |
| **Quantile** | **float?** | Represents the quantity of sessions that have a maximum probability less than the predicted probability. | [optional] |
| **MaxQuantile** | **float?** | Represents the quantity of sessions that have a maximum probability less than the predicted session max probability. | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
