---
title: DocumentBodyTableCaptionItem
---
## ININ.PureCloudApi.Model.DocumentBodyTableCaptionItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the caption item. | |
| **Text** | [**DocumentText**](DocumentText.html) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Paragraph** | [**DocumentBodyParagraph**](DocumentBodyParagraph.html) | Paragraph. It must contain a value if the type of the block is Paragraph. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage.html) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo.html) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList.html) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
{: class="table table-striped"}


