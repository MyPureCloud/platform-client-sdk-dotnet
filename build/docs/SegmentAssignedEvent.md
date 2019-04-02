---
title: SegmentAssignedEvent
---
## ININ.PureCloudApi.Model.SegmentAssignedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Segment** | [**JourneySegment**](JourneySegment.html) | The segment that was matched. | |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | [optional] |
| **Browser** | [**Browser**](Browser.html) | Customer&#39;s browser. | [optional] |
| **Device** | [**Device**](Device.html) | Customer&#39;s device. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation.html) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Visitor&#39;s IP address. | [optional] |
| **IpOrganization** | **string** | Visitor&#39;s IP-based organization or ISP name. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign.html) | Marketing / traffic source information. | [optional] |
| **VisitReferrer** | [**Referrer**](Referrer.html) | Visit&#39;s referrer. | [optional] |
| **VisitCreatedDate** | **DateTime?** | When visit was created (e.g. timestamp of the first event in visit). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


