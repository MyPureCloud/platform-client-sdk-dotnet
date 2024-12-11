# CrossPlatformPolicyCreate

## ININ.PureCloudApi.Model.CrossPlatformPolicyCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The policy name. | |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Order** | **int?** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **MediaPolicies** | [**CrossPlatformMediaPolicies**](CrossPlatformMediaPolicies) | Conditions and actions per media type | [optional] |
| **Conditions** | [**PolicyConditions**](PolicyConditions) | Conditions | [optional] |
| **Actions** | [**CrossPlatformPolicyActions**](CrossPlatformPolicyActions) | Actions | [optional] |
| **PolicyErrors** | [**PolicyErrors**](PolicyErrors) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
