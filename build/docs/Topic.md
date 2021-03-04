---
title: Topic
---
## ININ.PureCloudApi.Model.Topic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Published** | **bool?** |  | [optional] |
| **Strictness** | **string** |  | [optional] |
| **Programs** | [**List&lt;BaseProgramEntity&gt;**](BaseProgramEntity.html) |  | [optional] |
| **Tags** | **List&lt;string&gt;** |  | [optional] |
| **Dialect** | **string** |  | [optional] |
| **Participants** | **string** |  | [optional] |
| **Phrases** | [**List&lt;Phrase&gt;**](Phrase.html) |  | [optional] |
| **ModifiedBy** | [**AddressableEntityRef**](AddressableEntityRef.html) |  | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PublishedBy** | [**AddressableEntityRef**](AddressableEntityRef.html) |  | [optional] |
| **DatePublished** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


