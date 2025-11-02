# CoachingScheduleSlotsJobResponse

## ININ.PureCloudApi.Model.CoachingScheduleSlotsJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **AttendeeIds** | **List&lt;string&gt;** | The attendee IDs to fetch the slots for. | [optional] |
| **FacilitatorIds** | **List&lt;string&gt;** | The facilitator IDs to fetch the slots for. | [optional] |
| **LengthInMinutes** | **int?** | The length in minutes of the slots. | [optional] |
| **BusinessUnitId** | **string** | The Business Unit Id of the users. | [optional] |
| **ActivityCodeId** | **string** | The Activity Code Id of the slots. | [optional] |
| **Results** | [**List&lt;CoachingScheduleSlotsJobResult&gt;**](CoachingScheduleSlotsJobResult) | The results of the job. | [optional] |
| **SlotsType** | **string** | The type of slots fetched in the job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
