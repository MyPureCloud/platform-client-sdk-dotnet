# FaxSendRequest

## ININ.PureCloudApi.Model.FaxSendRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Addresses** | **List&lt;string&gt;** | A list of outbound fax dialing addresses. E.g. +13175555555 or 3175555555 | |
| **DocumentId** | **string** | DocumentId of Content Management artifact. If Content Management document is not used for faxing, documentId should be null | [optional] |
| **ContentType** | **string** | The content type that is going to be uploaded. If Content Management document is used for faxing, contentType will be ignored | [optional] |
| **Workspace** | [**Workspace**](Workspace) | Workspace in which the document should be stored. If Content Management document is used for faxing, workspace will be ignored | [optional] |
| **CoverSheet** | [**CoverSheet**](CoverSheet) | Data for coversheet generation. | [optional] |
| **TimeZoneOffsetMinutes** | **int?** | Time zone offset minutes from GMT | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
