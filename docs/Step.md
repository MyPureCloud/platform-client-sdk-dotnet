# Step

## ININ.PureCloudApi.Model.Step

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Step. | [optional] |
| **Description** | **string** | The description of the Step. | [optional] |
| **DateCreated** | **DateTime?** | The Step creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The Step modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | The Step completion date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateStarted** | **DateTime?** | The Step start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The ID of the User who modified the Step. | [optional] |
| **Version** | **int?** | The version of the Step. | [optional] |
| **Status** | **string** | The Status of the Step. | [optional] |
| **Stage** | [**StageReference**](StageReference) | The parent Stage of the Step. | [optional] |
| **WorkitemActivity** | [**WorkitemActivityReference**](WorkitemActivityReference) | The workitem activity linked to this step. Present only for workitem-type steps that have been activated. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Case** | [**CaseReference**](CaseReference) | The parent Case of the Step. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
