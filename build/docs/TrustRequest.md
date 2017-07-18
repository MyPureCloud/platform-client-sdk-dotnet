---
title: TrustRequest
---
## ININ.PureCloudApi.Model.TrustRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser.html) | User who created this request. | [optional] |
| **DateCreated** | **DateTime?** | Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Trustee** | [**Organization**](Organization.html) | Trustee organization who generated this request. | |
| **Users** | [**List&lt;OrgUser&gt;**](OrgUser.html) | The list of trustee users that are requesting access. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


