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
| **Schema** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **RequiresCurrentUser** | **bool?** | True if the topic user ID is required to match the subscribing user ID | [optional] |
| **RequiresCurrentUserOrPermission** | **bool?** | True if permissions are only required when the topic user ID does not match the subscribing user ID | [optional] |
{: class="table table-striped"}


