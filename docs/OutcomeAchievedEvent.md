# OutcomeAchievedEvent

## ININ.PureCloudApi.Model.OutcomeAchievedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Outcome** | [**OutcomeAchievedEventOutcome**](OutcomeAchievedEventOutcome) | The outcome achieved. | |
| **UserAgentString** | **string** | HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). | [optional] |
| **Browser** | [**Browser**](Browser) | Customer&#39;s browser. | [optional] |
| **Device** | [**Device**](Device) | Customer&#39;s device. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Visitor&#39;s IP address. | [optional] |
| **IpOrganization** | **string** | Visitor&#39;s IP-based organization or ISP name. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign) | Marketing / traffic source information. | [optional] |
| **VisitReferrer** | [**Referrer**](Referrer) | Visit&#39;s referrer. | [optional] |
| **VisitCreatedDate** | **DateTime?** | When visit was created (e.g. timestamp of the first event in visit). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
