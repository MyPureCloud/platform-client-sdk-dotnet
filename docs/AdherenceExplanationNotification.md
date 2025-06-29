# AdherenceExplanationNotification

## ININ.PureCloudApi.Model.AdherenceExplanationNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Agent** | [**UserReference**](UserReference) | The agent for whom the adherence explanation applies | [optional] |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which the agent belonged at the time the adherence explanation was submitted | [optional] |
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which the agent belonged at the time the adherence explanation was submitted | [optional] |
| **StartDate** | **DateTime?** | The start date of the adherence explanation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthMinutes** | **int?** | The length of the adherence explanation in minutes | [optional] |
| **Status** | **string** | The status of the adherence explanation | [optional] |
| **Type** | **string** | The type of the adherence explanation | [optional] |
| **Notes** | **string** | Notes about the adherence explanation | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
