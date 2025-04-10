# CreateObjective

## ININ.PureCloudApi.Model.CreateObjective

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TemplateId** | **string** | The id of this objective&#39;s base template | [optional] |
| **Zones** | [**List&lt;ObjectiveZone&gt;**](ObjectiveZone) | Objective zone specifies min,max points and values for the associated metric | [optional] |
| **Enabled** | **bool?** | A flag for whether this objective is enabled for the related metric | [optional] |
| **TopicIds** | **List&lt;string&gt;** | A list of topic ids for detected topic metrics | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | A list of media types for the metric | [optional] |
| **QueueIds** | **List&lt;string&gt;** | A list of queue ids for the metric | [optional] |
| **TopicIdsFilterType** | **string** | A filter type for topic Ids. It&#39;s only used for objectives with topicIds. Default filter behavior is \&quot;or\&quot;. | [optional] |
| **EvaluationFormContextIds** | **List&lt;string&gt;** | The ids of associated evaluation form context, for Quality Evaluation Score metrics | [optional] |
| **InitialDirection** | **string** | The initial direction to filter on | [optional] |
| **DateStart** | **String** | start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
