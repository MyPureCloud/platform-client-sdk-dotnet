# AssignedLearningModule

## ININ.PureCloudApi.Model.AssignedLearningModule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of learning module | |
| **ExcludedFromCatalog** | **bool?** | If true, learning module is excluded when retrieving modules for manual assignment | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created learning module | [optional] |
| **DateCreated** | **DateTime?** | The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who modified learning module | [optional] |
| **DateModified** | **DateTime?** | The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | The version of published learning module | [optional] |
| **ExternalId** | **string** | The external ID of the learning module | [optional] |
| **Source** | **string** | The source of the learning module | [optional] |
| **Rule** | [**LearningModuleRule**](LearningModuleRule) | The rule for learning module; read-only, and only populated when requested via expand param. | [optional] |
| **EnforceContentOrder** | **bool?** | If true, learning module content should be viewed one by one in order | [optional] |
| **ReviewAssessmentResults** | [**ReviewAssessmentResults**](ReviewAssessmentResults) | Allows to view Assessment results in detail | [optional] |
| **CurrentAssignments** | [**List&lt;LearningAssignment&gt;**](LearningAssignment) | The current assignments for the requested users | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **IsArchived** | **bool?** | If true, learning module is archived | [optional] |
| **IsPublished** | **bool?** | If true, learning module is published | [optional] |
| **Description** | **string** | The description of learning module | [optional] |
| **CompletionTimeInDays** | **int?** | The completion time of learning module in days | |
| **Type** | **string** | The type for the learning module | [optional] |
| **InformSteps** | [**List&lt;LearningModuleInformStep&gt;**](LearningModuleInformStep) | The list of inform steps in a learning module | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm) | The assessment form for learning module | [optional] |
| **SummaryData** | [**LearningModuleSummary**](LearningModuleSummary) | The learning module summary data | [optional] |
| **ReassignSummaryData** | [**LearningModuleReassignSummary**](LearningModuleReassignSummary) | The learning module reassign summary data | [optional] |
| **CoverArt** | [**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse) | The cover art for the learning module | [optional] |
| **LengthInMinutes** | **int?** | The recommended time in minutes to complete the module | [optional] |
| **ArchivalMode** | **string** | The mode of archival for learning module | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
