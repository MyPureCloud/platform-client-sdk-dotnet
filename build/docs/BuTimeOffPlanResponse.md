# BuTimeOffPlanResponse

## ININ.PureCloudApi.Model.BuTimeOffPlanResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of this time-off plan | |
| **ActivityCodeIds** | **List&lt;string&gt;** | The IDs of activity codes associated with this time-off plan | |
| **TimeOffLimits** | [**List&lt;BuTimeOffLimitReference&gt;**](BuTimeOffLimitReference) | The IDs of time-off limits associated with this time-off plan | [optional] |
| **AutoApprovalRule** | **string** | Auto approval rule for this time-off plan | |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | The number of days before the time-off request start date for when the request will be expired from the waitlist | |
| **HrisTimeOffType** | [**HrisTimeOffType**](HrisTimeOffType) | Time-off type, if this time-off plan is associated with the integration | [optional] |
| **Enabled** | **bool?** | Whether this time-off plan is currently being used by agents | |
| **CountAgainstTimeOffLimits** | **bool?** | Whether this time-off plan counts against time-off limits | |
| **BusinessUnitAssociation** | [**TimeOffPlanBusinessUnitAssociation**](TimeOffPlanBusinessUnitAssociation) | Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated | [optional] |
| **ManagementUnitAssociation** | [**TimeOffPlanManagementUnitAssociation**](TimeOffPlanManagementUnitAssociation) | Management Unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the time-off plan | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
