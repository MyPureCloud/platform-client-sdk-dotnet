---
title: SegmentAssignment
---
## ININ.PureCloudApi.Model.SegmentAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique identifier for the segment assignment. | [optional] |
| **State** | **string** | State of the segment assignment. | [optional] |
| **DateAssigned** | **DateTime?** | Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateUnassigned** | **DateTime?** | Date when the segment was unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the segment assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Segment** | [**SegmentAssignmentSegment**](SegmentAssignmentSegment.html) | The segment the assignment is for. | [optional] |
| **CustomerId** | **string** | ID of the customer to which the segment is assigned. | [optional] |
| **CustomerIdType** | **string** | Type of customer ID (e.g. cookie, email, phone). | [optional] |
| **Session** | [**SegmentAssignmentSession**](SegmentAssignmentSession.html) | For session-scoped segments, the session for which the segment was assigned. | [optional] |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef.html) | External contact of the customer to which the segment is assigned. | [optional] |
{: class="table table-striped"}


