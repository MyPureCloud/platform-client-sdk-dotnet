---
title: KnowledgeContextResponse
---
## ININ.PureCloudApi.Model.KnowledgeContextResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Context ID. | [optional] |
| **Name** | **string** | Context name. | |
| **Description** | **string** | Context description. | [optional] |
| **DateCreated** | **DateTime?** | The date when the context was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateModified** | **DateTime?** | The date when the context was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Values** | [**List&lt;KnowledgeContextValueResponse&gt;**](KnowledgeContextValueResponse.html) | Knowledge context values. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


