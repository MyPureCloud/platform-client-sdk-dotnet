# WorkitemWrapup

## ININ.PureCloudApi.Model.WorkitemWrapup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Workitem** | [**WorkitemReference**](WorkitemReference) | Workitem that the wrapup code has been added to. | [optional] |
| **WrapupCode** | [**WrapupIdReference**](WrapupIdReference) | The wrapup code used in the workitem. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who added the wrapup code to the workitem. | [optional] |
| **User** | [**UserReference**](UserReference) | The user for whom wrapup code was added. This may be the same as modifiedBy. | [optional] |
| **DateModified** | **DateTime?** | The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
