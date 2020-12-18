---
title: CrossPlatformPolicy
---
## ININ.PureCloudApi.Model.CrossPlatformPolicy

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
| **MediaPolicies** | [**CrossPlatformMediaPolicies**](CrossPlatformMediaPolicies.html) | Conditions and actions per media type | [optional] |
| **Conditions** | [**PolicyConditions**](PolicyConditions.html) | Conditions | [optional] |
| **Actions** | [**CrossPlatformPolicyActions**](CrossPlatformPolicyActions.html) | Actions | [optional] |
| **PolicyErrors** | [**PolicyErrors**](PolicyErrors.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


