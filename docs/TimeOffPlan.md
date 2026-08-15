# TimeOffPlan

## ININ.PureCloudApi.Model.TimeOffPlan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Name** | **string** | Deprecated. The name of this time off plan. | [optional] |
| **ActivityCodeIds** | **List&lt;string&gt;** | Deprecated. The set of activity code IDs associated with this time off plan. | [optional] |
| **TimeOffLimits** | [**List&lt;TimeOffLimitReference&gt;**](TimeOffLimitReference) | Deprecated. The set of time off limit IDs associated with this time off plan. | [optional] |
| **AutoApprovalRule** | **string** | Deprecated. Auto approval rule for this time off plan | [optional] |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | Deprecated. The number of days before the time off request start date for when the request will be expired from the waitlist. | [optional] |
| **HrisTimeOffType** | [**HrisTimeOffType**](HrisTimeOffType) | Deprecated. Time off type, if this time off plan is associated with the integration. | [optional] |
| **Active** | **bool?** | Deprecated. Whether this time off plan is currently being used by agents. | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Deprecated. Version metadata for the time off plan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
