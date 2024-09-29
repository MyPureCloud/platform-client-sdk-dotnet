# DialerResponsesetConfigChangeResponseSet

## ININ.PureCloudApi.Model.DialerResponsesetConfigChangeResponseSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Responses** | [**Dictionary&lt;string, DialerResponsesetConfigChangeReaction&gt;**](DialerResponsesetConfigChangeReaction) | Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}} | [optional] |
| **BeepDetectionEnabled** | **bool?** | When beep detection is enabled, answering machine detection will wait for the beep before transferring the call | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
