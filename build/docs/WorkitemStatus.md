# WorkitemStatus

## ININ.PureCloudApi.Model.WorkitemStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Category** | **string** | The Category of the Status. | [optional] |
| **DestinationStatuses** | [**List&lt;WorkitemStatusReference&gt;**](WorkitemStatusReference) | The Statuses the Status can transition to. | [optional] |
| **Description** | **string** | The description of the Status. | [optional] |
| **DefaultDestinationStatus** | [**WorkitemStatusReference**](WorkitemStatusReference) | Default destination status to which this Status will transition to if auto status transition enabled. | [optional] |
| **StatusTransitionDelaySeconds** | **int?** | Delay in seconds for auto status transition | [optional] |
| **StatusTransitionTime** | **string** | Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS | [optional] |
| **Worktype** | [**WorktypeReference**](WorktypeReference) | The Worktype containing the Status. | [optional] |
| **AutoTerminateWorkitem** | **bool?** | Terminate workitem on selection of status. Applicable only for statuses in the Closed category. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
