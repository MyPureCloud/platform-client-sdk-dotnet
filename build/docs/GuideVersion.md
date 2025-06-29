# GuideVersion

## ININ.PureCloudApi.Model.GuideVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SelfUri** | **string** |  | [optional] |
| **Guide** | [**AddressableEntityRef**](AddressableEntityRef) | The guide this version belongs to. | [optional] |
| **Version** | **string** | Guide version. | [optional] |
| **Instruction** | **string** | The instruction given to this version of the guide, for how it should behave when interacting with a User. | [optional] |
| **State** | **string** | The current state of the guide version. | [optional] |
| **DateCreated** | **DateTime?** | The date and time the guide version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date and time the guide version was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Variables** | [**List&lt;Variable&gt;**](Variable) | The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution). | [optional] |
| **Resources** | [**GuideVersionResources**](GuideVersionResources) | The resources associated with this version of the guide. | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
