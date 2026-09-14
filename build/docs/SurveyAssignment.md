# SurveyAssignment

## ININ.PureCloudApi.Model.SurveyAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SurveyForm** | [**PublishedSurveyFormReference**](PublishedSurveyFormReference) | The survey form used for this survey. | [optional] |
| **Flow** | [**DomainEntityRef**](DomainEntityRef) | The URI reference to the flow associated with this survey. | [optional] |
| **InviteTimeInterval** | **string** | An ISO 8601 repeated interval consisting of the number of repetitions, the start datetime, and the interval (e.g. R2/2018-03-01T13:00:00Z/P1M10DT2H30M). Total duration must not exceed 90 days. | [optional] |
| **SendingUser** | **string** | User together with sendingDomain used to send email, null to use no-reply | [optional] |
| **SendingDomain** | **string** | Validated email domain, required | |
| **UseThreadingTimelineForSendTime** | **bool?** | If true, the survey invitation send time will be calculated using the threading timeline. If false or unspecified, a fixed 72-hour delay will be used. Default is false for new policies. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
