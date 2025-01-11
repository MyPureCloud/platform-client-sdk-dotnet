# RoutePathRequest

## ININ.PureCloudApi.Model.RoutePathRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The ID of the queue to associate with the route path | |
| **MediaType** | **string** | The media type of the given queue to associate with the route path | |
| **LanguageId** | **string** | The ID of the language to associate with the route path | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The set of skill IDs to associate with the route path | [optional] |
| **SourcePlanningGroup** | [**SourcePlanningGroupRequest**](SourcePlanningGroupRequest) | The planning group from which to take route paths. This property is only needed if a route path already exists in another planning group.Note that taking a route path from another planning group will modify the other planning group | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
