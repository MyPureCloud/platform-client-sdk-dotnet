# OrganizationPresence

## ININ.PureCloudApi.Model.OrganizationPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **LanguageLabels** | **Dictionary&lt;string, string&gt;** | The label used for the system presence in each specified language | |
| **SystemPresence** | **string** |  | [optional] |
| **Deactivated** | **bool?** |  | [optional] |
| **Primary** | **bool?** |  | [optional] |
| **CreatedBy** | [**User**](User) |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**User**](User) |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
