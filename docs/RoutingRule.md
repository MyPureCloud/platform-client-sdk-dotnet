# RoutingRule

## ININ.PureCloudApi.Model.RoutingRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Operator** | **string** | matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule&#39;s threshold.  ANY matches all specified agents, regardless of score. | [optional] |
| **Threshold** | **int?** | threshold required for routing attempt (generally an agent score).  may be null for operator ANY. | [optional] |
| **WaitSeconds** | **double?** | seconds to wait in this rule before moving to the next | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
