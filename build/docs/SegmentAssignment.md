# SegmentAssignment

## ININ.PureCloudApi.Model.SegmentAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateAssigned** | **DateTime?** | Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateForUnassignment** | **DateTime?** | Date indicating when a segment is scheduled to be unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Segment** | [**SegmentAssignmentSegment**](SegmentAssignmentSegment) | The segment the assignment is for. | |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef) | External contact of the customer to which the segment is assigned. | |
| **Session** | [**SegmentAssignmentSession**](SegmentAssignmentSession) | For session-scoped segments, the session for which the segment was assigned. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
