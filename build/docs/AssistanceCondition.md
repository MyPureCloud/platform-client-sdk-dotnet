---
title: AssistanceCondition
---
## ININ.PureCloudApi.Model.AssistanceCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **_Operator** | **string** | The operator for the assistance condition. The operator defines whether the listed topicIds should EXIST or NOTEXIST for the condition to be evaluated as true. | [optional] |
| **TopicIds** | **List&lt;string&gt;** | List of topicIds within the assistance condition which would be combined together using logical OR operator. Eg ( topicId_1 || topicId_2 ) . | [optional] |
{: class="table table-striped"}


