---
title: AvailableTopic
---
## ININ.PureCloudApi.Model.AvailableTopic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **RequiresPermissions** | **List&lt;string&gt;** | Permissions required to subscribe to the topic | [optional] |
| **RequiresDivisionPermissions** | **bool?** | True if the subscribing user must belong to the same division as the topic object ID | [optional] |
| **Enforced** | **bool?** | Whether or not the permissions on this topic are enforced | [optional] |
| **Visibility** | **string** | Visibility of this topic (Public or Preview) | [optional] |
| **Schema** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **RequiresCurrentUser** | **bool?** | True if the topic user ID is required to match the subscribing user ID | [optional] |
| **RequiresCurrentUserOrPermission** | **bool?** | True if permissions are only required when the topic user ID does not match the subscribing user ID | [optional] |
| **Transports** | **List&lt;string&gt;** | Transports that support events for the topic | [optional] |
| **PublicApiTemplateUriPaths** | **List&lt;string&gt;** |  | [optional] |
{: class="table table-striped"}


