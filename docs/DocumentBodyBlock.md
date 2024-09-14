# DocumentBodyBlock

## ININ.PureCloudApi.Model.DocumentBodyBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value. | |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Table** | [**DocumentBodyTable**](DocumentBodyTable) | Table. It must contain a value if type of the block is Table. | [optional] |
| **Paragraph** | [**DocumentBodyParagraph**](DocumentBodyParagraph) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
