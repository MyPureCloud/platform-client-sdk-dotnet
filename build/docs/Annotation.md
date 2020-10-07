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
| **Description** | **string** | Text of annotation. Maximum character limit is 300. | [optional] |
| **KeywordName** | **string** | The word or phrase which is being looked for with speech recognition. | [optional] |
| **Confidence** | **float?** | Actual confidence that this is an accurate match. | [optional] |
| **KeywordSetId** | **string** | A unique identifier for the keyword set to which this spotted keyword belongs. | [optional] |
| **KeywordSetName** | **string** | The keyword set to which this spotted keyword belongs. | [optional] |
| **Utterance** | **string** | The phonetic spellings for the phrase and alternate spellings. | [optional] |
| **TimeBegin** | **string** | Beginning time offset of the keyword spot match. | [optional] |
| **TimeEnd** | **string** | Ending time offset of the keyword spot match. | [optional] |
| **KeywordConfidenceThreshold** | **string** | Configured sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives. | [optional] |
| **AgentScoreModifier** | **string** | A modifier to the evaluation score when the phrase is spotted in the agent channel. | |
| **CustomerScoreModifier** | **string** | A modifier to the evaluation score when the phrase is spotted in the customer channel. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


