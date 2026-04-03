# Stepplan

## ININ.PureCloudApi.Model.Stepplan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Stepplan. | [optional] |
| **Description** | **string** | The description of the Stepplan. | [optional] |
| **Caseplan** | [**CaseplanReference**](CaseplanReference) | The Caseplan of the Stepplan. | [optional] |
| **Stageplan** | [**StageplanReference**](StageplanReference) | The Stageplan of the Stepplan. | [optional] |
| **DateCreated** | **DateTime?** | The Stepplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Stepplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The ID of the User who modified the Stepplan. | [optional] |
| **ActivityType** | **string** | The activityType of the Stepplan. | [optional] |
| **WorkitemSettings** | [**WorkitemSettingsResponse**](WorkitemSettingsResponse) | The workitemSettings of the Stepplan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
