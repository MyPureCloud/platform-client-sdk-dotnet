---
title: WorkitemStatus
---
## ININ.PureCloudApi.Model.WorkitemStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Category** | **string** | The Category of the Status. | [optional] |
| **DestinationStatuses** | [**List&lt;WorkitemStatusReference&gt;**](WorkitemStatusReference.html) | The Statuses the Status can transition to. | [optional] |
| **Description** | **string** | The description of the Status. | [optional] |
| **DefaultDestinationStatus** | [**WorkitemStatusReference**](WorkitemStatusReference.html) | Default destination status to which this Status will transition to if auto status transition enabled. | [optional] |
| **StatusTransitionDelaySeconds** | **int?** | Delay in seconds for auto status transition | [optional] |
| **StatusTransitionTime** | **string** | Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS | [optional] |
| **Worktype** | [**WorktypeReference**](WorktypeReference.html) | The Worktype containing the Status. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


