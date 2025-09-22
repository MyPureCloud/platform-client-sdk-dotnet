# JourneySegmentRequest

## ININ.PureCloudApi.Model.JourneySegmentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IsActive** | **bool?** | Whether or not the segment is active. | [optional] |
| **DisplayName** | **string** | The display name of the segment. | |
| **Version** | **int?** | The version of the segment. | [optional] |
| **Description** | **string** | A description of the segment. | [optional] |
| **Color** | **string** | The hexadecimal color value of the segment. | |
| **ShouldDisplayToAgent** | **bool?** | Whether or not the segment should be displayed to agent/supervisor users. | [optional] |
| **Context** | [**RequestContext**](RequestContext) | The context of the segment. | |
| **Journey** | [**RequestJourney**](RequestJourney) | The pattern of rules defining the segment. | |
| **ExternalSegment** | [**RequestExternalSegment**](RequestExternalSegment) | Details of an entity corresponding to this segment in an external system. | [optional] |
| **AssignmentExpirationDays** | **int?** | Time, in days, from when the segment is assigned until it is automatically unassigned. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
