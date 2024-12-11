# DocumentTableContentBlock

## ININ.PureCloudApi.Model.DocumentTableContentBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value. | |
| **Text** | [**DocumentText**](DocumentText) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **Paragraph** | [**DocumentBodyParagraph**](DocumentBodyParagraph) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Table** | [**DocumentBodyTable**](DocumentBodyTable) | Table. It must contain a value if the type of the block is Table. | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
