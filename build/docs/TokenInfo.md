---
title: TokenInfo
---
## ININ.PureCloudApi.Model.TokenInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Organization** | [**NamedEntity**](NamedEntity.html) | The current organization | [optional] |
| **HomeOrganization** | [**NamedEntity**](NamedEntity.html) | The token&#39;s home organization | [optional] |
| **AuthorizedScope** | **List&lt;string&gt;** | The list of scopes authorized for the OAuth client | [optional] |
| **ClonedUser** | [**TokenInfoClonedUser**](TokenInfoClonedUser.html) | Only present when a user is a clone of trustee user in the trustor org. | [optional] |
| **OAuthClient** | [**OrgOAuthClient**](OrgOAuthClient.html) |  | [optional] |
{: class="table table-striped"}


