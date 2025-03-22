# ActivityPlanListItem

## ININ.PureCloudApi.Model.ActivityPlanListItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the activity plan | |
| **ManagementUnits** | [**List&lt;ManagementUnitReference&gt;**](ManagementUnitReference) | The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit | [optional] |
| **Description** | **string** | The description of this activity plan | |
| **ActivityCode** | [**ActivityCodeReference**](ActivityCodeReference) | The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes | |
| **Type** | **string** | The type of the activity plan | |
| **OptimizationObjective** | **string** | The optimization objective of this activity plan | |
| **RecurrenceSettings** | [**RecurrenceSettings**](RecurrenceSettings) | Recurrence settings for this activity plan | [optional] |
| **State** | **string** | The state of this activity plan | |
| **LastRunDate** | **DateTime?** | The date the activity plan was last run, in ISO-8601 format | [optional] |
| **LastRunBy** | [**UserReference**](UserReference) | The last user to run this activity plan | [optional] |
| **CreatedDate** | **DateTime?** | The date the activity plan was created, in ISO-8601 format | |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created this activity plan | |
| **ModifiedDate** | **DateTime?** | The date the activity plan was modified, in ISO-8601 format | |
| **ModifiedBy** | [**UserReference**](UserReference) | The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
