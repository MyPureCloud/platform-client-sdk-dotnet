---
title: MediaEndpointStatistics
---
## ININ.PureCloudApi.Model.MediaEndpointStatistics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Trunk** | [**NamedEntity**](NamedEntity.html) | Trunk information utilized when creating the media endpoint | [optional] |
| **Station** | [**NamedEntity**](NamedEntity.html) | Station information associated with media endpoint | [optional] |
| **User** | [**NamedEntity**](NamedEntity.html) | User information associated media endpoint | [optional] |
| **Ice** | [**MediaIceStatistics**](MediaIceStatistics.html) | The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245 | [optional] |
| **Rtp** | [**MediaRtpStatistics**](MediaRtpStatistics.html) | Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550 | [optional] |
{: class="table table-striped"}


