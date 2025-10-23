# Topic

## ININ.PureCloudApi.Model.Topic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Published** | **bool?** |  | [optional] |
| **Strictness** | **string** |  | [optional] |
| **MatchingType** | **string** |  | [optional] |
| **Programs** | [**List&lt;BaseProgramEntity&gt;**](BaseProgramEntity) |  | [optional] |
| **Tags** | **List&lt;string&gt;** |  | [optional] |
| **Dialect** | **string** |  | [optional] |
| **Participants** | **string** |  | [optional] |
| **Phrases** | [**List&lt;Phrase&gt;**](Phrase) |  | [optional] |
| **ModifiedBy** | [**AddressableEntityRef**](AddressableEntityRef) |  | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PublishedBy** | [**AddressableEntityRef**](AddressableEntityRef) |  | [optional] |
| **DatePublished** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
