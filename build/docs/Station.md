---
title: Station
---
## ININ.PureCloudApi.Model.Station

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Status** | **string** |  | [optional] |
| **UserId** | **string** | The Id of the user currently logged in and associated with the station. | [optional] |
| **WebRtcUserId** | **string** | The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone. | [optional] |
| **PrimaryEdge** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **SecondaryEdge** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **LineAppearanceId** | **string** |  | [optional] |
| **WebRtcMediaDscp** | **int?** | The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone. | [optional] |
| **WebRtcPersistentEnabled** | **bool?** | The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone. | [optional] |
| **WebRtcForceTurn** | **bool?** | Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


