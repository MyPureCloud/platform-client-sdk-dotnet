# AdherenceExplanationJob

## ININ.PureCloudApi.Model.AdherenceExplanationJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Type** | **string** | The type of the adherence explanation job | [optional] |
| **Status** | **string** | The status of the adherence explanation job | [optional] |
| **AdherenceExplanation** | [**AdherenceExplanationResponse**](AdherenceExplanationResponse) | The adherence explanation added or modified by the job once complete; may be null if status &#x3D;&#x3D; &#39;Error&#39;. Used if type is in [ &#39;AddExplanation&#39;, &#39;UpdateExplanation&#39; ] | [optional] |
| **DownloadUrl** | **string** | A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39; and type is in [ &#39;QueryAgentExplanations&#39;, &#39;QueryBuExplanations&#39; ] | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Error details if status &#x3D;&#x3D; &#39;Error&#39; | [optional] |
| **AgentQueryResponseTemplate** | [**AdherenceExplanationListingAgentQueryResponse**](AdherenceExplanationListingAgentQueryResponse) | Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryAgentExplanations&#39; | [optional] |
| **BuQueryResponseTemplate** | [**AdherenceExplanationListingBuQueryResponse**](AdherenceExplanationListingBuQueryResponse) | Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryBuExplanations&#39; | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
