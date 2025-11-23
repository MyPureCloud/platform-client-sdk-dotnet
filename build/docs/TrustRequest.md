# TrustRequest

## ININ.PureCloudApi.Model.TrustRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser) | User who created this request. | [optional] |
| **DateCreated** | **DateTime?** | Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Trustee** | [**Organization**](Organization) | Trustee organization who generated this request. | |
| **Users** | [**List&lt;OrgUser&gt;**](OrgUser) | The list of trustee users that are requesting access. | [optional] |
| **Groups** | [**List&lt;TrustGroup&gt;**](TrustGroup) | The list of trustee groups that are requesting access. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
