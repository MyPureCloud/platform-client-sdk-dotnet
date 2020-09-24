---
title: DevelopmentActivity
---
## ININ.PureCloudApi.Model.DevelopmentActivity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateCompleted** | **DateTime?** | Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | User that created activity | [optional] |
| **DateCreated** | **DateTime?** | Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Name** | **string** | The name of the activity | [optional] |
| **Type** | **string** | The type of activity | [optional] |
| **Status** | **string** | The status of the activity | [optional] |
| **DateDue** | **DateTime?** | Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Facilitator** | [**UserReference**](UserReference.html) | Facilitator of the activity | [optional] |
| **Attendees** | [**List&lt;UserReference&gt;**](UserReference.html) | List of users attending the activity | [optional] |
| **IsOverdue** | **bool?** | Indicates if the activity is overdue | [optional] |
{: class="table table-striped"}


