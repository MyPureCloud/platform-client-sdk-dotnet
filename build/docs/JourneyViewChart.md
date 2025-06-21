# JourneyViewChart

## ININ.PureCloudApi.Model.JourneyViewChart

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | The version of the journey view chart | [optional] |
| **GroupByTime** | **string** | A time unit to group the metrics by. There is a limit on the number of groupBy properties which can be specified. | [optional] |
| **GroupByAttributes** | [**List&lt;JourneyViewChartGroupByAttribute&gt;**](JourneyViewChartGroupByAttribute) | A list of attributes to group the metrics by. There is a limit on the number of groupBy properties which can be specified. | [optional] |
| **Metrics** | [**List&lt;JourneyViewChartMetric&gt;**](JourneyViewChartMetric) | A list of metrics to calculate within the chart by (aka the y axis) | |
| **DisplayAttributes** | [**JourneyViewChartDisplayAttributes**](JourneyViewChartDisplayAttributes) | Optional display attributes for rendering the chart | [optional] |
| **GroupByMax** | **int?** | A maximum on the number of values being grouped by | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
