---
title: IVR
---
## ININ.PureCloudApi.Model.IVR

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
| **Dnis** | **List&lt;string&gt;** | The phone number(s) to contact the IVR by.  Each phone number must be unique and not in use by another resource.  For example, a user and an iVR cannot have the same phone number. | [optional] |
| **OpenHoursFlow** | [**DomainEntityRef**](DomainEntityRef.html) | The Architect flow to execute during the hours an organization is open. | [optional] |
| **ClosedHoursFlow** | [**DomainEntityRef**](DomainEntityRef.html) | The Architect flow to execute during the hours an organization is closed. | [optional] |
| **HolidayHoursFlow** | [**DomainEntityRef**](DomainEntityRef.html) | The Architect flow to execute during an organization&#39;s holiday hours. | [optional] |
| **ScheduleGroup** | [**DomainEntityRef**](DomainEntityRef.html) | The schedule group defining the open and closed hours for an organization.  If this is provided, an open flow and a closed flow must be specified as well. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


