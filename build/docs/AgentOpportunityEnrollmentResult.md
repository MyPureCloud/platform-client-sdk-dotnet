# AgentOpportunityEnrollmentResult

## ININ.PureCloudApi.Model.AgentOpportunityEnrollmentResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The current status of the enrollment | |
| **Schedule** | [**BuScheduleReference**](BuScheduleReference) | The schedule on which the enrollment was added when this enrollment was approved | [optional] |
| **SystemMessageCode** | **string** | The system-generated message code about enrollment processing results or failures | [optional] |
| **ReviewNote** | **string** | Supervisor&#39;s note explaining the agent&#39;s enrollment status change | [optional] |
| **DenialCode** | **string** | The denial code | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | The metadata for the enrollment | |



_PureCloudPlatform.Client.V2 268.0.0_
