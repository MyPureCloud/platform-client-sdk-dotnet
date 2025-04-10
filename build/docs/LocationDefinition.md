# LocationDefinition

## ININ.PureCloudApi.Model.LocationDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ContactUser** | [**AddressableEntityRef**](AddressableEntityRef) | Site contact for the location entity | [optional] |
| **EmergencyNumber** | [**LocationEmergencyNumber**](LocationEmergencyNumber) | Emergency number for the location entity | [optional] |
| **Address** | [**LocationAddress**](LocationAddress) |  | [optional] |
| **State** | **string** | Current state of the location entity | [optional] |
| **Notes** | **string** | Notes for the location entity | [optional] |
| **Version** | **int?** | Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response | [optional] |
| **Path** | **List&lt;string&gt;** | A list of ancestor IDs in order | [optional] |
| **ProfileImage** | [**List&lt;LocationImage&gt;**](LocationImage) | Profile image of the location entity, retrieved with ?expand&#x3D;images query parameter | [optional] |
| **FloorplanImage** | [**List&lt;LocationImage&gt;**](LocationImage) | Floorplan images of the location entity, retrieved with ?expand&#x3D;images query parameter | [optional] |
| **AddressVerificationDetails** | [**LocationAddressVerificationDetails**](LocationAddressVerificationDetails) | Address verification information, retrieve dwith the ?expand&#x3D;addressVerificationDetails query parameter | [optional] |
| **AddressVerified** | **bool?** | Boolean field which states if the address has been verified as an actual address | [optional] |
| **AddressStored** | **bool?** | Boolean field which states if the address has been stored for E911 | [optional] |
| **Images** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
