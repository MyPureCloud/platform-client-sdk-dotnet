# PatchSegment

## ININ.PureCloudApi.Model.PatchSegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IsActive** | **bool?** | Whether or not the segment is active. | [optional] |
| **DisplayName** | **string** | The display name of the segment. | [optional] |
| **Version** | **int?** | The version of the segment. | [optional] |
| **Description** | **string** | A description of the segment. | [optional] |
| **Color** | **string** | The hexadecimal color value of the segment. | [optional] |
| **ShouldDisplayToAgent** | **bool?** | Whether or not the segment should be displayed to agent/supervisor users. | [optional] |
| **Context** | [**PatchContext**](PatchContext) | The context of the segment. | [optional] |
| **Journey** | [**PatchJourney**](PatchJourney) | The pattern of rules defining the segment. | [optional] |
| **ExternalSegment** | [**PatchExternalSegment**](PatchExternalSegment) | Details of an entity corresponding to this segment in an external system. | [optional] |
| **AssignmentExpirationDays** | **int?** | Time, in days, from when the segment is assigned until it is automatically unassigned. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
