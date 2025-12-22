# OAuthAuthorization

## ININ.PureCloudApi.Model.OAuthAuthorization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Client** | [**OAuthClient**](OAuthClient) |  | [optional] |
| **Scope** | **List&lt;string&gt;** |  | [optional] |
| **Roles** | **List&lt;string&gt;** |  | [optional] |
| **ResourceOwner** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **ModifiedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Pending** | **bool?** |  | [optional] |
| **State** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
