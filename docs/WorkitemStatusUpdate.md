# WorkitemStatusUpdate

## ININ.PureCloudApi.Model.WorkitemStatusUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Status. Valid length between 3 and 256 characters. | [optional] |
| **DestinationStatusIds** | **List&lt;string&gt;** | A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations. | [optional] |
| **Description** | **string** | The description of the Status. Maximum length of 512 characters. | [optional] |
| **DefaultDestinationStatusId** | **string** | Default destination status to which this Status will transition to if auto status transition enabled. | [optional] |
| **StatusTransitionDelaySeconds** | **int?** | Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided. | [optional] |
| **StatusTransitionTime** | **string** | Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS | [optional] |
| **AutoTerminateWorkitem** | **bool?** | Terminate workitem on selection of status. Applicable only for statuses in the Closed category. | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
