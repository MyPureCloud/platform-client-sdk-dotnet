---
title: ManagementUnit
---
## ININ.PureCloudApi.Model.ManagementUnit

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division.html) | The division to which this entity belongs. | [optional] |
| **StartDayOfWeek** | **string** | Start day of week for scheduling and forecasting purposes. Moving to Business Unit | [optional] |
| **TimeZone** | **string** | The time zone for the management unit in standard Olson format.  Moving to Business Unit | [optional] |
| **Settings** | [**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse.html) | The configuration settings for this management unit | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version info metadata for this management unit. Deprecated, use settings.metadata | [optional] |
| **Version** | **int?** | The version of the underlying entity.  Deprecated, use field from settings.metadata instead | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The user who last modified this entity.  Deprecated, use field from settings.metadata instead | [optional] |
| **DateModified** | **DateTime?** | The date and time at which this entity was last modified.  Deprecated, use field from settings.metadata instead. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


