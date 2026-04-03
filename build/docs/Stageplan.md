# Stageplan

## ININ.PureCloudApi.Model.Stageplan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Stageplan. | [optional] |
| **Description** | **string** | The description of the Stageplan. | [optional] |
| **Caseplan** | [**CaseplanReference**](CaseplanReference) | The Caseplan of the Stageplan. | [optional] |
| **DateCreated** | **DateTime?** | The Stageplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Stageplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The ID of the User who modified the Stageplan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
