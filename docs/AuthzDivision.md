# AuthzDivision

## ININ.PureCloudApi.Model.AuthzDivision

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | A helpful description for the division. | |
| **HomeDivision** | **bool?** | A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update. | [optional] |
| **ObjectCounts** | **Dictionary&lt;string, long?&gt;** | A count of objects in this division, grouped by type. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
