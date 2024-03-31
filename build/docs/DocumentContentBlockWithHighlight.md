---
title: DocumentContentBlockWithHighlight
---
## ININ.PureCloudApi.Model.DocumentContentBlockWithHighlight

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the paragraph block. | |
| **Text** | [**DocumentText**](DocumentText.html) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage.html) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo.html) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **AnswerHighlight** | [**DocumentContentHighlightIndex**](DocumentContentHighlightIndex.html) | The block highlight data. | [optional] |
{: class="table table-striped"}


