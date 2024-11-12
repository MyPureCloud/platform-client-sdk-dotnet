# MessagingCampaignSchedule

## ININ.PureCloudApi.Model.MessagingCampaignSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Intervals** | [**List&lt;ScheduleInterval&gt;**](ScheduleInterval) | A list of intervals during which to run the associated Campaign. | |
| **TimeZone** | **string** | The time zone for this messaging campaign schedule. | [optional] |
| **MessagingCampaign** | [**DomainEntityRef**](DomainEntityRef) | The Campaign that this messaging campaign schedule is for. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
