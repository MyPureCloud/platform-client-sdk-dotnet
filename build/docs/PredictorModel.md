# PredictorModel

## ININ.PureCloudApi.Model.PredictorModel

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Kpi** | **string** | The key performance indicator used in the model. | [optional] |
| **Queues** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The List of Queues that are assessed for Predictive Routing. | [optional] |
| **DateCreated** | **DateTime?** | DateTime indicating when the model was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateTrained** | **DateTime?** | DateTime indicating when the model was last trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MediaType** | **string** | The media type of the model. | [optional] |
| **Features** | [**List&lt;PredictorModelFeature&gt;**](PredictorModelFeature) |  | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
