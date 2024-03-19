---
title: DocumentBodyBlock
---
## ININ.PureCloudApi.Model.DocumentBodyBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the block for the body. This determines which body block object (paragraph, list, video, image or table) would have a value. | |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage.html) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo.html) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList.html) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Table** | [**DocumentBodyTable**](DocumentBodyTable.html) | Table. It must contain a value if type of the block is Table. | [optional] |
| **Paragraph** | [**DocumentBodyParagraph**](DocumentBodyParagraph.html) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |
{: class="table table-striped"}


