# AuthorizationPolicy

## ININ.PureCloudApi.Model.AuthorizationPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **TargetResource** | **string** | The targeted resource to which the policy should apply, in the form of domain:entity:action | [optional] |
| **Subject** | [**Subject**](Subject) | The subject to whom the policy will apply, including type and id | |
| **Effect** | **string** | The effect this policy should have when its conditions are met | |
| **Condition** | **Object** | The condition tree the policy will evaluate | [optional] |
| **Description** | **string** |  | [optional] |
| **DateModified** | **DateTime?** | Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PresetAttributes** | [**Dictionary&lt;string, TypedAttribute&gt;**](TypedAttribute) | Map of names and values of preset attributes to use in policy evaluation | [optional] |
| **Active** | **bool?** | Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
