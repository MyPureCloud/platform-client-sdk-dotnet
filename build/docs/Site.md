---
title: Site
---
## ININ.PureCloudApi.Model.Site

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **PrimarySites** | [**List&lt;UriReference&gt;**](UriReference.html) |  | [optional] |
| **SecondarySites** | [**List&lt;UriReference&gt;**](UriReference.html) |  | [optional] |
| **PrimaryEdges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **SecondaryEdges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) |  | [optional] |
| **Edges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **EdgeAutoUpdateConfig** | [**EdgeAutoUpdateConfig**](EdgeAutoUpdateConfig.html) | Recurrance rule, time zone, and start/end settings for automatic edge updates for this site | [optional] |
| **Location** | [**LocationDefinition**](LocationDefinition.html) | Location | |
| **Managed** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


