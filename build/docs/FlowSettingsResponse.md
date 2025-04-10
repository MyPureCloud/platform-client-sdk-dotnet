# FlowSettingsResponse

## ININ.PureCloudApi.Model.FlowSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | The Flow Type | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | User that last changed the log level setting. | [optional] |
| **ModifiedByClient** | [**DomainEntityRef**](DomainEntityRef) | OAuth client that last changed the log level setting. | [optional] |
| **DateModified** | **DateTime?** | The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LogLevelCharacteristics** | [**FlowLogLevel**](FlowLogLevel) | The log level set for this flow | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
