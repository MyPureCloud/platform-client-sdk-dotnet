# ResponseSet

## ININ.PureCloudApi.Model.ResponseSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the ResponseSet. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Responses** | [**Dictionary&lt;string, Reaction&gt;**](Reaction) | Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}. | |
| **BeepDetectionEnabled** | **bool?** | Whether to enable answering machine beep detection | [optional] |
| **AmdSpeechDistinguishEnabled** | **bool?** | Whether to enable answering machine detection | [optional] |
| **LiveSpeakerDetectionMode** | **string** | Setting level of live speaker detection based on ringbacks | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
