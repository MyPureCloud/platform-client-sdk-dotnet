# WfmHistoricalAdherenceBulkResponse

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceBulkResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Job** | [**WfmHistoricalAdherenceBulkJobReference**](WfmHistoricalAdherenceBulkJobReference) | A reference to the job that was started by the request | [optional] |
| **DownloadUrls** | **List&lt;string&gt;** | The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete | [optional] |
| **DownloadResult** | [**WfmHistoricalAdherenceBulkResult**](WfmHistoricalAdherenceBulkResult) | Results will always come via downloadUrls; however the schema is included for documentation | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
