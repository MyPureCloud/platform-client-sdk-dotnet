# LearningScheduleSlotsJobResponse

## ININ.PureCloudApi.Model.LearningScheduleSlotsJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **UserIds** | **List&lt;string&gt;** | The user IDs to fetch the slots for. | [optional] |
| **LengthInMinutes** | **int?** | The length in minutes of the slots. | [optional] |
| **BusinessUnitId** | **string** | The Business Unit Id of the users. | [optional] |
| **ActivityCodeId** | **string** | The Activity Code Id of the slots. | [optional] |
| **SlotsType** | **string** | The type of slots fetched in the job. | [optional] |
| **Results** | [**List&lt;LearningScheduleSlotsJobResult&gt;**](LearningScheduleSlotsJobResult) | The results of the job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
