---
title: IVR
---
## ININ.PureCloudApi.Model.IVR

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
| **Dnis** | **List&lt;string&gt;** | The phone number(s) to contact the IVR by.  Each phone number must be unique and not in use by another resource.  For example, a user and an iVR cannot have the same phone number. | [optional] |
| **OpenHoursFlow** | [**UriReference**](UriReference.html) | The Architect flow to execute during the hours an organization is open. | [optional] |
| **ClosedHoursFlow** | [**UriReference**](UriReference.html) | The Architect flow to execute during the hours an organization is closed. | [optional] |
| **ScheduleGroup** | [**UriReference**](UriReference.html) | The schedule group defining the open and closed hours for an organization.  If this is provided, an open flow and a closed flow must be specified as well. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


