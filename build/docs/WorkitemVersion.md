---
title: WorkitemVersion
---
## ININ.PureCloudApi.Model.WorkitemVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Workitem. | [optional] |
| **Division** | [**Division**](Division.html) | The division to which this entity belongs. | [optional] |
| **Type** | [**WorktypeReference**](WorktypeReference.html) | The Worktype of the Workitem. | [optional] |
| **Description** | **string** | The description of the Workitem. | [optional] |
| **Language** | [**LanguageReference**](LanguageReference.html) | The language of the Workitem. | [optional] |
| **UtilizationLabel** | [**WorkitemUtilizationLabelReference**](WorkitemUtilizationLabelReference.html) | The utilization label of the Workitem. | [optional] |
| **Priority** | **int?** | The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000. | [optional] |
| **DateCreated** | **DateTime?** | The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateDue** | **DateTime?** | The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpires** | **DateTime?** | The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DurationSeconds** | **int?** | The estimated duration in seconds to complete the workitem. | [optional] |
| **Ttl** | **int?** | The time to live of the Workitem in seconds. | [optional] |
| **Status** | [**WorkitemStatusReference**](WorkitemStatusReference.html) | The current Status of the Workitem. | [optional] |
| **StatusCategory** | **string** | The Category of the current Status of the Workitem. | [optional] |
| **DateStatusChanged** | **DateTime?** | The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateClosed** | **DateTime?** | The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Workbin** | [**WorkbinReference**](WorkbinReference.html) | The Workbin that contains the Workitem. | [optional] |
| **Reporter** | [**UserReferenceWithName**](UserReferenceWithName.html) | The reporter of the Workitem. | [optional] |
| **Assignee** | [**UserReferenceWithName**](UserReferenceWithName.html) | The assignee of the Workitem. | [optional] |
| **ExternalContact** | [**ExternalContactReference**](ExternalContactReference.html) | The external contact of the Workitem. | [optional] |
| **ExternalTag** | **string** | The external tag of the Workitem. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The User who modified the Workitem. | [optional] |
| **Queue** | [**WorkitemQueueReference**](WorkitemQueueReference.html) | The Workitems queue. | [optional] |
| **AssignmentState** | **string** | The assignment state of the workitem. | [optional] |
| **DateAssignmentStateChanged** | **DateTime?** | The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AlertTimeoutSeconds** | **int?** | The duration in seconds before an alert will timeout. | [optional] |
| **Skills** | [**List&lt;RoutingSkillReference&gt;**](RoutingSkillReference.html) | The skills of the Workitem. | [optional] |
| **PreferredAgents** | [**List&lt;UserReference&gt;**](UserReference.html) | The preferred agents of the Workitem. | [optional] |
| **AutoStatusTransition** | **bool?** | Set it to false to disable auto status transition. By default, it is enabled. | [optional] |
| **Schema** | [**WorkitemSchema**](WorkitemSchema.html) | The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time. | [optional] |
| **CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields defined in the schema referenced by the Workitem. | [optional] |
| **AutoStatusTransitionDetail** | [**AutoStatusTransitionDetail**](AutoStatusTransitionDetail.html) | Auto status transition details of Workitem. | [optional] |
| **ScoredAgents** | [**List&lt;WorkitemScoredAgent&gt;**](WorkitemScoredAgent.html) | A list of scored agents for the Workitem. | [optional] |
| **Version** | **int?** | Version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


