---
title: AppEventResponse
---
## ININ.PureCloudApi.Model.AppEventResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | System-generated UUID for the event. | [optional] |
| **CustomerId** | **string** | Identifier of the customer in the source of the event. | [optional] |
| **CustomerIdType** | **string** | Type of identifier for the customer ID (cookie, email etc.). | [optional] |
| **EventName** | **string** | Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). | [optional] |
| **ScreenName** | **string** | The name of the screen in the app that the event took place. | [optional] |
| **App** | [**JourneyApp**](JourneyApp.html) | Application that the customer is interacting with. | [optional] |
| **Device** | [**Device**](Device.html) | Customer&#39;s device. | [optional] |
| **IpAddress** | **string** | Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation.html) | Customer&#39;s geolocation. | [optional] |
| **SdkLibrary** | [**SdkLibrary**](SdkLibrary.html) | SDK library used to generate the event. | [optional] |
| **NetworkConnectivity** | [**NetworkConnectivity**](NetworkConnectivity.html) | Information relating to the device&#39;s network connectivity. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign.html) | Marketing / traffic source information. | [optional] |
| **Session** | [**AppEventResponseSession**](AppEventResponseSession.html) | The app session the event belongs to. | [optional] |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute.html) | User-defined attributes associated with a particular event. | [optional] |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute.html) | Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone). | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef.html) | The external contact associated with this app event. | [optional] |
{: class="table table-striped"}


