# AppEvent

## ININ.PureCloudApi.Model.AppEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventName** | **string** | Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). | |
| **ScreenName** | **string** | The name of the screen in the app that the event took place. | |
| **App** | [**JourneyApp**](JourneyApp) | Application that the customer is interacting with. | |
| **Device** | [**Device**](Device) | Customer&#39;s device. | |
| **IpAddress** | **string** | Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation) | Customer&#39;s geolocation. | [optional] |
| **SdkLibrary** | [**SdkLibrary**](SdkLibrary) | SDK library used to generate the event. | [optional] |
| **NetworkConnectivity** | [**NetworkConnectivity**](NetworkConnectivity) | Information relating to the device&#39;s network connectivity. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign) | Marketing / traffic source information. | [optional] |
| **SearchQuery** | **string** | Represents the keywords in a customer search query. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | User-defined attributes associated with a particular event. | |
| **Traits** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute) | Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, givenName, cellPhone. | |



_PureCloudPlatform.Client.V2 248.0.0_
