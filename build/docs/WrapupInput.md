# WrapupInput

## ININ.PureCloudApi.Model.WrapupInput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Code** | **string** | The user configured wrap up code id. | [optional] |
| **Name** | **string** | The user configured wrap up code name. | [optional] |
| **Notes** | **string** | Text entered by the agent to describe the call or disposition. | [optional] |
| **Tags** | **List&lt;string&gt;** | List of tags selected by the agent to describe the call or disposition. | [optional] |
| **DurationSeconds** | **int?** | The length of time in seconds that the agent spent doing after call work. | [optional] |
| **EndTime** | **DateTime?** | The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Provisional** | **bool?** | Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later. | [optional] |
| **DisableEndTimeUpdates** | **bool?** | Prevent updates to wrapup end time when set to true. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
