# AdherenceExplanationResponse

## ININ.PureCloudApi.Model.AdherenceExplanationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Agent** | [**UserReference**](UserReference) | The agent to whom this adherence explanation applies | |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which the agent belonged at the time the adherence explanation was submitted | |
| **BusinessUnit** | [**BusinessUnitReference**](BusinessUnitReference) | The business unit to which the agent belonged at the time the adherence explanation was submitted | |
| **Type** | **string** | The type of the adherence explanation | |
| **Status** | **string** | The status of the adherence explanation | |
| **StartDate** | **DateTime?** | The start timestamp of the adherence explanation in ISO-8601 format | |
| **LengthMinutes** | **int?** | The length of the adherence explanation in minutes | |
| **Notes** | **string** | Notes about the adherence explanation | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference) | The user who reviewed the adherence explanation, if applicable. The id may be &#39;System&#39; if it was an automated process | [optional] |
| **ReviewedDate** | **DateTime?** | The timestamp for when the adherence explanation was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
