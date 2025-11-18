# CampaignSchedule

## ININ.PureCloudApi.Model.CampaignSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Intervals** | [**List&lt;ScheduleInterval&gt;**](ScheduleInterval) | A list of intervals during which to run the associated Campaign. | |
| **Recurrences** | [**List&lt;Reoccurrence&gt;**](Reoccurrence) | Recurring schedules of the campaign | [optional] |
| **TimeZone** | **string** | The time zone for this CampaignSchedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones | [optional] |
| **Campaign** | [**DivisionedDomainEntityRef**](DivisionedDomainEntityRef) | The Campaign that this CampaignSchedule is for. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
