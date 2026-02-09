# ExternalContact

## ININ.PureCloudApi.Model.ExternalContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to which this entity belongs. | [optional] |
| **FirstName** | **string** | The first name of the contact. Max: 1000 characters. Leading and trailing whitespace stripped. | [optional] |
| **MiddleName** | **string** | The middle name of the contact. Max: 1000 characters. Leading and trailing whitespace stripped. | [optional] |
| **LastName** | **string** | The last name of the contact. Max: 1000 characters. Leading and trailing whitespace stripped. | [optional] |
| **Salutation** | **string** | The salutation of the contact. Max: 1000 characters. Leading and trailing whitespace stripped. | [optional] |
| **Title** | **string** | The title of the contact. Max: 1000 characters. Leading and trailing whitespace stripped. | [optional] |
| **WorkPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **CellPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **HomePhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **OtherPhone** | [**PhoneNumber**](PhoneNumber) |  | [optional] |
| **WorkEmail** | **string** | The work email of the contact. Max: 256 characters. Leading and trailing whitespace stripped. Valid email format | [optional] |
| **PersonalEmail** | **string** | The personal email of the contact. Max: 256 characters. Leading and trailing whitespace stripped. Valid email format | [optional] |
| **OtherEmail** | **string** | The other email of the contact. Max: 256 characters. Leading and trailing whitespace stripped. Valid email format | [optional] |
| **Address** | [**ContactAddress**](ContactAddress) |  | [optional] |
| **TwitterId** | [**TwitterId**](TwitterId) | User information for a Twitter account | [optional] |
| **LineId** | [**LineId**](LineId) |  | [optional] |
| **WhatsAppId** | [**WhatsAppId**](WhatsAppId) | User information for a WhatsApp account | [optional] |
| **FacebookId** | [**FacebookId**](FacebookId) | User information for a Facebook account | [optional] |
| **InstagramId** | [**InstagramId**](InstagramId) | User information for an Instagram account | [optional] |
| **AppleOpaqueIds** | [**List&lt;AppleOpaqueId&gt;**](AppleOpaqueId) | User information for an Apple account. Max: 10 ids | [optional] |
| **ExternalIds** | [**List&lt;ExternalId&gt;**](ExternalId) | A list of external identifiers that identify this contact in an external system. Max: 10 ids | [optional] |
| **Identifiers** | [**List&lt;ContactIdentifier&gt;**](ContactIdentifier) | Identifiers claimed by this contact | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization) |  | [optional] |
| **SurveyOptOut** | **bool?** |  | [optional] |
| **ExternalSystemUrl** | **string** | A string that identifies an external system-of-record resource that may have more detailed information on the contact. Should be a valid URL (including the http/https protocol, port, and path [if any]). Leading and trailing whitespace stripped. Max 1000 characters. | [optional] |
| **Schema** | [**DataSchema**](DataSchema) | The schema defining custom fields for this contact | [optional] |
| **CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields defined in the schema referenced by schemaId and schemaVersion. | [optional] |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **Type** | **string** | The type of contact | [optional] |
| **CanonicalContact** | [**ContactAddressableEntityRef**](ContactAddressableEntityRef) | The contact at the head of the merge tree. If null, this contact is not a part of any merge. | [optional] |
| **MergeSet** | [**List&lt;ContactAddressableEntityRef&gt;**](ContactAddressableEntityRef) | The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge. | [optional] |
| **MergedFrom** | [**List&lt;ContactAddressableEntityRef&gt;**](ContactAddressableEntityRef) | The input contacts from the merge operation. | [optional] |
| **MergedTo** | [**ContactAddressableEntityRef**](ContactAddressableEntityRef) | The output contact from the merge operation. | [optional] |
| **MergeOperation** | [**MergeOperation**](MergeOperation) | (Deprecated: use mergedTo and mergedFrom instead) Information about the merge history of this contact. If null, this contact is not a part of any merge. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
