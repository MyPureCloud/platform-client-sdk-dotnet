# CreateShareResponse

## ININ.PureCloudApi.Model.CreateShareResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **SharedEntityType** | **string** |  | [optional] |
| **SharedEntity** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **MemberType** | **string** |  | [optional] |
| **Member** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **SharedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Workspace** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Succeeded** | [**List&lt;Share&gt;**](Share) |  | [optional] |
| **Failed** | [**List&lt;Share&gt;**](Share) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
