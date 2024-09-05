# AppEventResponseSession

## ININ.PureCloudApi.Model.AppEventResponseSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the app session. | |
| **DurationInSeconds** | **int?** | Indicates how long the customer has been in the app within this session. | |
| **EventCount** | **int?** | The count of all events recorded during this session. | |
| **ScreenviewCount** | **int?** | The count of all screen views recorded during this session. | |
| **Referrer** | [**Referrer**](Referrer) | The referrer of the first event in the app session. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | UTC timestamp of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 214.0.0_
