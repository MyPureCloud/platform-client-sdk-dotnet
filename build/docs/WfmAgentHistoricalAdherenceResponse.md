# WfmAgentHistoricalAdherenceResponse

## ININ.PureCloudApi.Model.WfmAgentHistoricalAdherenceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Job** | [**WfmAgentHistoricalAdherenceJobReference**](WfmAgentHistoricalAdherenceJobReference) | A reference to the job that was started by the request | |
| **DownloadUrls** | **List&lt;string&gt;** | The url list to GET the results of the agent adherence query. This field is populated only if query state is Complete | [optional] |
| **Result** | [**WfmAgentHistoricalAdherenceResult**](WfmAgentHistoricalAdherenceResult) | Results will come via downloadUrls, however it may come inline if small enough | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
