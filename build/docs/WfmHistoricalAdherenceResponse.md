---
title: WfmHistoricalAdherenceResponse
---
## ININ.PureCloudApi.Model.WfmHistoricalAdherenceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The query ID to listen for | [optional] |
| **DownloadUrl** | **string** | Deprecated. Use downloadUrls instead. | [optional] |
| **DownloadResult** | [**WfmHistoricalAdherenceResultWrapper**](WfmHistoricalAdherenceResultWrapper.html) | Result will always come via downloadUrls; however the schema is included for documentation | [optional] |
| **DownloadUrls** | **List&lt;string&gt;** | The uri list to GET the results of the Historical Adherence query. For notification purposes only | [optional] |
| **QueryState** | **string** | The state of the adherence query | [optional] |
{: class="table table-striped"}


