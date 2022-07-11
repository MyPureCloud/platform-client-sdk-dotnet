---
title: BuQueryAgentSchedulesRequest
---
## ININ.PureCloudApi.Model.BuQueryAgentSchedulesRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitId** | **string** | The ID of the management unit to query | |
| **UserIds** | **List&lt;string&gt;** | The IDs of the users to query.  Omit to query all user schedules in the management unit.  | [optional] |
| **TeamIds** | **List&lt;string&gt;** | The teamIds to request. If null or not set, results will be queried for requested users if applicable or otherwise all users in the management unit | [optional] |
{: class="table table-striped"}


