# Draft

## ININ.PureCloudApi.Model.Draft

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Draft name | |
| **Miner** | [**Miner**](Miner) | Miner to which the draft belongs. | [optional] |
| **Intents** | [**List&lt;DraftIntents&gt;**](DraftIntents) | Draft intent object. | [optional] |
| **Topics** | [**List&lt;DraftTopics&gt;**](DraftTopics) | Draft topic object. | [optional] |
| **DateCreated** | **DateTime?** | Date when the draft was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the draft was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
