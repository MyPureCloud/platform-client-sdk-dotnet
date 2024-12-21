# LongTermForecastResultResponse

## ININ.PureCloudApi.Model.LongTermForecastResultResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Result** | [**LongTermForecastResult**](LongTermForecastResult) | The result of the operation.  Populated whenever the result is small enough to pass through the api directly | [optional] |
| **DownloadUrl** | **string** | The download url to fetch the result.  Only populated if the result is too large to pass through the api directly | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
