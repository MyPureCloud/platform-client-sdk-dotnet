# AgentQueryOpportunityResult

## ININ.PureCloudApi.Model.AgentQueryOpportunityResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the opportunity | |
| **Description** | **string** | Additional details describing the purpose or context of this opportunity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the opportunity | |
| **StartDate** | **DateTime?** | The start date and time of the opportunity in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end date and time of the opportunity in ISO-8601 format | |
| **DeadlineDate** | **DateTime?** | The deadline date and time for enrollment in the opportunity in ISO-8601 format | |
| **Status** | **string** | The current status of the opportunity | |
| **Capacity** | **int?** | The maximum capacity for this opportunity | |
| **EnrollmentCounts** | [**PendingAndApprovedOpportunityEnrollmentCounts**](PendingAndApprovedOpportunityEnrollmentCounts) | Subset of enrollment counts which are relevant to the agent | |
| **Enrollment** | [**AgentOpportunityEnrollmentResult**](AgentOpportunityEnrollmentResult) | The agent&#39;s enrollment in this opportunity, if enrolled | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | The metadata for the opportunity | |



_PureCloudPlatform.Client.V2 268.0.0_
