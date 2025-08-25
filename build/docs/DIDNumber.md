# DIDNumber

## ININ.PureCloudApi.Model.DIDNumber

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Number** | **string** | The number of the DID formatted as E164. | [optional] |
| **Assigned** | **bool?** | True if this DID is assigned to an entity.  False otherwise. | [optional] |
| **DidPool** | [**AddressableEntityRef**](AddressableEntityRef) | A Uri reference to the DID Pool this DID is a part of. | [optional] |
| **Owner** | [**DomainEntityRef**](DomainEntityRef) | A Uri reference to the owner of this DID.  The owner&#39;s type can be found in ownerType.  If the DID is unassigned, this will be NULL. | [optional] |
| **OwnerType** | **string** | The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
