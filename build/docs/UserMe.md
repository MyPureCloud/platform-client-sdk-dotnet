---
title: UserMe
---
## ININ.PureCloudApi.Model.UserMe

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division.html) | The division to which this entity belongs. | [optional] |
| **Chat** | [**Chat**](Chat.html) |  | [optional] |
| **Department** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **PrimaryContactInfo** | [**List&lt;Contact&gt;**](Contact.html) | Auto populated from addresses. | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) | Email addresses and phone numbers for this user | [optional] |
| **State** | **string** | The current state for this user. | [optional] |
| **Title** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **Manager** | [**User**](User.html) |  | [optional] |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Version** | **int?** | Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. | |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus.html) | ACD routing status | [optional] |
| **Presence** | [**UserPresence**](UserPresence.html) | Active presence | [optional] |
| **ConversationSummary** | [**UserConversationSummary**](UserConversationSummary.html) | Summary of conversion statistics for conversation types. | [optional] |
| **OutOfOffice** | [**OutOfOffice**](OutOfOffice.html) | Determine if out of office is enabled | [optional] |
| **Geolocation** | [**Geolocation**](Geolocation.html) | Current geolocation position | [optional] |
| **Station** | [**UserStations**](UserStations.html) | Effective, default, and last station information | [optional] |
| **Authorization** | [**UserAuthorization**](UserAuthorization.html) | Roles and permissions assigned to the user | [optional] |
| **ProfileSkills** | **List&lt;string&gt;** | Profile skills possessed by the user | [optional] |
| **Locations** | [**List&lt;Location&gt;**](Location.html) | The user placement at each site location. | [optional] |
| **Groups** | [**List&lt;Group&gt;**](Group.html) | The groups the user is a member of | [optional] |
| **Skills** | [**List&lt;UserRoutingSkill&gt;**](UserRoutingSkill.html) | Routing (ACD) skills possessed by the user | [optional] |
| **Languages** | [**List&lt;UserRoutingLanguage&gt;**](UserRoutingLanguage.html) | Routing (ACD) languages possessed by the user | [optional] |
| **AcdAutoAnswer** | **bool?** | acd auto answer | [optional] |
| **LanguagePreference** | **string** | preferred language by the user | [optional] |
| **Date** | [**ServerDate**](ServerDate.html) | The PureCloud system date time. | [optional] |
| **GeolocationSettings** | [**GeolocationSettings**](GeolocationSettings.html) | Geolocation settings for user&#39;s organization. | [optional] |
| **Organization** | [**Organization**](Organization.html) | Organization details for this user. | [optional] |
| **PresenceDefinitions** | [**List&lt;OrganizationPresence&gt;**](OrganizationPresence.html) | The first 100 presence definitions for user&#39;s organization. | [optional] |
| **LocationDefinitions** | [**List&lt;LocationDefinition&gt;**](LocationDefinition.html) | The first 100 site locations for user&#39;s organization | [optional] |
| **OrgAuthorization** | [**List&lt;DomainOrganizationRole&gt;**](DomainOrganizationRole.html) | The first 100 organization roles, with applicable permission policies, for user&#39;s organization. | [optional] |
| **Favorites** | [**List&lt;User&gt;**](User.html) | The first 50 favorited users. | [optional] |
| **Superiors** | [**List&lt;User&gt;**](User.html) | The first 50 superiors of this user. | [optional] |
| **DirectReports** | [**List&lt;User&gt;**](User.html) | The first 50 direct reports to this user. | [optional] |
| **Adjacents** | [**Adjacents**](Adjacents.html) | The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands. | [optional] |
| **RoutingSkills** | [**List&lt;RoutingSkill&gt;**](RoutingSkill.html) | The first 50 routing skills for user&#39;s organizations | [optional] |
| **FieldConfigs** | [**FieldConfigs**](FieldConfigs.html) | The field config for all entities types of user&#39;s organization | [optional] |
| **Token** | [**TokenInfo**](TokenInfo.html) | Information about the current token | [optional] |
| **Trustors** | [**List&lt;Trustor&gt;**](Trustor.html) | Organizations having this user as a trustee | [optional] |
| **OrgProducts** | [**List&lt;DomainOrganizationProduct&gt;**](DomainOrganizationProduct.html) | Products enabled in this organization | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


