# AgentEffectiveBid

## ININ.PureCloudApi.Model.AgentEffectiveBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the schedule bid | |
| **Name** | **string** |  | [optional] |
| **EffectiveDate** | **String** | The effective date of the bid relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EndDate** | **String** | The end date of the bid, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an active schedule bid. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DownloadUrl** | **string** | The download URL to fetch the list of schedule sets and the agents assigned to them | |
| **DownloadTemplate** | [**AgentAssignedScheduleSetList**](AgentAssignedScheduleSetList) | This field will always be null. Effective schedule sets are returned through the download URL. The schema is included here for documentation purposes | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
