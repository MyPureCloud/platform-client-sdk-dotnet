# Reoccurrence

## ININ.PureCloudApi.Model.Reoccurrence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Start** | **string** | The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss | |
| **End** | **string** | The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss | |
| **TimeZone** | **string** | The time zone for the recurrence. The time zone of the recurrence is determined by prioritizing the recurrence&#39;s time zone if specified, then the schedule&#39;s time zone if set, and finally defaulting to UTC if neither defines a time zone. See here for a list of valid time zones https://www.iana.org/time-zones | [optional] |
| **Pattern** | [**Pattern**](Pattern) | The schedule pattern e.g.: Daily/Weekly | |
| **Range** | [**Range**](Range) | The schedule range e.g.: EndDate/NoEnd/Numbered | |
| **Alterations** | [**List&lt;Alteration&gt;**](Alteration) | Modifications to the original recurrence schedule (Exclusions/Inclusions) | [optional] |
| **NextOccurrenceDetails** | [**NextOccurrenceDetails**](NextOccurrenceDetails) | The next occurrence details for the next start and end occurrences for the recurrence | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
