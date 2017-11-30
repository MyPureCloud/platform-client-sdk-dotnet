---
title: ManagementUnit
---
## ININ.PureCloudApi.Model.ManagementUnit

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **StartDayOfWeek** | **string** | Start day of week for scheduling and forecasting purposes | [optional] |
| **TimeZone** | **string** | The time zone for the management unit in standard Olson Format (See https://en.wikipedia.org/wiki/Tz_database) | [optional] |
| **Settings** | [**ManagementUnitSettings**](ManagementUnitSettings.html) | The configuration settings for this management unit | [optional] |
| **Version** | **int?** | The version of the underlying entity | |
| **DateModified** | **DateTime?** | The date and time at which this entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**User**](User.html) | The user who last modified this entity | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


