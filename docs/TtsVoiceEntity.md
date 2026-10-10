# TtsVoiceEntity

## ININ.PureCloudApi.Model.TtsVoiceEntity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DisplayName** | **string** | The display name of the TTS voice | [optional] |
| **Gender** | **string** | The gender of the TTS voice | |
| **VoiceType** | **string** | The type of the TTS voice | [optional] |
| **Language** | **string** | The language supported by the TTS voice | |
| **Engine** | [**TtsEngineEntity**](TtsEngineEntity) | Ths TTS engine this voice belongs to | |
| **IsDefault** | **bool?** | The voice is the default voice for its language | [optional] |
| **SupportedModels** | **List&lt;string&gt;** | The models supported by the TTS voice | [optional] |
| **Provider** | **string** | The provider of the TTS voice | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
