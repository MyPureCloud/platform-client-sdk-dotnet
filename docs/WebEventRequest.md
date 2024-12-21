# WebEventRequest

## ININ.PureCloudApi.Model.WebEventRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CustomerCookieId** | **string** | A UUID representing the customer making the request. | |
| **EventName** | **string** | Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered. | |
| **Page** | [**RequestPage**](RequestPage) | The webpage where the user interaction occurred. | |
| **UserAgentString** | **string** | Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15). | [optional] |
| **Browser** | [**WebEventBrowser**](WebEventBrowser) | Customer&#39;s browser. | [optional] |
| **Device** | [**WebEventDevice**](WebEventDevice) | Customer&#39;s device. | [optional] |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **IpAddress** | **string** | Customer&#39;s IP address. | [optional] |
| **ReferrerUrl** | **string** | Identifies the referrer URL that originally generated the request for the current page being viewed. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level. | [optional] |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions. | [optional] |
| **CreatedDate** | **DateTime?** | UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 224.0.0_
