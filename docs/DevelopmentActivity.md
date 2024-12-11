# DevelopmentActivity

## ININ.PureCloudApi.Model.DevelopmentActivity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateCompleted** | **DateTime?** | Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | User that created activity | [optional] |
| **DateCreated** | **DateTime?** | Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PercentageScore** | **float?** | The user&#39;s percentage score for this activity | [optional] |
| **IsPassed** | **bool?** | True if the activity was passed | [optional] |
| **IsLatest** | **bool?** | True if this is the latest version of assignment assigned to the user | [optional] |
| **IsModuleArchived** | **bool?** | True if the associated module is archived | [optional] |
| **ArchivalMode** | **string** | Module archive type | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Name** | **string** | The name of the activity | [optional] |
| **Type** | **string** | The type of activity | [optional] |
| **Status** | **string** | The status of the activity | [optional] |
| **DateDue** | **DateTime?** | Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Facilitator** | [**UserReference**](UserReference) | Facilitator of the activity | [optional] |
| **Attendees** | [**List&lt;UserReference&gt;**](UserReference) | List of users attending the activity | [optional] |
| **IsOverdue** | **bool?** | Indicates if the activity is overdue | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
