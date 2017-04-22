---
title: UpdateUser
---
## ININ.PureCloudApi.Model.UpdateUser

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Chat** | [**Chat**](Chat.html) |  | [optional] |
| **Department** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **PrimaryContactInfo** | [**List&lt;Contact&gt;**](Contact.html) |  | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) | Email addresses and phone numbers for this user | [optional] |
| **Title** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **Manager** | **string** |  | [optional] |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Version** | **int?** | Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. | [optional] |
| **ProfileSkills** | **List&lt;string&gt;** | Skills possessed by the user | [optional] |
| **Locations** | [**List&lt;Location&gt;**](Location.html) | The user placement at each site location. | [optional] |
| **Groups** | [**List&lt;Group&gt;**](Group.html) | The groups the user is a member of | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


