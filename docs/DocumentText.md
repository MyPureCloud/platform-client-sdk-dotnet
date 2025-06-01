# DocumentText

## ININ.PureCloudApi.Model.DocumentText

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Text** | **string** | Text. | |
| **Marks** | **List&lt;string&gt;** | The unique list of marks (whether it is bold and/or underlined etc.) for the text. | [optional] |
| **Hyperlink** | **string** | The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt; | [optional] |
| **Properties** | [**DocumentTextProperties**](DocumentTextProperties) | The properties for the text. | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
