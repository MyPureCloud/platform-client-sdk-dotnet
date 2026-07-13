# QueryOpportunityEnrollmentsResult

## ININ.PureCloudApi.Model.QueryOpportunityEnrollmentsResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **NextStartDate** | **DateTime?** | The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results | [optional] |
| **Enrollments** | [**List&lt;QueryOpportunityEnrollmentResult&gt;**](QueryOpportunityEnrollmentResult) | The enrollments for the query operation | |
| **Opportunities** | [**List&lt;QueryEnrollmentOpportunityResult&gt;**](QueryEnrollmentOpportunityResult) | The referenced opportunities when expand&#x3D;opportunities is specified | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
