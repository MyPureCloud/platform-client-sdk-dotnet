---
title: LearningAssignment
---
## ININ.PureCloudApi.Model.LearningAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the assignment | [optional] |
| **DateCreated** | **DateTime?** | The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The user who modified the assignment | [optional] |
| **DateModified** | **DateTime?** | The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IsOverdue** | **bool?** | True if the assignment is overdue | [optional] |
| **IsRule** | **bool?** | True if this assignment was created by a Rule | [optional] |
| **IsManual** | **bool?** | True if this assignment was created manually | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **State** | **string** | The Learning Assignment state | [optional] |
| **DateRecommendedForCompletion** | **DateTime?** | The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | The version of Learning module assigned | [optional] |
| **Module** | [**LearningModule**](LearningModule.html) | The Learning module object associated with this assignment | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user to whom the assignment is assigned | [optional] |
{: class="table table-striped"}


