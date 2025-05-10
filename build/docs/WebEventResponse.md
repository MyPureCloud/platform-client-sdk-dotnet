# WebEventResponse

## ININ.PureCloudApi.Model.WebEventResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CustomerId** | **string** | Identifier of the customer in the source of the event. | |
| **EventName** | **string** | Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered. | |
| **CustomerIdType** | **string** | Type of identifier for the customer ID (e.g., cookie). | |
| **Page** | [**ResponsePage**](ResponsePage) | The webpage where the user interaction occurred. | |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | |
| **Browser** | [**WebEventBrowser**](WebEventBrowser) | Customer&#39;s browser. | |
| **Device** | [**WebEventDevice**](WebEventDevice) | Customer&#39;s device. | |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation) | Customer&#39;s geolocation. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign) | Urchin Tracking Module (UTM) parameters used to track the effectiveness of online marketing campaigns. | [optional] |
| **Session** | [**WebEventResponseSession**](WebEventResponseSession) | The session that the event belongs to. | |
| **Referrer** | [**Referrer**](Referrer) | Identifies the web page that originally generated the request for the current page being viewed. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level. | |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, givenName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions. | |
| **Authenticated** | **bool?** | Indicates whether the event was produced during an authenticated session. | |
| **CreatedDate** | **DateTime?** | UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 233.0.0_
