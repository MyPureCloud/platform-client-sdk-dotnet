# TrustMemberCreate

## ININ.PureCloudApi.Model.TrustMemberCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Trustee User or Group Id | |
| **RoleIds** | **List&lt;string&gt;** | The list of roles to be granted to this user or group. Roles will be granted in all divisions. | [optional] |
| **RoleDivisions** | [**RoleDivisionGrants**](RoleDivisionGrants) | The list of trustor organization roles granting this user or group access paired with the divisions for those roles. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
