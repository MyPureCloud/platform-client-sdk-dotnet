# GoogleAuthToken

## ININ.PureCloudApi.Model.GoogleAuthToken

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours. | |
| **ClientId** | **string** | ID of the Genesys-owned Google API client | |
| **Scopes** | **List&lt;string&gt;** | Google API authorization scopes that have been granted to the Genesys-owned Google API client | |
| **DateCreated** | **DateTime?** | Date this token was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Integration | |



_PureCloudPlatform.Client.V2 257.0.0_
