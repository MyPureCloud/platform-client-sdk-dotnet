# QueueConversationSocialExpressionEventTopicErrorDetails

## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicErrorDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **long?** | The HTTP status code for this message (400, 401, 403, 404, 500, etc. | [optional] |
| **Code** | **string** | A code unique to this error. | [optional] |
| **Message** | **string** | Friendly description of this error. | [optional] |
| **MessageWithParams** | **string** | This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39; | [optional] |
| **MessageParams** | **Dictionary&lt;string, string&gt;** | Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39; | [optional] |
| **ContextId** | **string** | The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead. | [optional] |
| **Uri** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
