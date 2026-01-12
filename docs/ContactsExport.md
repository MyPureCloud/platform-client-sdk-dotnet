# ContactsExport

## ININ.PureCloudApi.Model.ContactsExport

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Division IDs of entities | [optional] |
| **QueryConditions** | [**ContactsExportQueryConditions**](ContactsExportQueryConditions) | Query conditions to apply on export | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | The user that created this request | [optional] |
| **DateCreated** | **DateTime?** | When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The status of the request | [optional] |
| **DownloadUrl** | **string** | The location where the results of the request can be retrieved | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
