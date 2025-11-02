# UserAuthorization

## ININ.PureCloudApi.Model.UserAuthorization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Roles** | [**List&lt;DomainRole&gt;**](DomainRole) |  | [optional] |
| **UnusedRoles** | [**List&lt;DomainRole&gt;**](DomainRole) | A collection of the roles the user is not using | [optional] |
| **Permissions** | **List&lt;string&gt;** | A collection of the permissions granted by all assigned roles | [optional] |
| **PermissionPolicies** | [**List&lt;ResourcePermissionPolicy&gt;**](ResourcePermissionPolicy) | The policies configured for assigned permissions. | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
