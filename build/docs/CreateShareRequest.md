---
title: CreateShareRequest
---
## ININ.PureCloudApi.Model.CreateShareRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SharedEntityType** | **string** | The share entity type | |
| **SharedEntity** | [**SharedEntity**](SharedEntity.html) | The entity that will be shared | |
| **MemberType** | **string** |  | [optional] |
| **Member** | [**SharedEntity**](SharedEntity.html) | The member that will have access to this share. Only required if a list of members is not provided. | [optional] |
| **Members** | [**List&lt;CreateShareRequestMember&gt;**](CreateShareRequestMember.html) |  | [optional] |
{: class="table table-striped"}


