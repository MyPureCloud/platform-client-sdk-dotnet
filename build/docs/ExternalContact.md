---
title: ExternalContact
---
## ININ.PureCloudApi.Model.ExternalContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **FirstName** | **string** | The first name of the contact. | |
| **MiddleName** | **string** |  | [optional] |
| **LastName** | **string** | The last name of the contact. | |
| **Salutation** | **string** |  | [optional] |
| **Title** | **string** |  | [optional] |
| **WorkPhone** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **CellPhone** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **HomePhone** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **OtherPhone** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **WorkEmail** | **string** |  | [optional] |
| **PersonalEmail** | **string** |  | [optional] |
| **OtherEmail** | **string** |  | [optional] |
| **Address** | [**ContactAddress**](ContactAddress.html) |  | [optional] |
| **TwitterId** | [**TwitterId**](TwitterId.html) |  | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization.html) |  | [optional] |
| **SurveyOptOut** | **bool?** |  | [optional] |
| **ExternalSystemUrl** | **string** | Identifies an external system-of-record resource that may have more detailed information on the contact | [optional] |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource.html) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


