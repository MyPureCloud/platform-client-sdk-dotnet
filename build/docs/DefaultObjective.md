# DefaultObjective

## ININ.PureCloudApi.Model.DefaultObjective

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TemplateId** | **string** | The id of this objective&#39;s base template | [optional] |
| **Zones** | [**List&lt;ObjectiveZone&gt;**](ObjectiveZone) | Objective zone specifies min,max points and values for the associated metric | [optional] |
| **Enabled** | **bool?** | A flag for whether this objective is enabled for the related metric | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | A list of media types for the metric | [optional] |
| **Queues** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | A list of queues for the metric | [optional] |
| **Topics** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | A list of topic ids for detected topic metrics | [optional] |
| **TopicIdsFilterType** | **string** | A filter type for topic Ids. It&#39;s only used for objectives with topicIds. Default filter behavior is \&quot;or\&quot;. | [optional] |
| **EvaluationFormContextIds** | **List&lt;string&gt;** | The ids of associated evaluation form context, for Quality Evaluation Score metrics | [optional] |
| **InitialDirection** | **string** | The initial direction to filter on | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
