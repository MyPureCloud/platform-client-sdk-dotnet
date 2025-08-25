# ProgramTranscriptionEngines

## ININ.PureCloudApi.Model.ProgramTranscriptionEngines

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Program** | [**BaseProgramEntity**](BaseProgramEntity) | The ID of the program | [optional] |
| **TranscriptionEngines** | [**List&lt;ProgramTranscriptionEngine&gt;**](ProgramTranscriptionEngine) | The program transcription engine settings | [optional] |
| **ModifiedBy** | [**AddressableEntityRef**](AddressableEntityRef) | The user last modified the record | [optional] |
| **DateModified** | **DateTime?** | The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
