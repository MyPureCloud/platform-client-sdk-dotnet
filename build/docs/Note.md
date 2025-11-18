# Note

## ININ.PureCloudApi.Model.Note

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to which this entity belongs. | [optional] |
| **EntityId** | **string** | The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs. | [optional] |
| **EntityType** | **string** | This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used. | [optional] |
| **NoteText** | **string** |  | [optional] |
| **ModifyDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreateDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**User**](User) | When creating or updating a note, only User.id is required. User object is fully populated when expanding a note. | |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
