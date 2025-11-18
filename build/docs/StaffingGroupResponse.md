# StaffingGroupResponse

## ININ.PureCloudApi.Model.StaffingGroupResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the staffing group | |
| **Users** | [**List&lt;UserReference&gt;**](UserReference) | The list of users that belong to the staffing group | [optional] |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit | [optional] |
| **PlanningGroups** | [**List&lt;PlanningGroupReference&gt;**](PlanningGroupReference) | The list of planning groups that are associated with the staffing group | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the staffing group | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
