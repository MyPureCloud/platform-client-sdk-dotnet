# ServiceGoalTemplate

## ININ.PureCloudApi.Model.ServiceGoalTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ServiceLevel** | [**BuServiceLevel**](BuServiceLevel) | Service level targets for this service goal template | [optional] |
| **AverageSpeedOfAnswer** | [**BuAverageSpeedOfAnswer**](BuAverageSpeedOfAnswer) | Average speed of answer targets for this service goal template | [optional] |
| **AbandonRate** | [**BuAbandonRate**](BuAbandonRate) | Abandon rate targets for this service goal template | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the service goal template | [optional] |
| **ImpactOverride** | [**ServiceGoalTemplateImpactOverride**](ServiceGoalTemplateImpactOverride) | Settings controlling max percent increase and decrease of service goals for this service goal template | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
