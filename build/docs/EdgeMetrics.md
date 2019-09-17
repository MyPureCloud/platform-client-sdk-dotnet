---
title: EdgeMetrics
---
## ININ.PureCloudApi.Model.EdgeMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Edge** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **EventTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **UpTimeMsec** | **long?** |  | [optional] |
| **Processors** | [**List&lt;EdgeMetricsProcessor&gt;**](EdgeMetricsProcessor.html) |  | [optional] |
| **Memory** | [**List&lt;EdgeMetricsMemory&gt;**](EdgeMetricsMemory.html) |  | [optional] |
| **Disks** | [**List&lt;EdgeMetricsDisk&gt;**](EdgeMetricsDisk.html) |  | [optional] |
| **Subsystems** | [**List&lt;EdgeMetricsSubsystem&gt;**](EdgeMetricsSubsystem.html) |  | [optional] |
| **Networks** | [**List&lt;EdgeMetricsNetwork&gt;**](EdgeMetricsNetwork.html) |  | [optional] |
{: class="table table-striped"}


