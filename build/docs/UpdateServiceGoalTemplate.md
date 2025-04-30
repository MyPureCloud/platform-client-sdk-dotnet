# UpdateServiceGoalTemplate

## ININ.PureCloudApi.Model.UpdateServiceGoalTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the service goal template. | [optional] |
| **ServiceLevel** | [**BuServiceLevel**](BuServiceLevel) | Service level targets for this service goal template | [optional] |
| **AverageSpeedOfAnswer** | [**BuAverageSpeedOfAnswer**](BuAverageSpeedOfAnswer) | Average speed of answer targets for this service goal template | [optional] |
| **AbandonRate** | [**BuAbandonRate**](BuAbandonRate) | Abandon rate targets for this service goal template | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the service goal template | |
| **ImpactOverride** | [**ServiceGoalTemplateImpactOverride**](ServiceGoalTemplateImpactOverride) | Settings controlling max percent increase and decrease of service goals for this service goal template | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
