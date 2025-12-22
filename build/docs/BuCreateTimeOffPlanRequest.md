# BuCreateTimeOffPlanRequest

## ININ.PureCloudApi.Model.BuCreateTimeOffPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of this time-off plan | |
| **ActivityCodeIds** | **List&lt;string&gt;** | The IDs of activity codes to associate with this time-off plan | [optional] |
| **AutoApprovalRule** | **string** | Auto approval rule for this time-off plan. Default is Never | [optional] |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | The number of days before the time-off request start date for when the request will be expired from the waitlist. Default is 0 | [optional] |
| **AutoPublishApprovedTimeOffRequests** | **bool?** | Whether newly approved time-off requests with activity codes associated with this time-off plan should be automatically published to the schedule | [optional] |
| **RestrictedActivityCodeIds** | **List&lt;string&gt;** | The IDs of non time-off activity codes to check for conflicts in case the auto approval rule specifies checking activity codes. If these activity codes are present in schedule and overlap with the time-off request duration, the request will not be auto approved | [optional] |
| **HrisTimeOffType** | [**HrisTimeOffType**](HrisTimeOffType) | Time-off type, if this time-off plan is associated with the integration | [optional] |
| **Enabled** | **bool?** | Whether this time-off plan should be used by agents. Default is true | [optional] |
| **CountAgainstTimeOffLimits** | **bool?** | Whether this time-off plan should count against time-off limits. Default is false | [optional] |
| **BusinessUnitAssociation** | [**CreateTimeOffPlanBusinessUnitAssociation**](CreateTimeOffPlanBusinessUnitAssociation) | Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated | [optional] |
| **ManagementUnitAssociation** | [**CreateTimeOffPlanManagementUnitAssociation**](CreateTimeOffPlanManagementUnitAssociation) | Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
