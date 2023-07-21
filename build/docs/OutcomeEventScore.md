---
title: OutcomeEventScore
---
## ININ.PureCloudApi.Model.OutcomeEventScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Outcome** | [**AddressableEntityRef**](AddressableEntityRef.html) | The outcome that the score was calculated for. | [optional] |
| **SessionMaxProbability** | **float?** | Represents the max probability reached in the session. | [optional] |
| **Probability** | **float?** | Represents the likelihood of a customer reaching or achieving a given outcome. | [optional] |
| **Percentile** | **int?** | (Deprecated: use the &#39;quantile&#39; field instead) Represents the predicted probability&#39;s percentile score when compared with all other generated probabilities for a given outcome. | [optional] |
| **SessionMaxPercentile** | **int?** | (Deprecated: use the &#39;quantile&#39; field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session. | [optional] |
| **Quantile** | **float?** | Represents the quantity of sessions that have a maximum probability less than the predicted probability. | [optional] |
| **SessionMaxQuantile** | **float?** | Represents the quantity of sessions that have a maximum probability less than the predicted session max probability. | [optional] |
{: class="table table-striped"}


