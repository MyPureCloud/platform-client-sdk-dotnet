---
title: WebEvent
---
## ININ.PureCloudApi.Model.WebEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventName** | **string** | Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered). | |
| **TotalEventCount** | **int?** | The total count of events performed by the customer across all sessions. | [optional] |
| **TotalPageviewCount** | **int?** | The total count of pageviews performed by the customer across all sessions. | [optional] |
| **Page** | [**JourneyPage**](JourneyPage.html) | The webpage where the user interaction occurred. | [optional] |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | [optional] |
| **Browser** | [**Browser**](Browser.html) | Customer&#39;s browser. | [optional] |
| **Device** | [**Device**](Device.html) | Customer&#39;s device. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation.html) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign.html) | Marketing / traffic source information. | [optional] |
| **Referrer** | [**Referrer**](Referrer.html) | Identifies the page URL that originally generated the request for the current page being viewed. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute.html) | User-defined attributes associated with a particular event. | [optional] |
{: class="table table-striped"}


