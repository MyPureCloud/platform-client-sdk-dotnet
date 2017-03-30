---
title: UserScheduleAdherence
---
## ININ.PureCloudApi.Model.UserScheduleAdherence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User.html) | The user for whom this status applies | [optional] |
| **ManagementUnit** | [**ManagementUnit**](ManagementUnit.html) | The management unit to which this user belongs | [optional] |
| **ScheduledActivityCategory** | **string** | Activity for which the user is scheduled | [optional] |
| **SystemPresence** | **string** | Actual underlying system presence value | [optional] |
| **OrganizationSecondaryPresenceId** | **string** | Organization Secondary Presence Id. | [optional] |
| **RoutingStatus** | **string** | Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue | [optional] |
| **ActualActivityCategory** | **string** | Activity in which the user is actually engaged | [optional] |
| **IsOutOfOffice** | **bool?** | Whether the user is marked OutOfOffice | [optional] |
| **AdherenceState** | **string** | The user&#39;s current adherence state | [optional] |
| **Impact** | **string** | The impact of the user&#39;s current adherenceState | [optional] |
| **TimeOfAdherenceChange** | **string** | Time when the user entered the current adherenceState in ISO-8601 format | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


