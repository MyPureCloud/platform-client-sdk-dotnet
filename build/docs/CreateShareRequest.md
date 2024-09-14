# CreateShareRequest

## ININ.PureCloudApi.Model.CreateShareRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SharedEntityType** | **string** | The share entity type | |
| **SharedEntity** | [**SharedEntity**](SharedEntity) | The entity that will be shared | |
| **MemberType** | **string** |  | [optional] |
| **Member** | [**SharedEntity**](SharedEntity) | The member that will have access to this share. Only required if a list of members is not provided. | [optional] |
| **Members** | [**List&lt;CreateShareRequestMember&gt;**](CreateShareRequestMember) |  | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
