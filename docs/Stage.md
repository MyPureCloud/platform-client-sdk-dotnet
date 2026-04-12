# Stage

## ININ.PureCloudApi.Model.Stage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Stage. | [optional] |
| **Description** | **string** | The description of the Stage. | [optional] |
| **DateCreated** | **DateTime?** | The Stage creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Stage modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | The Stage completion date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateStarted** | **DateTime?** | The Stage start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The ID of the User who modified the Stage. | [optional] |
| **Version** | **int?** | The version of the Stage. | [optional] |
| **Status** | **string** | The Status of the Stage. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Case** | [**CaseReference**](CaseReference) | The parent case of the Stage. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
