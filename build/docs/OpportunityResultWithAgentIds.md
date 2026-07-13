# OpportunityResultWithAgentIds

## ININ.PureCloudApi.Model.OpportunityResultWithAgentIds

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **StartDate** | **DateTime?** | The start date and time of the opportunity in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end date and time of the opportunity in ISO-8601 format | |
| **Status** | **string** | The current status of the opportunity | |
| **OpenDate** | **DateTime?** | The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published | [optional] |
| **DeadlineDate** | **DateTime?** | The deadline date and time for enrollment in the opportunity in ISO-8601 format | |
| **Name** | **string** | The name of the opportunity | |
| **Description** | **string** | Additional details describing the purpose or context of this opportunity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the opportunity | |
| **ApprovalType** | **string** | The approval type for enrollments | |
| **AgentCount** | **int?** | The total number of agents invited to this opportunity | |
| **Capacity** | **int?** | The maximum capacity (enrollment slots) for this opportunity | |
| **EnrollmentProcessingCount** | **int?** | The number of enrollments currently being processed | |
| **EnrollmentCounts** | [**OpportunityEnrollmentCounts**](OpportunityEnrollmentCounts) | The counts for enrollment statuses | |
| **PublishedDate** | **DateTime?** | The date and time when the opportunity was published in ISO-8601 format | [optional] |
| **ClosedDate** | **DateTime?** | The date and time when the opportunity was closed in ISO-8601 format | [optional] |
| **SystemMessageCode** | **string** | The system-generated message code about opportunity processing issues or validation failures | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | The metadata for the opportunity | |
| **AgentIds** | **List&lt;string&gt;** | The IDs of the agents that are invited to the opportunity | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
