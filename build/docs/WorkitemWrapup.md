---
title: WorkitemWrapup
---
## ININ.PureCloudApi.Model.WorkitemWrapup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Workitem** | [**WorkitemReference**](WorkitemReference.html) | Workitem that the wrapup code has been added to. | [optional] |
| **WrapupCode** | [**WrapupIdReference**](WrapupIdReference.html) | The wrapup code used in the workitem. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The user who added the wrapup code to the workitem. | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user for whom wrapup code was added. This may be the same as modifiedBy. | [optional] |
| **DateModified** | **DateTime?** | The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


