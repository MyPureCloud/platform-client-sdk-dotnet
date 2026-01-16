# BusinessUnitActivityCode

## ININ.PureCloudApi.Model.BusinessUnitActivityCode

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Active** | **bool?** | Whether this activity code is active or has been deleted | [optional] |
| **DefaultCode** | **bool?** | Whether this is a default activity code | [optional] |
| **Category** | **string** | The category of the activity code | [optional] |
| **LengthInMinutes** | **int?** | The default length of the activity in minutes | [optional] |
| **CountsAsPaidTime** | **bool?** | Whether an agent is paid while performing this activity | [optional] |
| **CountsAsWorkTime** | **bool?** | Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints | [optional] |
| **AgentTimeOffSelectable** | **bool?** | Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off. | [optional] |
| **CountsTowardShrinkage** | **bool?** | Whether or not this activity code counts toward shrinkage calculations | [optional] |
| **PlannedShrinkage** | **bool?** | Whether this activity code is considered planned or unplanned shrinkage | [optional] |
| **Interruptible** | **bool?** | Whether this activity code is considered interruptible | [optional] |
| **SecondaryPresences** | [**List&lt;SecondaryPresence&gt;**](SecondaryPresence) | The secondary presences of this activity code | [optional] |
| **PlanningGroups** | [**List&lt;PlanningGroupReference&gt;**](PlanningGroupReference) | Planning groups associated with this activity code | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata of this activity code | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
