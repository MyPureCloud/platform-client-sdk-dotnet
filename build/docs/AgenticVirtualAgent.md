# AgenticVirtualAgent

## ININ.PureCloudApi.Model.AgenticVirtualAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | The date and time the virtual agent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date and time the virtual agent was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The status of the virtual agent. | [optional] |
| **LatestSavedVersion** | [**AgenticVersionAddressableEntity**](AgenticVersionAddressableEntity) | The latest saved version of the virtual agent. | [optional] |
| **LatestProductionReadyVersion** | [**AgenticVersionAddressableEntity**](AgenticVersionAddressableEntity) | The latest production ready version of the virtual agent. | [optional] |
| **ImageUri** | **string** | The URI of the image for the virtual agent. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
