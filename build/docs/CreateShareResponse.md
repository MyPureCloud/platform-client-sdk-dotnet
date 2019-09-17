---
title: CreateShareResponse
---
## ININ.PureCloudApi.Model.CreateShareResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **SharedEntityType** | **string** |  | [optional] |
| **SharedEntity** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **MemberType** | **string** |  | [optional] |
| **Member** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **SharedBy** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **Workspace** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **Succeeded** | [**List&lt;Share&gt;**](Share.html) |  | [optional] |
| **Failed** | [**List&lt;Share&gt;**](Share.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


