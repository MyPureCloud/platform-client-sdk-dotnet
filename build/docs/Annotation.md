# Annotation

## ININ.PureCloudApi.Model.Annotation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **Location** | **long?** | Offset of annotation in milliseconds. | [optional] |
| **DurationMs** | **long?** | Duration of annotation in milliseconds. | [optional] |
| **AbsoluteLocation** | **long?** | Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses). | [optional] |
| **AbsoluteDurationMs** | **long?** | Duration of annotation (milliseconds). | [optional] |
| **RecordingLocation** | **long?** | Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts | [optional] |
| **RecordingDurationMs** | **long?** | Duration of annotation (milliseconds), adjusted for any recording cuts. | [optional] |
| **User** | [**User**](User) | User that created this annotation (if any). | [optional] |
| **Description** | **string** | Text of annotation. Maximum character limit is 500. | [optional] |
| **Reason** | **string** | Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause | [optional] |
| **Annotations** | [**List&lt;Annotation&gt;**](Annotation) | List of annotations | [optional] |
| **RealtimeLocation** | **long?** | Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
