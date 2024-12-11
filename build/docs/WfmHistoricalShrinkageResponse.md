# WfmHistoricalShrinkageResponse

## ININ.PureCloudApi.Model.WfmHistoricalShrinkageResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OperationId** | **string** | The operationId for which to listen | [optional] |
| **DownloadUrls** | **List&lt;string&gt;** | The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete | [optional] |
| **DownloadResult** | [**HistoricalShrinkageResultListing**](HistoricalShrinkageResultListing) | Result will always come via downloadUrls; however the schema is included for documentation | [optional] |
| **State** | **string** | The state of the shrinkage query | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
