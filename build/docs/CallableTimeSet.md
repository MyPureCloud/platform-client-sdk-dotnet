---
title: CallableTimeSet
---
## ININ.PureCloudApi.Model.CallableTimeSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **CallableTimes** | [**List&lt;CallableTime&gt;**](CallableTime.html) | list of time/timezone groupings for which it is acceptable to place outbound calls | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


