# CustomerIntentResponse

## ININ.PureCloudApi.Model.CustomerIntentResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the customer intent | |
| **Description** | **string** | Description of the customer intent | |
| **ExpiryTime** | **int?** | Expiry time in hours of the customer intent | |
| **Category** | [**AddressableEntityRef**](AddressableEntityRef) | Category of the customer intent | [optional] |
| **DateCreated** | **DateTime?** | Creation date of the customer intent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
