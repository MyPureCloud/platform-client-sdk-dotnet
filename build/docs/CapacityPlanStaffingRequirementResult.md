# CapacityPlanStaffingRequirementResult

## ININ.PureCloudApi.Model.CapacityPlanStaffingRequirementResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which the capacity plan belongs | |
| **CapacityPlan** | [**CapacityPlanReference**](CapacityPlanReference) | The capacity plan for which requirements are generated | |
| **Status** | **string** | The status of the requirement generation of the capacity plan | |
| **ReferenceBusinessUnitDate** | **String** | The reference date for interval-based data for the requirements. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Granularity** | **string** | Granularity of the intervals | |
| **ErrorCode** | **string** | The error code when status is &#39;Failed&#39; | [optional] |
| **DownloadUrl** | **string** | The URL to get the requirements results for the capacity plan. It will be populated if the status is &#39;Complete&#39; | [optional] |
| **DownloadTemplate** | [**StaffingRequirementResultResponseTemplate**](StaffingRequirementResultResponseTemplate) | Staffing requirement results always come through downloadUrl, the schema included here is just for documentation | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
