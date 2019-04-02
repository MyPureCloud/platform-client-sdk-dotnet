---
title: JourneySegment
---
## ININ.PureCloudApi.Model.JourneySegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **IsActive** | **bool?** | Whether or not the segment is active. | [optional] |
| **DisplayName** | **string** | The display name of the segment. | |
| **Version** | **int?** | The version of the segment. | [optional] |
| **Description** | **string** | A description of the segment. | [optional] |
| **Color** | **string** | The hexadecimal color value of the segment. | [optional] |
| **ShouldDisplayToAgent** | **bool?** | Whether or not the segment should be displayed to agent/supervisor users. | [optional] |
| **Context** | [**Context**](Context.html) | The context of the segment. | [optional] |
| **Journey** | [**Journey**](Journey.html) | The pattern of rules defining the segment. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


