# AgentsWorkPlansResponse

## ININ.PureCloudApi.Model.AgentsWorkPlansResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DownloadUrl** | **string** | URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl | [optional] |
| **Result** | [**MuAgentsWorkPlansResult**](MuAgentsWorkPlansResult) | The result of agent(s) work plans query | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
