# GroupUpdate

## ININ.PureCloudApi.Model.GroupUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The group name. | [optional] |
| **Description** | **string** |  | [optional] |
| **State** | **string** | State of the group. | [optional] |
| **Version** | **int?** | Current version for this resource. | |
| **Images** | [**List&lt;Image&gt;**](Image) |  | [optional] |
| **Addresses** | [**List&lt;GroupContact&gt;**](GroupContact) |  | [optional] |
| **RulesVisible** | **bool?** | Are membership rules visible to the person requesting to view the group | [optional] |
| **Visibility** | **string** | Who can view this group | [optional] |
| **RolesEnabled** | **bool?** | Allow roles to be assigned to this group | [optional] |
| **IncludeOwners** | **bool?** | Allow owners to be included as members of the group | [optional] |
| **CallsEnabled** | **bool?** | Allow calls to be placed to this group. | [optional] |
| **OwnerIds** | **List&lt;string&gt;** | Owners of the group | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
