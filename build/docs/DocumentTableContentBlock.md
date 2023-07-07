---
title: DocumentTableContentBlock
---
## ININ.PureCloudApi.Model.DocumentTableContentBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value. | |
| **Paragraph** | [**DocumentBodyParagraph**](DocumentBodyParagraph.html) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |
| **Text** | [**DocumentText**](DocumentText.html) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage.html) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo.html) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList.html) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Table** | [**DocumentBodyTable**](DocumentBodyTable.html) | Table. It must contain a value if the type of the block is Table. | [optional] |
{: class="table table-striped"}


