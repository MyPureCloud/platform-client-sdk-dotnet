---
title: ExternalOrganization
---
## ININ.PureCloudApi.Model.ExternalOrganization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the company. | |
| **CompanyType** | **string** |  | [optional] |
| **Industry** | **string** |  | [optional] |
| **PrimaryContactId** | **string** |  | [optional] |
| **Address** | [**ContactAddress**](ContactAddress.html) |  | [optional] |
| **PhoneNumber** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **FaxNumber** | [**PhoneNumber**](PhoneNumber.html) |  | [optional] |
| **EmployeeCount** | **long?** |  | [optional] |
| **Revenue** | **long?** |  | [optional] |
| **Tags** | **List&lt;string&gt;** |  | [optional] |
| **Websites** | **List&lt;string&gt;** |  | [optional] |
| **Tickers** | [**List&lt;Ticker&gt;**](Ticker.html) |  | [optional] |
| **TwitterId** | [**TwitterId**](TwitterId.html) |  | [optional] |
| **ExternalSystemUrl** | **string** | A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the HTTP protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace. | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Trustor** | [**Trustor**](Trustor.html) |  | [optional] |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource.html) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


