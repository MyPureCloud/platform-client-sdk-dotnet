---
title: Trustee
---
## ININ.PureCloudApi.Model.Trustee

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Organization Id for this trust. | [optional] |
| **Enabled** | **bool?** | If disabled no trustee user will have access, even if they were previously added. | |
| **UsesDefaultRole** | **bool?** | Denotes if trustee uses admin role by default. | [optional] |
| **DateCreated** | **DateTime?** | Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser.html) | User that created trust. | [optional] |
| **Organization** | [**Organization**](Organization.html) | Organization associated with this trust. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


