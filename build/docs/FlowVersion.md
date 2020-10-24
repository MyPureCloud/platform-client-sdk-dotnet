---
title: FlowVersion
---
## ININ.PureCloudApi.Model.FlowVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow version identifier | [optional] |
| **Name** | **string** |  | [optional] |
| **CommitVersion** | **string** |  | [optional] |
| **ConfigurationVersion** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **Secure** | **bool?** |  | [optional] |
| **Debug** | **bool?** |  | [optional] |
| **CreatedBy** | [**User**](User.html) |  | [optional] |
| **CreatedByClient** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **ConfigurationUri** | **string** |  | [optional] |
| **DateCreated** | **long?** |  | [optional] |
| **GenerationId** | **string** |  | [optional] |
| **PublishResultUri** | **string** |  | [optional] |
| **InputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) |  | [optional] |
| **OutputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) |  | [optional] |
| **NluInfo** | [**NluInfo**](NluInfo.html) | Information about the NLU domain version for the flow version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


