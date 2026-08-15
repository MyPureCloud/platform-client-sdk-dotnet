# EngagementFilter

## ININ.PureCloudApi.Model.EngagementFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Operator** | **string** | The comparison operator for engagement metric filtering. | |
| **From** | **int?** | The inclusive lower bound of the engagement metric count. Required when operator is Between, not allowed otherwise. | [optional] |
| **To** | **int?** | The inclusive upper bound of the engagement metric count. Required when operator is Between, not allowed otherwise. | [optional] |
| **Value** | **int?** | The engagement metric count to compare against. Required for every operator except Between, not allowed for Between. | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
