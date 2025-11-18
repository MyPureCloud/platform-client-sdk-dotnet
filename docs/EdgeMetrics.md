# EdgeMetrics

## ININ.PureCloudApi.Model.EdgeMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Edge** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **EventTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **UpTimeMsec** | **long?** |  | [optional] |
| **Processors** | [**List&lt;EdgeMetricsProcessor&gt;**](EdgeMetricsProcessor) |  | [optional] |
| **Memory** | [**List&lt;EdgeMetricsMemory&gt;**](EdgeMetricsMemory) |  | [optional] |
| **Disks** | [**List&lt;EdgeMetricsDisk&gt;**](EdgeMetricsDisk) |  | [optional] |
| **Subsystems** | [**List&lt;EdgeMetricsSubsystem&gt;**](EdgeMetricsSubsystem) |  | [optional] |
| **Networks** | [**List&lt;EdgeMetricsNetwork&gt;**](EdgeMetricsNetwork) |  | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
