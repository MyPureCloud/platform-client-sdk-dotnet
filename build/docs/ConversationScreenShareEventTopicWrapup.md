# ConversationScreenShareEventTopicWrapup

## ININ.PureCloudApi.Model.ConversationScreenShareEventTopicWrapup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Code** | **string** | The user configured wrap up code name. | [optional] |
| **Notes** | **string** | Text entered by the agent to describe the call or disposition. | [optional] |
| **Tags** | **List&lt;string&gt;** | List of tags selected by the agent to describe the call or disposition. | [optional] |
| **DurationSeconds** | **long?** | The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally | [optional] |
| **EndTime** | **DateTime?** | The timestamp when the wrapup was finished. | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
