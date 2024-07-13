---
title: FixedAvailability
---
## ININ.PureCloudApi.Model.FixedAvailability

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AvailabilityRange** | [**AvailabilityRange**](AvailabilityRange.html) | The range of time of day the activity can be scheduled | [optional] |
| **DateRange** | [**RequiredLocalDateRange**](RequiredLocalDateRange.html) | The range of date for which the activity plan could be scheduled | [optional] |
| **DaysOfWeek** | **List&lt;string&gt;** | The days of week available for scheduling. Empty list or null means daysOfWeek is not considered | [optional] |
{: class="table table-striped"}


