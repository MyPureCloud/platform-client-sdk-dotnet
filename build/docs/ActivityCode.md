# ActivityCode

## ININ.PureCloudApi.Model.ActivityCode

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Name** | **string** | The name of the activity code. Default activity codes will be created with an empty name | [optional] |
| **IsActive** | **bool?** | Whether this activity code is active or has been deleted | [optional] |
| **IsDefault** | **bool?** | Whether this is a default activity code | [optional] |
| **Category** | **string** | The activity code&#39;s category. | [optional] |
| **LengthInMinutes** | **int?** | The default length of the activity in minutes | [optional] |
| **CountsAsPaidTime** | **bool?** | Whether an agent is paid while performing this activity | [optional] |
| **CountsAsWorkTime** | **bool?** | Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints | [optional] |
| **AgentTimeOffSelectable** | **bool?** | Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off. | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the associated management unit&#39;s list of activity codes | |



_PureCloudPlatform.Client.V2 236.0.0_
