# NumberRouting

## ININ.PureCloudApi.Model.NumberRouting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **NumberId** | **string** | Phone number Id that has a disaster recovery linking | [optional] |
| **OwnerOrganizationId** | **string** | Owner organization of numberId | [optional] |
| **CarrierCode** | **string** | Code that indicates which carrier manages the number ie. VERIZON | [optional] |
| **PendingOrganizationId** | **string** | OrganizationId where the number will be routed to during a change routing event | [optional] |
| **Region** | **string** | The current region where the number is located | [optional] |
| **Status** | **string** | The current status of the number routing | [optional] |
| **ActiveOrganizationId** | **string** | The orgId where the number is currently routing to | [optional] |
| **LinkedOrganizationIds** | **List&lt;string&gt;** | List of linked organizations ids | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
