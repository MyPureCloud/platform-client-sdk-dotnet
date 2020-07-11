---
title: ContentGeneric
---
## ININ.PureCloudApi.Model.ContentGeneric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | An ID assigned to this rich message content. Each instance inside the content array has a unique ID. | [optional] |
| **Title** | **string** | Text to show in the title row | [optional] |
| **Description** | **string** | Text to show in the description row. This is immediately below the title | [optional] |
| **Image** | **string** | Path or URI to an image file | [optional] |
| **Video** | **string** | Path or URI to a video file | [optional] |
| **Actions** | [**ContentActions**](ContentActions.html) | User actions available on the content. All actions are optional and all actions are executed simultaneously. | [optional] |
| **Components** | [**List&lt;ButtonComponent&gt;**](ButtonComponent.html) | An array of component objects | [optional] |
{: class="table table-striped"}


