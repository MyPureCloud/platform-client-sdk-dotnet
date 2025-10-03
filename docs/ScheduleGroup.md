# ScheduleGroup

## ININ.PureCloudApi.Model.ScheduleGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Division** | [**WritableDivision**](WritableDivision) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **TimeZone** | **string** | The timezone the schedules are a part of.  This is not a schedule property to allow a schedule to be used in multiple timezones. | [optional] |
| **OpenSchedules** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The schedules defining the hours an organization is open. | [optional] |
| **ClosedSchedules** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The schedules defining the hours an organization is closed. | [optional] |
| **HolidaySchedules** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The schedules defining the hours an organization is closed for the holidays. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
