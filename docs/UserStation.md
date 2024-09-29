# UserStation

## ININ.PureCloudApi.Model.UserStation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this station | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **AssociatedUser** | [**User**](User) |  | [optional] |
| **AssociatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DefaultUser** | [**User**](User) |  | [optional] |
| **ProviderInfo** | **Dictionary&lt;string, string&gt;** | Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; } | [optional] |
| **WebRtcCallAppearances** | **int?** | The number of call appearances on the station. | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
