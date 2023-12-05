---
title: DomainOrganizationRoleUpdate
---
## ININ.PureCloudApi.Model.DomainOrganizationRoleUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | role id | [optional] |
| **Name** | **string** | The name of the role | |
| **Description** | **string** |  | [optional] |
| **DefaultRoleId** | **string** |  | [optional] |
| **Permissions** | **List&lt;string&gt;** |  | [optional] |
| **UnusedPermissions** | **List&lt;string&gt;** | A collection of the permissions the role is not using | [optional] |
| **PermissionPolicies** | [**List&lt;DomainPermissionPolicy&gt;**](DomainPermissionPolicy.html) |  | [optional] |
| **UserCount** | **int?** |  | [optional] |
| **RoleNeedsUpdate** | **bool?** | Optional unless patch operation. | [optional] |
| **Default** | **bool?** |  | [optional] |
| **Base** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


