---
title: Trustor
---
## ININ.PureCloudApi.Model.Trustor

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Organization Id for this trust. | [optional] |
| **Enabled** | **bool?** | If disabled no trustee user will have access, even if they were previously added. | |
| **DateCreated** | **DateTime?** | Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser.html) | User that created trust. | [optional] |
| **Organization** | [**Organization**](Organization.html) | Organization associated with this trust. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


