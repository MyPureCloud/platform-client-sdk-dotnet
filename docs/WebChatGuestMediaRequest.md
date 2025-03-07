# WebChatGuestMediaRequest

## ININ.PureCloudApi.Model.WebChatGuestMediaRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Types** | **List&lt;string&gt;** | The types of media being requested. | |
| **State** | **string** | The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED. | |
| **CommunicationId** | **string** | The ID of the new media communication, if applicable. | [optional] |
| **SecurityKey** | **string** | The security information related to a media request. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
