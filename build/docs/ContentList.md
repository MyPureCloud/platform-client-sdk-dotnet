---
title: ContentList
---
## ININ.PureCloudApi.Model.ContentList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | An ID assigned to this rich message content. Each instance inside the content array has a unique ID. | [optional] |
| **ListType** | **string** | The type of list this instance represents | [optional] |
| **Title** | **string** | Text to show in the title row | [optional] |
| **Description** | **string** | Text to show in the description row. This is immediately below the title | [optional] |
| **SubmitLabel** | **string** | Label for Submit button | [optional] |
| **Actions** | [**ContentActions**](ContentActions.html) | User actions available on the content. All actions are optional and all actions are executed simultaneously. | [optional] |
| **Components** | [**List&lt;ListItemComponent&gt;**](ListItemComponent.html) | An array of component objects | [optional] |
{: class="table table-striped"}


