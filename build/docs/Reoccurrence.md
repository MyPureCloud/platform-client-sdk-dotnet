---
title: Reoccurrence
---
## ININ.PureCloudApi.Model.Reoccurrence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Start** | **string** | The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss | |
| **End** | **string** | The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss | |
| **TimeZone** | **string** | The time zone for the recurrence. The time zone of the recurrence is determined by prioritizing the recurrence&#39;s time zone if specified, then the schedule&#39;s time zone if set, and finally defaulting to UTC if neither defines a time zone. | |
| **Pattern** | [**Pattern**](Pattern.html) | The schedule pattern e.g.: Daily/Weekly | |
| **Range** | [**Range**](Range.html) | The schedule range e.g.: EndDate/NoEnd/Numbered | |
| **Alterations** | [**List&lt;Alteration&gt;**](Alteration.html) | Modifications to the original recurrence schedule (Exclusions/Inclusions) | [optional] |
| **NextOccurrenceDetails** | [**NextOccurrenceDetails**](NextOccurrenceDetails.html) | The next occurrence details for the next start and end occurrences for the recurrence | [optional] |
{: class="table table-striped"}


