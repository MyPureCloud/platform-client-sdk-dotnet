---
title: Session
---
## ININ.PureCloudApi.Model.Session

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **CustomerId** | **string** | Primary identifier of the customer in the source where the events for the session originate from. | [optional] |
| **CustomerIdType** | **string** | Type of source customer identifier (e.g. cookie, email, phone). | [optional] |
| **Type** | **string** | Session types indicate the type or category of sessions (e.g. web, app). | [optional] |
| **ExternalId** | **string** | Unique identifier in the external system where the events for the session originate from. | [optional] |
| **ExternalUrl** | **string** | A URL that identifies an external system-of-record resource that may have more detailed information on the session. | [optional] |
| **ShortId** | **string** | Shortened numeric identifier of 4-6 digits. | [optional] |
| **OutcomeAchievements** | [**List&lt;OutcomeAchievement&gt;**](OutcomeAchievement.html) | List of the outcome achievements by the customer in this session. | [optional] |
| **SegmentAssignments** | [**List&lt;SessionSegmentAssignment&gt;**](SessionSegmentAssignment.html) | List of the segment assignments to the customer in this session. | [optional] |
| **Attributes** | [**Dictionary&lt;string, CustomEventAttribute&gt;**](CustomEventAttribute.html) | Attributes projected from the session&#39;s event stream. | [optional] |
| **AttributeLists** | [**Dictionary&lt;string, CustomEventAttributeList&gt;**](CustomEventAttributeList.html) | List-type attributes projected from the session&#39;s event stream. | [optional] |
| **Browser** | [**Browser**](Browser.html) | Customer&#39;s browser. | [optional] |
| **Device** | [**Device**](Device.html) | Customer&#39;s device. | [optional] |
| **Geolocation** | [**JourneyGeolocation**](JourneyGeolocation.html) | Customer&#39;s geolocation. | [optional] |
| **IpAddress** | **string** | Customer&#39;s IP address. | [optional] |
| **IpOrganization** | **string** | Customer&#39;s IP-based organization or ISP name. | [optional] |
| **LastPage** | [**JourneyPage**](JourneyPage.html) | The webpage where the customer&#39;s last web interaction occurred. | [optional] |
| **MktCampaign** | [**JourneyCampaign**](JourneyCampaign.html) | Marketing / traffic source information. | [optional] |
| **Referrer** | [**Referrer**](Referrer.html) | Identifies the page URL that originally generated the request for the current page being viewed. | [optional] |
| **SearchTerms** | **List&lt;string&gt;** | Search terms associated with the session. | [optional] |
| **UserAgentString** | **string** | String identifying the user agent. | [optional] |
| **DurationInSeconds** | **int?** | Indicates how long the session has been active (valid for an individual device). | [optional] |
| **EventCount** | **int?** | The count of all events performed during the session. | [optional] |
| **PageviewCount** | **int?** | The count of all pageviews performed during the session. | [optional] |
| **ScreenviewCount** | **int?** | The count of all screenviews performed during the session. | [optional] |
| **LastEvent** | [**SessionLastEvent**](SessionLastEvent.html) | Information about the most recent event in this session. | [optional] |
| **LastConnectedQueue** | [**ConnectedQueue**](ConnectedQueue.html) | The last queue connected to this session. | [optional] |
| **LastConnectedUser** | [**ConnectedUser**](ConnectedUser.html) | The last user connected to this session. | [optional] |
| **LastUserDisposition** | [**ConversationUserDisposition**](ConversationUserDisposition.html) | The last user disposition connected to this session. | [optional] |
| **ConversationChannels** | [**List&lt;ConversationChannel&gt;**](ConversationChannel.html) | Represents the channels used for this conversation. | [optional] |
| **OriginatingDirection** | **string** | The original direction of the conversation. | [optional] |
| **ConversationSubject** | **string** | The subject for the conversation, for example an email subject. | [optional] |
| **LastUserDisconnectType** | **string** | Disconnect reason for the last user connected to the conversation. | [optional] |
| **LastAcdOutcome** | **string** | Last ACD outcome for the conversation. | [optional] |
| **Authenticated** | **bool?** | Indicates whether or not the session is authenticated. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndedDate** | **DateTime?** | Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalContact** | [**AddressableEntityRef**](AddressableEntityRef.html) | The external contact associated with this session. | [optional] |
| **AwayDate** | **DateTime?** | Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IdleDate** | **DateTime?** | Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef.html) | The conversation for this session. | [optional] |
{: class="table table-striped"}


