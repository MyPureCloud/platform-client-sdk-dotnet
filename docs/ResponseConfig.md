# ResponseConfig

## ININ.PureCloudApi.Model.ResponseConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TranslationMap** | **Dictionary&lt;string, string&gt;** | Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response. | [optional] |
| **TranslationMapDefaults** | **Dictionary&lt;string, string&gt;** | Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key. | [optional] |
| **SuccessTemplate** | **string** | Velocity template to build response to return from Action. | [optional] |
| **SuccessTemplateUri** | **string** | URI to retrieve success template. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
