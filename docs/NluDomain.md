# NluDomain

## ININ.PureCloudApi.Model.NluDomain

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the NLU domain. | |
| **Language** | **string** | The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;. | [optional] |
| **DraftVersion** | [**NluDomainVersion**](NluDomainVersion) | The draft version of that NLU domain. | [optional] |
| **LastPublishedVersion** | [**NluDomainVersion**](NluDomainVersion) | The last published version of that NLU domain. | [optional] |
| **DateCreated** | **DateTime?** | The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EngineVersion** | **string** | The version of the NLU engine to use. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
