# SendMessagingTemplateRequest

## ININ.PureCloudApi.Model.SendMessagingTemplateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ResponseId** | **string** | Unique identifier for a Response Management response to fetch and apply pre-configured message content when sending outbound responses. | [optional] |
| **Parameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter) | A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead. | [optional] |
| **HeaderParameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter) | A list of Response Management header parameter substitutions for the response&#39;s messaging template | [optional] |
| **BodyParameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter) | A list of Response Management body parameter substitutions for the response&#39;s messaging template | [optional] |
| **ButtonUrlParameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter) | A list of Response Management button url parameter substitutions for the response&#39;s messaging template | [optional] |
| **CarouselParameters** | [**CarouselParameters**](CarouselParameters) | Template parameters for carousel card components | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
