# TrustUser

## ININ.PureCloudApi.Model.TrustUser

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Chat** | [**Chat**](Chat) |  | [optional] |
| **Department** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **PrimaryContactInfo** | [**List&lt;Contact&gt;**](Contact) | Auto populated from addresses. | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact) | Email addresses and phone numbers for this user | [optional] |
| **State** | **string** | The current state for this user. | [optional] |
| **Title** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **Manager** | [**User**](User) |  | [optional] |
| **Images** | [**List&lt;Image&gt;**](Image) |  | [optional] |
| **Version** | **int?** | Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. | |
| **Certifications** | **List&lt;string&gt;** |  | [optional] |
| **Biography** | [**Biography**](Biography) |  | [optional] |
| **EmployerInfo** | [**EmployerInfo**](EmployerInfo) |  | [optional] |
| **PreferredName** | **string** | Preferred full name of the agent | [optional] |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus) | ACD routing status | [optional] |
| **Presence** | [**UserPresence**](UserPresence) | Active presence | [optional] |
| **IntegrationPresence** | [**UserPresence**](UserPresence) | Integration presence | [optional] |
| **ConversationSummary** | [**UserConversationSummary**](UserConversationSummary) | Summary of conversion statistics for conversation types. | [optional] |
| **OutOfOffice** | [**OutOfOffice**](OutOfOffice) | Determine if out of office is enabled | [optional] |
| **Geolocation** | [**Geolocation**](Geolocation) | Current geolocation position | [optional] |
| **Station** | [**UserStations**](UserStations) | Effective, default, and last station information | [optional] |
| **Authorization** | [**UserAuthorization**](UserAuthorization) | Roles and permissions assigned to the user | [optional] |
| **ProfileSkills** | **List&lt;string&gt;** | Profile skills possessed by the user | [optional] |
| **Locations** | [**List&lt;Location&gt;**](Location) | The user placement at each site location. | [optional] |
| **Groups** | [**List&lt;Group&gt;**](Group) | The groups the user is a member of | [optional] |
| **Team** | [**Team**](Team) | The team the user is a member of | [optional] |
| **WorkPlanBidRanks** | [**WorkPlanBidRanks**](WorkPlanBidRanks) | The WFM work plan bid rank settings for the user | [optional] |
| **Skills** | [**List&lt;UserRoutingSkill&gt;**](UserRoutingSkill) | Routing (ACD) skills possessed by the user | [optional] |
| **Languages** | [**List&lt;UserRoutingLanguage&gt;**](UserRoutingLanguage) | Routing (ACD) languages possessed by the user | [optional] |
| **AcdAutoAnswer** | **bool?** | acd auto answer | [optional] |
| **LanguagePreference** | **string** | preferred language by the user | [optional] |
| **LastTokenIssued** | [**OAuthLastTokenIssued**](OAuthLastTokenIssued) |  | [optional] |
| **DateLastLogin** | **DateTime?** | The last time the user logged in using username and password. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateWelcomeSent** | **DateTime?** | The date &amp; time the user was sent their welcome email. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **TrustUserDetails** | [**TrustUserDetails**](TrustUserDetails) |  | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
