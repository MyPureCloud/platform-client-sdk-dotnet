---
title: Reoccurrence
---
## ININ.PureCloudApi.Model.Reoccurrence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Start** | **string** | The  start date time of the initial occurrence as an ISO-8601 string in UTC time, e.g: 2023-11-21T16:30:25.000Z | |
| **End** | **string** | The end date time of the initial occurrence as an ISO-8601 string in UTC time, e.g: 2023-12-21T16:30:25.000Z | |
| **TimeZone** | **string** | The time zone of the schedule e.g.:  America/New_York | |
| **Pattern** | [**Pattern**](Pattern.html) | The schedule pattern e.g.: Daily/Weekly | |
| **Range** | [**Range**](Range.html) | The schedule range e.g.: EndDate/NoEnd/Numbered | |
| **Alterations** | [**List&lt;Alteration&gt;**](Alteration.html) | Modifications to the original recurrence schedule (Exclusions/Inclusions) | [optional] |
{: class="table table-striped"}


