---
title: WorkitemStatusUpdate
---
## ININ.PureCloudApi.Model.WorkitemStatusUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Status. Valid length between 3 and 256 characters. | [optional] |
| **DestinationStatusIds** | **List&lt;string&gt;** | A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations. | [optional] |
| **Description** | **string** | The description of the Status. Maximum length of 4096 characters. | [optional] |
| **DefaultDestinationStatusId** | **string** | Default destination status to which this Status will transition to if auto status transition enabled. | [optional] |
| **StatusTransitionDelaySeconds** | **int?** | Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided. | [optional] |
| **StatusTransitionTime** | **DateTime?** | Time in HH:MM:SS format at which auto status transition will occur after statusTransitionDelaySeconds delay. To set Time, the statusTransitionDelaySeconds must be equal to or greater than 86400 i.e. a day | [optional] |
{: class="table table-striped"}


