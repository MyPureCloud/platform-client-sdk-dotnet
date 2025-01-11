# DomainOrganizationRole

## ININ.PureCloudApi.Model.DomainOrganizationRole

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | role id | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **DefaultRoleId** | **string** |  | [optional] |
| **Permissions** | **List&lt;string&gt;** |  | [optional] |
| **UnusedPermissions** | **List&lt;string&gt;** | A collection of the permissions the role is not using | [optional] |
| **PermissionPolicies** | [**List&lt;DomainPermissionPolicy&gt;**](DomainPermissionPolicy) |  | [optional] |
| **UserCount** | **int?** |  | [optional] |
| **RoleNeedsUpdate** | **bool?** | Optional unless patch operation. | [optional] |
| **Base** | **bool?** |  | [optional] |
| **Default** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
