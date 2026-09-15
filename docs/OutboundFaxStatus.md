# OutboundFaxStatus

## ININ.PureCloudApi.Model.OutboundFaxStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **InitiatingUser** | [**AddressableEntityRef**](AddressableEntityRef) | The user who sent the fax. | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AuditTransactionId** | **string** |  | [optional] |
| **ExpirationTime** | **long?** |  | [optional] |
| **StatusCode** | **string** | Lifecycle status of the outbound fax send (e.g. UPLOADING, TRANSMITTING, COMPLETE, TERMINATED). | [optional] |
| **Result** | **string** | Transmission result of the fax. Does NOT indicate successful arrival to a workspace&#39;s inbox. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
