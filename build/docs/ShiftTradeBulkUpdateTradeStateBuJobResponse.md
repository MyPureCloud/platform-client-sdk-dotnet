# ShiftTradeBulkUpdateTradeStateBuJobResponse

## ININ.PureCloudApi.Model.ShiftTradeBulkUpdateTradeStateBuJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The status of the job | |
| **Type** | **string** | The type of the job | |
| **DownloadUrl** | **string** | The URL where completed results might be available for download in case the result body for that job type is too large | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **BulkUpdateTradeStatesResult** | [**BulkUpdateShiftTradeStateResult**](BulkUpdateShiftTradeStateResult) | Results for BulkUpdateTradeStates job type | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
