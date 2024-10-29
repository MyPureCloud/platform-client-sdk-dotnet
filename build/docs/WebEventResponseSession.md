# WebEventResponseSession

## ININ.PureCloudApi.Model.WebEventResponseSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DurationInSeconds** | **int?** | Indicates how long the customer has been on the site within this session. | |
| **EventCount** | **int?** | The count of all events recorded during this session. | |
| **PageviewCount** | **int?** | The count of all pageviews performed during this session. | |
| **Referrer** | [**Referrer**](Referrer) | The referrer of the first event in the web session. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Date of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 220.0.0_
