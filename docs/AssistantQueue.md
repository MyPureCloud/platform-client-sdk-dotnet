# AssistantQueue

## ININ.PureCloudApi.Model.AssistantQueue

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the queue. | |
| **MediaTypes** | **List&lt;string&gt;** | List of media Types in which the assistant is activated for this queue. | |
| **Assistant** | [**Assistant**](Assistant) | Assistant to which the queue is assigned. | [optional] |
| **DateCreated** | **DateTime?** | Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
