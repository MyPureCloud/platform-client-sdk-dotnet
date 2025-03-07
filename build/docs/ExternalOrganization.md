# ExternalOrganization

## ININ.PureCloudApi.Model.ExternalOrganization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the company. | |
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to which this entity belongs. | [optional] |
| **CompanyType** | **string** |  | [optional] |
| **Industry** | **string** |  | [optional] |
| **PrimaryContactId** | **string** |  | [optional] |
| **Address** | [**ContactAddress**](ContactAddress) |  | [optional] |
| **PhoneNumber** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **FaxNumber** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **EmployeeCount** | **long?** |  | [optional] |
| **Revenue** | **long?** |  | [optional] |
| **Tags** | **List&lt;string&gt;** |  | [optional] |
| **Websites** | **List&lt;string&gt;** |  | [optional] |
| **Tickers** | [**List&lt;Ticker&gt;**](Ticker) |  | [optional] |
| **TwitterId** | [**TwitterId**](TwitterId) |  | [optional] |
| **ExternalSystemUrl** | **string** | A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace. | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Trustor** | [**Trustor**](Trustor) |  | [optional] |
| **Schema** | [**DataSchema**](DataSchema) | The schema defining custom fields for this contact | [optional] |
| **CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields defined in the schema referenced by schemaId and schemaVersion. | [optional] |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
