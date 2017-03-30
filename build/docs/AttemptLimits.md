---
title: AttemptLimits
---
## ININ.PureCloudApi.Model.AttemptLimits

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **MaxAttemptsPerContact** | **int?** |  | [optional] |
| **MaxAttemptsPerNumber** | **int?** |  | [optional] |
| **TimeZoneId** | **string** | The timezone is necessary to define when \&quot;today\&quot; starts and ends | [optional] |
| **ResetPeriod** | **string** | After how long the number of attempts will be set back to 0 | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


