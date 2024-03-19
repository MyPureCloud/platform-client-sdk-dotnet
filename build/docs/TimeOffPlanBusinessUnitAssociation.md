---
title: TimeOffPlanBusinessUnitAssociation
---
## ININ.PureCloudApi.Model.TimeOffPlanBusinessUnitAssociation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnits** | [**List&lt;ManagementUnitReference&gt;**](ManagementUnitReference.html) | Management units to which this time-off plan applies. This must not be set if staffingGroups is populated | [optional] |
| **StaffingGroups** | [**List&lt;StaffingGroupReference&gt;**](StaffingGroupReference.html) | Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated | [optional] |
{: class="table table-striped"}


