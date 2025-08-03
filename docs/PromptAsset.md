# PromptAsset

## ININ.PureCloudApi.Model.PromptAsset

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **PromptId** | **string** | Associated prompt ID | [optional] |
| **Language** | **string** | Prompt resource language | [optional] |
| **MediaUri** | **string** | URI of the resource audio | [optional] |
| **TtsString** | **string** | Text to speech of the resource | [optional] |
| **Text** | **string** | Text of the resource | [optional] |
| **UploadStatus** | **string** | Audio upload status | [optional] |
| **UploadUri** | **string** | Deprecated. This was use for uploading the resource audio. | [optional] |
| **LanguageDefault** | **bool?** | Whether or not this resource locale is the default for the language | [optional] |
| **Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** |  | [optional] |
| **DurationSeconds** | **double?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
