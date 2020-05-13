---
title: BuManagementUnitScheduleSummary
---
## ININ.PureCloudApi.Model.BuManagementUnitScheduleSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference.html) | The management unit to which this summary applies | [optional] |
| **AgentCount** | **int?** | The number of agents from this management unit that are in the schedule | [optional] |
| **StartDate** | **DateTime?** | The start of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndDate** | **DateTime?** | The end of the schedule change in the management unit. Only populated in schedule update notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Agents** | [**List&lt;UserReference&gt;**](UserReference.html) | The changed agents in the management unit. Only populated in schedule update notifications | [optional] |
{: class="table table-striped"}


