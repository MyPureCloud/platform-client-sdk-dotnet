# CallForwarding

## ININ.PureCloudApi.Model.CallForwarding

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User) |  | [optional] |
| **Enabled** | **bool?** | Whether or not CallForwarding is enabled | [optional] |
| **PhoneNumber** | **string** | This property is deprecated. Please use the calls property | [optional] |
| **Calls** | [**List&lt;CallRoute&gt;**](CallRoute) | An ordered list of CallRoutes to be executed when CallForwarding is enabled | [optional] |
| **Voicemail** | **string** | The type of voicemail to use with the callForwarding configuration | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
