---
title: Annotation
---
## ININ.PureCloudApi.Model.Annotation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **Location** | **long?** | Offset of annotation in milliseconds. | [optional] |
| **DurationMs** | **long?** | Duration of annotation in milliseconds. | [optional] |
| **AbsoluteLocation** | **long?** | Offset of annotation (milliseconds) from start of recording. | [optional] |
| **AbsoluteDurationMs** | **long?** | Duration of annotation (milliseconds). | [optional] |
| **RecordingLocation** | **long?** | Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts | [optional] |
| **RecordingDurationMs** | **long?** | Duration of annotation (milliseconds), adjusted for any recording cuts. | [optional] |
| **User** | [**User**](User.html) | User that created this annotation (if any). | [optional] |
| **Description** | **string** | Text of annotation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


