# ExecutionDataGlobalSettingsResponse

## ININ.PureCloudApi.Model.ExecutionDataGlobalSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Enabled** | **bool?** | whether or not the setting is enabled. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | User that last changed the setting. | [optional] |
| **ModifiedByClient** | [**DomainEntityRef**](DomainEntityRef) | OAuth client that last changed the setting. | [optional] |
| **DateModified** | **DateTime?** | The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
