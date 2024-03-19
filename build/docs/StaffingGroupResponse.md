---
title: StaffingGroupResponse
---
## ININ.PureCloudApi.Model.StaffingGroupResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the staffing group | |
| **Users** | [**List&lt;UserReference&gt;**](UserReference.html) | The list of users that belong to the staffing group | [optional] |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference.html) | The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the staffing group | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


