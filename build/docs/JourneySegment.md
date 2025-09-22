# JourneySegment

## ININ.PureCloudApi.Model.JourneySegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the segment. | |
| **IsActive** | **bool?** | Whether or not the segment is active. | |
| **DisplayName** | **string** | The display name of the segment. | |
| **Version** | **int?** | The version of the segment. | |
| **Description** | **string** | A description of the segment. | [optional] |
| **Color** | **string** | The hexadecimal color value of the segment. | |
| **Scope** | **string** | The target entity that a segment applies to. | |
| **ShouldDisplayToAgent** | **bool?** | Whether or not the segment should be displayed to agent/supervisor users. | |
| **Context** | [**Context**](Context) | The context of the segment. | |
| **Journey** | [**Journey**](Journey) | The pattern of rules defining the segment. | |
| **ExternalSegment** | [**ExternalSegment**](ExternalSegment) | Details of an entity corresponding to this segment in an external system. | [optional] |
| **AssignmentExpirationDays** | **int?** | Time, in days, from when the segment is assigned until it is automatically unassigned. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 242.0.0_
