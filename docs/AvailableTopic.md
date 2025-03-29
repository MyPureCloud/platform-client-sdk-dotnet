# AvailableTopic

## ININ.PureCloudApi.Model.AvailableTopic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **PermissionDetails** | [**List&lt;PermissionDetails&gt;**](PermissionDetails) | Full detailed permissions required to subscribe to the topic | [optional] |
| **RequiresPermissions** | **List&lt;string&gt;** | Permissions required to subscribe to the topic | [optional] |
| **RequiresDivisionPermissions** | **bool?** | True if the subscribing user must belong to the same division as the topic object ID | [optional] |
| **RequiresAnyValidator** | **bool?** | If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met. | [optional] |
| **Enforced** | **bool?** | Whether or not the permissions on this topic are enforced | [optional] |
| **Visibility** | **string** | Visibility of this topic (Public or Preview) | [optional] |
| **Schema** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **RequiresCurrentUser** | **bool?** | True if the topic user ID is required to match the subscribing user ID | [optional] |
| **RequiresCurrentUserOrPermission** | **bool?** | True if permissions are only required when the topic user ID does not match the subscribing user ID | [optional] |
| **Transports** | **List&lt;string&gt;** | Transports that support events for the topic | [optional] |
| **PublicApiTemplateUriPaths** | **List&lt;string&gt;** |  | [optional] |
| **TopicParameters** | **List&lt;string&gt;** | Parameters in the topic name that can be substituted, in the order they appear in the topic name | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
