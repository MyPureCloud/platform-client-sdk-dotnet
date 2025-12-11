# TtsEngineEntity

## ININ.PureCloudApi.Model.TtsEngineEntity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Languages** | **List&lt;string&gt;** | The set of languages the TTS engine supports | |
| **OutputFormats** | **List&lt;string&gt;** | The set of output formats the TTS engine can produce | |
| **Voices** | [**List&lt;TtsVoiceEntity&gt;**](TtsVoiceEntity) | The set of voices the TTS engine supports | [optional] |
| **IsDefault** | **bool?** | The TTS engine is the global default engine | [optional] |
| **IsSecure** | **bool?** | The TTS engine can be used in a secure call flow | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
