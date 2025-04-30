# Workspace

## ININ.PureCloudApi.Model.Workspace

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The current name of the workspace. | |
| **Type** | **string** |  | [optional] |
| **IsCurrentUserWorkspace** | **bool?** |  | [optional] |
| **User** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Bucket** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Summary** | [**WorkspaceSummary**](WorkspaceSummary) |  | [optional] |
| **Acl** | **List&lt;string&gt;** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
