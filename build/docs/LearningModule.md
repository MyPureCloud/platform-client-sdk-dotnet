---
title: LearningModule
---
## ININ.PureCloudApi.Model.LearningModule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of learning module | |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created learning module | [optional] |
| **DateCreated** | **DateTime?** | The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The user who modified learning module | [optional] |
| **DateModified** | **DateTime?** | The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | The version of published learning module | [optional] |
| **ExternalId** | **string** | The external ID of the learning module | [optional] |
| **Source** | **string** | The source of the learning module | [optional] |
| **Rule** | [**LearningModuleRule**](LearningModuleRule.html) | The rule for learning module; read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **IsArchived** | **bool?** | If true, learning module is archived | [optional] |
| **IsPublished** | **bool?** | If true, learning module is published | [optional] |
| **Description** | **string** | The description of learning module | [optional] |
| **CompletionTimeInDays** | **int?** | The completion time of learning module in days | |
| **Type** | **string** | The type for the learning module | [optional] |
| **InformSteps** | [**List&lt;LearningModuleInformStep&gt;**](LearningModuleInformStep.html) | The list of inform steps in a learning module | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm.html) | The assessment form for learning module | [optional] |
| **SummaryData** | [**LearningModuleSummary**](LearningModuleSummary.html) | The learning module summary data | [optional] |
{: class="table table-striped"}


