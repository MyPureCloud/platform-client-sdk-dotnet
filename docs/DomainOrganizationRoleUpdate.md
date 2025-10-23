# DomainOrganizationRoleUpdate

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
| **PermissionPolicies** | [**List&lt;DomainPermissionPolicy&gt;**](DomainPermissionPolicy) |  | [optional] |
| **UserCount** | **int?** |  | [optional] |
| **RoleNeedsUpdate** | **bool?** | Optional unless patch operation. | [optional] |
| **BaseLicense** | **string** |  | [optional] |
| **AddonLicenses** | **List&lt;string&gt;** |  | [optional] |
| **DateLicenseLastUpdated** | **DateTime?** | The time that this role licenses were most recently updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Default** | **bool?** |  | [optional] |
| **Base** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
