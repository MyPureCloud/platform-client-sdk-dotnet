# PatchOpportunityRequest

## ININ.PureCloudApi.Model.PatchOpportunityRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start date and time of the opportunity in ISO-8601 format | [optional] |
| **EndDate** | **DateTime?** | The end date and time of the opportunity in ISO-8601 format | [optional] |
| **OpenDate** | [**ValueWrapperInstant**](ValueWrapperInstant) | The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published | [optional] |
| **DeadlineDate** | **DateTime?** | The deadline date and time for enrollment in the opportunity in ISO-8601 format | [optional] |
| **Name** | **string** | The name of the opportunity | [optional] |
| **Description** | [**ValueWrapperString**](ValueWrapperString) | Additional details describing the purpose or context of this opportunity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the opportunity | [optional] |
| **ApprovalType** | **string** | The approval type for enrollments | [optional] |
| **Capacity** | **int?** | The maximum capacity (enrollment slots) for this opportunity | [optional] |
| **AgentIds** | [**ListWrapperString**](ListWrapperString) | The IDs of the agents that are invited to the opportunity | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | The metadata for the opportunity | |



_PureCloudPlatform.Client.V2 268.0.0_
