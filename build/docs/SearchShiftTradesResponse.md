# SearchShiftTradesResponse

## ININ.PureCloudApi.Model.SearchShiftTradesResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Trades** | [**List&lt;SearchShiftTradeResponse&gt;**](SearchShiftTradeResponse) | The shift trades that match the search criteria | [optional] |
| **DownloadUrl** | **string** | URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
