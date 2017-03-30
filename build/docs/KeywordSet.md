---
title: KeywordSet
---
## ININ.PureCloudApi.Model.KeywordSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Queues** | [**List&lt;Queue&gt;**](Queue.html) |  | [optional] |
| **Language** | **string** | Language code, such as &#39;en-US&#39; | |
| **Agents** | [**List&lt;User&gt;**](User.html) |  | [optional] |
| **Keywords** | [**List&lt;Keyword&gt;**](Keyword.html) | The list of keywords to be used for keyword spotting. | |
| **ParticipantPurposes** | **List&lt;string&gt;** | The types of participants to use keyword spotting on. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


