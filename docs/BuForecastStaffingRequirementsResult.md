# BuForecastStaffingRequirementsResult

## ININ.PureCloudApi.Model.BuForecastStaffingRequirementsResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekNumber** | **int?** | The week number represented by this response | |
| **DownloadUrl** | **string** | The url to get the requirements results for this week | |
| **DownloadUrlExpirationDate** | **DateTime?** | The expiration date of the download url, as an ISO-8601 string | |
| **PlanningGroupStaffingRequirements** | [**List&lt;StaffingRequirementsPlanningGroupData&gt;**](StaffingRequirementsPlanningGroupData) | Results will always come via downloadUrl, however the schema is included for documentation | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
