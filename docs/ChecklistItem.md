# ChecklistItem

## ININ.PureCloudApi.Model.ChecklistItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the checklist item. | |
| **Name** | **string** | Name of the checklist item. | |
| **Description** | **string** | Description of the checklist item. | [optional] |
| **AutomatedCheckEnabled** | **bool?** | Flag to indicate whether automated check is enabled for this checklist item. | [optional] |
| **Important** | **bool?** | Flag to indicate whether this checklist item is marked as important. | [optional] |
| **StateFromModel** | **string** | Checklist state as evaluated by the model. | [optional] |
| **StateFromAgent** | **string** | Checklist state as evaluated by the agent. | [optional] |
| **DateLastModifiedByModel** | **DateTime?** | Date when the checklist item was last modified by the model. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateLastModifiedByAgent** | **DateTime?** | Date when the checklist item was last modified by the agent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastModifiedInAcw** | **bool?** | Flag to indicate whether this checklist item was modified in ACW. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
