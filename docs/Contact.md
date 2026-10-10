# Contact

## ININ.PureCloudApi.Model.Contact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Address** | **string** | Email address or phone number for this contact type | [optional] |
| **Display** | **string** | Formatted version of the address property | [optional] |
| **MediaType** | **string** |  | [optional] |
| **Type** | **string** | The type of this contact entry. Note: the PRIMARY email address cannot be changed via PATCH /api/v2/users/{userId}; submitting a modified value for the PRIMARY entry returns a 400 error. | [optional] |
| **Extension** | **string** | Use internal extension instead of address. Mutually exclusive with the address field. | [optional] |
| **CountryCode** | **string** |  | [optional] |
| **Integration** | **string** | Integration tag value if this number is associated with an external integration. | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
