# WebEvent

## ININ.PureCloudApi.Model.WebEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventName** | **string** | Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered). | |
| **TotalEventCount** | **int?** | The total count of events performed by the customer across all sessions. | |
| **TotalPageviewCount** | **int?** | The total count of pageviews performed by the customer across all sessions. | |
| **Page** | [**JourneyPage**](JourneyPage) | The webpage where the user interaction occurred. | |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | |
| **Browser** | [**Browser**](Browser) | Customer&#39;s browser. | |
| **Device** | [**Device**](Device) | Customer&#39;s device. | |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign) | Marketing / traffic source information. | [optional] |
| **Referrer** | [**Referrer**](Referrer) | Identifies the page URL that originally generated the request for the current page being viewed. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined attributes associated with a particular event. | |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined traits associated with a particular event. | |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **Authenticated** | **bool?** | Indicates whether the event was produced during an authenticated session. | |



_PureCloudPlatform.Client.V2 238.0.0_
