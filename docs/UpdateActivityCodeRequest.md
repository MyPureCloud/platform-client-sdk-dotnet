# UpdateActivityCodeRequest

## ININ.PureCloudApi.Model.UpdateActivityCodeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the activity code | [optional] |
| **Category** | **string** | The activity code&#39;s category. Attempting to change the category of a default activity code will return an error | [optional] |
| **LengthInMinutes** | **int?** | The default length of the activity in minutes | [optional] |
| **CountsAsPaidTime** | **bool?** | Whether an agent is paid while performing this activity | [optional] |
| **CountsAsWorkTime** | **bool?** | Indicates whether or not the activity should be counted as work time | [optional] |
| **AgentTimeOffSelectable** | **bool?** | Whether an agent can select this activity code when creating or editing a time off request | [optional] |
| **CountsTowardShrinkage** | **bool?** | Whether or not this activity code counts toward shrinkage calculations | [optional] |
| **PlannedShrinkage** | **bool?** | Whether this activity code is considered planned or unplanned shrinkage | [optional] |
| **Interruptible** | **bool?** | Whether this activity code is considered interruptible | [optional] |
| **SecondaryPresences** | [**ListWrapperSecondaryPresence**](ListWrapperSecondaryPresence) | The secondary presences of this activity code | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the associated business unit&#39;s list of activity codes | |



_PureCloudPlatform.Client.V2 215.0.0_
