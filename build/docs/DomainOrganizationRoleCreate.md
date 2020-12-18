---
title: DomainOrganizationRoleCreate
---
## ININ.PureCloudApi.Model.DomainOrganizationRoleCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The role name | |
| **Description** | **string** |  | [optional] |
| **DefaultRoleId** | **string** |  | [optional] |
| **Permissions** | **List&lt;string&gt;** |  | [optional] |
| **UnusedPermissions** | **List&lt;string&gt;** | A collection of the permissions the role is not using | [optional] |
| **PermissionPolicies** | [**List&lt;DomainPermissionPolicy&gt;**](DomainPermissionPolicy.html) |  | [optional] |
| **UserCount** | **int?** |  | [optional] |
| **RoleNeedsUpdate** | **bool?** | Optional unless patch operation. | [optional] |
| **_Default** | **bool?** |  | [optional] |
| **_Base** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


