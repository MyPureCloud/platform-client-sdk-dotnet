# ExternalContact

## ININ.PureCloudApi.Model.ExternalContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **FirstName** | **string** | The first name of the contact. | [optional] |
| **MiddleName** | **string** |  | [optional] |
| **LastName** | **string** | The last name of the contact. | [optional] |
| **Salutation** | **string** |  | [optional] |
| **Title** | **string** |  | [optional] |
| **WorkPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **CellPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **HomePhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **OtherPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **WorkEmail** | **string** |  | [optional] |
| **PersonalEmail** | **string** |  | [optional] |
| **OtherEmail** | **string** |  | [optional] |
| **Address** | [**ContactAddress**](ContactAddress) |  | [optional] |
| **TwitterId** | [**TwitterId**](TwitterId) |  | [optional] |
| **LineId** | [**LineId**](LineId) |  | [optional] |
| **WhatsAppId** | [**WhatsAppId**](WhatsAppId) |  | [optional] |
| **FacebookId** | [**FacebookId**](FacebookId) |  | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization) |  | [optional] |
| **SurveyOptOut** | **bool?** |  | [optional] |
| **ExternalSystemUrl** | **string** | A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace. | [optional] |
| **Schema** | [**DataSchema**](DataSchema) | The schema defining custom fields for this contact | [optional] |
| **CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields defined in the schema referenced by schemaId and schemaVersion. | [optional] |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **Type** | **string** | The type of contact | [optional] |
| **CanonicalContact** | [**ContactAddressableEntityRef**](ContactAddressableEntityRef) | The contact at the head of the merge tree. If null, this contact is not a part of any merge. | [optional] |
| **MergeSet** | [**List&lt;ContactAddressableEntityRef&gt;**](ContactAddressableEntityRef) | The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge. | [optional] |
| **MergeOperation** | [**MergeOperation**](MergeOperation) | Information about the merge history of this contact. If null, this contact is not a part of any merge. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
