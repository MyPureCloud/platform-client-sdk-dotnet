# MessagingCampaignScheduleConfigChangeMessagingCampaignSchedule

## ININ.PureCloudApi.Model.MessagingCampaignScheduleConfigChangeMessagingCampaignSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Intervals** | [**List&lt;MessagingCampaignScheduleConfigChangeScheduleInterval&gt;**](MessagingCampaignScheduleConfigChangeScheduleInterval) | a list of start and end times | [optional] |
| **Recurrences** | [**List&lt;MessagingCampaignScheduleConfigChangeScheduleRecurrence&gt;**](MessagingCampaignScheduleConfigChangeScheduleRecurrence) | a list of recurrences for a schedule | [optional] |
| **TimeZone** | **string** | time zone identifier to be applied to the intervals; for example Africa/Abidjan | [optional] |
| **MessagingCampaign** | [**MessagingCampaignScheduleConfigChangeUriReference**](MessagingCampaignScheduleConfigChangeUriReference) |  | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
