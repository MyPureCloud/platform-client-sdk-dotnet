# ScheduleBidGroup

## ININ.PureCloudApi.Model.ScheduleBidGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the schedule bid group | |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which this bid group belongs | |
| **Agents** | [**List&lt;UserReference&gt;**](UserReference) | The agents who participate in this bid group | |
| **WorkPlans** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference) | The work plans used in this bid group | [optional] |
| **WorkPlanRotations** | [**List&lt;BidGroupWorkPlanRotationResponse&gt;**](BidGroupWorkPlanRotationResponse) | The work plan rotations used in this bid group | [optional] |
| **PlanningGroups** | [**List&lt;PlanningGroupReference&gt;**](PlanningGroupReference) | The planning groups selected in this bid group | |
| **DownloadUrl** | **string** | The downloadUrl to fetch Schedule sets. It will be populated if the status of this bid is &#39;Optimized&#39; | [optional] |
| **DownloadTemplate** | [**BidGroupScheduleSet**](BidGroupScheduleSet) | Schedule sets always come through downloadUrl, the schema included here is just for documentation | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
