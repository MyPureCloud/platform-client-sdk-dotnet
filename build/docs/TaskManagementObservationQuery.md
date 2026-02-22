# TaskManagementObservationQuery

## ININ.PureCloudApi.Model.TaskManagementObservationQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by. Determines how the results will be grouped in the response. | |
| **Metrics** | [**List&lt;TaskManagementQueryMetric&gt;**](TaskManagementQueryMetric) | List of metrics to be retrieved. Specifies which observational metrics should be included in the response. | |
| **Filter** | [**TaskManagementObservationQueryFilter**](TaskManagementObservationQueryFilter) | Filter to return a subset of observations. | |
| **Expands** | **List&lt;string&gt;** | List of properties to expand. Additional details about the objects returned in the results will be included in the response if supplied. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
