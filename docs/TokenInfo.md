# TokenInfo

## ININ.PureCloudApi.Model.TokenInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Organization** | [**NamedEntity**](NamedEntity) | The current organization | [optional] |
| **HomeOrganization** | [**NamedEntity**](NamedEntity) | The token&#39;s home organization | [optional] |
| **AuthorizedScope** | **List&lt;string&gt;** | The list of scopes authorized for the OAuth client | [optional] |
| **ClonedUser** | [**TokenInfoClonedUser**](TokenInfoClonedUser) | Only present when a user is a clone of trustee user in the trustor org. | [optional] |
| **OAuthClient** | [**OrgOAuthClient**](OrgOAuthClient) |  | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
