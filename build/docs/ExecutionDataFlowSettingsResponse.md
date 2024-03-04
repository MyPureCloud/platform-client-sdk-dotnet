---
title: ExecutionDataFlowSettingsResponse
---
## ININ.PureCloudApi.Model.ExecutionDataFlowSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Enabled** | **bool?** | whether or not the setting is enabled. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | User that last changed the setting. | [optional] |
| **ModifiedByClient** | [**DomainEntityRef**](DomainEntityRef.html) | OAuth client that last changed the setting. | [optional] |
| **DateModified** | **DateTime?** | The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


