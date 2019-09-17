---
title: Site
---
## ININ.PureCloudApi.Model.Site

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **PrimarySites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef.html) |  | [optional] |
| **SecondarySites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef.html) |  | [optional] |
| **PrimaryEdges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **SecondaryEdges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) |  | [optional] |
| **Edges** | [**List&lt;Edge&gt;**](Edge.html) |  | [optional] |
| **EdgeAutoUpdateConfig** | [**EdgeAutoUpdateConfig**](EdgeAutoUpdateConfig.html) | Recurrance rule, time zone, and start/end settings for automatic edge updates for this site | [optional] |
| **Location** | [**LocationDefinition**](LocationDefinition.html) | Location | |
| **Managed** | **bool?** |  | [optional] |
| **NtpSettings** | [**NTPSettings**](NTPSettings.html) | Network Time Protocol settings for the site | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


