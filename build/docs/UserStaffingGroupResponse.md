# UserStaffingGroupResponse

## ININ.PureCloudApi.Model.UserStaffingGroupResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **String** | Effective start date of the user assignment in ISO-8601 format or empty value. Empty value means no limit on start-date. | [optional] |
| **EndDate** | **String** | Effective end date of the user assignment in ISO-8601 format or empty value. Empty value means no limit on end-date. | [optional] |
| **User** | [**UserReference**](UserReference) | The user associated with the staffing group | [optional] |
| **StaffingGroup** | [**StaffingGroupReference**](StaffingGroupReference) | The staffing group associated with the user | [optional] |



_PureCloudPlatform.Client.V2 271.0.0_
