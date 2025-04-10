# Trustor

## ININ.PureCloudApi.Model.Trustor

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Organization Id for this trust. | [optional] |
| **Enabled** | **bool?** | If disabled no trustee user will have access, even if they were previously added. | |
| **DateCreated** | **DateTime?** | Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser) | User that created trust. | [optional] |
| **Organization** | [**Organization**](Organization) | Organization associated with this trust. | [optional] |
| **Authorization** | [**TrusteeAuthorization**](TrusteeAuthorization) | Authorization for the trustee user has in this trustor organization | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
