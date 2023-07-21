---
title: DocumentListContentBlock
---
## ININ.PureCloudApi.Model.DocumentListContentBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the list block. | |
| **Text** | [**DocumentText**](DocumentText.html) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage.html) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList.html) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo.html) | Video. It must contain a value if the type of the block is Video. | [optional] |
{: class="table table-striped"}


