---
title: GroupUpdate
---
## ININ.PureCloudApi.Model.GroupUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The group name. | [optional] |
| **Description** | **string** |  | [optional] |
| **State** | **string** | State of the group. | [optional] |
| **Version** | **int?** | Current version for this resource. | |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Addresses** | [**List&lt;GroupContact&gt;**](GroupContact.html) |  | [optional] |
| **RulesVisible** | **bool?** | Are membership rules visible to the person requesting to view the group | [optional] |
| **Visibility** | **string** | Who can view this group | [optional] |
| **RolesEnabled** | **bool?** | Allow roles to be assigned to this group | [optional] |
| **OwnerIds** | **List&lt;string&gt;** | Owners of the group | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


