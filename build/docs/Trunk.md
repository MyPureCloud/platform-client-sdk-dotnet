# Trunk

## ININ.PureCloudApi.Model.Trunk

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **TrunkType** | **string** | The type of this trunk. | [optional] |
| **Edge** | [**DomainEntityRef**](DomainEntityRef) | The Edge using this trunk. | [optional] |
| **TrunkBase** | [**DomainEntityRef**](DomainEntityRef) | The trunk base configuration used on this trunk. | [optional] |
| **TrunkMetabase** | [**DomainEntityRef**](DomainEntityRef) | The metabase used to create this trunk. | [optional] |
| **EdgeGroup** | [**DomainEntityRef**](DomainEntityRef) | The edge group associated with this trunk. | [optional] |
| **InService** | **bool?** | True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base. | [optional] |
| **Enabled** | **bool?** | True if the Edge used by this trunk is in-service | [optional] |
| **LogicalInterface** | [**DomainEntityRef**](DomainEntityRef) | The Logical Interface on the Edge to which the trunk is assigned. | [optional] |
| **ConnectedStatus** | [**TrunkConnectedStatus**](TrunkConnectedStatus) | The connected status of the trunk | [optional] |
| **OptionsStatus** | [**List&lt;TrunkMetricsOptions&gt;**](TrunkMetricsOptions) | The trunk optionsStatus | [optional] |
| **RegistersStatus** | [**List&lt;TrunkMetricsRegisters&gt;**](TrunkMetricsRegisters) | The trunk registersStatus | [optional] |
| **IpStatus** | [**TrunkMetricsNetworkTypeIp**](TrunkMetricsNetworkTypeIp) | The trunk ipStatus | [optional] |
| **OptionsEnabledStatus** | **string** | Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0. | [optional] |
| **RegistersEnabledStatus** | **string** | Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0. | [optional] |
| **Family** | **int?** | The IP Network Family of the trunk | [optional] |
| **ProxyAddressList** | **List&lt;string&gt;** | The list of proxy addresses (ports if provided) for the trunk | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
