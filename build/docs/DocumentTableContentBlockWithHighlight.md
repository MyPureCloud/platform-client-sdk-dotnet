# DocumentTableContentBlockWithHighlight

## ININ.PureCloudApi.Model.DocumentTableContentBlockWithHighlight

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value. | |
| **Text** | [**DocumentText**](DocumentText) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **Paragraph** | [**DocumentBodyParagraphWithHighlight**](DocumentBodyParagraphWithHighlight) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |
| **List** | [**DocumentBodyListWithHighlight**](DocumentBodyListWithHighlight) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Table** | [**DocumentBodyTableWithHighlight**](DocumentBodyTableWithHighlight) | Table. It must contain a value if the type of the block is Table. | [optional] |
| **AnswerHighlight** | [**DocumentContentHighlightIndex**](DocumentContentHighlightIndex) | The block highlight data. | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
