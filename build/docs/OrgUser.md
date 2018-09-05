---
title: OrgUser
---
## ININ.PureCloudApi.Model.OrgUser

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
| **Organization** | [**Organization**](Organization.html) |  | [optional] |
{: class="table table-striped"}


