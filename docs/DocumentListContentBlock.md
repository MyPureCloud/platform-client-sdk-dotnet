# DocumentListContentBlock

## ININ.PureCloudApi.Model.DocumentListContentBlock

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the list block. | |
| **Text** | [**DocumentText**](DocumentText) | Text. It must contain a value if the type of the block is Text. | [optional] |
| **Image** | [**DocumentBodyImage**](DocumentBodyImage) | Image. It must contain a value if the type of the block is Image. | [optional] |
| **Video** | [**DocumentBodyVideo**](DocumentBodyVideo) | Video. It must contain a value if the type of the block is Video. | [optional] |
| **List** | [**DocumentBodyList**](DocumentBodyList) | List. It must contain a value if the type of the block is UnorderedList or OrderedList. | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
