# Trustee

## ININ.PureCloudApi.Model.Trustee

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Organization Id for this trust. | [optional] |
| **Enabled** | **bool?** | If disabled no trustee user will have access, even if they were previously added. | |
| **UsesDefaultRole** | **bool?** | Denotes if trustee uses admin role by default. | [optional] |
| **HasFullAccess** | **bool?** | Denotes if trustee uses full access role by default. | [optional] |
| **IsTrustedUser** | **bool?** | Denotes if trustee is given Trusted User access by default. | [optional] |
| **DateCreated** | **DateTime?** | Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpired** | **DateTime?** | The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**OrgUser**](OrgUser) | User that created trust. | [optional] |
| **Organization** | [**Organization**](Organization) | Organization associated with this trust. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
