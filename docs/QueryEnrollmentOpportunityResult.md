# QueryEnrollmentOpportunityResult

## ININ.PureCloudApi.Model.QueryEnrollmentOpportunityResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the opportunity | |
| **ActivityCodeId** | **string** | The ID of the activity code associated with the opportunity | |
| **StartDate** | **DateTime?** | The start date and time of the opportunity in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end date and time of the opportunity in ISO-8601 format | |
| **DeadlineDate** | **DateTime?** | The deadline date and time for enrollment in the opportunity in ISO-8601 format | |
| **Status** | **string** | The current status of the opportunity | |
| **Capacity** | **int?** | The maximum capacity (enrollment slots) for this opportunity | |
| **EnrollmentCounts** | [**PendingAndApprovedOpportunityEnrollmentCounts**](PendingAndApprovedOpportunityEnrollmentCounts) | The counts for enrollment statuses | |



_PureCloudPlatform.Client.V2 268.0.0_
