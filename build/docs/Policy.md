# Policy

## ININ.PureCloudApi.Model.Policy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Order** | **int?** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **MediaPolicies** | [**MediaPolicies**](MediaPolicies) | Conditions and actions per media type | [optional] |
| **Conditions** | [**PolicyConditions**](PolicyConditions) | Conditions | [optional] |
| **Actions** | [**PolicyActions**](PolicyActions) | Actions | [optional] |
| **PolicyErrors** | [**PolicyErrors**](PolicyErrors) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
