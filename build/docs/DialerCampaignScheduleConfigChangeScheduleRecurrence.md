---
title: DialerCampaignScheduleConfigChangeScheduleRecurrence
---
## ININ.PureCloudApi.Model.DialerCampaignScheduleConfigChangeScheduleRecurrence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | the recurrence id | [optional] |
| **Start** | **string** | scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **End** | **string** | scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **TimeZone** | **string** | the timezone the recurrence will use | [optional] |
| **Range** | [**DialerCampaignScheduleConfigChangeRecurrenceRange**](DialerCampaignScheduleConfigChangeRecurrenceRange.html) |  | [optional] |
| **Pattern** | [**DialerCampaignScheduleConfigChangeRecurrencePattern**](DialerCampaignScheduleConfigChangeRecurrencePattern.html) |  | [optional] |
| **Alterations** | [**List&lt;DialerCampaignScheduleConfigChangeAlteration&gt;**](DialerCampaignScheduleConfigChangeAlteration.html) | modifications to the original recurrence schedule | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
{: class="table table-striped"}


