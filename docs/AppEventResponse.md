# AppEventResponse

## ININ.PureCloudApi.Model.AppEventResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | System-generated UUID for the event. | |
| **CustomerId** | **string** | Identifier of the customer in the source of the event. | |
| **CustomerIdType** | **string** | Type of identifier for the customer ID (cookie, email etc.). | |
| **EventName** | **string** | Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). | |
| **ScreenName** | **string** | The name of the screen in the app that the event took place. | |
| **App** | [**JourneyApp**](JourneyApp) | Application that the customer is interacting with. | |
| **Device** | [**Device**](Device) | Customer&#39;s device. | |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation) | Customer&#39;s geolocation. | [optional] |
| **SdkLibrary** | [**SdkLibrary**](SdkLibrary) | SDK library used to generate the event. | [optional] |
| **NetworkConnectivity** | [**NetworkConnectivity**](NetworkConnectivity) | Information relating to the device&#39;s network connectivity. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign) | Marketing / traffic source information. | [optional] |
| **Session** | [**AppEventResponseSession**](AppEventResponseSession) | The app session the event belongs to. | |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined attributes associated with a particular event. | |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, givenName, cellPhone). | |
| **CreatedDate** | **DateTime?** | UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 242.0.0_
