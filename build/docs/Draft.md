---
title: Draft
---
## ININ.PureCloudApi.Model.Draft

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Draft name | |
| **Miner** | [**Miner**](Miner.html) | Miner to which the draft belongs. | [optional] |
| **Intents** | [**List&lt;DraftIntents&gt;**](DraftIntents.html) | Draft intent object. | [optional] |
| **Topics** | [**List&lt;DraftTopics&gt;**](DraftTopics.html) | Draft topic object. | [optional] |
| **DateCreated** | **DateTime?** | Date when the draft was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the draft was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


