---
title: WebActionEvent
---
## ININ.PureCloudApi.Model.WebActionEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | [**EventAction**](EventAction.html) | The action that triggered the event. | |
| **ActionMap** | [**ActionEventActionMap**](ActionEventActionMap.html) | The action map that triggered the action. | |
| **ActionTarget** | [**AddressableEntityRef**](AddressableEntityRef.html) | The target for engagement actions. | |
| **TimeToDisposition** | **long?** | Milliseconds elapsed until the action is disposed. | [optional] |
| **ErrorCode** | **string** | Code of the error returned when the action fails. | [optional] |
| **ErrorMessage** | **string** | Message of the error returned when the action fails. | [optional] |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | |
| **Browser** | [**Browser**](Browser.html) | Customer&#39;s browser. | |
| **Device** | [**Device**](Device.html) | Customer&#39;s device. | |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation.html) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Visitor&#39;s IP address. | [optional] |
| **IpOrganization** | **string** | Visitor&#39;s IP-based organization or ISP name. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign.html) | Marketing / traffic source information. | [optional] |
| **VisitReferrer** | [**Referrer**](Referrer.html) | Visit&#39;s referrer. | [optional] |
{: class="table table-striped"}


