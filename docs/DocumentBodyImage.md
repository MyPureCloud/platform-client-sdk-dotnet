# DocumentBodyImage

## ININ.PureCloudApi.Model.DocumentBodyImage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Url** | **string** | The URL for the image. | |
| **Hyperlink** | **string** | The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt; | [optional] |
| **Properties** | [**DocumentBodyImageProperties**](DocumentBodyImageProperties) | The properties for the image. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
