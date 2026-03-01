# EmailCampaignScheduleConfigChangeEmailCampaignSchedule

## ININ.PureCloudApi.Model.EmailCampaignScheduleConfigChangeEmailCampaignSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Intervals** | [**List&lt;EmailCampaignScheduleConfigChangeScheduleInterval&gt;**](EmailCampaignScheduleConfigChangeScheduleInterval) | a list of start and end times | [optional] |
| **Recurrences** | [**List&lt;EmailCampaignScheduleConfigChangeScheduleRecurrence&gt;**](EmailCampaignScheduleConfigChangeScheduleRecurrence) | a list of recurrences for a schedule | [optional] |
| **TimeZone** | **string** | time zone identifier to be applied to the intervals; for example Africa/Abidjan | [optional] |
| **EmailCampaign** | [**EmailCampaignScheduleConfigChangeUriReference**](EmailCampaignScheduleConfigChangeUriReference) |  | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
