---
title: TrustCreate
---
## ININ.PureCloudApi.Model.TrustCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PairingId** | **string** | The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.  Not required when creating a default pairing with Customer Care. | [optional] |
| **Enabled** | **bool?** | If disabled no trustee user will have access, even if they were previously added. | |
| **Users** | [**List&lt;TrustMemberCreate&gt;**](TrustMemberCreate.html) | The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor. If no users are specified, at least one group is required. | [optional] |
| **Groups** | [**List&lt;TrustMemberCreate&gt;**](TrustMemberCreate.html) | The list of groups and their roles to which access will be granted. The groups are from the trustee and the roles are from the trustor. If no groups are specified, at least one user is required. | [optional] |
{: class="table table-striped"}


