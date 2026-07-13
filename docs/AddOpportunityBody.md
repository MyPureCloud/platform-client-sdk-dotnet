# AddOpportunityBody

## ININ.PureCloudApi.Model.AddOpportunityBody

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start date and time of the opportunity in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end date and time of the opportunity in ISO-8601 format | |
| **OpenDate** | **DateTime?** | The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published | [optional] |
| **DeadlineDate** | **DateTime?** | The deadline date and time for enrollment in the opportunity in ISO-8601 format | |
| **Name** | **string** | The name of the opportunity | |
| **Description** | **string** | Additional details describing the purpose or context of this opportunity | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the opportunity | |
| **ApprovalType** | **string** | The approval type for enrollments | |
| **Capacity** | **int?** | The maximum capacity (enrollment slots) for this opportunity | |



_PureCloudPlatform.Client.V2 268.0.0_
