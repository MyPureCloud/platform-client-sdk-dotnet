---
title: ContentQuickReply
---
## ININ.PureCloudApi.Model.ContentQuickReply

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | An ID assigned to the quick reply. Each object inside the content array has a unique ID. | [optional] |
| **Text** | **string** | Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply. | |
| **Payload** | **string** | Content of the textback payload after clicking a quick reply | [optional] |
| **Image** | **string** | Image associated with quick reply | [optional] |
| **Action** | **string** | Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \&quot;Message\&quot; which sends a message using the quick reply text. | [optional] |
{: class="table table-striped"}


