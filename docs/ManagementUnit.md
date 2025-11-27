# ManagementUnit

## ININ.PureCloudApi.Model.ManagementUnit

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which this management unit belongs | [optional] |
| **StartDayOfWeek** | **string** | Start day of week for scheduling and forecasting purposes. Moving to Business Unit | [optional] |
| **TimeZone** | **string** | The time zone for the management unit in standard Olson format.  Moving to Business Unit | [optional] |
| **Settings** | [**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse) | The configuration settings for this management unit | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version info metadata for this management unit. Deprecated, use settings.metadata | [optional] |
| **Division** | [**DivisionReference**](DivisionReference) | The division to which this entity belongs. | [optional] |
| **Version** | **int?** | The version of the underlying entity.  Deprecated, use field from settings.metadata instead | [optional] |
| **DateModified** | **DateTime?** | The date and time at which this entity was last modified.  Deprecated, use field from settings.metadata instead. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who last modified this entity.  Deprecated, use field from settings.metadata instead | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
