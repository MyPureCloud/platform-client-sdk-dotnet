---
title: NluDomain
---
## ININ.PureCloudApi.Model.NluDomain

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the NLU domain. | |
| **Language** | **string** | The ISO 639-1 language code of the NLU domain, e.g. `en`. | [optional] |
| **DraftVersion** | [**NluDomainVersion**](NluDomainVersion.html) | The draft version of that NLU domain. | [optional] |
| **LastPublishedVersion** | [**NluDomainVersion**](NluDomainVersion.html) | The last published version of that NLU domain. | [optional] |
| **DateCreated** | **DateTime?** | The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


