---
title: StatusChange
---
## ININ.PureCloudApi.Model.StatusChange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStatusChanged** | **DateTime?** | The date of this status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The status the change request transitioned to | [optional] |
| **PreviousStatus** | **string** | The status the change request transitioned from | [optional] |
| **Message** | **string** | A short message describing the status change | [optional] |
| **ChangedBy** | **string** | If applicable, the user who updated the change request to this status | [optional] |
| **RejectReason** | **string** | The reason for rejecting the limit override request | [optional] |
{: class="table table-striped"}


