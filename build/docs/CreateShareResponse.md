---
title: CreateShareResponse
---
## ININ.PureCloudApi.Model.CreateShareResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **SharedEntityType** | **string** |  | [optional] |
| **SharedEntity** | [**UriReference**](UriReference.html) |  | [optional] |
| **MemberType** | **string** |  | [optional] |
| **Member** | [**UriReference**](UriReference.html) |  | [optional] |
| **SharedBy** | [**UriReference**](UriReference.html) |  | [optional] |
| **Workspace** | [**UriReference**](UriReference.html) |  | [optional] |
| **Succeeded** | [**List&lt;Share&gt;**](Share.html) |  | [optional] |
| **Failed** | [**List&lt;Share&gt;**](Share.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


