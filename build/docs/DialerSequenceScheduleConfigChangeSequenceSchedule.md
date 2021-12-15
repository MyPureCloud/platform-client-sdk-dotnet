---
title: DialerSequenceScheduleConfigChangeSequenceSchedule
---
## ININ.PureCloudApi.Model.DialerSequenceScheduleConfigChangeSequenceSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Intervals** | [**List&lt;DialerSequenceScheduleConfigChangeScheduleInterval&gt;**](DialerSequenceScheduleConfigChangeScheduleInterval.html) | a list of start and end times | [optional] |
| **TimeZone** | **string** | time zone identifier to be applied to the intervals; for example Africa/Abidjan | [optional] |
| **Sequence** | [**DialerSequenceScheduleConfigChangeUriReference**](DialerSequenceScheduleConfigChangeUriReference.html) |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
{: class="table table-striped"}


