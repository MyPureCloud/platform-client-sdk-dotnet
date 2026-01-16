# TimeOffPlanBusinessUnitAssociation

## ININ.PureCloudApi.Model.TimeOffPlanBusinessUnitAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnits** | [**List&lt;ManagementUnitReference&gt;**](ManagementUnitReference) | Management units to which this time-off plan applies. This must not be set if staffingGroups is populated | [optional] |
| **StaffingGroups** | [**List&lt;StaffingGroupReference&gt;**](StaffingGroupReference) | Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
